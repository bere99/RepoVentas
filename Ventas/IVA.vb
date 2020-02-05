Public Class IVA
    Public Function calculosIVA(ByVal precioT As Single, ByVal tipo As Single) As Object
        Dim IVA As Single
        Dim pSinIVA As Single
        IVA = 1 + tipo
        pSinIVA = precioT / IVA
        Return {pSinIVA, precioT - pSinIVA}
    End Function
End Class
