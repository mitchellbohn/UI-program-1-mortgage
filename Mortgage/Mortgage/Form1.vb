Public Class Form1

    Dim charactersAllowed As String = ".1234567890"

    Private Sub TextPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextPrice.TextChanged
        Dim theText As String = TextPrice.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextPrice.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextPrice.Text.Length - 1
            Letter = TextPrice.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextPrice.Text = theText
        TextPrice.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub TextPayment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextPayment.TextChanged
        Dim theText As String = TextPayment.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextPayment.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextPayment.Text.Length - 1
            Letter = TextPayment.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextPayment.Text = theText
        TextPayment.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub TextInterest_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextInterest.TextChanged
        Dim theText As String = TextInterest.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextInterest.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextInterest.Text.Length - 1
            Letter = TextInterest.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextInterest.Text = theText
        TextInterest.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub TextTerm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextTerm.TextChanged
        Dim theText As String = TextTerm.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextTerm.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextTerm.Text.Length - 1
            Letter = TextTerm.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextTerm.Text = theText
        TextTerm.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim price As Double
        Dim down As Double
        Dim interest As Double
        Dim term As Double
        Dim mortgage As Double

        If TextPrice.Text = "" Then
            MessageBox.Show("Please Enter a Number for House Price.")
        ElseIf TextPayment.Text = "" Then
            MessageBox.Show("Please Enter a Number for Down Payment.")
        ElseIf TextInterest.Text = "" Then
            MessageBox.Show("Please Enter a Number for Interest Rate.")
        ElseIf TextTerm.Text = "" Then
            MessageBox.Show("Please Enter a Number for Term (in years).")
        Else
            price = Double.Parse(TextPrice.Text)
            down = Double.Parse(TextPayment.Text)
            interest = Double.Parse(TextInterest.Text)
            term = Double.Parse(TextTerm.Text)
            mortgage = ((price - down) * interest * (interest + 1) ^ (term * 12)) / ((interest + 1) ^ (term * 12) - 1)
            TextMort.Text = mortgage.ToString()
            TextMort.Visible = True
            MortLabel.Visible = True
        End If
    End Sub

    Private Sub Mortgage_TextChanged(sender As Object, e As EventArgs) Handles TextMort.TextChanged
        TextMort.Visible = False
        MortLabel.Visible = False
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TextPrice.Text = ""
        TextPayment.Text = ""
        TextInterest.Text = ""
        TextTerm.Text = ""
        TextMort.Text = ""
        If TextMort.Visible And MortLabel.Visible Then
            TextMort.Visible = False
            MortLabel.Visible = False
        End If
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Me.Close()
    End Sub
End Class