Public Class Form1

    Private StrengthWords() As String = {"Invalid", "Very Weak", "Weak", "Better", "Medium", "Strong", "Perfect"}

    Private Sub tbPassword_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbPassword.KeyUp
        CalculateMeter()
    End Sub

    Sub CalculateMeter()
        Dim score As Integer
        Dim password As String = tbPassword.Text

        If (password.Length > 6) Then score += 1
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") And System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then score += 1


        If System.Text.RegularExpressions.Regex.IsMatch(password, "\d+") Then score += 1

        If System.Text.RegularExpressions.Regex.IsMatch(password, "[,!,@,#,$,%,^,&,*,?,_,~,-,/,"",]") Then score += 1

        If (password.Length >= 10) Then score += 1
        If (password.Length >= 15) Then score += 1

        pbStrength.Value = score / 6 * 100
        lblProgressbar.Width = 50 * score
        lblProgressbar.Text = StrengthWords(score)

        lblProgressbar.TextAlign = ContentAlignment.MiddleCenter
        lblProgressbar.BackColor = GetColor(score)
        pbStrength.ForeColor = GetColor(score)

    End Sub

    Private Function GetColor(ByVal score As Integer) As Color
        Select Case score
            Case 0
                Return Color.Red
            Case 1
                Return Color.Red
            Case 2
                Return Color.Purple
            Case 3
                Return Color.LightGreen
            Case 4
                Return Color.MediumSeaGreen
            Case 5
                Return Color.Green
            Case 6
                Return Color.DarkGreen
        End Select
    End Function

End Class
