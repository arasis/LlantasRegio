Imports System.Runtime.CompilerServices
Module Module1
    <Extension()> Public Function GetMyNumberToWords(ByVal value As String) As String
        Dim str As String = String.Empty

        Select Case Convert.ToDouble(value)
            Case 0 : str = "CERO"
            Case 1 : str = "UN"
            Case 2 : str = "DOS"
            Case 3 : str = "TRES"
            Case 4 : str = "CUATRO"
            Case 5 : str = "CINCO"
            Case 6 : str = "SEIS"
            Case 7 : str = "SIETE"
            Case 8 : str = "OCHO"
            Case 9 : str = "NUEVE"
            Case 10 : str = "DIEZ"
            Case 11 : str = "ONCE"
            Case 12 : str = "DOCE"
            Case 13 : str = "TRECE"
            Case 14 : str = "CATORCE"
            Case 15 : str = "QUINCE"
            Case Is < 20 : str = "DIECI" & GetMyNumberToWords(value - 10)
            Case 20 : str = "VEINTE"
            Case Is < 30 : str = "VEINTI" & GetMyNumberToWords(value - 20)
            Case 30 : str = "TREINTA"
            Case 40 : str = "CUARENTA"
            Case 50 : str = "CINCUENTA"
            Case 60 : str = "SESENTA"
            Case 70 : str = "SETENTA"
            Case 80 : str = "OCHENTA"
            Case 90 : str = "NOVENTA"
            Case Is < 100 : str = GetMyNumberToWords(Int(value \ 10) * 10) & " Y " & GetMyNumberToWords(value Mod 10)
            Case 100 : str = "CIEN"
            Case Is < 200 : str = "CIENTO " & GetMyNumberToWords(value - 100)
            Case 200, 300, 400, 600, 800 : str = GetMyNumberToWords(Int(value \ 100)) & "CIENTOS"
            Case 500 : str = "QUINIENTOS"
            Case 700 : str = "SETECIENTOS"
            Case 900 : str = "NOVECIENTOS"
            Case Is < 1000 : str = GetMyNumberToWords(Int(value \ 100) * 100) & " " & GetMyNumberToWords(value Mod 100)
            Case 1000 : str = "MIL"
            Case Is < 2000 : str = "MIL " & GetMyNumberToWords(value Mod 1000)
            Case Is < 1000000 : str = GetMyNumberToWords(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then str = str & " " & GetMyNumberToWords(value Mod 1000)
            Case 1000000 : str = "UN MILLON"
            Case Is < 2000000 : str = "UN MILLON " & GetMyNumberToWords(value Mod 1000000)
            Case Is < 1000000000000.0# : str = GetMyNumberToWords(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then str = str & " " & GetMyNumberToWords(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : str = "UN BILLON"
            Case Is < 2000000000000.0# : str = "UN BILLON " & GetMyNumberToWords(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : str = str(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then str = str & " " & GetMyNumberToWords(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select

        Return str
    End Function
End Module
