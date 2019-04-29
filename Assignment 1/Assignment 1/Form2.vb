Structure product
    ' Product File Record Structure
    <VBFixedString(10)> Dim productID As String
    <VBFixedString(20)> Dim addon As String
    <VBFixedString(30)> Dim productsize As String
    <VBFixedString(40)> Dim productimage As String
    <VBFixedString(10)> Dim finalprice As String
End Structure
Public Class frmproduct
    ' Global variables
    Dim Number As Integer
    Dim CurrentRec As Integer
    Dim product As product
    Dim Filename As String = "product.dat"
    Dim NumberOfRecords As Integer
    Dim TableFormat As String = "{0,-10}{1,-10}{2,-20}{3,-20}{4,-20}{5,-20}"
    Dim finalprice As String

    Dim ImgLoc As String = "F:\Hnd computing\Programming\Assignment one\Assignment one\"
    Private Sub frmproduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Loading the Product Form
        FileOpen(1, Filename, OpenMode.Random, , , Len(product))

        NumberOfRecords = LOF(1) / Len(product)

        FileClose(1)
    End Sub

    Private Sub btnupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupload.Click
        'upload button pressed
        Dim OpenFileDialog1 As New OpenFileDialog

        'Dialog only shows certain picture types
        OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            picproduct.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
        'Picture displayed
        cbmimage.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        ' View records in List box button pressed

        ' Clear the listbox

        lstproduct.Items.Clear()
        ' Add the Headings to the Listbox

        lstproduct.Items.Add(String.Format(TableFormat, "No.", "Product ID", "Add On", "Product Size", "Image Name", "Final Price"))
        ' Open the file
        FileOpen(1, Filename, OpenMode.Random, , , Len(product))

        Number = 1
        ' Read all Product records and add to the list box
        Do While Not EOF(1)
            FileGet(1, product)
            lstproduct.Items.Add(String.Format(TableFormat, Number, Trim(product.productID), Trim(product.addon), Trim(product.productsize), Trim(product.productimage), Trim(product.finalprice)))
            Number += 1
        Loop
        'close the file
        FileClose(1)
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        'search button pressed

        Dim Number As Integer
        'choosing search type

        Dim srchType As String = cbmsize.Text
        ' Clear the listbox

        lstproduct.Items.Clear()
        ' Add the Headings to the Listbox

        lstproduct.Items.Add(String.Format(TableFormat, "No.", "Product ID", "Add On", "Product Size", "Image Name", "Final Price"))
        ' Open the file

        FileOpen(1, Filename, OpenMode.Random, , , Len(product))
        ' Read all Product records and add to the list box
        Number = 1
        Do While Not EOF(1)
            FileGet(1, product)
            If Trim(product.productsize) = Trim(srchType) Then
                lstproduct.Items.Add(String.Format(TableFormat, Number, product.productID, product.addon, product.productsize, product.productimage, product.finalprice))
            End If
            Number = Number + 1
        Loop
        'close the file
        FileClose(1)
    End Sub

    Private Sub cbmimage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbmimage.SelectedIndexChanged
        'geetin images from my resources
        If cbmimage.Text = "Halo 3" Then
            picproduct.Image = My.Resources.halo3
        ElseIf cbmimage.Text = "BloodBorne" Then
            picproduct.Image = My.Resources.Bloodborne
        ElseIf cbmimage.Text = "DarkSouls" Then
            picproduct.Image = My.Resources.Darksouls
        ElseIf cbmimage.Text = "Pokemon" Then
            picproduct.Image = My.Resources.PikaClu
        ElseIf cbmimage.Text = "FireWatch" Then
            picproduct.Image = My.Resources.FireWatch
        ElseIf cbmimage.Text = "MW2" Then
            picproduct.Image = My.Resources.MW2
        ElseIf cbmimage.Text = "UnderTale" Then
            picproduct.Image = My.Resources.Undertale
        ElseIf cbmimage.Text = "DisHonred" Then
            picproduct.Image = My.Resources.Dishonred
        ElseIf cbmimage.Text = "Fallout" Then
            picproduct.Image = My.Resources.Fallout
        ElseIf cbmimage.Text = "FinalFantasy" Then
            picproduct.Image = My.Resources.FinalFantasy
        ElseIf cbmimage.Text = "Tetris" Then
            picproduct.Image = My.Resources.Tetris
        ElseIf cbmimage.Text = "World Of WarCraft" Then
            picproduct.Image = My.Resources.Lichking
        ElseIf cbmimage.Text = "Legend Of Zelda" Then
            picproduct.Image = My.Resources.Zelda
        ElseIf cbmimage.Text = "Gears Of War" Then
            picproduct.Image = My.Resources.GearsOfWar
        ElseIf cbmimage.Text = "Portal" Then
            picproduct.Image = My.Resources.Portal
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        ' add button pressed
        'calculations for final price
        If cbmsize.Text = "8.5 X 11 Smallest" Then
            finalprice = 20
        ElseIf cbmsize.Text = "11 X 17 Small" Then
            finalprice = 25
        ElseIf cbmsize.Text = "18 X 24 Medium" Then
            finalprice = 30
        ElseIf cbmsize.Text = "24 X 36 Large" Then
            finalprice = 35
        ElseIf cbmsize.Text = "27 X 40 Movie Poster" Then
            finalprice = 40
        ElseIf cbmsize.Text = "40 X 60 Bus Stop Poster" Then
            finalprice = 45
        End If

        'calculations for final price
        If cbmaddon.Text = "No frame" Then
            finalprice = finalprice + 0
        ElseIf cbmaddon.Text = "Glossy" Then
            finalprice = finalprice + 10
        ElseIf cbmaddon.Text = "Photo Realistic" Then
            finalprice = finalprice + 15
        ElseIf cbmaddon.Text = "Frame Included" Then
            finalprice = finalprice + 20
        End If


        txtfinalprice.Text = finalprice

        ' Copy the values in the text boxes on the form to the Product record structure
        product.productID = txtproductid.Text
        product.addon = cbmaddon.Text
        product.productsize = cbmsize.Text
        product.productimage = cbmimage.Text
        product.finalprice = txtfinalprice.Text

        NumberOfRecords += 1

        ' Clear the text boxes in the form
        FileOpen(1, Filename, OpenMode.Random, , , Len(product))
        FilePut(1, product, NumberOfRecords)
        FileClose(1)

        'txtproductid.Text = ""
        'cbmaddon.Text = ""
        'cbmsize.Text = ""
        'cbmimage.Text = ""
        'txtfinalprice.Text = ""

        'place cursor in product id textbox
        txtproductid.Focus()
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        ' Edit button pressed
        'Open file
        FileOpen(1, Filename, OpenMode.Random, , , Len(product))

        'Get details from the form record
        product.productID = txtproductid.Text
        product.addon = cbmaddon.Text
        product.productsize = cbmsize.Text
        product.productimage = cbmimage.Text
        product.finalprice = txtfinalprice.Text

        'save record
        FilePut(1, product, CurrentRec)

        'close file
        FileClose(1)

        'clear form
        txtproductid.Text = ""
        cbmaddon.Text = ""
        cbmsize.Text = ""
        cbmimage.Text = ""
        txtfinalprice.Text = ""

        'place cursor on ID text box
        txtproductid.Focus()

        MessageBox.Show("Product details saved", "Message", MessageBoxButtons.OK)
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
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
            'Open Product File
            FileOpen(1, Filename, OpenMode.Random, , , Len(product))
            'Open tempoary file
            FileOpen(2, TempFileName, OpenMode.Random, , , Len(product))

            ' Write all records to the Temporary file - Except the one to be deleted
            Do While Not EOF(1)
                FileGet(1, product)

                If Trim(product.productID) <> Trim(ID) Then
                    FilePut(2, product)
                End If
            Loop

            'Close Product File
            FileClose(1)
            'Close Temp File
            FileClose(2)

            'Delete Product File
            Kill(Filename)

            'Rename the Temporary File as Product File 
            Rename(TempFileName, Filename)

            'Subtract 1 from total number of records
            NumberOfRecords -= 1

            'Clear form;
            txtproductid.Text = ""
            cbmaddon.Text = ""
            cbmsize.Text = ""
            cbmimage.Text = ""
            txtfinalprice.Text = ""

            'Place cursor on ID text box
            txtproductid.Focus()

            MessageBox.Show("Product record deleted", "Message", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub lstproduct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstproduct.SelectedIndexChanged
        ' Record selected from listbox
        Dim recno As String

        Dim lastrecdata As String = lstproduct.SelectedItem
        If lastrecdata <> "" Then

            ' The record position from the listbox will match the record number on the file
            recno = Trim(lastrecdata.Substring(0, 5))
            CurrentRec = Convert.ToInt32(recno)

            FileOpen(1, Filename, OpenMode.Random, , , Len(product))
            FileGet(1, product, CurrentRec)

            ' Fill the fields
            txtproductid.Text = product.productID
            cbmaddon.Text = product.addon
            cbmsize.Text = product.productsize
            cbmimage.Text = product.productimage
            txtfinalprice.Text = product.finalprice

            'close the file
            FileClose(1)
        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        'clear button pressed

        txtproductid.Text = ""
        cbmaddon.Text = ""
        cbmsize.Text = ""
        cbmimage.Text = ""
        txtfinalprice.Text = ""

        'cursor placed on ID
        txtproductid.Focus()
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        ' Reset File button pressed
        ' Delete the Product file
        Kill(Filename)
        NumberOfRecords = 0
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        ' Exit button pressed
        Me.Close()
    End Sub

    Private Sub btnpriceinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpriceinfo.Click
        'info button pressed shows price info form
        frmpriceinfo.Show()
    End Sub

    Private Sub btnhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhelp.Click
        'help button pressed shows help form
        frmhelp.Show()
    End Sub

    Private Sub txtproductid_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtproductid.Validating
        'validation of ID
        If txtproductid.Text Like "####" Then
            ErrorProvider.SetError(txtproductid, "")
        Else
            ErrorProvider.SetError(txtproductid, "Please Input four digit number")
            e.Cancel = True
        End If
    End Sub

    Private Sub cbmaddon_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbmaddon.Validating
        'validation of Add-on
        If cbmaddon.Text = "" Then
            ErrorProvider.SetError(cbmaddon, "Must Choose a Add-on")
            e.Cancel = True
        Else
            ErrorProvider.SetError(cbmaddon, "")
        End If
    End Sub

    Private Sub cbmsize_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbmsize.Validating
        'validation of Size
        If cbmsize.Text = "" Then
            ErrorProvider.SetError(cbmsize, "Must Choose a Size")
            e.Cancel = True
        Else
            ErrorProvider.SetError(cbmsize, "")
        End If
    End Sub

    Private Sub cbmimage_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbmimage.Validating
        'validation of Images
        If cbmimage.Text = "" Then
            ErrorProvider.SetError(cbmimage, "Must Choose a Image")
            e.Cancel = True
        Else
            ErrorProvider.SetError(cbmimage, "")
        End If
    End Sub
End Class