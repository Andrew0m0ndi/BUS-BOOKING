Option Strict On
Option Explicit On

Imports System.Text


Public Class Form1

    ' =========================================================================
    ' CONSTANTS (All monetary values and factors declared as Decimal constants)
    ' =========================================================================
    Private Const BOOKING_FEE As Decimal = 50D
    Private Const GROUP_DISCOUNT_RATE As Decimal = 0.1D
    Private Const GROUP_DISCOUNT_MIN_TICKETS As Integer = 5

    ' Optional extras costs (per ticket)
    Private Const EXTRA_LUGGAGE_PRICE As Decimal = 200D
    Private Const EXTRA_INSURANCE_PRICE As Decimal = 100D
    Private Const EXTRA_MEAL_PRICE As Decimal = 250D

    ' Passenger category pricing factors
    Private Const FACTOR_ADULT As Decimal = 1D
    Private Const FACTOR_STUDENT As Decimal = 0.8D
    Private Const FACTOR_CHILD As Decimal = 0.5D

    ' Seat class pricing factors
    Private Const FACTOR_STANDARD As Decimal = 1D
    Private Const FACTOR_BUSINESS As Decimal = 1.4D

    ' Weekend pricing factors (Saturday or Sunday)
    Private Const FACTOR_WEEKEND As Decimal = 1.1D
    Private Const FACTOR_WEEKDAY As Decimal = 1D

    ' Base route fares (KES)
    Private Const FARE_MOMBASA As Decimal = 1500D
    Private Const FARE_KISUMU As Decimal = 1400D
    Private Const FARE_ELDORET As Decimal = 1200D
    Private Const FARE_NAKURU As Decimal = 700D
    Private Const FARE_NYERI As Decimal = 600D
    Private Const FARE_GARISSA As Decimal = 1300D

    ' =========================================================================
    ' FORM LIFECYCLE & BUTTON EVENT HANDLERS
    ' =========================================================================

    ''' <summary>
    ''' Form Load Event: initializes all controls to clean starting state.
    ''' </summary>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Change the error provider icon to a yellow warning triangle:
        errProvider.Icon = SystemIcons.Error

        ResetForm()
    End Sub

    ''' <summary>
    ''' Form Shown Event: ensures radio buttons remain unselected initially
    ''' can verify input validation for passenger type and seat class.
    ''' </summary>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        rdoAdult.Checked = False
        rdoStudent.Checked = False
        rdoChild.Checked = False
        rdoStandard.Checked = False
        rdoBusiness.Checked = False
        txtName.Focus()
    End Sub

    ''' <summary>
    ''' Calculate Button Click Event: performs robust validation, computes fares,
    ''' and renders the itemised receipt. Wrapped in Try-Catch to prevent crashes.
    ''' </summary>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            ' 1. Validate all inputs and collect any errors
            Dim validationErrors As New List(Of String)()
            Dim isValid As Boolean = ValidateInputs(validationErrors)

            If Not isValid Then
                ' Report all problems at once in a clear MessageBox
                Dim sbMessage As New StringBuilder()
                sbMessage.AppendLine("Please resolve the following issue(s) before calculating:")
                sbMessage.AppendLine()
                For Each errItem As String In validationErrors
                    sbMessage.AppendLine(errItem)
                Next

                MessageBox.Show(sbMessage.ToString(), "Validation Errors Detected",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' 2. Input values are valid: retrieve values safely
            Dim passengerName As String = txtName.Text.Trim()
            Dim selectedRoute As String = If(cboRoute.SelectedItem IsNot Nothing, cboRoute.SelectedItem.ToString(), cboRoute.Text)
            Dim travelDate As DateTime = dtpTravelDate.Value
            Dim ticketCount As Integer = Convert.ToInt32(nudTickets.Value)

            ' Route base fare (using Select Case procedure)
            Dim baseRouteFare As Decimal = GetRouteFare(selectedRoute)

            ' Pricing factors
            Dim passengerFactor As Decimal = GetPassengerFactor()
            Dim passengerTypeName As String = GetPassengerTypeName()
            Dim classFactor As Decimal = GetClassFactor()
            Dim seatClassName As String = GetSeatClassName()
            Dim weekendFactor As Decimal = GetWeekendFactor(travelDate)

            ' Fare per ticket = Route fare x Passenger factor x Class factor x Weekend factor
            Dim farePerTicket As Decimal = CalculateFarePerTicket(baseRouteFare, passengerFactor, classFactor, weekendFactor)

            ' Extras per ticket (collected via a loop over the CheckBoxes)
            Dim extrasList As New List(Of String)()
            Dim extrasPerTicket As Decimal = GetExtrasPerTicket(extrasList)

            ' Build extras description string
            Dim extrasDescription As String
            If extrasList.Count > 0 Then
                extrasDescription = String.Join(", ", extrasList)
            Else
                extrasDescription = "None"
            End If

            ' Subtotal = Tickets x (Fare per ticket + Extras per ticket)
            Dim subtotal As Decimal = ticketCount * (farePerTicket + extrasPerTicket)

            ' Group discount = 10% of Subtotal if Tickets >= 5, otherwise 0
            Dim groupDiscount As Decimal = 0D
            If ticketCount >= GROUP_DISCOUNT_MIN_TICKETS Then
                groupDiscount = subtotal * GROUP_DISCOUNT_RATE
            End If

            ' Booking fee = KES 50, once per booking
            Dim bookingFee As Decimal = BOOKING_FEE

            ' TOTAL = Subtotal - Group discount + Booking fee
            Dim grandTotal As Decimal = subtotal - groupDiscount + bookingFee

            ' 3. Format and display the itemised receipt via dedicated Sub procedure
            BuildAndShowReceipt(passengerName, selectedRoute, travelDate,
                                passengerTypeName, seatClassName, ticketCount,
                                farePerTicket, extrasPerTicket, extrasDescription,
                                subtotal, groupDiscount, bookingFee, grandTotal)

        Catch ex As Exception
            ' Defensive programming: Calculate must never crash whatever the user does
            MessageBox.Show("An unexpected error occurred during calculation:" & vbCrLf & ex.Message,
                            "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Clear Button Click Event: resets all controls to their starting state.
    ''' </summary>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetForm()
    End Sub

    ''' <summary>
    ''' Exit Button Click Event: closes the form (which triggers FormClosing for confirmation).
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' FormClosing Event: ensures confirmation is requested whether the user clicks Exit,
    ''' presses the window Close (X) button, or uses Alt+F4 / Escape.
    ''' </summary>
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim userResponse As DialogResult = MessageBox.Show(
            "Are you sure you want to exit the Bus Ticket Booking Calculator?",
            "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2)

        If userResponse = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    ' =========================================================================
    ' REQUIRED PROCEDURES AND FUNCTIONS
    ' =========================================================================

    ''' <summary>
    ''' Procedure 1 (Function): Looks up the base fare for a given route using Select Case.
    ''' </summary>
    Private Function GetRouteFare(ByVal routeName As String) As Decimal
        Select Case routeName
            Case "Nairobi - Mombasa"
                Return FARE_MOMBASA
            Case "Nairobi - Kisumu"
                Return FARE_KISUMU
            Case "Nairobi - Eldoret"
                Return FARE_ELDORET
            Case "Nairobi - Nakuru"
                Return FARE_NAKURU
            Case "Nairobi - Nyeri"
                Return FARE_NYERI
            Case "Nairobi - Garissa"
                Return FARE_GARISSA
            Case Else
                Return 0D
        End Select
    End Function

    ''' <summary>
    ''' Procedure 2 (Function): Computes the fare per ticket based on factors.
    ''' Formula: Route fare x Passenger factor x Class factor x Weekend factor
    ''' </summary>
    Private Function CalculateFarePerTicket(ByVal routeFare As Decimal,
                                            ByVal passengerFactor As Decimal,
                                            ByVal classFactor As Decimal,
                                            ByVal weekendFactor As Decimal) As Decimal
        Return routeFare * passengerFactor * classFactor * weekendFactor
    End Function

    ''' <summary>
    ''' Procedure 3 (Function): Iterates through optional extras using a loop
    ''' and sums the total extras per ticket while recording selected names.
    ''' </summary>
    Private Function GetExtrasPerTicket(ByRef selectedExtrasList As List(Of String)) As Decimal
        Dim totalExtras As Decimal = 0D
        selectedExtrasList.Clear()

        ' Use an array of CheckBoxes and a For Each loop to collect ticked extras
        Dim extrasBoxes As CheckBox() = {chkLuggage, chkInsurance, chkMeal}

        For Each chk As CheckBox In extrasBoxes
            If chk.Checked Then
                Select Case chk.Name
                    Case "chkLuggage"
                        totalExtras += EXTRA_LUGGAGE_PRICE
                        selectedExtrasList.Add("Extra luggage")
                    Case "chkInsurance"
                        totalExtras += EXTRA_INSURANCE_PRICE
                        selectedExtrasList.Add("Travel insurance")
                    Case "chkMeal"
                        totalExtras += EXTRA_MEAL_PRICE
                        selectedExtrasList.Add("Meal")
                End Select
            End If
        Next

        Return totalExtras
    End Function

    ''' <summary>
    ''' Procedure 4 (Sub): Formats and displays the itemised receipt in the multiline TextBox.
    ''' </summary>
    Private Sub BuildAndShowReceipt(ByVal passengerName As String,
                                    ByVal routeName As String,
                                    ByVal travelDate As DateTime,
                                    ByVal passengerType As String,
                                    ByVal seatClass As String,
                                    ByVal ticketsCount As Integer,
                                    ByVal farePerTicket As Decimal,
                                    ByVal extrasPerTicket As Decimal,
                                    ByVal extrasText As String,
                                    ByVal subtotal As Decimal,
                                    ByVal groupDiscount As Decimal,
                                    ByVal bookingFee As Decimal,
                                    ByVal grandTotal As Decimal)

        Dim sbReceipt As New StringBuilder()

        ' Header line matching assignment specification
        sbReceipt.AppendLine(" BOOKING RECEIPT ")
        sbReceipt.AppendLine(String.Format("{0,-17}: {1}", "PASSENGER", passengerName))
        sbReceipt.AppendLine(String.Format("{0,-17}: {1}", "ROUTE", routeName))
        ' Format date as "DayOfWeek, d Month" to match the sample specification
        sbReceipt.AppendLine(String.Format("{0,-17}: {1}", "TRAVEL DATE", travelDate.ToString("dddd, d MMMM")))
        sbReceipt.AppendLine(String.Format("{0,-17}: {1} / {2}", "PASSENGER / CLASS", passengerType, seatClass))
        sbReceipt.AppendLine(String.Format("{0,-17}: {1}", "TICKETS", ticketsCount))
        sbReceipt.AppendLine(String.Format("{0,-17}: {1}", "FARE PER TICKET", FormatKES(farePerTicket)))

        ' Extras line with item description
        sbReceipt.AppendLine(String.Format("{0,-17}: {1}  ({2})", "EXTRAS PER TICKET", FormatKES(extrasPerTicket), extrasText))

        sbReceipt.AppendLine(String.Format("{0,-17}: {1}", "SUBTOTAL", FormatKES(subtotal)))
        sbReceipt.AppendLine(String.Format("{0,-17}: {1}", "GROUP DISCOUNT", FormatKES(groupDiscount)))
        sbReceipt.AppendLine(String.Format("{0,-17}: {1}", "BOOKING FEE", FormatKES(bookingFee)))
        sbReceipt.AppendLine(String.Format("{0,-17}: {1}", "TOTAL", FormatKES(grandTotal)))

        txtReceipt.Text = sbReceipt.ToString()
    End Sub

    ' =========================================================================
    ' ADDITIONAL HELPER PROCEDURES & VALIDATION FUNCTIONS
    ' =========================================================================

    ''' <summary>
    ''' Helper Function: Returns whether the travel date falls on a weekend (Saturday or Sunday)
    ''' using the date's DayOfWeek property as required.
    ''' </summary>
    Private Function IsWeekend(ByVal checkDate As DateTime) As Boolean
        Return (checkDate.DayOfWeek = DayOfWeek.Saturday OrElse checkDate.DayOfWeek = DayOfWeek.Sunday)
    End Function

    ''' <summary>
    ''' Helper Function: Returns 1.10 on weekend, otherwise 1.00.
    ''' </summary>
    Private Function GetWeekendFactor(ByVal checkDate As DateTime) As Decimal
        If IsWeekend(checkDate) Then
            Return FACTOR_WEEKEND
        Else
            Return FACTOR_WEEKDAY
        End If
    End Function

    ''' <summary>
    ''' Helper Function: Determines the pricing factor for the selected passenger type.
    ''' </summary>
    Private Function GetPassengerFactor() As Decimal
        If rdoAdult.Checked Then
            Return FACTOR_ADULT
        ElseIf rdoStudent.Checked Then
            Return FACTOR_STUDENT
        ElseIf rdoChild.Checked Then
            Return FACTOR_CHILD
        Else
            Return 0D
        End If
    End Function

    ''' <summary>
    ''' Helper Function: Returns display string for passenger type.
    ''' </summary>
    Private Function GetPassengerTypeName() As String
        If rdoAdult.Checked Then
            Return "Adult"
        ElseIf rdoStudent.Checked Then
            Return "Student"
        ElseIf rdoChild.Checked Then
            Return "Child"
        Else
            Return "Unselected"
        End If
    End Function

    ''' <summary>
    ''' Helper Function: Determines the pricing factor for the selected seat class.
    ''' </summary>
    Private Function GetClassFactor() As Decimal
        If rdoStandard.Checked Then
            Return FACTOR_STANDARD
        ElseIf rdoBusiness.Checked Then
            Return FACTOR_BUSINESS
        Else
            Return 0D
        End If
    End Function

    ''' <summary>
    ''' Helper Function: Returns display string for seat class.
    ''' </summary>
    Private Function GetSeatClassName() As String
        If rdoStandard.Checked Then
            Return "Standard"
        ElseIf rdoBusiness.Checked Then
            Return "Business"
        Else
            Return "Unselected"
        End If
    End Function

    ''' <summary>
    ''' Helper Function: Checks if a string contains any numeric digits using a loop.
    ''' </summary>
    Private Function HasDigits(ByVal text As String) As Boolean
        For Each ch As Char In text
            If Char.IsDigit(ch) Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Helper Function: Formats any Decimal currency value as "KES 4,146.00"
    ''' (thousands separator with two decimal places).
    ''' </summary>
    Private Function FormatKES(ByVal amount As Decimal) As String
        Return "KES " & amount.ToString("N2")
    End Function

    ''' <summary>
    ''' Validation Function: Validates all inputs and reports all problems at once.
    ''' Uses If...ElseIf.
    ''' </summary>
    Private Function ValidateInputs(ByRef errors As List(Of String)) As Boolean
        errors.Clear()
        errProvider.Clear()

        ' 1. Validate Passenger Name: not empty and contains no digits (uses If...ElseIf)
        Dim cleanName As String = txtName.Text.Trim()
        If String.IsNullOrWhiteSpace(cleanName) Then
            errors.Add("• Passenger name cannot be empty.")
            errProvider.SetError(txtName, "Passenger name is required.")
        ElseIf HasDigits(cleanName) Then
            errors.Add("• Passenger name must not contain numbers/digits.")
            errProvider.SetError(txtName, "Name cannot contain digits.")
        End If

        ' 2. Validate Travel Route (uses If...ElseIf)
        If cboRoute.SelectedIndex = -1 Then
            errors.Add("• A travel route must be chosen.")
            errProvider.SetError(cboRoute, "Please select a route from the list.")
        ElseIf String.IsNullOrWhiteSpace(cboRoute.Text) Then
            errors.Add("• Selected route is invalid.")
            errProvider.SetError(cboRoute, "Invalid route selection.")
        End If

        ' 3. Validate Passenger Type (Adult, Student, Child)
        If Not (rdoAdult.Checked OrElse rdoStudent.Checked OrElse rdoChild.Checked) Then
            errors.Add("• A passenger type must be chosen (Adult, Student, or Child).")
            errProvider.SetError(grpPassengerType, "Please select a passenger type.")
        End If

        ' 4. Validate Seat Class (Standard, Business)
        If Not (rdoStandard.Checked OrElse rdoBusiness.Checked) Then
            errors.Add("• A seat class must be chosen (Standard or Business).")
            errProvider.SetError(grpSeatClass, "Please select a seat class.")
        End If

        ' 5. Validate Travel Date: must not be in the past
        If dtpTravelDate.Value.Date < DateTime.Today Then
            errors.Add("• Travel date cannot be in the past. Please choose today or a future date.")
            errProvider.SetError(dtpTravelDate, "Travel date cannot be in the past.")
        End If

        Return (errors.Count = 0)
    End Function

    ''' <summary>
    ''' Sub Procedure: Resets every form control to its starting initial state.
    ''' </summary>
    Private Sub ResetForm()
        txtName.Clear()
        cboRoute.SelectedIndex = -1

        ' Uncheck all radio buttons so validation can verify selection
        rdoAdult.Checked = False
        rdoStudent.Checked = False
        rdoChild.Checked = False

        rdoStandard.Checked = False
        rdoBusiness.Checked = False

        ' Reset numeric tickets to default of 1
        nudTickets.Value = 1D

        ' Reset travel date to current date
        dtpTravelDate.Value = DateTime.Today

        ' Uncheck all extras
        chkLuggage.Checked = False
        chkInsurance.Checked = False
        chkMeal.Checked = False

        ' Clear receipt and error markers
        txtReceipt.Clear()
        errProvider.Clear()

        ' Set focus to first input
        txtName.Focus()
    End Sub

    Private Sub lblHeaderSubtitle_Click(sender As Object, e As EventArgs) Handles lblHeaderSubtitle.Click

    End Sub

    Private Sub tipHelper_Popup(sender As Object, e As PopupEventArgs) Handles tipHelper.Popup

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub cboRoute_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoute.SelectedIndexChanged

    End Sub
End Class
