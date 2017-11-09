Imports EnglishTeacher.Remove
Imports EnglishTeacher.Module1
Public Class Form3
    Dim animals(6) As String
    Dim randomValue As Integer = 0
    Dim upperbound As Integer = 5
    Dim lowerbound As Integer = 0
    Dim points = 0
    Dim n = 0
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        animals = {"Cow", "Elephant", "Lion", "Monkey", "Tiger", "Wolf"}
        randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        txtWord.Text = animals(randomValue)
        Rnd()
    End Sub

    Private Sub picCow_Click(sender As Object, e As EventArgs) Handles picCow.Click
        If randomValue = 0 Then
            points += 1
            lbl_score.Text = points
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox("Score of Round" & points)
            Module1.score += points
            MsgBox("Overall Score:" & Module1.score)
            Me.Hide()
            Form1.Show()
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub

    Private Sub picEl_Click(sender As Object, e As EventArgs) Handles picEl.Click
        If randomValue = 1 Then
            points += 1
            lbl_score.Text = points
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox("Score of Round" & points)
            Module1.score += points
            MsgBox("Overall Score:" & Module1.score)
            Me.Hide()
            Form1.Show()
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub

    Private Sub picLion_Click(sender As Object, e As EventArgs) Handles picLion.Click
        If randomValue = 2 Then
            points += 1
            lbl_score.Text = points
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox("Score of Round" & points)
            Module1.score += points
            MsgBox("Overall Score:" & Module1.score)
            Me.Hide()
            Form1.Show()
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub

    Private Sub picMonkey_Click(sender As Object, e As EventArgs) Handles picMonkey.Click
        If randomValue = 3 Then
            points += 1
            lbl_score.Text = points
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox("Score of Round" & points)
            Module1.score += points
            MsgBox("Overall Score:" & Module1.score)
            Me.Hide()
            Form1.Show()
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub

    Private Sub picTiger_Click(sender As Object, e As EventArgs) Handles picTiger.Click
        If randomValue = 4 Then
            points += 1
            lbl_score.Text = points
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox("Score of Round" & points)
            Module1.score += points
            MsgBox("Overall Score:" & Module1.score)
            Me.Hide()
            Form1.Show()
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub

    Private Sub picWolf_Click(sender As Object, e As EventArgs) Handles picWolf.Click
        If randomValue = 5 Then
            points += 1
            lbl_score.Text = points
        End If
        If n < 5 Then
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
            txtWord.Text = animals(randomValue)
            Rnd()
        Else
            MsgBox("Score of Round" & points)
            Module1.score += points
            MsgBox("Overall Score:" & Module1.score)
            Me.Hide()
            Form1.Show()
        End If
        n += 1
        animals = RemoveAt(animals, randomValue)
        upperbound -= 1
    End Sub


End Class