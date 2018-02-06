<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextPrice = New System.Windows.Forms.TextBox()
        Me.TextPayment = New System.Windows.Forms.TextBox()
        Me.TextInterest = New System.Windows.Forms.TextBox()
        Me.TextTerm = New System.Windows.Forms.TextBox()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.InterestRate = New System.Windows.Forms.Label()
        Me.HousePayment = New System.Windows.Forms.Label()
        Me.HousePrice = New System.Windows.Forms.Label()
        Me.Term = New System.Windows.Forms.Label()
        Me.MortLabel = New System.Windows.Forms.Label()
        Me.Mortgage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextPrice
        '
        Me.TextPrice.Location = New System.Drawing.Point(114, 13)
        Me.TextPrice.Name = "TextPrice"
        Me.TextPrice.Size = New System.Drawing.Size(158, 20)
        Me.TextPrice.TabIndex = 0
        '
        'TextPayment
        '
        Me.TextPayment.Location = New System.Drawing.Point(114, 40)
        Me.TextPayment.Name = "TextPayment"
        Me.TextPayment.Size = New System.Drawing.Size(158, 20)
        Me.TextPayment.TabIndex = 1
        '
        'TextInterest
        '
        Me.TextInterest.Location = New System.Drawing.Point(114, 67)
        Me.TextInterest.Name = "TextInterest"
        Me.TextInterest.Size = New System.Drawing.Size(158, 20)
        Me.TextInterest.TabIndex = 2
        '
        'TextTerm
        '
        Me.TextTerm.Location = New System.Drawing.Point(114, 94)
        Me.TextTerm.Name = "TextTerm"
        Me.TextTerm.Size = New System.Drawing.Size(158, 20)
        Me.TextTerm.TabIndex = 3
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(114, 120)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(75, 23)
        Me.Calculate.TabIndex = 8
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(12, 226)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 9
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(197, 226)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(75, 23)
        Me.Quit.TabIndex = 10
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'InterestRate
        '
        Me.InterestRate.AutoSize = True
        Me.InterestRate.Location = New System.Drawing.Point(40, 67)
        Me.InterestRate.Name = "InterestRate"
        Me.InterestRate.Size = New System.Drawing.Size(68, 13)
        Me.InterestRate.TabIndex = 6
        Me.InterestRate.Text = "Interest Rate"
        '
        'HousePayment
        '
        Me.HousePayment.AutoSize = True
        Me.HousePayment.Location = New System.Drawing.Point(26, 40)
        Me.HousePayment.Name = "HousePayment"
        Me.HousePayment.Size = New System.Drawing.Size(82, 13)
        Me.HousePayment.TabIndex = 5
        Me.HousePayment.Text = "House Payment"
        '
        'HousePrice
        '
        Me.HousePrice.AutoSize = True
        Me.HousePrice.Location = New System.Drawing.Point(43, 13)
        Me.HousePrice.Name = "HousePrice"
        Me.HousePrice.Size = New System.Drawing.Size(65, 13)
        Me.HousePrice.TabIndex = 4
        Me.HousePrice.Text = "House Price"
        '
        'Term
        '
        Me.Term.AutoSize = True
        Me.Term.Location = New System.Drawing.Point(59, 94)
        Me.Term.Name = "Term"
        Me.Term.Size = New System.Drawing.Size(49, 26)
        Me.Term.TabIndex = 7
        Me.Term.Text = "Term" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(in years)"
        '
        'MortLabel
        '
        Me.MortLabel.AutoSize = True
        Me.MortLabel.Location = New System.Drawing.Point(12, 149)
        Me.MortLabel.Name = "MortLabel"
        Me.MortLabel.Size = New System.Drawing.Size(96, 26)
        Me.MortLabel.TabIndex = 11
        Me.MortLabel.Text = "Mortgage Payment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(in months)"
        '
        'Mortgage
        '
        Me.Mortgage.Location = New System.Drawing.Point(114, 149)
        Me.Mortgage.Name = "Mortgage"
        Me.Mortgage.Size = New System.Drawing.Size(158, 20)
        Me.Mortgage.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Mortgage)
        Me.Controls.Add(Me.MortLabel)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.Term)
        Me.Controls.Add(Me.InterestRate)
        Me.Controls.Add(Me.HousePayment)
        Me.Controls.Add(Me.HousePrice)
        Me.Controls.Add(Me.TextTerm)
        Me.Controls.Add(Me.TextInterest)
        Me.Controls.Add(Me.TextPayment)
        Me.Controls.Add(Me.TextPrice)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextPrice As TextBox
    Friend WithEvents TextPayment As TextBox
    Friend WithEvents TextInterest As TextBox
    Friend WithEvents TextTerm As TextBox
    Friend WithEvents Calculate As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Quit As Button
    Friend WithEvents InterestRate As Label
    Friend WithEvents HousePayment As Label
    Friend WithEvents HousePrice As Label
    Friend WithEvents Term As Label
    Friend WithEvents MortLabel As Label
    Friend WithEvents Mortgage As TextBox
End Class
