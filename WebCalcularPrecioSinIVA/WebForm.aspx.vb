Public Class WebForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) And TextBox1.Text > 0 Then
            LabelErrors.Text = " "
            Dim IVA As New IVA
            Dim resultados(1) As Single
            resultados = IVA.calculosIVA(TextBox1.Text, DropDownList1.SelectedValue)
            IVAPagar.Text = resultados(1)
            PrecioSinIVA.Text = resultados(0)
        Else
            LabelErrors.Text = "El precio debe ser un número positivo."
            IVAPagar.Text = " "
            PrecioSinIVA.Text = " "
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub
End Class