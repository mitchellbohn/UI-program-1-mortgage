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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.TabMenu = New System.Windows.Forms.TabControl()
        Me.HomePage = New System.Windows.Forms.TabPage()
        Me.HomeTitle = New System.Windows.Forms.Label()
        Me.HomeMsg = New System.Windows.Forms.Label()
        Me.MortTab = New System.Windows.Forms.TabPage()
        Me.HowMuch = New System.Windows.Forms.TabPage()
        CType(Me.HouseIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMenu.SuspendLayout()
        Me.HomePage.SuspendLayout()
        Me.MortTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextPrice
        '
        Me.TextPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPrice.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextPrice.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextPrice.Location = New System.Drawing.Point(170, 18)
        Me.TextPrice.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextPrice.Name = "TextPrice"
        Me.TextPrice.Size = New System.Drawing.Size(377, 33)
        Me.TextPrice.TabIndex = 0
        '
        'TextPayment
        '
        Me.TextPayment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPayment.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextPayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextPayment.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextPayment.Location = New System.Drawing.Point(170, 52)
        Me.TextPayment.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextPayment.Name = "TextPayment"
        Me.TextPayment.Size = New System.Drawing.Size(377, 33)
        Me.TextPayment.TabIndex = 1
        '
        'TextInterest
        '
        Me.TextInterest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextInterest.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextInterest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextInterest.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextInterest.Location = New System.Drawing.Point(170, 86)
        Me.TextInterest.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextInterest.Name = "TextInterest"
        Me.TextInterest.Size = New System.Drawing.Size(377, 33)
        Me.TextInterest.TabIndex = 2
        '
        'TextTerm
        '
        Me.TextTerm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextTerm.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextTerm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextTerm.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextTerm.Location = New System.Drawing.Point(170, 120)
        Me.TextTerm.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextTerm.Name = "TextTerm"
        Me.TextTerm.Size = New System.Drawing.Size(377, 33)
        Me.TextTerm.TabIndex = 3
        '
        'Calculate
        '
        Me.Calculate.BackColor = System.Drawing.Color.Turquoise
        Me.Calculate.FlatAppearance.BorderSize = 0
        Me.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Calculate.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Calculate.Location = New System.Drawing.Point(170, 154)
        Me.Calculate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(124, 37)
        Me.Calculate.TabIndex = 8
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = False
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.Turquoise
        Me.Clear.FlatAppearance.BorderSize = 0
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Clear.Location = New System.Drawing.Point(170, 237)
        Me.Clear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(124, 37)
        Me.Clear.TabIndex = 9
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Quit
        '
        Me.Quit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Quit.BackColor = System.Drawing.Color.Gray
        Me.Quit.FlatAppearance.BorderSize = 0
        Me.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Quit.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Quit.Location = New System.Drawing.Point(427, 469)
        Me.Quit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(124, 37)
        Me.Quit.TabIndex = 10
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = False
        '
        'InterestRate
        '
        Me.InterestRate.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.InterestRate.ForeColor = System.Drawing.Color.Black
        Me.InterestRate.Location = New System.Drawing.Point(9, 86)
        Me.InterestRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InterestRate.Name = "InterestRate"
        Me.InterestRate.Size = New System.Drawing.Size(153, 22)
        Me.InterestRate.TabIndex = 6
        Me.InterestRate.Text = "Interest Rate"
        Me.InterestRate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HousePayment
        '
        Me.HousePayment.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.HousePayment.ForeColor = System.Drawing.Color.Black
        Me.HousePayment.Location = New System.Drawing.Point(9, 52)
        Me.HousePayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HousePayment.Name = "HousePayment"
        Me.HousePayment.Size = New System.Drawing.Size(153, 22)
        Me.HousePayment.TabIndex = 5
        Me.HousePayment.Text = "Down Payment"
        Me.HousePayment.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HousePrice
        '
        Me.HousePrice.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.HousePrice.ForeColor = System.Drawing.Color.Black
        Me.HousePrice.Location = New System.Drawing.Point(9, 18)
        Me.HousePrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HousePrice.Name = "HousePrice"
        Me.HousePrice.Size = New System.Drawing.Size(153, 22)
        Me.HousePrice.TabIndex = 4
        Me.HousePrice.Text = "House Price"
        Me.HousePrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Term
        '
        Me.Term.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Term.ForeColor = System.Drawing.Color.Black
        Me.Term.Location = New System.Drawing.Point(9, 120)
        Me.Term.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Term.Name = "Term"
        Me.Term.Size = New System.Drawing.Size(153, 22)
        Me.Term.TabIndex = 7
        Me.Term.Text = "Term (in years)"
        Me.Term.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MortLabel
        '
        Me.MortLabel.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.MortLabel.ForeColor = System.Drawing.Color.Black
        Me.MortLabel.Location = New System.Drawing.Point(9, 203)
        Me.MortLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MortLabel.Name = "MortLabel"
        Me.MortLabel.Size = New System.Drawing.Size(153, 22)
        Me.MortLabel.TabIndex = 11
        Me.MortLabel.Text = "Monthly Payment"
        Me.MortLabel.Visible = False
        '
        'TextMort
        '
        Me.TextMort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextMort.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextMort.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextMort.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextMort.Location = New System.Drawing.Point(170, 203)
        Me.TextMort.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextMort.Name = "TextMort"
        Me.TextMort.ReadOnly = True
        Me.TextMort.Size = New System.Drawing.Size(377, 33)
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
        Me.Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.BackColor = System.Drawing.Color.Turquoise
        Me.Title.Font = New System.Drawing.Font("Arial", 25.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Location = New System.Drawing.Point(83, 13)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(468, 64)
        Me.Title.TabIndex = 14
        Me.Title.Text = "Mitchell's Mortgage Calculator"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Turquoise
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(564, 90)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'TabMenu
        '
        Me.TabMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabMenu.Controls.Add(Me.HomePage)
        Me.TabMenu.Controls.Add(Me.MortTab)
        Me.TabMenu.Controls.Add(Me.HowMuch)
        Me.TabMenu.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TabMenu.Location = New System.Drawing.Point(0, 96)
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.SelectedIndex = 0
        Me.TabMenu.Size = New System.Drawing.Size(564, 364)
        Me.TabMenu.TabIndex = 16
        '
        'HomePage
        '
        Me.HomePage.BackColor = System.Drawing.Color.AntiqueWhite
        Me.HomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HomePage.Controls.Add(Me.HomeTitle)
        Me.HomePage.Controls.Add(Me.HomeMsg)
        Me.HomePage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HomePage.Location = New System.Drawing.Point(4, 41)
        Me.HomePage.Name = "HomePage"
        Me.HomePage.Padding = New System.Windows.Forms.Padding(3)
        Me.HomePage.Size = New System.Drawing.Size(556, 319)
        Me.HomePage.TabIndex = 1
        Me.HomePage.Text = "Home Page"
        '
        'HomeTitle
        '
        Me.HomeTitle.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.HomeTitle.Location = New System.Drawing.Point(0, 0)
        Me.HomeTitle.Name = "HomeTitle"
        Me.HomeTitle.Size = New System.Drawing.Size(556, 86)
        Me.HomeTitle.TabIndex = 1
        Me.HomeTitle.Text = "Amet aliquam"
        Me.HomeTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'HomeMsg
        '
        Me.HomeMsg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeMsg.AutoSize = True
        Me.HomeMsg.Location = New System.Drawing.Point(0, 86)
        Me.HomeMsg.MaximumSize = New System.Drawing.Size(512, 0)
        Me.HomeMsg.MinimumSize = New System.Drawing.Size(512, 0)
        Me.HomeMsg.Name = "HomeMsg"
        Me.HomeMsg.Size = New System.Drawing.Size(512, 160)
        Me.HomeMsg.TabIndex = 0
        Me.HomeMsg.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" &
    "cididunt ut labore et dolore magna aliqua. Varius morbi enim nunc faucibus."
        '
        'MortTab
        '
        Me.MortTab.BackColor = System.Drawing.Color.AntiqueWhite
        Me.MortTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MortTab.Controls.Add(Me.TextMort)
        Me.MortTab.Controls.Add(Me.TextPrice)
        Me.MortTab.Controls.Add(Me.TextPayment)
        Me.MortTab.Controls.Add(Me.Clear)
        Me.MortTab.Controls.Add(Me.Calculate)
        Me.MortTab.Controls.Add(Me.TextInterest)
        Me.MortTab.Controls.Add(Me.Term)
        Me.MortTab.Controls.Add(Me.TextTerm)
        Me.MortTab.Controls.Add(Me.InterestRate)
        Me.MortTab.Controls.Add(Me.HousePrice)
        Me.MortTab.Controls.Add(Me.HousePayment)
        Me.MortTab.Controls.Add(Me.MortLabel)
        Me.MortTab.Location = New System.Drawing.Point(4, 41)
        Me.MortTab.Name = "MortTab"
        Me.MortTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MortTab.Size = New System.Drawing.Size(556, 319)
        Me.MortTab.TabIndex = 0
        Me.MortTab.Text = "Mortgage Payment"
        '
        'HowMuch
        '
        Me.HowMuch.BackColor = System.Drawing.Color.AntiqueWhite
        Me.HowMuch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HowMuch.Cursor = System.Windows.Forms.Cursors.Default
        Me.HowMuch.Location = New System.Drawing.Point(4, 41)
        Me.HowMuch.Name = "HowMuch"
        Me.HowMuch.Size = New System.Drawing.Size(556, 319)
        Me.HowMuch.TabIndex = 2
        Me.HowMuch.Text = "How Much House Can I Afford?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(564, 521)
        Me.Controls.Add(Me.HouseIcon)
        Me.Controls.Add(Me.TabMenu)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(580, 560)
        Me.Name = "Form1"
        Me.Text = "Mitchell's Mortgage Manager"
        CType(Me.HouseIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMenu.ResumeLayout(False)
        Me.HomePage.ResumeLayout(False)
        Me.HomePage.PerformLayout()
        Me.MortTab.ResumeLayout(False)
        Me.MortTab.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents TabMenu As TabControl
    Friend WithEvents HomePage As TabPage
    Friend WithEvents MortTab As TabPage
    Friend WithEvents HowMuch As TabPage
    Friend WithEvents HomeMsg As Label
    Friend WithEvents HomeTitle As Label
End Class
