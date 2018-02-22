Public Class Form1

    Dim charactersAllowed As String = ".1234567890"

    Private Sub TextPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextPrice.TextChanged
        TextPrice.BackColor = System.Drawing.Color.PaleTurquoise
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

    Private Sub TextPay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextPay.TextChanged
        TextPay.BackColor = System.Drawing.Color.PaleTurquoise
        Dim theText As String = TextPay.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextPay.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextPay.Text.Length - 1
            Letter = TextPay.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextPay.Text = theText
        TextPay.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub TextPrice_Click(sender As Object, e As EventArgs) Handles TextPrice.Click
        TermBox.Visible = False
        InterestBox.Visible = False
    End Sub
    Private Sub TextPay_Click(sender As Object, e As EventArgs) Handles TextPay.Click
        TermBox.Visible = False
        InterestBox.Visible = False
    End Sub

    Private Sub TextInterest_Click(sender As Object, e As EventArgs) Handles TextInterest.Click
        TermBox.Visible = False
        If InterestBox.Visible = True Then
            InterestBox.Visible = False
        ElseIf InterestBox.Visible = False Then
            InterestBox.Visible = True
        End If
    End Sub

    Private Sub TextInterest_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextInterest.TextChanged
        InterestBox.Visible = False
        TermBox.Visible = False
        TextInterest.BackColor = System.Drawing.Color.PaleTurquoise
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

    Private Sub InterestBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InterestBox.SelectedIndexChanged
        If InterestBox.SelectedIndex = 0 Then
            TextInterest.Text = "3.5"
        ElseIf InterestBox.SelectedIndex = 1 Then
            TextInterest.Text = "3.75"
        ElseIf InterestBox.SelectedIndex = 2 Then
            TextInterest.Text = "4"
        ElseIf InterestBox.SelectedIndex = 3 Then
            TextInterest.Text = "4.25"
        ElseIf InterestBox.SelectedIndex = 4 Then
            TextInterest.Text = "4.5"
        End If
    End Sub

    Private Sub TextTerm_Click(sender As Object, e As EventArgs) Handles TextTerm.Click
        InterestBox.Visible = False
        If TermBox.Visible = True Then
            TermBox.Visible = False
        ElseIf TermBox.Visible = False Then
            TermBox.Visible = True
        End If
    End Sub

    Private Sub TextTerm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextTerm.TextChanged
        TermBox.Visible = False
        TextTerm.BackColor = System.Drawing.Color.PaleTurquoise
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

    Private Sub TermBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TermBox.SelectedIndexChanged
        If TermBox.SelectedIndex = 0 Then
            TextTerm.Text = "30"
        ElseIf TermBox.SelectedIndex = 1 Then
            TextTerm.Text = "20"
        ElseIf TermBox.SelectedIndex = 2 Then
            TextTerm.Text = "15"
        ElseIf TermBox.SelectedIndex = 3 Then
            TextTerm.Text = "10"
        End If
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        TermBox.Visible = False
        InterestBox.Visible = False

        Dim price As Double
        Dim down As Double
        Dim interest As Double
        Dim term As Double
        Dim mortgage As Double

        If TextPrice.Text = "" Then
            MessageBox.Show("Please Enter a Number for House Price.")
            TextPrice.BackColor = System.Drawing.Color.NavajoWhite
        ElseIf TextPay.Text = "" Then
            MessageBox.Show("Please Enter a Number for Down Payment.")
            TextPay.BackColor = System.Drawing.Color.NavajoWhite
        ElseIf TextInterest.Text = "" Then
            MessageBox.Show("Please Enter a Number for Interest Rate.")
            TextInterest.BackColor = System.Drawing.Color.NavajoWhite
        ElseIf TextTerm.Text = "" Then
            MessageBox.Show("Please Enter a Number for Term (in years).")
            TextTerm.BackColor = System.Drawing.Color.NavajoWhite
        Else
            price = Double.Parse(TextPrice.Text)
            down = Double.Parse(TextPay.Text)
            interest = Double.Parse(TextInterest.Text) / 100
            term = Double.Parse(TextTerm.Text)
            mortgage = (((price - down) * interest * (interest + 1) ^ (term)) / ((interest + 1) ^ (term) - 1)) / 12
            mortgage = Decimal.Round(mortgage, 2, MidpointRounding.AwayFromZero)
            TextMort.Text = mortgage.ToString()
            TextMort.Visible = True
            MortLabel.Visible = True
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        TermBox.Visible = False
        InterestBox.Visible = False

        TextPrice.BackColor = System.Drawing.Color.PaleTurquoise
        TextPay.BackColor = System.Drawing.Color.PaleTurquoise
        TextInterest.BackColor = System.Drawing.Color.PaleTurquoise
        TextTerm.BackColor = System.Drawing.Color.PaleTurquoise
        TextPrice.Text = ""
        TextPay.Text = ""
        TextInterest.Text = ""
        TextTerm.Text = ""
        TextMort.Text = ""
        If TextMort.Visible And MortLabel.Visible Then
            TextMort.Visible = False
            MortLabel.Visible = False
        End If
    End Sub

    Private Sub TextSalary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextSalary.TextChanged
        TextSalary.BackColor = System.Drawing.Color.PaleTurquoise
        Dim theText As String = TextSalary.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextSalary.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextSalary.Text.Length - 1
            Letter = TextSalary.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextSalary.Text = theText
        TextSalary.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub TextBills_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBills.TextChanged
        TextBills.BackColor = System.Drawing.Color.PaleTurquoise
        Dim theText As String = TextBills.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextBills.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextBills.Text.Length - 1
            Letter = TextBills.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextBills.Text = theText
        TextBills.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub TextSalary_Click(sender As Object, e As EventArgs) Handles TextSalary.Click
        TermBoxA.Visible = False
        InterestBoxA.Visible = False
    End Sub
    Private Sub TextBills_Click(sender As Object, e As EventArgs) Handles TextBills.Click
        TermBoxA.Visible = False
        InterestBoxA.Visible = False
    End Sub

    Private Sub TextInterestA_Click(sender As Object, e As EventArgs) Handles TextInterestA.Click
        TermBoxA.Visible = False
        If InterestBoxA.Visible = True Then
            InterestBoxA.Visible = False
        ElseIf InterestBoxA.Visible = False Then
            InterestBoxA.Visible = True
        End If
    End Sub

    Private Sub TextInterestA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextInterestA.TextChanged
        InterestBoxA.Visible = False
        TermBoxA.Visible = False
        TextInterestA.BackColor = System.Drawing.Color.PaleTurquoise
        Dim theText As String = TextInterestA.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextInterestA.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextInterestA.Text.Length - 1
            Letter = TextInterestA.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextInterestA.Text = theText
        TextInterestA.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub InterestBoxA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles InterestBoxA.SelectedIndexChanged
        If InterestBoxA.SelectedIndex = 0 Then
            TextInterestA.Text = "3.5"
        ElseIf InterestBoxA.SelectedIndex = 1 Then
            TextInterestA.Text = "3.75"
        ElseIf InterestBoxA.SelectedIndex = 2 Then
            TextInterestA.Text = "4"
        ElseIf InterestBoxA.SelectedIndex = 3 Then
            TextInterestA.Text = "4.25"
        ElseIf InterestBoxA.SelectedIndex = 4 Then
            TextInterestA.Text = "4.5"
        End If
    End Sub

    Private Sub TextTermA_Click(sender As Object, e As EventArgs) Handles TextTermA.Click
        InterestBoxA.Visible = False
        If TermBoxA.Visible = True Then
            TermBoxA.Visible = False
        ElseIf TermBoxA.Visible = False Then
            TermBoxA.Visible = True
        End If
    End Sub

    Private Sub TextTermA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextTermA.TextChanged
        TermBoxA.Visible = False
        TextTermA.BackColor = System.Drawing.Color.PaleTurquoise
        Dim theText As String = TextTermA.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextTermA.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextTermA.Text.Length - 1
            Letter = TextTermA.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextTermA.Text = theText
        TextTermA.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub TermBoxA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TermBoxA.SelectedIndexChanged
        If TermBoxA.SelectedIndex = 0 Then
            TextTermA.Text = "30"
        ElseIf TermBoxA.SelectedIndex = 1 Then
            TextTermA.Text = "20"
        ElseIf TermBoxA.SelectedIndex = 2 Then
            TextTermA.Text = "15"
        ElseIf TermBoxA.SelectedIndex = 3 Then
            TextTermA.Text = "10"
        End If
    End Sub

    Private Sub TextPayA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextPayA.TextChanged
        TextPayA.BackColor = System.Drawing.Color.PaleTurquoise
        Dim theText As String = TextPayA.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TextPayA.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TextPayA.Text.Length - 1
            Letter = TextPayA.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TextPayA.Text = theText
        TextPayA.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub CalculateA_Click(sender As Object, e As EventArgs) Handles CalculateA.Click
        TermBoxA.Visible = False
        InterestBoxA.Visible = False

        Dim salary As Double
        Dim bills As Double
        Dim interest As Double
        Dim term As Double
        Dim pay As Double
        Dim afford As Double
        Dim r As Double

        If TextSalary.Text = "" Then
            MessageBox.Show("Please Enter a Number for Monthly Salary.")
            TextSalary.BackColor = System.Drawing.Color.NavajoWhite
        ElseIf TextBills.Text = "" Then
            MessageBox.Show("Please Enter a Number for Monthly Bills.")
            TextBills.BackColor = System.Drawing.Color.NavajoWhite
        ElseIf TextInterestA.Text = "" Then
            MessageBox.Show("Please Enter a Number for Interest Rate.")
            TextInterestA.BackColor = System.Drawing.Color.NavajoWhite
        ElseIf TextTermA.Text = "" Then
            MessageBox.Show("Please Enter a Number for Term (in years).")
            TextTermA.BackColor = System.Drawing.Color.NavajoWhite
        ElseIf TextPayA.Text = "" Then
            MessageBox.Show("Please Enter a Number for Down Payment.")
            TextPayA.BackColor = System.Drawing.Color.NavajoWhite

        Else
            salary = Double.Parse(TextSalary.Text)
            bills = Double.Parse(TextBills.Text)
            interest = Double.Parse(TextInterestA.Text) / 100
            term = Double.Parse(TextTermA.Text)
            pay = Double.Parse(TextPayA.Text)
            afford = (((salary - bills) * term * 12) / (1 + (interest * term))) + pay
            afford = Decimal.Round(afford, 2, MidpointRounding.AwayFromZero)
            TextAfford.Text = afford.ToString()
            TextAfford.Visible = True
            AffordLabel.Visible = True
        End If
    End Sub

    Private Sub ClearA_Click(sender As Object, e As EventArgs) Handles ClearA.Click
        TermBoxA.Visible = False
        InterestBoxA.Visible = False

        TextSalary.BackColor = System.Drawing.Color.PaleTurquoise
        TextBills.BackColor = System.Drawing.Color.PaleTurquoise
        TextInterestA.BackColor = System.Drawing.Color.PaleTurquoise
        TextTermA.BackColor = System.Drawing.Color.PaleTurquoise
        TextPayA.BackColor = System.Drawing.Color.PaleTurquoise
        TextSalary.Text = ""
        TextBills.Text = ""
        TextInterestA.Text = ""
        TextTermA.Text = ""
        TextPayA.Text = ""
        TextMort.Text = ""
        If TextAfford.Visible Or AffordLabel.Visible Then
            TextAfford.Visible = False
            AffordLabel.Visible = False
        End If
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Me.Close()
    End Sub

End Class