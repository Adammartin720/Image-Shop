Public Class frmmenu

    Private Sub btncustomer_Click(sender As System.Object, e As System.EventArgs) Handles btncustomer.Click
        'Customer button shows frmcustomer
        frmcustomer.Show()
    End Sub

    Private Sub btnproduct_Click(sender As System.Object, e As System.EventArgs) Handles btnproduct.Click
        'Product button shows frmproduct
        frmproduct.Show()
    End Sub

    Private Sub btnorder_Click(sender As System.Object, e As System.EventArgs) Handles btnorder.Click
        'Order button shows frmorder
        frmorder.Show()
    End Sub

    Private Sub btnexit_Click(sender As System.Object, e As System.EventArgs) Handles btnexit.Click
        'exit button pressed
        Me.Close()
    End Sub
End Class