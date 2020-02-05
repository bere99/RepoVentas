Public Class IVA
    Public Function calculosIVA(ByVal precioT As Single, ByVal tipo As String) As Object
        Dim IVA As Single
        Dim pSinIVA As Single
        If tipo = "General" Then
            IVA = 1.21
        ElseIf tipo = "Reducido" Then
            IVA = 1.12
        ElseIf tipo = "Superreducido" Then
            IVA = 1.04
        End If
        pSinIVA = precioT / IVA
        Return {pSinIVA, precioT - pSinIVA}
    End Function
End Class
