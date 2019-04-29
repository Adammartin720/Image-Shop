<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnpriceinfo = New System.Windows.Forms.Button()
        Me.lstproduct = New System.Windows.Forms.ListBox()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.grpproduct = New System.Windows.Forms.GroupBox()
        Me.txtfinalprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbmaddon = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbmsize = New System.Windows.Forms.ComboBox()
        Me.btnupload = New System.Windows.Forms.Button()
        Me.cbmimage = New System.Windows.Forms.ComboBox()
        Me.picproduct = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpproduct.SuspendLayout()
        CType(Me.picproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnpriceinfo
        '
        Me.btnpriceinfo.Location = New System.Drawing.Point(685, 314)
        Me.btnpriceinfo.Name = "btnpriceinfo"
        Me.btnpriceinfo.Size = New System.Drawing.Size(73, 68)
        Me.btnpriceinfo.TabIndex = 40
        Me.btnpriceinfo.Text = "Price Information"
        Me.btnpriceinfo.UseVisualStyleBackColor = True
        '
        'lstproduct
        '
        Me.lstproduct.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstproduct.FormattingEnabled = True
        Me.lstproduct.HorizontalScrollbar = True
        Me.lstproduct.ItemHeight = 14
        Me.lstproduct.Location = New System.Drawing.Point(12, 262)
        Me.lstproduct.Name = "lstproduct"
        Me.lstproduct.ScrollAlwaysVisible = True
        Me.lstproduct.Size = New System.Drawing.Size(644, 270)
        Me.lstproduct.TabIndex = 39
        '
        'btnhelp
        '
        Me.btnhelp.Location = New System.Drawing.Point(685, 388)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(73, 68)
        Me.btnhelp.TabIndex = 38
        Me.btnhelp.Text = "Help? "
        Me.btnhelp.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(662, 500)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(116, 32)
        Me.btnexit.TabIndex = 36
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(662, 462)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(116, 32)
        Me.btnreset.TabIndex = 35
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(662, 217)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(116, 32)
        Me.btnclear.TabIndex = 34
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(662, 179)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(116, 32)
        Me.btnview.TabIndex = 33
        Me.btnview.Text = "View All"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(662, 141)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(116, 32)
        Me.btnsearch.TabIndex = 32
        Me.btnsearch.Text = "Search by "
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(662, 103)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(116, 32)
        Me.btndelete.TabIndex = 31
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(662, 65)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(116, 32)
        Me.btnedit.TabIndex = 30
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(662, 27)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(116, 32)
        Me.btnadd.TabIndex = 29
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'grpproduct
        '
        Me.grpproduct.Controls.Add(Me.txtfinalprice)
        Me.grpproduct.Controls.Add(Me.Label6)
        Me.grpproduct.Controls.Add(Me.Label5)
        Me.grpproduct.Controls.Add(Me.cbmaddon)
        Me.grpproduct.Controls.Add(Me.Label8)
        Me.grpproduct.Controls.Add(Me.Label4)
        Me.grpproduct.Controls.Add(Me.Label3)
        Me.grpproduct.Controls.Add(Me.Label2)
        Me.grpproduct.Controls.Add(Me.cbmsize)
        Me.grpproduct.Controls.Add(Me.btnupload)
        Me.grpproduct.Controls.Add(Me.cbmimage)
        Me.grpproduct.Controls.Add(Me.picproduct)
        Me.grpproduct.Controls.Add(Me.Label1)
        Me.grpproduct.Controls.Add(Me.txtproductid)
        Me.grpproduct.Location = New System.Drawing.Point(12, 12)
        Me.grpproduct.Name = "grpproduct"
        Me.grpproduct.Size = New System.Drawing.Size(644, 244)
        Me.grpproduct.TabIndex = 37
        Me.grpproduct.TabStop = False
        Me.grpproduct.Text = "Product Details"
        '
        'txtfinalprice
        '
        Me.txtfinalprice.Location = New System.Drawing.Point(82, 210)
        Me.txtfinalprice.Name = "txtfinalprice"
        Me.txtfinalprice.ReadOnly = True
        Me.txtfinalprice.Size = New System.Drawing.Size(141, 20)
        Me.txtfinalprice.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Choose your Image Size"
        '
        'cbmaddon
        '
        Me.cbmaddon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmaddon.FormattingEnabled = True
        Me.cbmaddon.Items.AddRange(New Object() {"No frame", "Glossy", "Photo Realistic", "Frame Included"})
        Me.cbmaddon.Location = New System.Drawing.Point(25, 129)
        Me.cbmaddon.Name = "cbmaddon"
        Me.cbmaddon.Size = New System.Drawing.Size(198, 21)
        Me.cbmaddon.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(241, 16)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Please Input Image details bellow"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(219, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Choose your Add-on to the Image"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Choose Your Image"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Product Size"
        '
        'cbmsize
        '
        Me.cbmsize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmsize.FormattingEnabled = True
        Me.cbmsize.Items.AddRange(New Object() {"8.5 X 11 Smallest", "11 X 17 Small", "18 X 24 Medium", "24 X 36 Large", "27 X 40 Movie Poster", "40 X 60 Bus Stop Poster"})
        Me.cbmsize.Location = New System.Drawing.Point(82, 178)
        Me.cbmsize.Name = "cbmsize"
        Me.cbmsize.Size = New System.Drawing.Size(141, 21)
        Me.cbmsize.TabIndex = 17
        '
        'btnupload
        '
        Me.btnupload.Location = New System.Drawing.Point(533, 188)
        Me.btnupload.Name = "btnupload"
        Me.btnupload.Size = New System.Drawing.Size(100, 49)
        Me.btnupload.TabIndex = 14
        Me.btnupload.Text = "Or you can upload your own image here!"
        Me.btnupload.UseVisualStyleBackColor = True
        '
        'cbmimage
        '
        Me.cbmimage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmimage.FormattingEnabled = True
        Me.cbmimage.Items.AddRange(New Object() {"Halo 3", "BloodBorne", "DarkSouls", "FireWatch", "Pokemon", "MW2", "UnderTale", "DisHonred", "Fallout", "FinalFantasy", "Tetris", "World Of WarCraft", "Legend Of Zelda", "Gears Of War", "Portal"})
        Me.cbmimage.Location = New System.Drawing.Point(372, 203)
        Me.cbmimage.Name = "cbmimage"
        Me.cbmimage.Size = New System.Drawing.Size(155, 21)
        Me.cbmimage.TabIndex = 13
        '
        'picproduct
        '
        Me.picproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picproduct.Location = New System.Drawing.Point(257, 15)
        Me.picproduct.Name = "picproduct"
        Me.picproduct.Size = New System.Drawing.Size(376, 167)
        Me.picproduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picproduct.TabIndex = 10
        Me.picproduct.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Product ID"
        '
        'txtproductid
        '
        Me.txtproductid.Location = New System.Drawing.Point(87, 78)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.Size = New System.Drawing.Size(141, 20)
        Me.txtproductid.TabIndex = 9
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 539)
        Me.Controls.Add(Me.btnpriceinfo)
        Me.Controls.Add(Me.lstproduct)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.grpproduct)
        Me.Name = "frmproduct"
        Me.Text = "Product Details"
        Me.grpproduct.ResumeLayout(False)
        Me.grpproduct.PerformLayout()
        CType(Me.picproduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnpriceinfo As System.Windows.Forms.Button
    Friend WithEvents lstproduct As System.Windows.Forms.ListBox
    Friend WithEvents btnhelp As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents grpproduct As System.Windows.Forms.GroupBox
    Friend WithEvents txtfinalprice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbmaddon As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbmsize As System.Windows.Forms.ComboBox
    Friend WithEvents btnupload As System.Windows.Forms.Button
    Friend WithEvents cbmimage As System.Windows.Forms.ComboBox
    Friend WithEvents picproduct As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtproductid As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
End Class
