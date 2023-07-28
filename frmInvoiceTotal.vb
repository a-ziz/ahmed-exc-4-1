Public Class frmInvoiceTotal

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click

        'Dim subtotal As Decimal = CDec(txtSubtotal.Text)
        Dim subtotal As Decimal = Decimal.Parse(txtSubtotal.Text)

        Dim discountPercent As Decimal = 0.25D
        Dim discountAmount As Decimal =
            Math.Round(subtotal * discountPercent, 2)
        Dim invoiceTotal As Decimal =
            Math.Round(subtotal - discountAmount, 2)

        txtDiscountPercent.Text = FormatPercent(discountPercent, 1)
        txtDiscountAmount.Text = discountAmount.ToString
        txtTotal.Text = invoiceTotal.ToString

        txtSubtotal.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class