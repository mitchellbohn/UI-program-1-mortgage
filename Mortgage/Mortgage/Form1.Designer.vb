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
        Me.TextMort = New System.Windows.Forms.TextBox()
        Me.HouseIcon = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.HouseIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextPrice
        '
        Me.TextPrice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextPrice.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextPrice.Location = New System.Drawing.Point(138, 130)
        Me.TextPrice.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextPrice.Name = "TextPrice"
        Me.TextPrice.Size = New System.Drawing.Size(307, 21)
        Me.TextPrice.TabIndex = 0
        '
        'TextPayment
        '
        Me.TextPayment.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextPayment.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextPayment.Location = New System.Drawing.Point(138, 174)
        Me.TextPayment.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextPayment.Name = "TextPayment"
        Me.TextPayment.Size = New System.Drawing.Size(307, 21)
        Me.TextPayment.TabIndex = 1
        '
        'TextInterest
        '
        Me.TextInterest.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextInterest.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextInterest.Location = New System.Drawing.Point(138, 217)
        Me.TextInterest.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextInterest.Name = "TextInterest"
        Me.TextInterest.Size = New System.Drawing.Size(307, 21)
        Me.TextInterest.TabIndex = 2
        '
        'TextTerm
        '
        Me.TextTerm.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextTerm.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextTerm.Location = New System.Drawing.Point(138, 262)
        Me.TextTerm.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextTerm.Name = "TextTerm"
        Me.TextTerm.Size = New System.Drawing.Size(307, 21)
        Me.TextTerm.TabIndex = 3
        '
        'Calculate
        '
        Me.Calculate.BackColor = System.Drawing.Color.PaleGreen
        Me.Calculate.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculate.Location = New System.Drawing.Point(138, 295)
        Me.Calculate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(124, 37)
        Me.Calculate.TabIndex = 8
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = False
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Clear.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(12, 532)
        Me.Clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(124, 37)
        Me.Clear.TabIndex = 9
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.Pink
        Me.Quit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.Location = New System.Drawing.Point(321, 532)
        Me.Quit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(124, 37)
        Me.Quit.TabIndex = 10
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = False
        '
        'InterestRate
        '
        Me.InterestRate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InterestRate.ForeColor = System.Drawing.SystemColors.Control
        Me.InterestRate.Location = New System.Drawing.Point(13, 217)
        Me.InterestRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InterestRate.Name = "InterestRate"
        Me.InterestRate.Size = New System.Drawing.Size(117, 27)
        Me.InterestRate.TabIndex = 6
        Me.InterestRate.Text = "Interest Rate"
        Me.InterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HousePayment
        '
        Me.HousePayment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HousePayment.ForeColor = System.Drawing.SystemColors.Control
        Me.HousePayment.Location = New System.Drawing.Point(13, 174)
        Me.HousePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HousePayment.Name = "HousePayment"
        Me.HousePayment.Size = New System.Drawing.Size(117, 27)
        Me.HousePayment.TabIndex = 5
        Me.HousePayment.Text = "Down Payment"
        Me.HousePayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HousePrice
        '
        Me.HousePrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HousePrice.ForeColor = System.Drawing.SystemColors.Control
        Me.HousePrice.Location = New System.Drawing.Point(13, 130)
        Me.HousePrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HousePrice.Name = "HousePrice"
        Me.HousePrice.Size = New System.Drawing.Size(117, 27)
        Me.HousePrice.TabIndex = 4
        Me.HousePrice.Text = "House Price"
        Me.HousePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Term
        '
        Me.Term.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Term.ForeColor = System.Drawing.SystemColors.Control
        Me.Term.Location = New System.Drawing.Point(13, 261)
        Me.Term.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Term.Name = "Term"
        Me.Term.Size = New System.Drawing.Size(117, 27)
        Me.Term.TabIndex = 7
        Me.Term.Text = "Term (in years)"
        Me.Term.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MortLabel
        '
        Me.MortLabel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MortLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.MortLabel.Location = New System.Drawing.Point(13, 403)
        Me.MortLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MortLabel.Name = "MortLabel"
        Me.MortLabel.Size = New System.Drawing.Size(132, 42)
        Me.MortLabel.TabIndex = 11
        Me.MortLabel.Text = "Mortgage Payment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(in months)"
        Me.MortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MortLabel.Visible = False
        '
        'TextMort
        '
        Me.TextMort.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextMort.Location = New System.Drawing.Point(153, 414)
        Me.TextMort.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextMort.Name = "TextMort"
        Me.TextMort.Size = New System.Drawing.Size(292, 21)
        Me.TextMort.TabIndex = 12
        Me.TextMort.Visible = False
        '
        'HouseIcon
        '
        Me.HouseIcon.BackColor = System.Drawing.Color.Turquoise
        Me.HouseIcon.Image = Global.Mortgage.My.Resources.Resources.house
        Me.HouseIcon.Location = New System.Drawing.Point(13, 13)
        Me.HouseIcon.Name = "HouseIcon"
        Me.HouseIcon.Size = New System.Drawing.Size(64, 64)
        Me.HouseIcon.TabIndex = 13
        Me.HouseIcon.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Turquoise
        Me.Title.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Location = New System.Drawing.Point(83, 31)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(250, 21)
        Me.Title.TabIndex = 14
        Me.Title.Text = "Mitchell's Mortgage Calculator"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Turquoise
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(458, 90)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(458, 584)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.HouseIcon)
        Me.Controls.Add(Me.TextMort)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Form1"
        Me.Text = "Mitchell's Mortgage Manager"
        CType(Me.HouseIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextMort As TextBox
    Friend WithEvents HouseIcon As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
