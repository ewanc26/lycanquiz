Public Class Form1
    ' Correct answers for Q1 to Q5 respectively
    Private correctAnswers As Boolean() = {True, False, True, False, True}

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Dim score As Integer = 0

        ' Arrays of radio buttons for True and False options per question
        Dim trueButtons As RadioButton() = {radBtnQ1True, radBtnQ2True, radBtnQ3True, radBtnQ4True, radBtnQ5True}
        Dim falseButtons As RadioButton() = {radBtnQ1False, radBtnQ2False, radBtnQ3False, radBtnQ4False, radBtnQ5False}

        For i As Integer = 0 To 4
            Dim correct As Boolean = correctAnswers(i)
            Dim trueChecked As Boolean = trueButtons(i).Checked
            Dim falseChecked As Boolean = falseButtons(i).Checked

            Select Case i + 1
                Case 1
                    ' Q1: Using "=" and "And"
                    If (trueChecked = correct) And (falseChecked <> correct) Then
                        score += 1
                    End If
                Case 2
                    ' Q2: Using "<>"
                    If (trueChecked = correct) Then
                        score += 1
                    End If
                Case 3
                    ' Q3: Using "=" and "And"
                    If (trueChecked = correct) And (falseChecked <> correct) Then
                        score += 1
                    End If
                Case 4
                    ' Q4: Using "=" and "And"
                    If (trueChecked = correct) And (falseChecked <> correct) Then
                        score += 1
                    End If
                Case 5
                    ' Q5: Combined "Or" and "And" with parentheses
                    If ((trueChecked = correct) Or (falseChecked <> correct)) And (trueChecked <> falseChecked) Then
                        score += 1
                    End If
            End Select
        Next

        If score <> 5 Then
            lblFinalScore.Text = $"Not everything! {score} / 5"
        Else
            lblFinalScore.Text = $"{score} / 5! You know it!"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
