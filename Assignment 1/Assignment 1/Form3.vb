Structure products
    'structure products
    <VBFixedString(10)> Dim productID As String
    <VBFixedString(20)> Dim addon As String
    <VBFixedString(30)> Dim productsize As String
    <VBFixedString(40)> Dim productimage As String
    <VBFixedString(10)> Dim finalprice As String
End Structure
Structure customers
    'strcutre customer
    <VBFixedString(10)> Dim customerID As String
    <VBFixedString(20)> Dim firstName As String
    <VBFixedString(20)> Dim surname As String
    <VBFixedString(20)> Dim address As String
    <VBFixedString(30)> Dim email As String
    <VBFixedString(12)> Dim telephone As String
    <VBFixedString(10)> Dim postcode As String
End Structure
Structure order
    'structure order
    <VBFixedString(10)> Dim productID As String
    <VBFixedString(10)> Dim customerID As String
    <VBFixedString(40)> Dim productimage As String
    <VBFixedString(10)> Dim finalprice As String
End Structure
Public Class frmorder
    ' Global variables
    Dim Number As Integer
    Dim CurrentRecp As Integer
    Dim CurrentRecc As Integer
    Dim CurrentReco As Integer
    Dim NumberOfRecordso As Integer

    Dim product As products
    Dim customer As customers
    Dim order As order

    'files nemes for product, customer and order
    Dim Filenamep As String = "product.dat"
    Dim Filenamec As String = "customer.dat"
    Dim Filenameo As String = "order.dat"

    'table format for Product, customer and order
    Dim TableFormatp As String = "{0,-10}{1, -10}{2,-20}{3,-20}{4,-20}{5,-20}"
    Dim TableFormatc As String = "{0,-5}{1,-10}{2,-15}{3,-20}{4,-25}{5,-30}{6,-35}{7,-38}"
    Dim TableFormato As String = "{0,-5}{1, -12}{2,-15}{3,-15}{4,-15}"

    Private Sub frmorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Loading the Order Form
        lstcustomer.Items.Clear()

        ' Add the Headings to the Listbox
        lstcustomer.Items.Add(String.Format(TableFormatc, "No.", "ID", "First Name", "Surname", "Address", "Email Address", "Telephone Number", "PostCode"))
        FileOpen(1, Filenamec, OpenMode.Random, , , Len(customer))

        Number = 1
        Do While Not EOF(1)
            FileGet(1, customer)
            ' Read all Customer records and add to the list box
            lstcustomer.Items.Add(String.Format(TableFormatc, Number, Trim(customer.customerID), Trim(customer.firstName), Trim(customer.surname), Trim(customer.address), Trim(customer.email), Trim(customer.telephone), Trim(customer.postcode)))
            Number += 1
        Loop

        FileClose(1)

        lstproduct.Items.Clear()
        ' Add the Headings to the Listbox
        lstproduct.Items.Add(String.Format(TableFormatp, "No.", "Product ID", "Add On", "Product Size", "Image Name", "Final Price"))

        FileOpen(2, Filenamep, OpenMode.Random, , , Len(product))

        Number = 1
        Do While Not EOF(2)
            FileGet(2, product)
            ' Read all Product records and add to the list box
            lstproduct.Items.Add(String.Format(TableFormatp, Number, Trim(product.productID), Trim(product.addon), Trim(product.productsize), Trim(product.productimage), Trim(product.finalprice)))
            Number += 1
        Loop

        'close the file
        FileClose(2)
    End Sub

    Private Sub lstcustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstcustomer.SelectedIndexChanged
        'Record selected from listbox
        Dim recno As String
        ' Store the selected record number 
        Dim lastrecdata As String = lstcustomer.SelectedItem

        If lastrecdata <> "" Then

            recno = Trim(lastrecdata.Substring(0, 5))
            CurrentRecc = Convert.ToInt32(recno)

            ' The record position from the listbox will match the record number on the file
            FileOpen(1, Filenamec, OpenMode.Random, , , Len(customer))
            FileGet(1, customer, CurrentRecc)

            ' Fill the fields
            txtcustomerid.Text = customer.customerID
            txtfirstname.Text = customer.firstName
            txtsurname.Text = customer.surname
            txtaddress.Text = customer.address
            txtemail.Text = customer.email
            txttelephone.Text = customer.telephone
            txtpostcode.Text = customer.postcode

            FileClose(1)

            lstorder.Items.Clear()
            ' Add the Headings to the Listbox
            lstorder.Items.Add(String.Format(TableFormato, "No.", "Product ID", "Customer ID", "Image Name", "Final Price"))
            FileOpen(3, Filenameo, OpenMode.Random, , , Len(order))
            Number = 1
            Do While Not EOF(3)
                FileGet(3, order)

                ' Read all Order records and add to the list box
                If Trim(order.customerID) = Trim(txtcustomerid.Text) Then
                    lstorder.Items.Add(String.Format(TableFormato, Number, Trim(order.productID), Trim(order.customerID), Trim(order.productimage), Trim(order.finalprice)))

                End If
                Number += 1
            Loop
            FileClose(3)
        End If
    End Sub

    Private Sub lstproduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstproduct.SelectedIndexChanged
        ' Record selected from listbox
        Dim recno As String

        ' Store the selected record number
        Dim lastrecdata As String = lstproduct.SelectedItem

        If lastrecdata <> "" Then

            ' The record position from the listbox will match the record number on the file
            recno = Trim(lastrecdata.Substring(0, 5))
            CurrentRecp = Convert.ToInt32(recno)
            FileOpen(2, Filenamep, OpenMode.Random, , , Len(product))
            FileGet(2, product, CurrentRecp)

            ' Fill the fields
            txtproductid.Text = product.productID
            txtaddon.Text = product.addon
            txtsize.Text = product.productsize
            txtimage.Text = product.productimage
            txtfinalprice.Text = product.finalprice

            FileClose(2)
        End If
    End Sub

    Private Sub lstorder_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstorder.SelectedIndexChanged
        ' Record selected from listbox
        Dim recno As String
        ' Store the selected record number
        Dim lastrecdata As String = lstorder.SelectedItem()

        ' The record position from the listbox will match the record number on the file
        If lastrecdata <> "" Then
            recno = Trim(lastrecdata.Substring(0, 5))
            CurrentReco = Convert.ToInt32(recno)
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        ' Add record button pressed
        ' Copy the values in the text boxes on the form to the record structures 
        order.productID = txtproductid.Text
        order.customerID = txtcustomerid.Text
        order.productimage = txtimage.Text
        order.finalprice = txtfinalprice.Text

        FileOpen(3, Filenameo, OpenMode.Random, , , Len(order))

        NumberOfRecordso = LOF(3) / Len(order)
        NumberOfRecordso += 1
        FilePut(3, order, NumberOfRecordso)
        FileClose(3)



        lstorder.Items.Clear()
        ' Add the Headings to the Listbox
        lstorder.Items.Add(String.Format(TableFormato, "No.", "Product ID", "Customer ID", "Image Name", "Final Price"))
        FileOpen(3, Filenameo, OpenMode.Random, , , Len(order))


        Number = 1
        Do While Not EOF(3)
            FileGet(3, order)

            ' Read all Order records and add to the list box
            If Trim(order.customerID) = Trim(txtcustomerid.Text) Then
                lstorder.Items.Add(String.Format(TableFormato, Number, Trim(order.productID), Trim(order.customerID), Trim(order.productimage), Trim(order.finalprice)))

            End If
            Number += 1
        Loop
        FileClose(3)
    End Sub

    Private Sub btnremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnremove.Click
        ' Delete button pressed
        'Local variables
        Dim Response As MsgBoxStyle
        Dim ID As String
        'Set up temporary file
        Dim TempFileName As String = "Temp.dat"

        'Display message box
        Response = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Check")

        'If yes delete
        If Response = MsgBoxResult.Yes Then

            'Get record number
            ID = txtproductid.Text

            FileOpen(3, Filenameo, OpenMode.Random, , , Len(order))
            FileOpen(4, TempFileName, OpenMode.Random, , , Len(order))

            Do While Not EOF(3)
                FileGet(3, order)

                If Trim(order.productID) <> Trim(ID) Then
                    FilePut(4, order)
                End If
            Loop

            FileClose(3)
            FileClose(4)

            Kill(Filenameo)
            Rename(TempFileName, Filenameo)

            NumberOfRecordso -= 1

            MessageBox.Show("Order removed from Order Details", "Message", MessageBoxButtons.OK)

            lstorder.Items.Clear()
            ' Add the Headings to the Listbox
            lstorder.Items.Add(String.Format(TableFormato, "No.", "Product ID", "Customer ID", "Image Name", "Final Price"))
            FileOpen(3, Filenameo, OpenMode.Random, , , Len(order))


            Number = 1
            Do While Not EOF(3)
                FileGet(3, order)

                If Trim(order.customerID) = Trim(txtcustomerid.Text) Then
                    ' Read all Order records and add to the list box
                    lstorder.Items.Add(String.Format(TableFormato, Number, order.productID, order.customerID, order.productimage, order.finalprice))

                End If
                Number += 1
            Loop
            FileClose(3)
        End If
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        ' Exit button pressed
        Me.Close()
    End Sub

    Private Sub btnhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhelp.Click
        'help button pressed shows help form
        frmhelp.Show()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        'Print button pressed
        PrintPreviewDialog.Document = PrintDoc
        PrintPreviewDialog.ShowDialog()
    End Sub

    Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        'print variables/sizes
        Dim x, y, fontheight As Integer
        Dim myfont As New Font("Arial", 12, FontStyle.Regular)
        Dim Dline, Dline2, Dline3, Dline4, Dline5, Dline6, Dline7, Dline8, Dline9, Dline10, Dline11, Dline12 As String

        fontheight = myfont.GetHeight(e.Graphics)
        x = 50
        y = 50
        'print titles
        e.Graphics.DrawString("Your Order Has Been Processed, Please Pick It Up At Our Store", myfont, Brushes.Black, x, y)
        y = y + fontheight

        e.Graphics.DrawString("", myfont, Brushes.Black, x, y)
        y = y + fontheight

        e.Graphics.DrawString("Customer Details", myfont, Brushes.Black, x, y)
        y = y + fontheight

        e.Graphics.DrawString("", myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline = "Customer ID: " & txtcustomerid.Text

        e.Graphics.DrawString(Dline, myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline2 = "First Name: " & txtfirstname.Text

        e.Graphics.DrawString(Dline2, myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline3 = "Surname: " & txtsurname.Text

        e.Graphics.DrawString(Dline3, myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline4 = "Address: " & txtaddress.Text

        e.Graphics.DrawString(Dline4, myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline5 = "Email: " & txtemail.Text

        e.Graphics.DrawString(Dline5, myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline6 = "Telephone Number: " & txttelephone.Text

        e.Graphics.DrawString(Dline6, myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline7 = "PostCode: " & txtpostcode.Text

        e.Graphics.DrawString(Dline7, myfont, Brushes.Black, x, y)
        y = y + fontheight


        e.Graphics.DrawString("Product Details", myfont, Brushes.Black, x, y)
        y = y + fontheight


        Dline8 = "Product ID: " & txtproductid.Text

        e.Graphics.DrawString(Dline8, myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline9 = "Add-on Item: " & txtaddon.Text

        e.Graphics.DrawString(Dline9, myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline10 = "Image Size: " & txtsize.Text

        e.Graphics.DrawString(Dline10, myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline11 = "Image Name: " & txtimage.Text

        e.Graphics.DrawString(Dline11, myfont, Brushes.Black, x, y)
        y = y + fontheight

        Dline12 = "Final Price: " & txtfinalprice.Text

        e.Graphics.DrawString(Dline12, myfont, Brushes.Black, x, y)
        y = y + fontheight
    End Sub
End Class