<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmorder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmorder))
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lstorder = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtimage = New System.Windows.Forms.TextBox()
        Me.txtsize = New System.Windows.Forms.TextBox()
        Me.txtaddon = New System.Windows.Forms.TextBox()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.lstproduct = New System.Windows.Forms.ListBox()
        Me.lstcustomer = New System.Windows.Forms.ListBox()
        Me.grpcustomer = New System.Windows.Forms.GroupBox()
        Me.txtpostcode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttelephone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.grpproduct = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtfinalprice = New System.Windows.Forms.TextBox()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.grpcustomer.SuspendLayout()
        Me.grpproduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(934, 379)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(116, 32)
        Me.btnexit.TabIndex = 53
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(934, 341)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(116, 32)
        Me.btnprint.TabIndex = 52
        Me.btnprint.Text = "Print Order Details"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(934, 303)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(116, 32)
        Me.btnremove.TabIndex = 51
        Me.btnremove.Text = "Remove Order"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(934, 265)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(116, 32)
        Me.btnadd.TabIndex = 50
        Me.btnadd.Text = "Add Order"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(819, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Order Details"
        '
        'lstorder
        '
        Me.lstorder.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstorder.FormattingEnabled = True
        Me.lstorder.HorizontalScrollbar = True
        Me.lstorder.ItemHeight = 14
        Me.lstorder.Location = New System.Drawing.Point(818, 49)
        Me.lstorder.Name = "lstorder"
        Me.lstorder.ScrollAlwaysVisible = True
        Me.lstorder.Size = New System.Drawing.Size(332, 200)
        Me.lstorder.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(544, 417)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Image Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(544, 391)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Image Size"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(544, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Add-On"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(544, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Product ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Product Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Customer Details"
        '
        'txtimage
        '
        Me.txtimage.Location = New System.Drawing.Point(618, 417)
        Me.txtimage.Name = "txtimage"
        Me.txtimage.ReadOnly = True
        Me.txtimage.Size = New System.Drawing.Size(156, 20)
        Me.txtimage.TabIndex = 39
        '
        'txtsize
        '
        Me.txtsize.Location = New System.Drawing.Point(618, 391)
        Me.txtsize.Name = "txtsize"
        Me.txtsize.ReadOnly = True
        Me.txtsize.Size = New System.Drawing.Size(156, 20)
        Me.txtsize.TabIndex = 38
        '
        'txtaddon
        '
        Me.txtaddon.Location = New System.Drawing.Point(618, 365)
        Me.txtaddon.Name = "txtaddon"
        Me.txtaddon.ReadOnly = True
        Me.txtaddon.Size = New System.Drawing.Size(156, 20)
        Me.txtaddon.TabIndex = 37
        '
        'txtproductid
        '
        Me.txtproductid.Location = New System.Drawing.Point(618, 339)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.ReadOnly = True
        Me.txtproductid.Size = New System.Drawing.Size(156, 20)
        Me.txtproductid.TabIndex = 36
        '
        'lstproduct
        '
        Me.lstproduct.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstproduct.FormattingEnabled = True
        Me.lstproduct.HorizontalScrollbar = True
        Me.lstproduct.ItemHeight = 14
        Me.lstproduct.Location = New System.Drawing.Point(12, 285)
        Me.lstproduct.Name = "lstproduct"
        Me.lstproduct.ScrollAlwaysVisible = True
        Me.lstproduct.Size = New System.Drawing.Size(508, 200)
        Me.lstproduct.TabIndex = 35
        '
        'lstcustomer
        '
        Me.lstcustomer.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstcustomer.FormattingEnabled = True
        Me.lstcustomer.HorizontalScrollbar = True
        Me.lstcustomer.ItemHeight = 14
        Me.lstcustomer.Location = New System.Drawing.Point(12, 49)
        Me.lstcustomer.Name = "lstcustomer"
        Me.lstcustomer.ScrollAlwaysVisible = True
        Me.lstcustomer.Size = New System.Drawing.Size(508, 214)
        Me.lstcustomer.TabIndex = 34
        '
        'grpcustomer
        '
        Me.grpcustomer.Controls.Add(Me.txtpostcode)
        Me.grpcustomer.Controls.Add(Me.Label10)
        Me.grpcustomer.Controls.Add(Me.txttelephone)
        Me.grpcustomer.Controls.Add(Me.Label9)
        Me.grpcustomer.Controls.Add(Me.txtemail)
        Me.grpcustomer.Controls.Add(Me.Label8)
        Me.grpcustomer.Controls.Add(Me.txtaddress)
        Me.grpcustomer.Controls.Add(Me.Label7)
        Me.grpcustomer.Controls.Add(Me.txtsurname)
        Me.grpcustomer.Controls.Add(Me.Label5)
        Me.grpcustomer.Controls.Add(Me.Label3)
        Me.grpcustomer.Controls.Add(Me.Label6)
        Me.grpcustomer.Controls.Add(Me.txtfirstname)
        Me.grpcustomer.Controls.Add(Me.txtcustomerid)
        Me.grpcustomer.Location = New System.Drawing.Point(526, 42)
        Me.grpcustomer.Name = "grpcustomer"
        Me.grpcustomer.Size = New System.Drawing.Size(286, 219)
        Me.grpcustomer.TabIndex = 46
        Me.grpcustomer.TabStop = False
        Me.grpcustomer.Text = "Customer Details"
        '
        'txtpostcode
        '
        Me.txtpostcode.Location = New System.Drawing.Point(89, 180)
        Me.txtpostcode.Name = "txtpostcode"
        Me.txtpostcode.ReadOnly = True
        Me.txtpostcode.Size = New System.Drawing.Size(156, 20)
        Me.txtpostcode.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Post-Code"
        '
        'txttelephone
        '
        Me.txttelephone.Location = New System.Drawing.Point(115, 149)
        Me.txttelephone.Name = "txttelephone"
        Me.txttelephone.ReadOnly = True
        Me.txttelephone.Size = New System.Drawing.Size(156, 20)
        Me.txttelephone.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Telephone Number"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(89, 123)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.ReadOnly = True
        Me.txtemail.Size = New System.Drawing.Size(156, 20)
        Me.txtemail.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Email"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(89, 97)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.ReadOnly = True
        Me.txtaddress.Size = New System.Drawing.Size(156, 20)
        Me.txtaddress.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Address"
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(89, 71)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.ReadOnly = True
        Me.txtsurname.Size = New System.Drawing.Size(156, 20)
        Me.txtsurname.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Customer ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Surname"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(89, 45)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.ReadOnly = True
        Me.txtfirstname.Size = New System.Drawing.Size(156, 20)
        Me.txtfirstname.TabIndex = 3
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Location = New System.Drawing.Point(89, 19)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.ReadOnly = True
        Me.txtcustomerid.Size = New System.Drawing.Size(156, 20)
        Me.txtcustomerid.TabIndex = 2
        '
        'grpproduct
        '
        Me.grpproduct.Controls.Add(Me.Label15)
        Me.grpproduct.Controls.Add(Me.txtfinalprice)
        Me.grpproduct.Location = New System.Drawing.Point(526, 285)
        Me.grpproduct.Name = "grpproduct"
        Me.grpproduct.Size = New System.Drawing.Size(286, 200)
        Me.grpproduct.TabIndex = 47
        Me.grpproduct.TabStop = False
        Me.grpproduct.Text = "Product Details"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 162)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Final Price"
        '
        'txtfinalprice
        '
        Me.txtfinalprice.Location = New System.Drawing.Point(92, 159)
        Me.txtfinalprice.Name = "txtfinalprice"
        Me.txtfinalprice.ReadOnly = True
        Me.txtfinalprice.Size = New System.Drawing.Size(156, 20)
        Me.txtfinalprice.TabIndex = 0
        '
        'btnhelp
        '
        Me.btnhelp.Location = New System.Drawing.Point(934, 417)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(116, 32)
        Me.btnhelp.TabIndex = 54
        Me.btnhelp.Text = "Help"
        Me.btnhelp.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(207, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Please Select Your Records Bellow"
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDoc
        '
        '
        'frmorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 500)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lstorder)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtimage)
        Me.Controls.Add(Me.txtsize)
        Me.Controls.Add(Me.txtaddon)
        Me.Controls.Add(Me.txtproductid)
        Me.Controls.Add(Me.lstproduct)
        Me.Controls.Add(Me.lstcustomer)
        Me.Controls.Add(Me.grpcustomer)
        Me.Controls.Add(Me.grpproduct)
        Me.Name = "frmorder"
        Me.Text = "Order Details"
        Me.grpcustomer.ResumeLayout(False)
        Me.grpcustomer.PerformLayout()
        Me.grpproduct.ResumeLayout(False)
        Me.grpproduct.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lstorder As System.Windows.Forms.ListBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtimage As System.Windows.Forms.TextBox
    Friend WithEvents txtsize As System.Windows.Forms.TextBox
    Friend WithEvents txtaddon As System.Windows.Forms.TextBox
    Friend WithEvents txtproductid As System.Windows.Forms.TextBox
    Friend WithEvents lstproduct As System.Windows.Forms.ListBox
    Friend WithEvents lstcustomer As System.Windows.Forms.ListBox
    Friend WithEvents grpcustomer As System.Windows.Forms.GroupBox
    Friend WithEvents txtpostcode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomerid As System.Windows.Forms.TextBox
    Friend WithEvents grpproduct As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtfinalprice As System.Windows.Forms.TextBox
    Friend WithEvents btnhelp As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
End Class
