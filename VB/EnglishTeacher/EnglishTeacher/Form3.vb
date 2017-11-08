Imports EnglishTeacher.Remove
Imports EnglishTeacher.Module1
Public Class Form3
    Dim animals(6) As String
    Dim randomValue As Integer = 0
    Dim upperbound As Integer = 5
    Dim lowerbound As Integer = 0
    Dim points = 0
    Dim n = 0
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtWord.TextChanged
        animals = {"Cow", "Elephant", "Lion", "Monkey", "Tiger", "Wolf"}
        randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        txtWord.Text = animals(randomValue)
        Rnd()
    End Sub

    Private Sub picCow_Click(sender As Object, e As EventArgs) Handles picCow.Click
        If randomValue = 0 Then
            points += 1
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox(points)
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub

    Private Sub picEl_Click(sender As Object, e As EventArgs) Handles picEl.Click
        If randomValue = 1 Then
            points += 1
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox(points)
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub

    Private Sub picLion_Click(sender As Object, e As EventArgs) Handles picLion.Click
        If randomValue = 2 Then
            points += 1
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox(points)
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub

    Private Sub picMonkey_Click(sender As Object, e As EventArgs) Handles picMonkey.Click
        If randomValue = 3 Then
            points += 1
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox(points)
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub

    Private Sub picTiger_Click(sender As Object, e As EventArgs) Handles picTiger.Click
        If randomValue = 4 Then
            points += 1
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox(points)
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub

    Private Sub picWolf_Click(sender As Object, e As EventArgs) Handles picWolf.Click
        If randomValue = 5 Then
            points += 1
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox("Overall Points:" & points)
            Module1.score += points
            MsgBox("Overall Score:" & score)
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub



End Class