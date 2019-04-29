Structure Customer
    'structure of customer
    <VBFixedString(10)> Dim customerID As String
    <VBFixedString(20)> Dim firstName As String
    <VBFixedString(20)> Dim surname As String
    <VBFixedString(20)> Dim address As String
    <VBFixedString(30)> Dim email As String
    <VBFixedString(12)> Dim telephone As String
    <VBFixedString(10)> Dim postcode As String
End Structure
Public Class frmcustomer
    ' Global variables
    Dim Number As Integer
    Dim CurrentRec As Integer
    Dim customer As Customer
    Dim Filename As String = "Customer.dat"
    Dim NumberOfRecords As Integer
    Dim TableFormat As String = "{0,-5}{1,-10}{2,-15}{3,-20}{4,-25}{5,-30}{6,-35}{7,-38}"

    ' Loading the Customer Form
    Private Sub frmcustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Store the number of records in the Customer file
        FileOpen(1, Filename, OpenMode.Random, , , Len(customer))

        NumberOfRecords = LOF(1) / Len(customer)

        FileClose(1)
    End Sub

    Private Sub btnadd_Click(sender As System.Object, e As System.EventArgs) Handles btnadd.Click
        ' Add record button pressed
        ' Copy the values in the text boxes on the form to the Customer record structure
        customer.customerID = txtcustomerid.Text
        customer.firstName = txtfirstname.Text
        customer.surname = txtsurname.Text
        customer.address = txtaddress.Text
        customer.email = txtemail.Text
        customer.telephone = txttelephone.Text
        customer.postcode = txtpostcode.Text

        NumberOfRecords += 1
        ' Add the new record to the end of the Student file
        FileOpen(1, Filename, OpenMode.Random, , , Len(customer))
        FilePut(1, customer, NumberOfRecords)
        FileClose(1)

        'Don't clear files as it bugs up the error provider
        'txtcustomerid.Text = ""
        'txtfirstname.Text = ""
        'txtsurname.Text = ""
        'txtaddress.Text = ""
        'txtemail.Text = ""
        'txttelephone.Text = ""
        'txtpostcode.Text = ""

        txtcustomerid.Focus()
        ' Place the cursor in the Customer Id textbox
    End Sub

    Private Sub btnview_Click(sender As System.Object, e As System.EventArgs) Handles btnview.Click
        'View Button Pressed
        ' View records in List box button pressed
        ' Clear the listbox
        lstcustomer.Items.Clear()

        ' Add the Headings to the Listbox
        lstcustomer.Items.Add(String.Format(TableFormat, "No.", "ID", "First Name", "Surname", "Address", "Email Address", "Telephone Number", "PostCode"))
        ' Open the file
        FileOpen(1, Filename, OpenMode.Random, , , Len(customer))


        Number = 1
        Do While Not EOF(1)
            FileGet(1, customer)
            ' Read all Customers records and add to the list box
            lstcustomer.Items.Add(String.Format(TableFormat, Number, Trim(customer.customerID), Trim(customer.firstName), Trim(customer.surname), Trim(customer.address), Trim(customer.email), Trim(customer.telephone), Trim(customer.postcode)))
            Number += 1
        Loop
        ' Close the file
        FileClose(1)
    End Sub

    Private Sub btnsearch_Click(sender As System.Object, e As System.EventArgs) Handles btnsearch.Click
        'Search Button Pressed
        Dim Number As Integer

        'Making search type
        Dim srchType As String = txtsurname.Text


        lstcustomer.Items.Clear()

        ' Add the Headings to the Listbox
        lstcustomer.Items.Add(String.Format(TableFormat, "No.", "ID", "First Name", "Surname", "Address", "Email Address", "Telephone Number", "PostCode"))
        ' Open the file
        FileOpen(1, Filename, OpenMode.Random, , , Len(customer))

        Number = 1
        Do While Not EOF(1)
            FileGet(1, customer)
            If Trim(customer.surname) = Trim(srchType) Then
                ' Read all Customers records and add to the list box
                lstcustomer.Items.Add(String.Format(TableFormat, Number, customer.customerID, customer.firstName, customer.surname, customer.address, customer.email, customer.telephone, customer.postcode))
            End If
            Number = Number + 1
        Loop
        'Close the file
        FileClose(1)
    End Sub

    Private Sub btnedit_Click(sender As System.Object, e As System.EventArgs) Handles btnedit.Click
        ' Edit button pressed
        'Open file
        FileOpen(1, Filename, OpenMode.Random, , , Len(customer))
        'Get details from the form record
        customer.customerID = txtcustomerid.Text
        customer.firstName = txtfirstname.Text
        customer.surname = txtsurname.Text
        customer.address = txtaddress.Text
        customer.email = txtemail.Text
        customer.telephone = txttelephone.Text
        customer.postcode = txtpostcode.Text
        'Save record
        FilePut(1, customer, CurrentRec)
        'Close file
        FileClose(1)


        'txtcustomerid.Text = ""
        'txtfirstname.Text = ""
        'txtsurname.Text = ""
        'txtaddress.Text = ""
        'txtemail.Text = ""
        'txttelephone.Text = ""
        'txtpostcode.Text = ""

        'Place cursor on ID text box
        txtcustomerid.Focus()
        MessageBox.Show("Customer details saved", "Message", MessageBoxButtons.OK)
    End Sub

    Private Sub btndelete_Click(sender As System.Object, e As System.EventArgs) Handles btndelete.Click
        ' Delete button pressed
        'Local variables
        Dim Response As MsgBoxStyle
        Dim ID As String
        Dim TempFileName As String = "Temp.dat"

        'Display message box
        Response = MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.YesNo, "Check")
        'If yes delete
        If Response = MsgBoxResult.Yes Then
            'Get record number
            ID = txtcustomerid.Text
            'Open Customer File
            'Open a Temporary File
            FileOpen(1, Filename, OpenMode.Random, , , Len(customer))
            FileOpen(2, TempFileName, OpenMode.Random, , , Len(customer))

            ' Write all records to the Temporary file - Except the one to be deleted 
            Do While Not EOF(1)
                FileGet(1, customer)

                If Trim(customer.customerID) <> Trim(ID) Then
                    FilePut(2, customer)
                End If
            Loop
            'Close Customer File
            FileClose(1)
            'Close Temp File
            FileClose(2)

            'Make the Temprary file the Customer file 

            'Delete Student File
            Kill(Filename)

            'Rename the Temporary File as Student File 
            Rename(TempFileName, Filename)

            'Subtract 1 from total number of records
            NumberOfRecords -= 1

            'txtcustomerid.Text = ""
            'txtfirstname.Text = ""
            'txtsurname.Text = ""
            'txtaddress.Text = ""
            'txtemail.Text = ""
            'txttelephone.Text = ""
            'txtpostcode.Text = ""

            'Place cursor on ID text box
            txtcustomerid.Focus()

            MessageBox.Show("Customer record deleted", "Message", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub lstcustomer_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstcustomer.SelectedIndexChanged
        Dim recno As String
        ' Store the selected record number 
        Dim lastrecdata As String = lstcustomer.SelectedItem

        If lastrecdata <> "" Then

            recno = Trim(lastrecdata.Substring(0, 5))
            CurrentRec = Convert.ToInt32(recno)
            ' The record position from the listbox will match the record number on the file
            FileOpen(1, Filename, OpenMode.Random, , , Len(customer))
            FileGet(1, customer, CurrentRec)
            ' Fill the fields
            txtcustomerid.Text = customer.customerID
            txtfirstname.Text = customer.firstName
            txtsurname.Text = customer.surname
            txtaddress.Text = customer.address
            txtemail.Text = customer.email
            txttelephone.Text = customer.telephone
            txtpostcode.Text = customer.postcode
            FileClose(1)
        End If
    End Sub

    Private Sub btnclear_Click(sender As System.Object, e As System.EventArgs) Handles btnclear.Click
        'Clear button pressed
        'clear all fields
        txtcustomerid.Text = ""
        txtfirstname.Text = ""
        txtsurname.Text = ""
        txtaddress.Text = ""
        txtemail.Text = ""
        txttelephone.Text = ""
        txtpostcode.Text = ""

        'place cursor on ID text box
        txtcustomerid.Focus()
    End Sub

    Private Sub btnreset_Click(sender As System.Object, e As System.EventArgs) Handles btnreset.Click
        ' Reset File button pressed
        ' Delete the Student file
        Kill(Filename)
        ' Store the number of records in the Customer file
        NumberOfRecords = 0
    End Sub

    Private Sub btnexit_Click(sender As System.Object, e As System.EventArgs) Handles btnexit.Click
        ' Exit button pressed
        Me.Close()
    End Sub

    Private Sub btnhelp_Click(sender As System.Object, e As System.EventArgs) Handles btnhelp.Click
        'Help button pressed
        frmhelp.Show()
    End Sub

    Private Sub txtcustomerid_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtcustomerid.Validating
        'Validation of ID
        If txtcustomerid.Text Like "####" Then
            ErrorProvider.SetError(txtcustomerid, "")
        Else
            ErrorProvider.SetError(txtcustomerid, "Please Input four digit number")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtfirstname_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtfirstname.Validating
        'Validation of First Name
        If txtfirstname.Text = "" Then
            ErrorProvider.SetError(txtfirstname, "Please Input a First Name")
            e.Cancel = True
        Else
            ErrorProvider.SetError(txtfirstname, "")
        End If
    End Sub

    Private Sub txtsurname_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtsurname.Validating
        'Validation of Surname
        If txtsurname.Text = "" Then
            ErrorProvider.SetError(txtsurname, "Please Input a Surname")
            e.Cancel = True
        Else
            ErrorProvider.SetError(txtsurname, "")
        End If
    End Sub

    Private Sub txtaddress_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtaddress.Validating
        'Validation of Address
        If txtaddress.Text = "" Then
            ErrorProvider.SetError(txtaddress, "Please Input the Address")
            e.Cancel = True
        Else
            ErrorProvider.SetError(txtaddress, "")
        End If
    End Sub

    Private Sub txttelephone_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txttelephone.Validating
        'Validation of Telephone Number
        If txttelephone.Text Like "##### ######" Then
            ErrorProvider.SetError(txttelephone, "")
        Else
            ErrorProvider.SetError(txttelephone, "Wrong Telephone Format")
            e.Cancel = True
        End If
    End Sub

    Private Sub txtpostcode_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtpostcode.Validating
        'Validation of PostCode
        If txtpostcode.Text.Length = 7 Then
            ErrorProvider.SetError(txtpostcode, "")
        Else
            ErrorProvider.SetError(txtpostcode, "Wrong Format Must be like SA9 1SD")
            e.Cancel = True
        End If

    End Sub

    Private Sub txtemail_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles txtemail.Validating
        'Validation of Email
        If txtemail.Text.EndsWith("@nptc.ac.uk") Then
            ErrorProvider.SetError(txtemail, "")
        Else
            ErrorProvider.SetError(txtemail, "Please Make Sure It Ends With @nptc.ac.uk")
            e.Cancel = True
        End If
    End Sub
End Class
