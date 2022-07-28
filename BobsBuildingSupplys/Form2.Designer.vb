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
        Me.lbl_ktvpoint = New System.Windows.Forms.Label()
        Me.lbl_ksatpoint = New System.Windows.Forms.Label()
        Me.lbl_k2gsocket = New System.Windows.Forms.Label()
        Me.lbl_k1gsocket = New System.Windows.Forms.Label()
        Me.cbo_kitchen2G = New System.Windows.Forms.ComboBox()
        Me.cbo_kitchen1G = New System.Windows.Forms.ComboBox()
        Me.chk_HeatPumpBedOne = New System.Windows.Forms.CheckBox()
        Me.lbl_bro2g = New System.Windows.Forms.Label()
        Me.lbl_bro1gsock = New System.Windows.Forms.Label()
        Me.cbo_bed1_2G = New System.Windows.Forms.ComboBox()
        Me.cbo_bed1_1G = New System.Windows.Forms.ComboBox()
        Me.lbl_Bed1SubHead = New System.Windows.Forms.Label()
        Me.lbl_bronet = New System.Windows.Forms.Label()
        Me.lbl_brosat = New System.Windows.Forms.Label()
        Me.cbo_bed1Net = New System.Windows.Forms.ComboBox()
        Me.lbl_brotv = New System.Windows.Forms.Label()
        Me.cbo_bed1SAT = New System.Windows.Forms.ComboBox()
        Me.cbo_bed1TV = New System.Windows.Forms.ComboBox()
        Me.chk_HeatPumpLiving = New System.Windows.Forms.CheckBox()
        Me.lbl_lr2g = New System.Windows.Forms.Label()
        Me.lbl_lr1g = New System.Windows.Forms.Label()
        Me.cbo_Living2G = New System.Windows.Forms.ComboBox()
        Me.cbo_Living1G = New System.Windows.Forms.ComboBox()
        Me.lbl_LivingSubHead = New System.Windows.Forms.Label()
        Me.lbl_lrnet = New System.Windows.Forms.Label()
        Me.lbl_lrsat = New System.Windows.Forms.Label()
        Me.cbo_LivingNet = New System.Windows.Forms.ComboBox()
        Me.lbl_lraerial = New System.Windows.Forms.Label()
        Me.cbo_LivingSAT = New System.Windows.Forms.ComboBox()
        Me.cbo_LivingTV = New System.Windows.Forms.ComboBox()
        Me.chk_HeatPumpBedTwo = New System.Windows.Forms.CheckBox()
        Me.lbl_brt2g = New System.Windows.Forms.Label()
        Me.lbl_brt1g = New System.Windows.Forms.Label()
        Me.cbo_bed2_2G = New System.Windows.Forms.ComboBox()
        Me.cbo_bed2_1G = New System.Windows.Forms.ComboBox()
        Me.lbl_Bed2SubHead = New System.Windows.Forms.Label()
        Me.lbl_brtnetwork = New System.Windows.Forms.Label()
        Me.lbl_brtsat = New System.Windows.Forms.Label()
        Me.cbo_bed2Net = New System.Windows.Forms.ComboBox()
        Me.lbl_brttv = New System.Windows.Forms.Label()
        Me.cbo_bed2SAT = New System.Windows.Forms.ComboBox()
        Me.cbo_bed2TV = New System.Windows.Forms.ComboBox()
        Me.chk_UpgradeBathRoom = New System.Windows.Forms.CheckBox()
        Me.lbl_bath2g = New System.Windows.Forms.Label()
        Me.lbl_bath1g = New System.Windows.Forms.Label()
        Me.cbo_bath2G = New System.Windows.Forms.ComboBox()
        Me.cbo_bath1G = New System.Windows.Forms.ComboBox()
        Me.lbl_BathSubHead = New System.Windows.Forms.Label()
        Me.lbl_knetpoint = New System.Windows.Forms.Label()
        Me.pic_back = New System.Windows.Forms.PictureBox()
        Me.pic_exit = New System.Windows.Forms.PictureBox()
        Me.lbl_totaldisplay = New System.Windows.Forms.Label()
        Me.lbl_kitch_cost = New System.Windows.Forms.Label()
        Me.lbl_bedroom_one = New System.Windows.Forms.Label()
        Me.lbl_living_cost = New System.Windows.Forms.Label()
        Me.lbl_bedroom_two_cost = New System.Windows.Forms.Label()
        Me.lbl_bathroom_cost = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lbl_ktvpoint
        '
        Me.lbl_ktvpoint.AutoSize = True
        Me.lbl_ktvpoint.Location = New System.Drawing.Point(160, 101)
        Me.lbl_ktvpoint.Name = "lbl_ktvpoint"
        Me.lbl_ktvpoint.Size = New System.Drawing.Size(51, 15)
        Me.lbl_ktvpoint.TabIndex = 8
        Me.lbl_ktvpoint.Text = "TV point"
        '
        'lbl_ksatpoint
        '
        Me.lbl_ksatpoint.AutoSize = True
        Me.lbl_ksatpoint.Location = New System.Drawing.Point(160, 129)
        Me.lbl_ksatpoint.Name = "lbl_ksatpoint"
        Me.lbl_ksatpoint.Size = New System.Drawing.Size(57, 15)
        Me.lbl_ksatpoint.TabIndex = 9
        Me.lbl_ksatpoint.Text = "SAT point"
        '
        'lbl_k2gsocket
        '
        Me.lbl_k2gsocket.AutoSize = True
        Me.lbl_k2gsocket.Location = New System.Drawing.Point(282, 129)
        Me.lbl_k2gsocket.Name = "lbl_k2gsocket"
        Me.lbl_k2gsocket.Size = New System.Drawing.Size(64, 15)
        Me.lbl_k2gsocket.TabIndex = 15
        Me.lbl_k2gsocket.Text = "2G Sockets"
        '
        'lbl_k1gsocket
        '
        Me.lbl_k1gsocket.AutoSize = True
        Me.lbl_k1gsocket.Location = New System.Drawing.Point(282, 101)
        Me.lbl_k1gsocket.Name = "lbl_k1gsocket"
        Me.lbl_k1gsocket.Size = New System.Drawing.Size(64, 15)
        Me.lbl_k1gsocket.TabIndex = 14
        Me.lbl_k1gsocket.Text = "1G Sockets"
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
        'lbl_bro2g
        '
        Me.lbl_bro2g.AutoSize = True
        Me.lbl_bro2g.Location = New System.Drawing.Point(464, 445)
        Me.lbl_bro2g.Name = "lbl_bro2g"
        Me.lbl_bro2g.Size = New System.Drawing.Size(64, 15)
        Me.lbl_bro2g.TabIndex = 39
        Me.lbl_bro2g.Text = "2G Sockets"
        '
        'lbl_bro1gsock
        '
        Me.lbl_bro1gsock.AutoSize = True
        Me.lbl_bro1gsock.Location = New System.Drawing.Point(464, 417)
        Me.lbl_bro1gsock.Name = "lbl_bro1gsock"
        Me.lbl_bro1gsock.Size = New System.Drawing.Size(64, 15)
        Me.lbl_bro1gsock.TabIndex = 38
        Me.lbl_bro1gsock.Text = "1G Sockets"
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
        'lbl_bronet
        '
        Me.lbl_bronet.AutoSize = True
        Me.lbl_bronet.Location = New System.Drawing.Point(345, 473)
        Me.lbl_bronet.Name = "lbl_bronet"
        Me.lbl_bronet.Size = New System.Drawing.Size(52, 15)
        Me.lbl_bronet.TabIndex = 34
        Me.lbl_bronet.Text = "Network"
        '
        'lbl_brosat
        '
        Me.lbl_brosat.AutoSize = True
        Me.lbl_brosat.Location = New System.Drawing.Point(345, 444)
        Me.lbl_brosat.Name = "lbl_brosat"
        Me.lbl_brosat.Size = New System.Drawing.Size(57, 15)
        Me.lbl_brosat.TabIndex = 33
        Me.lbl_brosat.Text = "SAT Point"
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
        'lbl_brotv
        '
        Me.lbl_brotv.AutoSize = True
        Me.lbl_brotv.Location = New System.Drawing.Point(345, 414)
        Me.lbl_brotv.Name = "lbl_brotv"
        Me.lbl_brotv.Size = New System.Drawing.Size(51, 15)
        Me.lbl_brotv.TabIndex = 32
        Me.lbl_brotv.Text = "TV Point"
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
        'lbl_lr2g
        '
        Me.lbl_lr2g.AutoSize = True
        Me.lbl_lr2g.Location = New System.Drawing.Point(261, 284)
        Me.lbl_lr2g.Name = "lbl_lr2g"
        Me.lbl_lr2g.Size = New System.Drawing.Size(64, 15)
        Me.lbl_lr2g.TabIndex = 51
        Me.lbl_lr2g.Text = "2G Sockets"
        '
        'lbl_lr1g
        '
        Me.lbl_lr1g.AutoSize = True
        Me.lbl_lr1g.Location = New System.Drawing.Point(262, 254)
        Me.lbl_lr1g.Name = "lbl_lr1g"
        Me.lbl_lr1g.Size = New System.Drawing.Size(64, 15)
        Me.lbl_lr1g.TabIndex = 50
        Me.lbl_lr1g.Text = "1G Sockets"
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
        'lbl_lrnet
        '
        Me.lbl_lrnet.AutoSize = True
        Me.lbl_lrnet.Location = New System.Drawing.Point(68, 312)
        Me.lbl_lrnet.Name = "lbl_lrnet"
        Me.lbl_lrnet.Size = New System.Drawing.Size(52, 15)
        Me.lbl_lrnet.TabIndex = 46
        Me.lbl_lrnet.Text = "Network"
        '
        'lbl_lrsat
        '
        Me.lbl_lrsat.AutoSize = True
        Me.lbl_lrsat.Location = New System.Drawing.Point(70, 282)
        Me.lbl_lrsat.Name = "lbl_lrsat"
        Me.lbl_lrsat.Size = New System.Drawing.Size(132, 15)
        Me.lbl_lrsat.TabIndex = 45
        Me.lbl_lrsat.Text = "Satellite Dish + TV point"
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
        'lbl_lraerial
        '
        Me.lbl_lraerial.AutoSize = True
        Me.lbl_lraerial.Location = New System.Drawing.Point(70, 253)
        Me.lbl_lraerial.Name = "lbl_lraerial"
        Me.lbl_lraerial.Size = New System.Drawing.Size(123, 15)
        Me.lbl_lraerial.TabIndex = 44
        Me.lbl_lraerial.Text = "Roof Aerial + TV point"
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
        'lbl_brt2g
        '
        Me.lbl_brt2g.AutoSize = True
        Me.lbl_brt2g.Location = New System.Drawing.Point(189, 437)
        Me.lbl_brt2g.Name = "lbl_brt2g"
        Me.lbl_brt2g.Size = New System.Drawing.Size(64, 15)
        Me.lbl_brt2g.TabIndex = 75
        Me.lbl_brt2g.Text = "2G Sockets"
        '
        'lbl_brt1g
        '
        Me.lbl_brt1g.AutoSize = True
        Me.lbl_brt1g.Location = New System.Drawing.Point(189, 409)
        Me.lbl_brt1g.Name = "lbl_brt1g"
        Me.lbl_brt1g.Size = New System.Drawing.Size(64, 15)
        Me.lbl_brt1g.TabIndex = 74
        Me.lbl_brt1g.Text = "1G Sockets"
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
        'lbl_brtnetwork
        '
        Me.lbl_brtnetwork.AutoSize = True
        Me.lbl_brtnetwork.Location = New System.Drawing.Point(70, 473)
        Me.lbl_brtnetwork.Name = "lbl_brtnetwork"
        Me.lbl_brtnetwork.Size = New System.Drawing.Size(52, 15)
        Me.lbl_brtnetwork.TabIndex = 70
        Me.lbl_brtnetwork.Text = "Network"
        '
        'lbl_brtsat
        '
        Me.lbl_brtsat.AutoSize = True
        Me.lbl_brtsat.Location = New System.Drawing.Point(70, 444)
        Me.lbl_brtsat.Name = "lbl_brtsat"
        Me.lbl_brtsat.Size = New System.Drawing.Size(57, 15)
        Me.lbl_brtsat.TabIndex = 69
        Me.lbl_brtsat.Text = "SAT point"
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
        'lbl_brttv
        '
        Me.lbl_brttv.AutoSize = True
        Me.lbl_brttv.Location = New System.Drawing.Point(70, 415)
        Me.lbl_brttv.Name = "lbl_brttv"
        Me.lbl_brttv.Size = New System.Drawing.Size(51, 15)
        Me.lbl_brttv.TabIndex = 68
        Me.lbl_brttv.Text = "TV point"
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
        'lbl_bath2g
        '
        Me.lbl_bath2g.AutoSize = True
        Me.lbl_bath2g.Location = New System.Drawing.Point(435, 277)
        Me.lbl_bath2g.Name = "lbl_bath2g"
        Me.lbl_bath2g.Size = New System.Drawing.Size(64, 15)
        Me.lbl_bath2g.TabIndex = 63
        Me.lbl_bath2g.Text = "2G Sockets"
        '
        'lbl_bath1g
        '
        Me.lbl_bath1g.AutoSize = True
        Me.lbl_bath1g.Location = New System.Drawing.Point(435, 249)
        Me.lbl_bath1g.Name = "lbl_bath1g"
        Me.lbl_bath1g.Size = New System.Drawing.Size(64, 15)
        Me.lbl_bath1g.TabIndex = 62
        Me.lbl_bath1g.Text = "1G Sockets"
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
        'lbl_knetpoint
        '
        Me.lbl_knetpoint.AutoSize = True
        Me.lbl_knetpoint.Location = New System.Drawing.Point(160, 159)
        Me.lbl_knetpoint.Name = "lbl_knetpoint"
        Me.lbl_knetpoint.Size = New System.Drawing.Size(52, 15)
        Me.lbl_knetpoint.TabIndex = 10
        Me.lbl_knetpoint.Text = "Network"
        '
        'pic_back
        '
        Me.pic_back.Image = CType(resources.GetObject("pic_back.Image"), System.Drawing.Image)
        Me.pic_back.Location = New System.Drawing.Point(0, 0)
        Me.pic_back.Name = "pic_back"
        Me.pic_back.Size = New System.Drawing.Size(20, 25)
        Me.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_back.TabIndex = 0
        Me.pic_back.TabStop = False
        '
        'pic_exit
        '
        Me.pic_exit.Image = CType(resources.GetObject("pic_exit.Image"), System.Drawing.Image)
        Me.pic_exit.Location = New System.Drawing.Point(516, 0)
        Me.pic_exit.Name = "pic_exit"
        Me.pic_exit.Size = New System.Drawing.Size(31, 34)
        Me.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_exit.TabIndex = 89
        Me.pic_exit.TabStop = False
        '
        'lbl_totaldisplay
        '
        Me.lbl_totaldisplay.AutoSize = True
        Me.lbl_totaldisplay.Location = New System.Drawing.Point(281, 71)
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
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(494, 493)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(53, 23)
        Me.btn_next.TabIndex = 97
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'frm_OrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 519)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.lbl_bathroom_cost)
        Me.Controls.Add(Me.lbl_bedroom_two_cost)
        Me.Controls.Add(Me.lbl_living_cost)
        Me.Controls.Add(Me.lbl_bedroom_one)
        Me.Controls.Add(Me.lbl_kitch_cost)
        Me.Controls.Add(Me.lbl_totaldisplay)
        Me.Controls.Add(Me.pic_exit)
        Me.Controls.Add(Me.pic_back)
        Me.Controls.Add(Me.chk_HeatPumpBedTwo)
        Me.Controls.Add(Me.lbl_brt2g)
        Me.Controls.Add(Me.lbl_brt1g)
        Me.Controls.Add(Me.cbo_bed2_2G)
        Me.Controls.Add(Me.cbo_bed2_1G)
        Me.Controls.Add(Me.lbl_Bed2SubHead)
        Me.Controls.Add(Me.lbl_brtnetwork)
        Me.Controls.Add(Me.lbl_brtsat)
        Me.Controls.Add(Me.cbo_bed2Net)
        Me.Controls.Add(Me.lbl_brttv)
        Me.Controls.Add(Me.cbo_bed2SAT)
        Me.Controls.Add(Me.cbo_bed2TV)
        Me.Controls.Add(Me.chk_UpgradeBathRoom)
        Me.Controls.Add(Me.lbl_bath2g)
        Me.Controls.Add(Me.lbl_bath1g)
        Me.Controls.Add(Me.cbo_bath2G)
        Me.Controls.Add(Me.cbo_bath1G)
        Me.Controls.Add(Me.lbl_BathSubHead)
        Me.Controls.Add(Me.chk_HeatPumpLiving)
        Me.Controls.Add(Me.lbl_lr2g)
        Me.Controls.Add(Me.lbl_lr1g)
        Me.Controls.Add(Me.cbo_Living2G)
        Me.Controls.Add(Me.cbo_Living1G)
        Me.Controls.Add(Me.lbl_LivingSubHead)
        Me.Controls.Add(Me.lbl_lrnet)
        Me.Controls.Add(Me.lbl_lrsat)
        Me.Controls.Add(Me.cbo_LivingNet)
        Me.Controls.Add(Me.lbl_lraerial)
        Me.Controls.Add(Me.cbo_LivingSAT)
        Me.Controls.Add(Me.cbo_LivingTV)
        Me.Controls.Add(Me.chk_HeatPumpBedOne)
        Me.Controls.Add(Me.lbl_bro2g)
        Me.Controls.Add(Me.lbl_bro1gsock)
        Me.Controls.Add(Me.cbo_bed1_2G)
        Me.Controls.Add(Me.cbo_bed1_1G)
        Me.Controls.Add(Me.lbl_Bed1SubHead)
        Me.Controls.Add(Me.lbl_bronet)
        Me.Controls.Add(Me.lbl_brosat)
        Me.Controls.Add(Me.cbo_bed1Net)
        Me.Controls.Add(Me.lbl_brotv)
        Me.Controls.Add(Me.cbo_bed1SAT)
        Me.Controls.Add(Me.cbo_bed1TV)
        Me.Controls.Add(Me.lbl_k2gsocket)
        Me.Controls.Add(Me.lbl_k1gsocket)
        Me.Controls.Add(Me.cbo_kitchen2G)
        Me.Controls.Add(Me.cbo_kitchen1G)
        Me.Controls.Add(Me.lbl_knetpoint)
        Me.Controls.Add(Me.lbl_ksatpoint)
        Me.Controls.Add(Me.lbl_ktvpoint)
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
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl_ktvpoint As Label
    Friend WithEvents lbl_ksatpoint As Label
    Friend WithEvents lbl_k2gsocket As Label
    Friend WithEvents lbl_k1gsocket As Label
    Friend WithEvents cbo_kitchen2G As ComboBox
    Friend WithEvents cbo_kitchen1G As ComboBox
    Friend WithEvents chk_HeatPumpBedOne As CheckBox
    Friend WithEvents lbl_bro2g As Label
    Friend WithEvents lbl_bro1gsock As Label
    Friend WithEvents cbo_bed1_2G As ComboBox
    Friend WithEvents cbo_bed1_1G As ComboBox
    Friend WithEvents lbl_Bed1SubHead As Label
    Friend WithEvents lbl_bronet As Label
    Friend WithEvents lbl_brosat As Label
    Friend WithEvents cbo_bed1Net As ComboBox
    Friend WithEvents lbl_brotv As Label
    Friend WithEvents cbo_bed1SAT As ComboBox
    Friend WithEvents cbo_bed1TV As ComboBox
    Friend WithEvents chk_HeatPumpLiving As CheckBox
    Friend WithEvents lbl_lr2g As Label
    Friend WithEvents lbl_lr1g As Label
    Friend WithEvents cbo_Living2G As ComboBox
    Friend WithEvents cbo_Living1G As ComboBox
    Friend WithEvents lbl_LivingSubHead As Label
    Friend WithEvents lbl_lrnet As Label
    Friend WithEvents lbl_lrsat As Label
    Friend WithEvents cbo_LivingNet As ComboBox
    Friend WithEvents lbl_lraerial As Label
    Friend WithEvents cbo_LivingSAT As ComboBox
    Friend WithEvents cbo_LivingTV As ComboBox
    Friend WithEvents chk_HeatPumpBedTwo As CheckBox
    Friend WithEvents lbl_brt2g As Label
    Friend WithEvents lbl_brt1g As Label
    Friend WithEvents cbo_bed2_2G As ComboBox
    Friend WithEvents cbo_bed2_1G As ComboBox
    Friend WithEvents lbl_Bed2SubHead As Label
    Friend WithEvents lbl_brtnetwork As Label
    Friend WithEvents lbl_brtsat As Label
    Friend WithEvents cbo_bed2Net As ComboBox
    Friend WithEvents lbl_brttv As Label
    Friend WithEvents cbo_bed2SAT As ComboBox
    Friend WithEvents cbo_bed2TV As ComboBox
    Friend WithEvents chk_UpgradeBathRoom As CheckBox
    Friend WithEvents lbl_bath2g As Label
    Friend WithEvents lbl_bath1g As Label
    Friend WithEvents cbo_bath2G As ComboBox
    Friend WithEvents cbo_bath1G As ComboBox
    Friend WithEvents lbl_BathSubHead As Label
    Friend WithEvents lbl_living_cost As Label
    Friend WithEvents lbl_knetpoint As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents pic_back As PictureBox
    Friend WithEvents pic_exit As PictureBox
    Friend WithEvents lbl_totaldisplay As Label
    Friend WithEvents lbl_kitch_cost As Label
    Friend WithEvents lbl_bedroom_one As Label
    Friend WithEvents lbl_bedroom_two_cost As Label
    Friend WithEvents lbl_bathroom_cost As Label
    Friend WithEvents btn_next As Button
End Class
