Imports System.IO
Imports EnglishTeacher.Remove
Public Class Form2
    Dim count As Integer = 0
    Dim randomValue As Integer = 0
    Dim score As Integer = 0
    Dim upperbound As Integer = 14
    Dim lowerbound As Integer = 0
    Dim wordsEn(15) As String
    Dim wordsBg(15) As String
    Dim valuesChosen(5) As Integer
    Dim pathEn As String = "D:\Petko 12a\Visual Basic\School-C-\VB\EnglishTeacher\EnglishTeacher\Recoruces\en.txt"
    Dim pathBg As String = "D:\Petko 12a\Visual Basic\School-C-\VB\EnglishTeacher\EnglishTeacher\Recoruces\bg.txt"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim srEn As StreamReader = New StreamReader(pathEn)
        Dim srBg As StreamReader = New StreamReader(pathBg)
        For index As Integer = 0 To upperbound
            wordsEn(index) = srEn.ReadLine()
            wordsBg(index) = srBg.ReadLine()
        Next
        srEn.Close()
        srBg.Close()
        wordsEn = RemoveAt(wordsEn, randomValue)
        wordsBg = RemoveAt(wordsBg, randomValue)
        upperbound -= 1
        Randomize()
        randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        valuesChosen(count) = randomValue
        txt_word_bg.Text = wordsBg(randomValue)
    End Sub

    Private Sub btn_subbmit_Click(sender As Object, e As EventArgs) Handles btn_subbmit.Click
        If StrComp(txt_word_en.Text.ToLower, wordsEn(randomValue).ToLower) = 0 Then
            score += 1
        End If
        Do
            Randomize()
            wordsEn = RemoveAt(wordsEn, randomValue)
            wordsBg = RemoveAt(wordsBg, randomValue)
            upperbound -= 1
            randomValue = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Loop While randomValue = valuesChosen(count)
        txt_word_bg.Text = wordsBg(randomValue)
        valuesChosen(count) = randomValue
        lbl_score.Text = score
        count += 1
        If count = 5 Then
            MsgBox("Score of Round:" & score)
            Module1.score += score
            Me.Hide()
            Form3.Show()
        End If
        txt_word_en.Clear()
    End Sub
End Class