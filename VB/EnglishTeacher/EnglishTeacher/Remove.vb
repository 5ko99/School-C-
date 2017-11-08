Public Class Remove
    Public Shared Function RemoveAt(arr As String(), index As Integer) As String()
        Dim arrNew() As String = {}
        For i As Integer = index To arr.Length - 2
            arr(i) = arr(i + 1)
        Next
        Return arr
    End Function
End Class
