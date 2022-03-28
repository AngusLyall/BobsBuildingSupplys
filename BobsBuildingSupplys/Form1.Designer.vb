<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbl_CusTitle = New System.Windows.Forms.Label()
        Me.lbl_CustFirstName = New System.Windows.Forms.Label()
        Me.lbl_custLastName = New System.Windows.Forms.Label()
        Me.txt_CusFirstName = New System.Windows.Forms.TextBox()
        Me.txt_CusLastName = New System.Windows.Forms.TextBox()
        Me.lbl_BusinessName = New System.Windows.Forms.Label()
        Me.txt_CusBusinessName = New System.Windows.Forms.TextBox()
        Me.lbl_custphone = New System.Windows.Forms.Label()
        Me.txt_CusPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lbl_cusBillingAdress = New System.Windows.Forms.Label()
        Me.lbl_cusDeliveryAdress = New System.Windows.Forms.Label()
        Me.txt_CusDeliveryAddress = New System.Windows.Forms.TextBox()
        Me.txt_CusBillingAdress = New System.Windows.Forms.TextBox()
        Me.chk_DeliverySameBilling = New System.Windows.Forms.CheckBox()
        Me.chk_TradeCus = New System.Windows.Forms.CheckBox()
        Me.tmr_RequestLimiter = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_FirstNameRequired = New System.Windows.Forms.Label()
        Me.lbl_LastNameRequired = New System.Windows.Forms.Label()
        Me.lbl_BusinessNameRequired = New System.Windows.Forms.Label()
        Me.lbl_PhoneNumberRequired = New System.Windows.Forms.Label()
        Me.lbl_BillingRequired = New System.Windows.Forms.Label()
        Me.lbl_DeliveryRequired = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_CusTitle
        '
        Me.lbl_CusTitle.AutoSize = True
        Me.lbl_CusTitle.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_CusTitle.Location = New System.Drawing.Point(47, 18)
        Me.lbl_CusTitle.Name = "lbl_CusTitle"
        Me.lbl_CusTitle.Size = New System.Drawing.Size(388, 65)
        Me.lbl_CusTitle.TabIndex = 0
        Me.lbl_CusTitle.Text = "Customer Details"
        '
        'lbl_CustFirstName
        '
        Me.lbl_CustFirstName.AutoSize = True
        Me.lbl_CustFirstName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_CustFirstName.Location = New System.Drawing.Point(12, 115)
        Me.lbl_CustFirstName.Name = "lbl_CustFirstName"
        Me.lbl_CustFirstName.Size = New System.Drawing.Size(109, 30)
        Me.lbl_CustFirstName.TabIndex = 1
        Me.lbl_CustFirstName.Text = "First name"
        '
        'lbl_custLastName
        '
        Me.lbl_custLastName.AutoSize = True
        Me.lbl_custLastName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_custLastName.Location = New System.Drawing.Point(12, 156)
        Me.lbl_custLastName.Name = "lbl_custLastName"
        Me.lbl_custLastName.Size = New System.Drawing.Size(108, 30)
        Me.lbl_custLastName.TabIndex = 2
        Me.lbl_custLastName.Text = "Last name"
        '
        'txt_CusFirstName
        '
        Me.txt_CusFirstName.Location = New System.Drawing.Point(191, 122)
        Me.txt_CusFirstName.Name = "txt_CusFirstName"
        Me.txt_CusFirstName.Size = New System.Drawing.Size(283, 23)
        Me.txt_CusFirstName.TabIndex = 3
        '
        'txt_CusLastName
        '
        Me.txt_CusLastName.Location = New System.Drawing.Point(191, 161)
        Me.txt_CusLastName.Name = "txt_CusLastName"
        Me.txt_CusLastName.Size = New System.Drawing.Size(283, 23)
        Me.txt_CusLastName.TabIndex = 4
        '
        'lbl_BusinessName
        '
        Me.lbl_BusinessName.AutoSize = True
        Me.lbl_BusinessName.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_BusinessName.Location = New System.Drawing.Point(11, 194)
        Me.lbl_BusinessName.Name = "lbl_BusinessName"
        Me.lbl_BusinessName.Size = New System.Drawing.Size(154, 30)
        Me.lbl_BusinessName.TabIndex = 5
        Me.lbl_BusinessName.Text = "Business Name"
        '
        'txt_CusBusinessName
        '
        Me.txt_CusBusinessName.Location = New System.Drawing.Point(191, 198)
        Me.txt_CusBusinessName.Name = "txt_CusBusinessName"
        Me.txt_CusBusinessName.Size = New System.Drawing.Size(283, 23)
        Me.txt_CusBusinessName.TabIndex = 6
        '
        'lbl_custphone
        '
        Me.lbl_custphone.AutoSize = True
        Me.lbl_custphone.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_custphone.Location = New System.Drawing.Point(12, 232)
        Me.lbl_custphone.Name = "lbl_custphone"
        Me.lbl_custphone.Size = New System.Drawing.Size(154, 30)
        Me.lbl_custphone.TabIndex = 7
        Me.lbl_custphone.Text = "Phone Number"
        '
        'txt_CusPhoneNumber
        '
        Me.txt_CusPhoneNumber.Location = New System.Drawing.Point(191, 236)
        Me.txt_CusPhoneNumber.Name = "txt_CusPhoneNumber"
        Me.txt_CusPhoneNumber.Size = New System.Drawing.Size(283, 23)
        Me.txt_CusPhoneNumber.TabIndex = 8
        '
        'lbl_cusBillingAdress
        '
        Me.lbl_cusBillingAdress.AutoSize = True
        Me.lbl_cusBillingAdress.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_cusBillingAdress.Location = New System.Drawing.Point(12, 272)
        Me.lbl_cusBillingAdress.Name = "lbl_cusBillingAdress"
        Me.lbl_cusBillingAdress.Size = New System.Drawing.Size(149, 30)
        Me.lbl_cusBillingAdress.TabIndex = 9
        Me.lbl_cusBillingAdress.Text = "Billing Address"
        '
        'lbl_cusDeliveryAdress
        '
        Me.lbl_cusDeliveryAdress.AutoSize = True
        Me.lbl_cusDeliveryAdress.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_cusDeliveryAdress.Location = New System.Drawing.Point(12, 309)
        Me.lbl_cusDeliveryAdress.Name = "lbl_cusDeliveryAdress"
        Me.lbl_cusDeliveryAdress.Size = New System.Drawing.Size(167, 30)
        Me.lbl_cusDeliveryAdress.TabIndex = 10
        Me.lbl_cusDeliveryAdress.Text = "Delivery Address"
        '
        'txt_CusDeliveryAddress
        '
        Me.txt_CusDeliveryAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txt_CusDeliveryAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_CusDeliveryAddress.Location = New System.Drawing.Point(191, 312)
        Me.txt_CusDeliveryAddress.Name = "txt_CusDeliveryAddress"
        Me.txt_CusDeliveryAddress.Size = New System.Drawing.Size(283, 23)
        Me.txt_CusDeliveryAddress.TabIndex = 13
        '
        'txt_CusBillingAdress
        '
        Me.txt_CusBillingAdress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txt_CusBillingAdress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_CusBillingAdress.Location = New System.Drawing.Point(191, 275)
        Me.txt_CusBillingAdress.Name = "txt_CusBillingAdress"
        Me.txt_CusBillingAdress.Size = New System.Drawing.Size(283, 23)
        Me.txt_CusBillingAdress.TabIndex = 12
        '
        'chk_DeliverySameBilling
        '
        Me.chk_DeliverySameBilling.AutoSize = True
        Me.chk_DeliverySameBilling.Location = New System.Drawing.Point(12, 356)
        Me.chk_DeliverySameBilling.Name = "chk_DeliverySameBilling"
        Me.chk_DeliverySameBilling.Size = New System.Drawing.Size(188, 19)
        Me.chk_DeliverySameBilling.TabIndex = 14
        Me.chk_DeliverySameBilling.Text = "Delivery Adress Same as Billing"
        Me.chk_DeliverySameBilling.UseVisualStyleBackColor = True
        '
        'chk_TradeCus
        '
        Me.chk_TradeCus.AutoSize = True
        Me.chk_TradeCus.Location = New System.Drawing.Point(12, 374)
        Me.chk_TradeCus.Name = "chk_TradeCus"
        Me.chk_TradeCus.Size = New System.Drawing.Size(109, 19)
        Me.chk_TradeCus.TabIndex = 15
        Me.chk_TradeCus.Text = "Trade Customer"
        Me.chk_TradeCus.UseVisualStyleBackColor = True
        '
        'tmr_RequestLimiter
        '
        Me.tmr_RequestLimiter.Enabled = True
        Me.tmr_RequestLimiter.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(407, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_FirstNameRequired
        '
        Me.lbl_FirstNameRequired.AutoSize = True
        Me.lbl_FirstNameRequired.ForeColor = System.Drawing.Color.Red
        Me.lbl_FirstNameRequired.Location = New System.Drawing.Point(112, 118)
        Me.lbl_FirstNameRequired.Name = "lbl_FirstNameRequired"
        Me.lbl_FirstNameRequired.Size = New System.Drawing.Size(12, 15)
        Me.lbl_FirstNameRequired.TabIndex = 17
        Me.lbl_FirstNameRequired.Text = "*"
        Me.lbl_FirstNameRequired.Visible = False
        '
        'lbl_LastNameRequired
        '
        Me.lbl_LastNameRequired.AutoSize = True
        Me.lbl_LastNameRequired.ForeColor = System.Drawing.Color.Red
        Me.lbl_LastNameRequired.Location = New System.Drawing.Point(111, 159)
        Me.lbl_LastNameRequired.Name = "lbl_LastNameRequired"
        Me.lbl_LastNameRequired.Size = New System.Drawing.Size(12, 15)
        Me.lbl_LastNameRequired.TabIndex = 18
        Me.lbl_LastNameRequired.Text = "*"
        Me.lbl_LastNameRequired.Visible = False
        '
        'lbl_BusinessNameRequired
        '
        Me.lbl_BusinessNameRequired.AutoSize = True
        Me.lbl_BusinessNameRequired.ForeColor = System.Drawing.Color.Red
        Me.lbl_BusinessNameRequired.Location = New System.Drawing.Point(156, 197)
        Me.lbl_BusinessNameRequired.Name = "lbl_BusinessNameRequired"
        Me.lbl_BusinessNameRequired.Size = New System.Drawing.Size(12, 15)
        Me.lbl_BusinessNameRequired.TabIndex = 19
        Me.lbl_BusinessNameRequired.Text = "*"
        Me.lbl_BusinessNameRequired.Visible = False
        '
        'lbl_PhoneNumberRequired
        '
        Me.lbl_PhoneNumberRequired.AutoSize = True
        Me.lbl_PhoneNumberRequired.ForeColor = System.Drawing.Color.Red
        Me.lbl_PhoneNumberRequired.Location = New System.Drawing.Point(158, 236)
        Me.lbl_PhoneNumberRequired.Name = "lbl_PhoneNumberRequired"
        Me.lbl_PhoneNumberRequired.Size = New System.Drawing.Size(12, 15)
        Me.lbl_PhoneNumberRequired.TabIndex = 20
        Me.lbl_PhoneNumberRequired.Text = "*"
        Me.lbl_PhoneNumberRequired.Visible = False
        '
        'lbl_BillingRequired
        '
        Me.lbl_BillingRequired.AutoSize = True
        Me.lbl_BillingRequired.ForeColor = System.Drawing.Color.Red
        Me.lbl_BillingRequired.Location = New System.Drawing.Point(154, 275)
        Me.lbl_BillingRequired.Name = "lbl_BillingRequired"
        Me.lbl_BillingRequired.Size = New System.Drawing.Size(12, 15)
        Me.lbl_BillingRequired.TabIndex = 21
        Me.lbl_BillingRequired.Text = "*"
        Me.lbl_BillingRequired.Visible = False
        '
        'lbl_DeliveryRequired
        '
        Me.lbl_DeliveryRequired.AutoSize = True
        Me.lbl_DeliveryRequired.ForeColor = System.Drawing.Color.Red
        Me.lbl_DeliveryRequired.Location = New System.Drawing.Point(171, 313)
        Me.lbl_DeliveryRequired.Name = "lbl_DeliveryRequired"
        Me.lbl_DeliveryRequired.Size = New System.Drawing.Size(12, 15)
        Me.lbl_DeliveryRequired.TabIndex = 22
        Me.lbl_DeliveryRequired.Text = "*"
        Me.lbl_DeliveryRequired.Visible = False
        '
        'CustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 412)
        Me.Controls.Add(Me.txt_CusDeliveryAddress)
        Me.Controls.Add(Me.lbl_DeliveryRequired)
        Me.Controls.Add(Me.lbl_BillingRequired)
        Me.Controls.Add(Me.lbl_PhoneNumberRequired)
        Me.Controls.Add(Me.lbl_BusinessNameRequired)
        Me.Controls.Add(Me.lbl_LastNameRequired)
        Me.Controls.Add(Me.lbl_FirstNameRequired)
        Me.Controls.Add(Me.lbl_CustFirstName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chk_TradeCus)
        Me.Controls.Add(Me.chk_DeliverySameBilling)
        Me.Controls.Add(Me.txt_CusBillingAdress)
        Me.Controls.Add(Me.lbl_cusDeliveryAdress)
        Me.Controls.Add(Me.lbl_cusBillingAdress)
        Me.Controls.Add(Me.txt_CusPhoneNumber)
        Me.Controls.Add(Me.lbl_custphone)
        Me.Controls.Add(Me.txt_CusBusinessName)
        Me.Controls.Add(Me.lbl_BusinessName)
        Me.Controls.Add(Me.txt_CusLastName)
        Me.Controls.Add(Me.txt_CusFirstName)
        Me.Controls.Add(Me.lbl_custLastName)
        Me.Controls.Add(Me.lbl_CusTitle)
        Me.Name = "CustomerDetails"
        Me.Text = "Business Name"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_CusTitle As Label
    Friend WithEvents lbl_CustFirstName As Label
    Friend WithEvents lbl_custLastName As Label
    Friend WithEvents txt_CusFirstName As TextBox
    Friend WithEvents txt_CusLastName As TextBox
    Friend WithEvents lbl_BusinessName As Label
    Friend WithEvents txt_CusBusinessName As TextBox
    Friend WithEvents lbl_custphone As Label
    Friend WithEvents txt_CusPhoneNumber As TextBox
    Friend WithEvents lbl_cusBillingAdress As Label
    Friend WithEvents lbl_cusDeliveryAdress As Label
    Friend WithEvents txt_CusDeliveryAddress As TextBox
    Friend WithEvents txt_CusBillingAdress As TextBox
    Friend WithEvents chk_DeliverySameBilling As CheckBox
    Friend WithEvents chk_TradeCus As CheckBox
    Friend WithEvents tmr_RequestLimiter As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_FirstNameRequired As Label
    Friend WithEvents lbl_LastNameRequired As Label
    Friend WithEvents lbl_BusinessNameRequired As Label
    Friend WithEvents lbl_PhoneNumberRequired As Label
    Friend WithEvents lbl_BillingRequired As Label
    Friend WithEvents lbl_DeliveryRequired As Label
End Class
