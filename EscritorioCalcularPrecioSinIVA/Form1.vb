Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Resultado(1) As Single
        Dim IVA As New IVA
        If TipoIVA.Text = "" Then
            LabelErrors.Text = "Selecciona el tipo de IVA que desea aplicar."
            IVAPagarBox.Text = " "
            PSinIVABox.Text = " "
        ElseIf PrecioT.Text = "" Then
            LabelErrors.Text = "El precio debe ser un número positivo."
            IVAPagarBox.Text = " "
            PSinIVABox.Text = " "
        ElseIf IsNumeric(PrecioT.Text) And PrecioT.Text > 0 Then
            LabelErrors.Text = " "
            Resultado = IVA.calculosIVA(PrecioT.Text, TipoIVA.Text)

            IVAPagarBox.Text = Resultado(1)
            PSinIVABox.Text = Resultado(0)


        End If

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
