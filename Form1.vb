Public Class Form1
    Private Sub btnRate10_Click(sender As Object, e As EventArgs) Handles btnRate10.Click
        Const decRATE10 As Decimal = 0.1D

        Dim decSales As Decimal
        Dim decComm10 As Decimal

        Decimal.TryParse(txtSales.Text, decSales)

        decComm10 = decSales * decRATE10

        txtCommission.Text = decComm10.ToString("C2")
    End Sub

    Private Sub btnRate8_Click(sender As Object, e As EventArgs) Handles btnRate8.Click
        Const decRATE8 As Decimal = 0.08D

        Dim decSales As Decimal
        Dim decComm8 As Decimal

        Decimal.TryParse(txtSales.Text, decSales)

        decComm8 = decSales * decRATE8

        txtCommission.Text = decComm8.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
