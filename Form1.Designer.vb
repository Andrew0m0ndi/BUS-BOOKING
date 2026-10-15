Option Strict On
Option Explicit On

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'Controls and Components
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderSubtitle As System.Windows.Forms.Label

    Friend WithEvents grpPassengerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblRoute As System.Windows.Forms.Label
    Friend WithEvents cboRoute As System.Windows.Forms.ComboBox
    Friend WithEvents lblTravelDate As System.Windows.Forms.Label
    Friend WithEvents dtpTravelDate As System.Windows.Forms.DateTimePicker

    Friend WithEvents grpPassengerType As System.Windows.Forms.GroupBox
    Friend WithEvents rdoAdult As System.Windows.Forms.RadioButton
    Friend WithEvents rdoStudent As System.Windows.Forms.RadioButton
    Friend WithEvents rdoChild As System.Windows.Forms.RadioButton

    Friend WithEvents grpSeatClass As System.Windows.Forms.GroupBox
    Friend WithEvents rdoStandard As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBusiness As System.Windows.Forms.RadioButton

    Friend WithEvents grpBookingDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblTickets As System.Windows.Forms.Label
    Friend WithEvents nudTickets As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGroupDiscountInfo As System.Windows.Forms.Label

    Friend WithEvents grpExtras As System.Windows.Forms.GroupBox
    Friend WithEvents chkLuggage As System.Windows.Forms.CheckBox
    Friend WithEvents chkInsurance As System.Windows.Forms.CheckBox
    Friend WithEvents chkMeal As System.Windows.Forms.CheckBox

    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

    Friend WithEvents grpReceipt As System.Windows.Forms.GroupBox
    Friend WithEvents txtReceipt As System.Windows.Forms.TextBox

    Friend WithEvents tipHelper As System.Windows.Forms.ToolTip
    Friend WithEvents errProvider As System.Windows.Forms.ErrorProvider


    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        pnlHeader = New Panel()
        lblHeaderTitle = New Label()
        lblHeaderSubtitle = New Label()
        grpPassengerDetails = New GroupBox()
        lblName = New Label()
        txtName = New TextBox()
        lblRoute = New Label()
        cboRoute = New ComboBox()
        lblTravelDate = New Label()
        dtpTravelDate = New DateTimePicker()
        grpPassengerType = New GroupBox()
        rdoAdult = New RadioButton()
        rdoStudent = New RadioButton()
        rdoChild = New RadioButton()
        grpSeatClass = New GroupBox()
        rdoStandard = New RadioButton()
        rdoBusiness = New RadioButton()
        grpBookingDetails = New GroupBox()
        lblTickets = New Label()
        nudTickets = New NumericUpDown()
        lblGroupDiscountInfo = New Label()
        grpExtras = New GroupBox()
        chkLuggage = New CheckBox()
        chkInsurance = New CheckBox()
        chkMeal = New CheckBox()
        btnCalculate = New Button()
        btnClear = New Button()
        btnExit = New Button()
        grpReceipt = New GroupBox()
        txtReceipt = New TextBox()
        tipHelper = New ToolTip(components)
        errProvider = New ErrorProvider(components)
        pnlHeader.SuspendLayout()
        grpPassengerDetails.SuspendLayout()
        grpPassengerType.SuspendLayout()
        grpSeatClass.SuspendLayout()
        grpBookingDetails.SuspendLayout()
        CType(nudTickets, ComponentModel.ISupportInitialize).BeginInit()
        grpExtras.SuspendLayout()
        grpReceipt.SuspendLayout()
        CType(errProvider, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.DimGray
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSubtitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(4, 5, 4, 5)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1314, 113)
        pnlHeader.TabIndex = 11
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 13.5F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.Black
        lblHeaderTitle.Location = New Point(29, 17)
        lblHeaderTitle.Margin = New Padding(4, 0, 4, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(475, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "BUS TICKET BOOKING CALCULATOR"
        ' 
        ' lblHeaderSubtitle
        ' 
        lblHeaderSubtitle.AutoSize = True
        lblHeaderSubtitle.Font = New Font("Segoe UI", 8.5F)
        lblHeaderSubtitle.ForeColor = Color.Black
        lblHeaderSubtitle.Location = New Point(31, 63)
        lblHeaderSubtitle.Margin = New Padding(4, 0, 4, 0)
        lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        lblHeaderSubtitle.Size = New Size(283, 23)
        lblHeaderSubtitle.TabIndex = 1
        lblHeaderSubtitle.Text = "CPP 2202 Application Programming"
        ' 
        ' grpPassengerDetails
        ' 
        grpPassengerDetails.Controls.Add(lblName)
        grpPassengerDetails.Controls.Add(txtName)
        grpPassengerDetails.Controls.Add(lblRoute)
        grpPassengerDetails.Controls.Add(cboRoute)
        grpPassengerDetails.Controls.Add(lblTravelDate)
        grpPassengerDetails.Controls.Add(dtpTravelDate)
        grpPassengerDetails.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        grpPassengerDetails.Location = New Point(29, 130)
        grpPassengerDetails.Margin = New Padding(4, 5, 4, 5)
        grpPassengerDetails.Name = "grpPassengerDetails"
        grpPassengerDetails.Padding = New Padding(4, 5, 4, 5)
        grpPassengerDetails.Size = New Size(614, 227)
        grpPassengerDetails.TabIndex = 0
        grpPassengerDetails.TabStop = False
        grpPassengerDetails.Text = " Passenger && Trip Details "
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 9.0F)
        lblName.Location = New Point(21, 47)
        lblName.Margin = New Padding(4, 0, 4, 0)
        lblName.Name = "lblName"
        lblName.Size = New Size(147, 25)
        lblName.TabIndex = 0
        lblName.Text = "Passenger Name:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 9.0F)
        txtName.Location = New Point(193, 42)
        txtName.Margin = New Padding(4, 5, 4, 5)
        txtName.Name = "txtName"
        txtName.Size = New Size(377, 31)
        txtName.TabIndex = 0
        tipHelper.SetToolTip(txtName, "Enter the full passenger name (letters and spaces only; no digits allowed).")
        ' 
        ' lblRoute
        ' 
        lblRoute.AutoSize = True
        lblRoute.Font = New Font("Segoe UI", 9.0F)
        lblRoute.Location = New Point(21, 105)
        lblRoute.Margin = New Padding(4, 0, 4, 0)
        lblRoute.Name = "lblRoute"
        lblRoute.Size = New Size(111, 25)
        lblRoute.TabIndex = 2
        lblRoute.Text = "Travel Route:"
        ' 
        ' cboRoute
        ' 
        cboRoute.DropDownStyle = ComboBoxStyle.DropDownList
        cboRoute.Font = New Font("Segoe UI", 9.0F)
        cboRoute.FormattingEnabled = True
        cboRoute.Items.AddRange(New Object() {"Nairobi - Mombasa", "Nairobi - Kisumu", "Nairobi - Eldoret", "Nairobi - Nakuru", "Nairobi - Nyeri", "Nairobi - Garissa"})
        cboRoute.Location = New Point(193, 100)
        cboRoute.Margin = New Padding(4, 5, 4, 5)
        cboRoute.Name = "cboRoute"
        cboRoute.Size = New Size(377, 33)
        cboRoute.TabIndex = 1
        tipHelper.SetToolTip(cboRoute, "Select your destination route from Nairobi.")
        ' 
        ' lblTravelDate
        ' 
        lblTravelDate.AutoSize = True
        lblTravelDate.Font = New Font("Segoe UI", 9.0F)
        lblTravelDate.Location = New Point(21, 163)
        lblTravelDate.Margin = New Padding(4, 0, 4, 0)
        lblTravelDate.Name = "lblTravelDate"
        lblTravelDate.Size = New Size(102, 25)
        lblTravelDate.TabIndex = 4
        lblTravelDate.Text = "Travel Date:"
        ' 
        ' dtpTravelDate
        ' 
        dtpTravelDate.CustomFormat = "dddd, dd MMMM yyyy"
        dtpTravelDate.Font = New Font("Segoe UI", 9.0F)
        dtpTravelDate.Format = DateTimePickerFormat.Custom
        dtpTravelDate.Location = New Point(193, 158)
        dtpTravelDate.Margin = New Padding(4, 5, 4, 5)
        dtpTravelDate.Name = "dtpTravelDate"
        dtpTravelDate.Size = New Size(377, 31)
        dtpTravelDate.TabIndex = 2
        tipHelper.SetToolTip(dtpTravelDate, "Select travel date. Dates in the past are not allowed. Weekend travel (Sat/Sun) includes a 10% factor.")
        ' 
        ' grpPassengerType
        ' 
        grpPassengerType.Controls.Add(rdoAdult)
        grpPassengerType.Controls.Add(rdoStudent)
        grpPassengerType.Controls.Add(rdoChild)
        grpPassengerType.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        grpPassengerType.Location = New Point(29, 370)
        grpPassengerType.Margin = New Padding(4, 5, 4, 5)
        grpPassengerType.Name = "grpPassengerType"
        grpPassengerType.Padding = New Padding(4, 5, 4, 5)
        grpPassengerType.Size = New Size(300, 193)
        grpPassengerType.TabIndex = 1
        grpPassengerType.TabStop = False
        grpPassengerType.Text = " Passenger Type "
        ' 
        ' rdoAdult
        ' 
        rdoAdult.AutoSize = True
        rdoAdult.Font = New Font("Segoe UI", 9.0F)
        rdoAdult.Location = New Point(29, 43)
        rdoAdult.Margin = New Padding(4, 5, 4, 5)
        rdoAdult.Name = "rdoAdult"
        rdoAdult.Size = New Size(85, 29)
        rdoAdult.TabIndex = 0
        rdoAdult.TabStop = True
        rdoAdult.Text = "Adult "
        tipHelper.SetToolTip(rdoAdult, "Standard adult fare (factor: 1.00)")
        rdoAdult.UseVisualStyleBackColor = True
        ' 
        ' rdoStudent
        ' 
        rdoStudent.AutoSize = True
        rdoStudent.Font = New Font("Segoe UI", 9.0F)
        rdoStudent.Location = New Point(29, 88)
        rdoStudent.Margin = New Padding(4, 5, 4, 5)
        rdoStudent.Name = "rdoStudent"
        rdoStudent.Size = New Size(98, 29)
        rdoStudent.TabIndex = 1
        rdoStudent.TabStop = True
        rdoStudent.Text = "Student"
        tipHelper.SetToolTip(rdoStudent, "Student concession fare (factor: 0.80)")
        rdoStudent.UseVisualStyleBackColor = True
        ' 
        ' rdoChild
        ' 
        rdoChild.AutoSize = True
        rdoChild.Font = New Font("Segoe UI", 9.0F)
        rdoChild.Location = New Point(29, 133)
        rdoChild.Margin = New Padding(4, 5, 4, 5)
        rdoChild.Name = "rdoChild"
        rdoChild.Size = New Size(82, 29)
        rdoChild.TabIndex = 2
        rdoChild.TabStop = True
        rdoChild.Text = "Child "
        tipHelper.SetToolTip(rdoChild, "Child concession fare (factor: 0.50)")
        rdoChild.UseVisualStyleBackColor = True
        ' 
        ' grpSeatClass
        ' 
        grpSeatClass.Controls.Add(rdoStandard)
        grpSeatClass.Controls.Add(rdoBusiness)
        grpSeatClass.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        grpSeatClass.Location = New Point(343, 370)
        grpSeatClass.Margin = New Padding(4, 5, 4, 5)
        grpSeatClass.Name = "grpSeatClass"
        grpSeatClass.Padding = New Padding(4, 5, 4, 5)
        grpSeatClass.Size = New Size(300, 193)
        grpSeatClass.TabIndex = 2
        grpSeatClass.TabStop = False
        grpSeatClass.Text = " Seat Class "
        ' 
        ' rdoStandard
        ' 
        rdoStandard.AutoSize = True
        rdoStandard.Font = New Font("Segoe UI", 9.0F)
        rdoStandard.Location = New Point(29, 60)
        rdoStandard.Margin = New Padding(4, 5, 4, 5)
        rdoStandard.Name = "rdoStandard"
        rdoStandard.Size = New Size(113, 29)
        rdoStandard.TabIndex = 0
        rdoStandard.TabStop = True
        rdoStandard.Text = "Standard "
        tipHelper.SetToolTip(rdoStandard, "Standard coach class (factor: 1.00)")
        rdoStandard.UseVisualStyleBackColor = True
        ' 
        ' rdoBusiness
        ' 
        rdoBusiness.AutoSize = True
        rdoBusiness.Font = New Font("Segoe UI", 9.0F)
        rdoBusiness.Location = New Point(29, 113)
        rdoBusiness.Margin = New Padding(4, 5, 4, 5)
        rdoBusiness.Name = "rdoBusiness"
        rdoBusiness.Size = New Size(109, 29)
        rdoBusiness.TabIndex = 1
        rdoBusiness.TabStop = True
        rdoBusiness.Text = "Business "
        tipHelper.SetToolTip(rdoBusiness, "Premium business class (factor: 1.40)")
        rdoBusiness.UseVisualStyleBackColor = True
        ' 
        ' grpBookingDetails
        ' 
        grpBookingDetails.Controls.Add(lblTickets)
        grpBookingDetails.Controls.Add(nudTickets)
        grpBookingDetails.Controls.Add(lblGroupDiscountInfo)
        grpBookingDetails.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        grpBookingDetails.Location = New Point(29, 575)
        grpBookingDetails.Margin = New Padding(4, 5, 4, 5)
        grpBookingDetails.Name = "grpBookingDetails"
        grpBookingDetails.Padding = New Padding(4, 5, 4, 5)
        grpBookingDetails.Size = New Size(614, 108)
        grpBookingDetails.TabIndex = 3
        grpBookingDetails.TabStop = False
        grpBookingDetails.Text = " Ticket Quantity "
        ' 
        ' lblTickets
        ' 
        lblTickets.AutoSize = True
        lblTickets.Font = New Font("Segoe UI", 9.0F)
        lblTickets.Location = New Point(21, 45)
        lblTickets.Margin = New Padding(4, 0, 4, 0)
        lblTickets.Name = "lblTickets"
        lblTickets.Size = New Size(233, 25)
        lblTickets.TabIndex = 0
        lblTickets.Text = "Number of Tickets (1 to 10):"
        ' 
        ' nudTickets
        ' 
        nudTickets.Font = New Font("Segoe UI", 9.0F)
        nudTickets.Location = New Point(264, 42)
        nudTickets.Margin = New Padding(4, 5, 4, 5)
        nudTickets.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        nudTickets.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudTickets.Name = "nudTickets"
        nudTickets.Size = New Size(100, 31)
        nudTickets.TabIndex = 0
        tipHelper.SetToolTip(nudTickets, "Select between 1 and 10 tickets. Bookings of 5 or more receive a 10% group discount!")
        nudTickets.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' lblGroupDiscountInfo
        ' 
        lblGroupDiscountInfo.AutoSize = True
        lblGroupDiscountInfo.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic)
        lblGroupDiscountInfo.ForeColor = Color.FromArgb(64, 64, 64)
        lblGroupDiscountInfo.Location = New Point(379, 48)
        lblGroupDiscountInfo.Margin = New Padding(4, 0, 4, 0)
        lblGroupDiscountInfo.Name = "lblGroupDiscountInfo"
        lblGroupDiscountInfo.Size = New Size(233, 23)
        lblGroupDiscountInfo.TabIndex = 2
        lblGroupDiscountInfo.Text = "(10% group discount for >= 5)"
        ' 
        ' grpExtras
        ' 
        grpExtras.Controls.Add(chkLuggage)
        grpExtras.Controls.Add(chkInsurance)
        grpExtras.Controls.Add(chkMeal)
        grpExtras.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        grpExtras.Location = New Point(29, 697)
        grpExtras.Margin = New Padding(4, 5, 4, 5)
        grpExtras.Name = "grpExtras"
        grpExtras.Padding = New Padding(4, 5, 4, 5)
        grpExtras.Size = New Size(614, 180)
        grpExtras.TabIndex = 4
        grpExtras.TabStop = False
        grpExtras.Text = " Optional Extras (Charged Per Ticket) "
        ' 
        ' chkLuggage
        ' 
        chkLuggage.AutoSize = True
        chkLuggage.Font = New Font("Segoe UI", 9.0F)
        chkLuggage.Location = New Point(29, 42)
        chkLuggage.Margin = New Padding(4, 5, 4, 5)
        chkLuggage.Name = "chkLuggage"
        chkLuggage.Size = New Size(249, 29)
        chkLuggage.TabIndex = 0
        chkLuggage.Text = "Extra luggage (KES 200.00)"
        tipHelper.SetToolTip(chkLuggage, "Luggage allowance up to 30kg (KES 200 per ticket)")
        chkLuggage.UseVisualStyleBackColor = True
        ' 
        ' chkInsurance
        ' 
        chkInsurance.AutoSize = True
        chkInsurance.Font = New Font("Segoe UI", 9.0F)
        chkInsurance.Location = New Point(29, 85)
        chkInsurance.Margin = New Padding(4, 5, 4, 5)
        chkInsurance.Name = "chkInsurance"
        chkInsurance.Size = New Size(264, 29)
        chkInsurance.TabIndex = 1
        chkInsurance.Text = "Travel insurance (KES 100.00)"
        tipHelper.SetToolTip(chkInsurance, "Comprehensive trip cover (KES 100 per ticket)")
        chkInsurance.UseVisualStyleBackColor = True
        ' 
        ' chkMeal
        ' 
        chkMeal.AutoSize = True
        chkMeal.Font = New Font("Segoe UI", 9.0F)
        chkMeal.Location = New Point(29, 128)
        chkMeal.Margin = New Padding(4, 5, 4, 5)
        chkMeal.Name = "chkMeal"
        chkMeal.Size = New Size(179, 29)
        chkMeal.TabIndex = 2
        chkMeal.Text = "Meal (KES 250.00)"
        tipHelper.SetToolTip(chkMeal, "On-board refreshment and meal (KES 250 per ticket)")
        chkMeal.UseVisualStyleBackColor = True
        ' 
        ' btnCalculate
        ' 
        btnCalculate.BackColor = Color.Gray
        btnCalculate.Cursor = Cursors.Hand
        btnCalculate.FlatStyle = FlatStyle.Flat
        btnCalculate.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnCalculate.ForeColor = Color.Black
        btnCalculate.Location = New Point(29, 897)
        btnCalculate.Margin = New Padding(4, 5, 4, 5)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(186, 70)
        btnCalculate.TabIndex = 5
        btnCalculate.Text = "CALCULATE"
        tipHelper.SetToolTip(btnCalculate, "Validate input fields, compute ticket fare, and generate receipt.")
        btnCalculate.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Gray
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(243, 897)
        btnClear.Margin = New Padding(4, 5, 4, 5)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(186, 70)
        btnClear.TabIndex = 6
        btnClear.Text = "CLEAR"
        tipHelper.SetToolTip(btnClear, "Reset all input fields and the receipt to their starting state.")
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Gray
        btnExit.Cursor = Cursors.Hand
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnExit.ForeColor = Color.Black
        btnExit.Location = New Point(457, 897)
        btnExit.Margin = New Padding(4, 5, 4, 5)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(186, 70)
        btnExit.TabIndex = 7
        btnExit.Text = "EXIT"
        tipHelper.SetToolTip(btnExit, "Exit the application (requires confirmation).")
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' grpReceipt
        ' 
        grpReceipt.Controls.Add(txtReceipt)
        grpReceipt.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        grpReceipt.Location = New Point(671, 130)
        grpReceipt.Margin = New Padding(4, 5, 4, 5)
        grpReceipt.Name = "grpReceipt"
        grpReceipt.Padding = New Padding(4, 5, 4, 5)
        grpReceipt.Size = New Size(614, 837)
        grpReceipt.TabIndex = 8
        grpReceipt.TabStop = False
        grpReceipt.Text = "Booking Receipt "
        ' 
        ' txtReceipt
        ' 
        txtReceipt.BackColor = Color.Silver
        txtReceipt.Font = New Font("Lucida Fax", 10.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        txtReceipt.Location = New Point(21, 42)
        txtReceipt.Margin = New Padding(4, 5, 4, 5)
        txtReceipt.Multiline = True
        txtReceipt.Name = "txtReceipt"
        txtReceipt.ReadOnly = True
        txtReceipt.ScrollBars = ScrollBars.Vertical
        txtReceipt.Size = New Size(570, 767)
        txtReceipt.TabIndex = 0
        tipHelper.SetToolTip(txtReceipt, "Generated itemised receipt showing full fare breakdown.")
        ' 
        ' tipHelper
        ' 
        ' 
        ' errProvider
        ' 
        errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
        errProvider.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(245, 247, 250)
        CancelButton = btnExit
        ClientSize = New Size(1314, 1000)
        Controls.Add(grpReceipt)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(grpExtras)
        Controls.Add(grpBookingDetails)
        Controls.Add(grpSeatClass)
        Controls.Add(grpPassengerType)
        Controls.Add(grpPassengerDetails)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bus Ticket Booking Calculator "
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        grpPassengerDetails.ResumeLayout(False)
        grpPassengerDetails.PerformLayout()
        grpPassengerType.ResumeLayout(False)
        grpPassengerType.PerformLayout()
        grpSeatClass.ResumeLayout(False)
        grpSeatClass.PerformLayout()
        grpBookingDetails.ResumeLayout(False)
        grpBookingDetails.PerformLayout()
        CType(nudTickets, ComponentModel.ISupportInitialize).EndInit()
        grpExtras.ResumeLayout(False)
        grpExtras.PerformLayout()
        grpReceipt.ResumeLayout(False)
        grpReceipt.PerformLayout()
        CType(errProvider, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

End Class
