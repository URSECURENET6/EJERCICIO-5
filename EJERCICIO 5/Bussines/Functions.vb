Imports System.Text.RegularExpressions

Module Functions
    Public num As Integer

    Public Delegate Sub delegatefillDGV(ByVal value As Object)

    Public Function Check(value As String) As Boolean
        If Regex.IsMatch(value, "\d{2}[-]\d{4}", RegexOptions.IgnoreCase) Then
            Return True
        Else
            If Regex.IsMatch(value, "\d{7}[_]\d{3}", RegexOptions.IgnoreCase) Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
End Module
