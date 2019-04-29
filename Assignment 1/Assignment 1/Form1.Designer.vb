<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcustomer
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
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnview = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lstcustomer = New System.Windows.Forms.ListBox()
        Me.grpcustomer = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcustomerid = New System.Windows.Forms.TextBox()
        Me.txttelephone = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtpostcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpcustomer.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnhelp
        '
        Me.btnhelp.Location = New System.Drawing.Point(692, 304)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(55, 48)
        Me.btnhelp.TabIndex = 37
        Me.btnhelp.Text = "Help?"
        Me.btnhelp.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(228, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Please Input your details bellow"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(663, 410)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(116, 32)
        Me.btnexit.TabIndex = 34
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(664, 372)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(116, 32)
        Me.btnreset.TabIndex = 33
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(664, 253)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(116, 32)
        Me.btnclear.TabIndex = 32
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnview
        '
        Me.btnview.Location = New System.Drawing.Point(664, 215)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(116, 32)
        Me.btnview.TabIndex = 31
        Me.btnview.Text = "View All"
        Me.btnview.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(664, 177)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(116, 32)
        Me.btnsearch.TabIndex = 30
        Me.btnsearch.Text = "Search By Surname"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(664, 139)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(116, 32)
        Me.btndelete.TabIndex = 29
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(664, 101)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(116, 32)
        Me.btnedit.TabIndex = 28
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(664, 62)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(116, 32)
        Me.btnadd.TabIndex = 27
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lstcustomer
        '
        Me.lstcustomer.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstcustomer.FormattingEnabled = True
        Me.lstcustomer.HorizontalScrollbar = True
        Me.lstcustomer.ItemHeight = 14
        Me.lstcustomer.Location = New System.Drawing.Point(10, 239)
        Me.lstcustomer.Name = "lstcustomer"
        Me.lstcustomer.ScrollAlwaysVisible = True
        Me.lstcustomer.Size = New System.Drawing.Size(647, 200)
        Me.lstcustomer.TabIndex = 26
        '
        'grpcustomer
        '
        Me.grpcustomer.Controls.Add(Me.Label5)
        Me.grpcustomer.Controls.Add(Me.txtcustomerid)
        Me.grpcustomer.Controls.Add(Me.txttelephone)
        Me.grpcustomer.Controls.Add(Me.txtemail)
        Me.grpcustomer.Controls.Add(Me.Label1)
        Me.grpcustomer.Controls.Add(Me.txtfirstname)
        Me.grpcustomer.Controls.Add(Me.Label6)
        Me.grpcustomer.Controls.Add(Me.Label7)
        Me.grpcustomer.Controls.Add(Me.Label2)
        Me.grpcustomer.Controls.Add(Me.txtsurname)
        Me.grpcustomer.Controls.Add(Me.txtaddress)
        Me.grpcustomer.Controls.Add(Me.txtpostcode)
        Me.grpcustomer.Controls.Add(Me.Label3)
        Me.grpcustomer.Controls.Add(Me.Label4)
        Me.grpcustomer.Location = New System.Drawing.Point(10, 52)
        Me.grpcustomer.Name = "grpcustomer"
        Me.grpcustomer.Size = New System.Drawing.Size(647, 173)
        Me.grpcustomer.TabIndex = 35
        Me.grpcustomer.TabStop = False
        Me.grpcustomer.Text = "Customer Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Customer ID"
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Location = New System.Drawing.Point(77, 29)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(153, 20)
        Me.txtcustomerid.TabIndex = 18
        '
        'txttelephone
        '
        Me.txttelephone.Location = New System.Drawing.Point(460, 94)
        Me.txttelephone.Name = "txttelephone"
        Me.txttelephone.Size = New System.Drawing.Size(161, 20)
        Me.txttelephone.TabIndex = 21
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(460, 56)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(161, 20)
        Me.txtemail.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(77, 64)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(153, 20)
        Me.txtfirstname.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(363, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Email Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Telephone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname"
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(77, 98)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(153, 20)
        Me.txtsurname.TabIndex = 3
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(77, 133)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(153, 20)
        Me.txtaddress.TabIndex = 5
        '
        'txtpostcode
        '
        Me.txtpostcode.Location = New System.Drawing.Point(460, 130)
        Me.txtpostcode.Name = "txtpostcode"
        Me.txtpostcode.Size = New System.Drawing.Size(161, 20)
        Me.txtpostcode.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PostCode"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 475)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lstcustomer)
        Me.Controls.Add(Me.grpcustomer)
        Me.Name = "frmcustomer"
        Me.Text = "Customer Details"
        Me.grpcustomer.ResumeLayout(False)
        Me.grpcustomer.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnhelp As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents lstcustomer As System.Windows.Forms.ListBox
    Friend WithEvents grpcustomer As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtcustomerid As System.Windows.Forms.TextBox
    Friend WithEvents txttelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtpostcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider

End Class
