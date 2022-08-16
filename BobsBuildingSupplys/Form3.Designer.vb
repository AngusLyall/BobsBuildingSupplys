<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lst_display = New System.Windows.Forms.ListBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.pic_back = New System.Windows.Forms.PictureBox()
        Me.pic_exit = New System.Windows.Forms.PictureBox()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.btn_newquote = New System.Windows.Forms.Button()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_display
        '
        Me.lst_display.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lst_display.FormattingEnabled = True
        Me.lst_display.ItemHeight = 15
        Me.lst_display.Location = New System.Drawing.Point(41, 42)
        Me.lst_display.Name = "lst_display"
        Me.lst_display.Size = New System.Drawing.Size(407, 319)
        Me.lst_display.TabIndex = 0
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(41, 367)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'pic_back
        '
        Me.pic_back.Image = CType(resources.GetObject("pic_back.Image"), System.Drawing.Image)
        Me.pic_back.Location = New System.Drawing.Point(4, 5)
        Me.pic_back.Name = "pic_back"
        Me.pic_back.Size = New System.Drawing.Size(20, 25)
        Me.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_back.TabIndex = 2
        Me.pic_back.TabStop = False
        '
        'pic_exit
        '
        Me.pic_exit.Image = CType(resources.GetObject("pic_exit.Image"), System.Drawing.Image)
        Me.pic_exit.Location = New System.Drawing.Point(459, 5)
        Me.pic_exit.Name = "pic_exit"
        Me.pic_exit.Size = New System.Drawing.Size(26, 25)
        Me.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_exit.TabIndex = 90
        Me.pic_exit.TabStop = False
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(122, 367)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(75, 23)
        Me.btn_print.TabIndex = 91
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'pic_logo
        '
        Me.pic_logo.Image = CType(resources.GetObject("pic_logo.Image"), System.Drawing.Image)
        Me.pic_logo.Location = New System.Drawing.Point(398, 5)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(94, 90)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_logo.TabIndex = 92
        Me.pic_logo.TabStop = False
        Me.pic_logo.Visible = False
        '
        'btn_newquote
        '
        Me.btn_newquote.Location = New System.Drawing.Point(203, 367)
        Me.btn_newquote.Name = "btn_newquote"
        Me.btn_newquote.Size = New System.Drawing.Size(75, 23)
        Me.btn_newquote.TabIndex = 93
        Me.btn_newquote.Text = "New Quote"
        Me.btn_newquote.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 420)
        Me.Controls.Add(Me.btn_newquote)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.pic_exit)
        Me.Controls.Add(Me.pic_back)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lst_display)
        Me.Controls.Add(Me.pic_logo)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lst_display As ListBox
    Friend WithEvents btn_save As Button
    Friend WithEvents pic_back As PictureBox
    Friend WithEvents pic_exit As PictureBox
    Friend WithEvents btn_print As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents btn_newquote As Button
End Class
