<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_OrderDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_OrderDetails))
        Me.lbl_OrderHeader = New System.Windows.Forms.Label()
        Me.lbl_kitchenSubHead = New System.Windows.Forms.Label()
        Me.chk_KitchenA = New System.Windows.Forms.CheckBox()
        Me.chk_KitchenB = New System.Windows.Forms.CheckBox()
        Me.chk_KitchenC = New System.Windows.Forms.CheckBox()
        Me.cbo_kitchenTV = New System.Windows.Forms.ComboBox()
        Me.cbo_kitchenSAT = New System.Windows.Forms.ComboBox()
        Me.cbo_kitchenNet = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_kitchen2G = New System.Windows.Forms.ComboBox()
        Me.cbo_kitchen1G = New System.Windows.Forms.ComboBox()
        Me.chk_HeatPumpBedOne = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbo_bed1_2G = New System.Windows.Forms.ComboBox()
        Me.cbo_bed1_1G = New System.Windows.Forms.ComboBox()
        Me.lbl_Bed1SubHead = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbo_bed1Net = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbo_bed1SAT = New System.Windows.Forms.ComboBox()
        Me.cbo_bed1TV = New System.Windows.Forms.ComboBox()
        Me.chk_HeatPumpLiving = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbo_Living2G = New System.Windows.Forms.ComboBox()
        Me.cbo_Living1G = New System.Windows.Forms.ComboBox()
        Me.lbl_LivingSubHead = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_LivingNet = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_LivingSAT = New System.Windows.Forms.ComboBox()
        Me.cbo_LivingTV = New System.Windows.Forms.ComboBox()
        Me.chk_HeatPumpBedTwo = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbo_bed2_2G = New System.Windows.Forms.ComboBox()
        Me.cbo_bed2_1G = New System.Windows.Forms.ComboBox()
        Me.lbl_Bed2SubHead = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbo_bed2Net = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cbo_bed2SAT = New System.Windows.Forms.ComboBox()
        Me.cbo_bed2TV = New System.Windows.Forms.ComboBox()
        Me.chk_UpgradeBathRoom = New System.Windows.Forms.CheckBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbo_bath2G = New System.Windows.Forms.ComboBox()
        Me.cbo_bath1G = New System.Windows.Forms.ComboBox()
        Me.lbl_BathSubHead = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_totaldisplay = New System.Windows.Forms.Label()
        Me.lbl_kitch_cost = New System.Windows.Forms.Label()
        Me.lbl_bedroom_one = New System.Windows.Forms.Label()
        Me.lbl_living_cost = New System.Windows.Forms.Label()
        Me.lbl_bedroom_two_cost = New System.Windows.Forms.Label()
        Me.lbl_bathroom_cost = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_OrderHeader
        '
        Me.lbl_OrderHeader.AutoSize = True
        Me.lbl_OrderHeader.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_OrderHeader.Location = New System.Drawing.Point(116, 9)
        Me.lbl_OrderHeader.Name = "lbl_OrderHeader"
        Me.lbl_OrderHeader.Size = New System.Drawing.Size(316, 65)
        Me.lbl_OrderHeader.TabIndex = 0
        Me.lbl_OrderHeader.Text = "Quote Details"
        '
        'lbl_kitchenSubHead
        '
        Me.lbl_kitchenSubHead.AutoSize = True
        Me.lbl_kitchenSubHead.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_kitchenSubHead.Location = New System.Drawing.Point(7, 71)
        Me.lbl_kitchenSubHead.Name = "lbl_kitchenSubHead"
        Me.lbl_kitchenSubHead.Size = New System.Drawing.Size(82, 30)
        Me.lbl_kitchenSubHead.TabIndex = 1
        Me.lbl_kitchenSubHead.Text = "Kitchen"
        '
        'chk_KitchenA
        '
        Me.chk_KitchenA.AutoSize = True
        Me.chk_KitchenA.Location = New System.Drawing.Point(12, 104)
        Me.chk_KitchenA.Name = "chk_KitchenA"
        Me.chk_KitchenA.Size = New System.Drawing.Size(82, 19)
        Me.chk_KitchenA.TabIndex = 2
        Me.chk_KitchenA.Text = "Upgrade A"
        Me.chk_KitchenA.UseVisualStyleBackColor = True
        '
        'chk_KitchenB
        '
        Me.chk_KitchenB.AutoSize = True
        Me.chk_KitchenB.Location = New System.Drawing.Point(12, 129)
        Me.chk_KitchenB.Name = "chk_KitchenB"
        Me.chk_KitchenB.Size = New System.Drawing.Size(81, 19)
        Me.chk_KitchenB.TabIndex = 3
        Me.chk_KitchenB.Text = "Upgrade B"
        Me.chk_KitchenB.UseVisualStyleBackColor = True
        '
        'chk_KitchenC
        '
        Me.chk_KitchenC.AutoSize = True
        Me.chk_KitchenC.Location = New System.Drawing.Point(12, 154)
        Me.chk_KitchenC.Name = "chk_KitchenC"
        Me.chk_KitchenC.Size = New System.Drawing.Size(82, 19)
        Me.chk_KitchenC.TabIndex = 4
        Me.chk_KitchenC.Text = "Upgrade C"
        Me.chk_KitchenC.UseVisualStyleBackColor = True
        '
        'cbo_kitchenTV
        '
        Me.cbo_kitchenTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_kitchenTV.FormattingEnabled = True
        Me.cbo_kitchenTV.Items.AddRange(New Object() {"0", "1"})
        Me.cbo_kitchenTV.Location = New System.Drawing.Point(100, 98)
        Me.cbo_kitchenTV.Name = "cbo_kitchenTV"
        Me.cbo_kitchenTV.Size = New System.Drawing.Size(54, 23)
        Me.cbo_kitchenTV.Sorted = True
        Me.cbo_kitchenTV.TabIndex = 5
        '
        'cbo_kitchenSAT
        '
        Me.cbo_kitchenSAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_kitchenSAT.FormattingEnabled = True
        Me.cbo_kitchenSAT.Items.AddRange(New Object() {"0", "1"})
        Me.cbo_kitchenSAT.Location = New System.Drawing.Point(100, 127)
        Me.cbo_kitchenSAT.Name = "cbo_kitchenSAT"
        Me.cbo_kitchenSAT.Size = New System.Drawing.Size(54, 23)
        Me.cbo_kitchenSAT.Sorted = True
        Me.cbo_kitchenSAT.TabIndex = 6
        '
        'cbo_kitchenNet
        '
        Me.cbo_kitchenNet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_kitchenNet.FormattingEnabled = True
        Me.cbo_kitchenNet.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_kitchenNet.Location = New System.Drawing.Point(100, 156)
        Me.cbo_kitchenNet.Name = "cbo_kitchenNet"
        Me.cbo_kitchenNet.Size = New System.Drawing.Size(54, 23)
        Me.cbo_kitchenNet.Sorted = True
        Me.cbo_kitchenNet.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "TV point"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SAT point"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(282, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "2G Sockets"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(282, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "1G Sockets"
        '
        'cbo_kitchen2G
        '
        Me.cbo_kitchen2G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_kitchen2G.FormattingEnabled = True
        Me.cbo_kitchen2G.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_kitchen2G.Location = New System.Drawing.Point(222, 127)
        Me.cbo_kitchen2G.Name = "cbo_kitchen2G"
        Me.cbo_kitchen2G.Size = New System.Drawing.Size(54, 23)
        Me.cbo_kitchen2G.Sorted = True
        Me.cbo_kitchen2G.TabIndex = 12
        '
        'cbo_kitchen1G
        '
        Me.cbo_kitchen1G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_kitchen1G.FormattingEnabled = True
        Me.cbo_kitchen1G.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_kitchen1G.Location = New System.Drawing.Point(222, 98)
        Me.cbo_kitchen1G.Name = "cbo_kitchen1G"
        Me.cbo_kitchen1G.Size = New System.Drawing.Size(54, 23)
        Me.cbo_kitchen1G.Sorted = True
        Me.cbo_kitchen1G.TabIndex = 11
        '
        'chk_HeatPumpBedOne
        '
        Me.chk_HeatPumpBedOne.AutoSize = True
        Me.chk_HeatPumpBedOne.Location = New System.Drawing.Point(406, 468)
        Me.chk_HeatPumpBedOne.Name = "chk_HeatPumpBedOne"
        Me.chk_HeatPumpBedOne.Size = New System.Drawing.Size(128, 19)
        Me.chk_HeatPumpBedOne.TabIndex = 40
        Me.chk_HeatPumpBedOne.Text = "Heat Pump (2.5Kw)"
        Me.chk_HeatPumpBedOne.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(464, 445)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 15)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "2G Sockets"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(464, 417)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 15)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "1G Sockets"
        '
        'cbo_bed1_2G
        '
        Me.cbo_bed1_2G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bed1_2G.FormattingEnabled = True
        Me.cbo_bed1_2G.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_bed1_2G.Location = New System.Drawing.Point(404, 441)
        Me.cbo_bed1_2G.Name = "cbo_bed1_2G"
        Me.cbo_bed1_2G.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bed1_2G.Sorted = True
        Me.cbo_bed1_2G.TabIndex = 37
        '
        'cbo_bed1_1G
        '
        Me.cbo_bed1_1G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bed1_1G.FormattingEnabled = True
        Me.cbo_bed1_1G.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_bed1_1G.Location = New System.Drawing.Point(404, 412)
        Me.cbo_bed1_1G.Name = "cbo_bed1_1G"
        Me.cbo_bed1_1G.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bed1_1G.Sorted = True
        Me.cbo_bed1_1G.TabIndex = 36
        '
        'lbl_Bed1SubHead
        '
        Me.lbl_Bed1SubHead.AutoSize = True
        Me.lbl_Bed1SubHead.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Bed1SubHead.Location = New System.Drawing.Point(281, 379)
        Me.lbl_Bed1SubHead.Name = "lbl_Bed1SubHead"
        Me.lbl_Bed1SubHead.Size = New System.Drawing.Size(153, 30)
        Me.lbl_Bed1SubHead.TabIndex = 35
        Me.lbl_Bed1SubHead.Text = "Bed Room One"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(345, 473)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 15)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "Network"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(345, 444)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 15)
        Me.Label18.TabIndex = 33
        Me.Label18.Text = "SAT Point"
        '
        'cbo_bed1Net
        '
        Me.cbo_bed1Net.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bed1Net.FormattingEnabled = True
        Me.cbo_bed1Net.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_bed1Net.Location = New System.Drawing.Point(285, 470)
        Me.cbo_bed1Net.MaxDropDownItems = 4
        Me.cbo_bed1Net.MaxLength = 4
        Me.cbo_bed1Net.Name = "cbo_bed1Net"
        Me.cbo_bed1Net.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bed1Net.Sorted = True
        Me.cbo_bed1Net.TabIndex = 31
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(345, 414)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 15)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "TV Point"
        '
        'cbo_bed1SAT
        '
        Me.cbo_bed1SAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bed1SAT.FormattingEnabled = True
        Me.cbo_bed1SAT.Items.AddRange(New Object() {"0", "1"})
        Me.cbo_bed1SAT.Location = New System.Drawing.Point(285, 440)
        Me.cbo_bed1SAT.Name = "cbo_bed1SAT"
        Me.cbo_bed1SAT.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bed1SAT.Sorted = True
        Me.cbo_bed1SAT.TabIndex = 30
        '
        'cbo_bed1TV
        '
        Me.cbo_bed1TV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bed1TV.FormattingEnabled = True
        Me.cbo_bed1TV.Items.AddRange(New Object() {"0", "1"})
        Me.cbo_bed1TV.Location = New System.Drawing.Point(285, 412)
        Me.cbo_bed1TV.Name = "cbo_bed1TV"
        Me.cbo_bed1TV.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bed1TV.Sorted = True
        Me.cbo_bed1TV.TabIndex = 29
        '
        'chk_HeatPumpLiving
        '
        Me.chk_HeatPumpLiving.AutoSize = True
        Me.chk_HeatPumpLiving.Location = New System.Drawing.Point(202, 309)
        Me.chk_HeatPumpLiving.Name = "chk_HeatPumpLiving"
        Me.chk_HeatPumpLiving.Size = New System.Drawing.Size(128, 19)
        Me.chk_HeatPumpLiving.TabIndex = 52
        Me.chk_HeatPumpLiving.Text = "Heat Pump (4.5Kw)"
        Me.chk_HeatPumpLiving.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(261, 284)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 15)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "2G Sockets"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(262, 254)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 15)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "1G Sockets"
        '
        'cbo_Living2G
        '
        Me.cbo_Living2G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Living2G.FormattingEnabled = True
        Me.cbo_Living2G.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_Living2G.Location = New System.Drawing.Point(204, 280)
        Me.cbo_Living2G.Name = "cbo_Living2G"
        Me.cbo_Living2G.Size = New System.Drawing.Size(54, 23)
        Me.cbo_Living2G.Sorted = True
        Me.cbo_Living2G.TabIndex = 49
        '
        'cbo_Living1G
        '
        Me.cbo_Living1G.BackColor = System.Drawing.SystemColors.Window
        Me.cbo_Living1G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Living1G.FormattingEnabled = True
        Me.cbo_Living1G.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_Living1G.Location = New System.Drawing.Point(205, 251)
        Me.cbo_Living1G.Name = "cbo_Living1G"
        Me.cbo_Living1G.Size = New System.Drawing.Size(54, 23)
        Me.cbo_Living1G.Sorted = True
        Me.cbo_Living1G.TabIndex = 48
        '
        'lbl_LivingSubHead
        '
        Me.lbl_LivingSubHead.AutoSize = True
        Me.lbl_LivingSubHead.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_LivingSubHead.Location = New System.Drawing.Point(8, 218)
        Me.lbl_LivingSubHead.Name = "lbl_LivingSubHead"
        Me.lbl_LivingSubHead.Size = New System.Drawing.Size(127, 30)
        Me.lbl_LivingSubHead.TabIndex = 47
        Me.lbl_LivingSubHead.Text = "Living Room"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Network"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 15)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Satellite Dish + TV point"
        '
        'cbo_LivingNet
        '
        Me.cbo_LivingNet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_LivingNet.FormattingEnabled = True
        Me.cbo_LivingNet.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_LivingNet.Location = New System.Drawing.Point(10, 309)
        Me.cbo_LivingNet.Name = "cbo_LivingNet"
        Me.cbo_LivingNet.Size = New System.Drawing.Size(54, 23)
        Me.cbo_LivingNet.Sorted = True
        Me.cbo_LivingNet.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(70, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 15)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Roof Aerial + TV point"
        '
        'cbo_LivingSAT
        '
        Me.cbo_LivingSAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_LivingSAT.FormattingEnabled = True
        Me.cbo_LivingSAT.Items.AddRange(New Object() {"0", "1"})
        Me.cbo_LivingSAT.Location = New System.Drawing.Point(10, 280)
        Me.cbo_LivingSAT.Name = "cbo_LivingSAT"
        Me.cbo_LivingSAT.Size = New System.Drawing.Size(54, 23)
        Me.cbo_LivingSAT.Sorted = True
        Me.cbo_LivingSAT.TabIndex = 42
        '
        'cbo_LivingTV
        '
        Me.cbo_LivingTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_LivingTV.FormattingEnabled = True
        Me.cbo_LivingTV.Items.AddRange(New Object() {"0", "1"})
        Me.cbo_LivingTV.Location = New System.Drawing.Point(10, 251)
        Me.cbo_LivingTV.Name = "cbo_LivingTV"
        Me.cbo_LivingTV.Size = New System.Drawing.Size(54, 23)
        Me.cbo_LivingTV.Sorted = True
        Me.cbo_LivingTV.TabIndex = 41
        '
        'chk_HeatPumpBedTwo
        '
        Me.chk_HeatPumpBedTwo.AutoSize = True
        Me.chk_HeatPumpBedTwo.Location = New System.Drawing.Point(131, 468)
        Me.chk_HeatPumpBedTwo.Name = "chk_HeatPumpBedTwo"
        Me.chk_HeatPumpBedTwo.Size = New System.Drawing.Size(128, 19)
        Me.chk_HeatPumpBedTwo.TabIndex = 76
        Me.chk_HeatPumpBedTwo.Text = "Heat Pump (2.5Kw)"
        Me.chk_HeatPumpBedTwo.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(189, 437)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 15)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "2G Sockets"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(189, 409)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 15)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "1G Sockets"
        '
        'cbo_bed2_2G
        '
        Me.cbo_bed2_2G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bed2_2G.FormattingEnabled = True
        Me.cbo_bed2_2G.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_bed2_2G.Location = New System.Drawing.Point(129, 441)
        Me.cbo_bed2_2G.Name = "cbo_bed2_2G"
        Me.cbo_bed2_2G.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bed2_2G.Sorted = True
        Me.cbo_bed2_2G.TabIndex = 73
        '
        'cbo_bed2_1G
        '
        Me.cbo_bed2_1G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bed2_1G.FormattingEnabled = True
        Me.cbo_bed2_1G.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_bed2_1G.Location = New System.Drawing.Point(129, 412)
        Me.cbo_bed2_1G.Name = "cbo_bed2_1G"
        Me.cbo_bed2_1G.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bed2_1G.Sorted = True
        Me.cbo_bed2_1G.TabIndex = 72
        '
        'lbl_Bed2SubHead
        '
        Me.lbl_Bed2SubHead.AutoSize = True
        Me.lbl_Bed2SubHead.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Bed2SubHead.Location = New System.Drawing.Point(8, 379)
        Me.lbl_Bed2SubHead.Name = "lbl_Bed2SubHead"
        Me.lbl_Bed2SubHead.Size = New System.Drawing.Size(151, 30)
        Me.lbl_Bed2SubHead.TabIndex = 71
        Me.lbl_Bed2SubHead.Text = "Bed Room Two"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(70, 473)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 15)
        Me.Label23.TabIndex = 70
        Me.Label23.Text = "Network"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(70, 444)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 15)
        Me.Label24.TabIndex = 69
        Me.Label24.Text = "SAT point"
        '
        'cbo_bed2Net
        '
        Me.cbo_bed2Net.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bed2Net.FormattingEnabled = True
        Me.cbo_bed2Net.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_bed2Net.Location = New System.Drawing.Point(10, 470)
        Me.cbo_bed2Net.Name = "cbo_bed2Net"
        Me.cbo_bed2Net.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bed2Net.Sorted = True
        Me.cbo_bed2Net.TabIndex = 67
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(70, 415)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 15)
        Me.Label25.TabIndex = 68
        Me.Label25.Text = "TV point"
        '
        'cbo_bed2SAT
        '
        Me.cbo_bed2SAT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bed2SAT.FormattingEnabled = True
        Me.cbo_bed2SAT.Items.AddRange(New Object() {"0", "1"})
        Me.cbo_bed2SAT.Location = New System.Drawing.Point(10, 441)
        Me.cbo_bed2SAT.Name = "cbo_bed2SAT"
        Me.cbo_bed2SAT.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bed2SAT.Sorted = True
        Me.cbo_bed2SAT.TabIndex = 66
        '
        'cbo_bed2TV
        '
        Me.cbo_bed2TV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bed2TV.FormattingEnabled = True
        Me.cbo_bed2TV.Items.AddRange(New Object() {"0", "1"})
        Me.cbo_bed2TV.Location = New System.Drawing.Point(10, 412)
        Me.cbo_bed2TV.Name = "cbo_bed2TV"
        Me.cbo_bed2TV.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bed2TV.Sorted = True
        Me.cbo_bed2TV.TabIndex = 65
        '
        'chk_UpgradeBathRoom
        '
        Me.chk_UpgradeBathRoom.AutoSize = True
        Me.chk_UpgradeBathRoom.Location = New System.Drawing.Point(377, 308)
        Me.chk_UpgradeBathRoom.Name = "chk_UpgradeBathRoom"
        Me.chk_UpgradeBathRoom.Size = New System.Drawing.Size(71, 19)
        Me.chk_UpgradeBathRoom.TabIndex = 64
        Me.chk_UpgradeBathRoom.Text = "Upgrade"
        Me.chk_UpgradeBathRoom.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(435, 277)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 15)
        Me.Label26.TabIndex = 63
        Me.Label26.Text = "2G Sockets"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(435, 249)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 15)
        Me.Label27.TabIndex = 62
        Me.Label27.Text = "1G Sockets"
        '
        'cbo_bath2G
        '
        Me.cbo_bath2G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bath2G.FormattingEnabled = True
        Me.cbo_bath2G.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_bath2G.Location = New System.Drawing.Point(375, 281)
        Me.cbo_bath2G.Name = "cbo_bath2G"
        Me.cbo_bath2G.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bath2G.Sorted = True
        Me.cbo_bath2G.TabIndex = 61
        '
        'cbo_bath1G
        '
        Me.cbo_bath1G.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_bath1G.FormattingEnabled = True
        Me.cbo_bath1G.Items.AddRange(New Object() {"0", "1", "2", "3", "4"})
        Me.cbo_bath1G.Location = New System.Drawing.Point(375, 252)
        Me.cbo_bath1G.Name = "cbo_bath1G"
        Me.cbo_bath1G.Size = New System.Drawing.Size(54, 23)
        Me.cbo_bath1G.Sorted = True
        Me.cbo_bath1G.TabIndex = 60
        '
        'lbl_BathSubHead
        '
        Me.lbl_BathSubHead.AutoSize = True
        Me.lbl_BathSubHead.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_BathSubHead.Location = New System.Drawing.Point(373, 219)
        Me.lbl_BathSubHead.Name = "lbl_BathSubHead"
        Me.lbl_BathSubHead.Size = New System.Drawing.Size(104, 30)
        Me.lbl_BathSubHead.TabIndex = 59
        Me.lbl_BathSubHead.Text = "Bathroom"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Network"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(516, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'lbl_totaldisplay
        '
        Me.lbl_totaldisplay.AutoSize = True
        Me.lbl_totaldisplay.Location = New System.Drawing.Point(381, 101)
        Me.lbl_totaldisplay.Name = "lbl_totaldisplay"
        Me.lbl_totaldisplay.Size = New System.Drawing.Size(76, 15)
        Me.lbl_totaldisplay.TabIndex = 90
        Me.lbl_totaldisplay.Text = "lbl_total_cost"
        Me.lbl_totaldisplay.Visible = False
        '
        'lbl_kitch_cost
        '
        Me.lbl_kitch_cost.AutoSize = True
        Me.lbl_kitch_cost.Location = New System.Drawing.Point(6, 183)
        Me.lbl_kitch_cost.Name = "lbl_kitch_cost"
        Me.lbl_kitch_cost.Size = New System.Drawing.Size(78, 15)
        Me.lbl_kitch_cost.TabIndex = 92
        Me.lbl_kitch_cost.Text = "lbl_kitch_cost"
        Me.lbl_kitch_cost.Visible = False
        '
        'lbl_bedroom_one
        '
        Me.lbl_bedroom_one.AutoSize = True
        Me.lbl_bedroom_one.Location = New System.Drawing.Point(283, 496)
        Me.lbl_bedroom_one.Name = "lbl_bedroom_one"
        Me.lbl_bedroom_one.Size = New System.Drawing.Size(126, 15)
        Me.lbl_bedroom_one.TabIndex = 93
        Me.lbl_bedroom_one.Text = "lbl_bedroom_one_cost"
        Me.lbl_bedroom_one.Visible = False
        '
        'lbl_living_cost
        '
        Me.lbl_living_cost.AutoSize = True
        Me.lbl_living_cost.Location = New System.Drawing.Point(8, 335)
        Me.lbl_living_cost.Name = "lbl_living_cost"
        Me.lbl_living_cost.Size = New System.Drawing.Size(81, 15)
        Me.lbl_living_cost.TabIndex = 94
        Me.lbl_living_cost.Text = "lbl_living_cost"
        Me.lbl_living_cost.Visible = False
        '
        'lbl_bedroom_two_cost
        '
        Me.lbl_bedroom_two_cost.AutoSize = True
        Me.lbl_bedroom_two_cost.Location = New System.Drawing.Point(7, 496)
        Me.lbl_bedroom_two_cost.Name = "lbl_bedroom_two_cost"
        Me.lbl_bedroom_two_cost.Size = New System.Drawing.Size(126, 15)
        Me.lbl_bedroom_two_cost.TabIndex = 95
        Me.lbl_bedroom_two_cost.Text = "lbl_bedroom_two_cost"
        Me.lbl_bedroom_two_cost.Visible = False
        '
        'lbl_bathroom_cost
        '
        Me.lbl_bathroom_cost.AutoSize = True
        Me.lbl_bathroom_cost.Location = New System.Drawing.Point(372, 335)
        Me.lbl_bathroom_cost.Name = "lbl_bathroom_cost"
        Me.lbl_bathroom_cost.Size = New System.Drawing.Size(76, 15)
        Me.lbl_bathroom_cost.TabIndex = 96
        Me.lbl_bathroom_cost.Text = "lbl_bath_cost"
        Me.lbl_bathroom_cost.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 493)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 23)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_OrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 519)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_bathroom_cost)
        Me.Controls.Add(Me.lbl_bedroom_two_cost)
        Me.Controls.Add(Me.lbl_living_cost)
        Me.Controls.Add(Me.lbl_bedroom_one)
        Me.Controls.Add(Me.lbl_kitch_cost)
        Me.Controls.Add(Me.lbl_totaldisplay)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chk_HeatPumpBedTwo)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cbo_bed2_2G)
        Me.Controls.Add(Me.cbo_bed2_1G)
        Me.Controls.Add(Me.lbl_Bed2SubHead)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cbo_bed2Net)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cbo_bed2SAT)
        Me.Controls.Add(Me.cbo_bed2TV)
        Me.Controls.Add(Me.chk_UpgradeBathRoom)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.cbo_bath2G)
        Me.Controls.Add(Me.cbo_bath1G)
        Me.Controls.Add(Me.lbl_BathSubHead)
        Me.Controls.Add(Me.chk_HeatPumpLiving)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbo_Living2G)
        Me.Controls.Add(Me.cbo_Living1G)
        Me.Controls.Add(Me.lbl_LivingSubHead)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbo_LivingNet)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbo_LivingSAT)
        Me.Controls.Add(Me.cbo_LivingTV)
        Me.Controls.Add(Me.chk_HeatPumpBedOne)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbo_bed1_2G)
        Me.Controls.Add(Me.cbo_bed1_1G)
        Me.Controls.Add(Me.lbl_Bed1SubHead)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cbo_bed1Net)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cbo_bed1SAT)
        Me.Controls.Add(Me.cbo_bed1TV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbo_kitchen2G)
        Me.Controls.Add(Me.cbo_kitchen1G)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_kitchenNet)
        Me.Controls.Add(Me.cbo_kitchenSAT)
        Me.Controls.Add(Me.cbo_kitchenTV)
        Me.Controls.Add(Me.chk_KitchenC)
        Me.Controls.Add(Me.chk_KitchenB)
        Me.Controls.Add(Me.chk_KitchenA)
        Me.Controls.Add(Me.lbl_kitchenSubHead)
        Me.Controls.Add(Me.lbl_OrderHeader)
        Me.Name = "frm_OrderDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Details"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_OrderHeader As Label
    Friend WithEvents lbl_kitchenSubHead As Label
    Friend WithEvents chk_KitchenA As CheckBox
    Friend WithEvents chk_KitchenB As CheckBox
    Friend WithEvents chk_KitchenC As CheckBox
    Friend WithEvents cbo_kitchenTV As ComboBox
    Friend WithEvents cbo_kitchenSAT As ComboBox
    Friend WithEvents cbo_kitchenNet As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbo_kitchen2G As ComboBox
    Friend WithEvents cbo_kitchen1G As ComboBox
    Friend WithEvents chk_HeatPumpBedOne As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbo_bed1_2G As ComboBox
    Friend WithEvents cbo_bed1_1G As ComboBox
    Friend WithEvents lbl_Bed1SubHead As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cbo_bed1Net As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cbo_bed1SAT As ComboBox
    Friend WithEvents cbo_bed1TV As ComboBox
    Friend WithEvents chk_HeatPumpLiving As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbo_Living2G As ComboBox
    Friend WithEvents cbo_Living1G As ComboBox
    Friend WithEvents lbl_LivingSubHead As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbo_LivingNet As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_LivingSAT As ComboBox
    Friend WithEvents cbo_LivingTV As ComboBox
    Friend WithEvents chk_HeatPumpBedTwo As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cbo_bed2_2G As ComboBox
    Friend WithEvents cbo_bed2_1G As ComboBox
    Friend WithEvents lbl_Bed2SubHead As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents cbo_bed2Net As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents cbo_bed2SAT As ComboBox
    Friend WithEvents cbo_bed2TV As ComboBox
    Friend WithEvents chk_UpgradeBathRoom As CheckBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents cbo_bath2G As ComboBox
    Friend WithEvents cbo_bath1G As ComboBox
    Friend WithEvents lbl_BathSubHead As Label
    Friend WithEvents lbl_living_cost As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_totaldisplay As Label
    Friend WithEvents lbl_kitch_cost As Label
    Friend WithEvents lbl_bedroom_one As Label
    Friend WithEvents lbl_bedroom_two_cost As Label
    Friend WithEvents lbl_bathroom_cost As Label
    Friend WithEvents Button1 As Button
End Class
