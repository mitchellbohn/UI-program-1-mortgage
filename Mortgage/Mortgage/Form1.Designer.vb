<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextPrice = New System.Windows.Forms.TextBox()
        Me.TextPay = New System.Windows.Forms.TextBox()
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
        Me.TopBanner = New System.Windows.Forms.PictureBox()
        Me.TabMenu = New System.Windows.Forms.TabControl()
        Me.HomePage = New System.Windows.Forms.TabPage()
        Me.HomeBar = New System.Windows.Forms.PictureBox()
        Me.HomeTitle = New System.Windows.Forms.Label()
        Me.HomeMsg = New System.Windows.Forms.Label()
        Me.MortTab = New System.Windows.Forms.TabPage()
        Me.TermBox = New System.Windows.Forms.ListBox()
        Me.InterestBox = New System.Windows.Forms.ListBox()
        Me.HowMuch = New System.Windows.Forms.TabPage()
        Me.TermBoxA = New System.Windows.Forms.ListBox()
        Me.InterestBoxA = New System.Windows.Forms.ListBox()
        Me.Adown = New System.Windows.Forms.Label()
        Me.TextPayA = New System.Windows.Forms.TextBox()
        Me.TextAfford = New System.Windows.Forms.TextBox()
        Me.TextSalary = New System.Windows.Forms.TextBox()
        Me.TextBills = New System.Windows.Forms.TextBox()
        Me.CalculateA = New System.Windows.Forms.Button()
        Me.ClearA = New System.Windows.Forms.Button()
        Me.TextInterestA = New System.Windows.Forms.TextBox()
        Me.Aterm = New System.Windows.Forms.Label()
        Me.TextTermA = New System.Windows.Forms.TextBox()
        Me.Ainterest = New System.Windows.Forms.Label()
        Me.Salary = New System.Windows.Forms.Label()
        Me.Bills = New System.Windows.Forms.Label()
        Me.AffordLabel = New System.Windows.Forms.Label()
        CType(Me.HouseIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMenu.SuspendLayout()
        Me.HomePage.SuspendLayout()
        CType(Me.HomeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MortTab.SuspendLayout()
        Me.HowMuch.SuspendLayout()
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
        Me.TextPrice.Size = New System.Drawing.Size(322, 22)
        Me.TextPrice.TabIndex = 0
        '
        'TextPay
        '
        Me.TextPay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPay.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextPay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextPay.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextPay.Location = New System.Drawing.Point(170, 52)
        Me.TextPay.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextPay.Name = "TextPay"
        Me.TextPay.Size = New System.Drawing.Size(322, 22)
        Me.TextPay.TabIndex = 1
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
        Me.TextInterest.Size = New System.Drawing.Size(322, 22)
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
        Me.TextTerm.Size = New System.Drawing.Size(322, 22)
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
        Me.Quit.Location = New System.Drawing.Point(372, 469)
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
        Me.TextMort.Size = New System.Drawing.Size(322, 22)
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
        Me.Title.Font = New System.Drawing.Font("Arial", 22.0!)
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.Location = New System.Drawing.Point(83, 13)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(413, 64)
        Me.Title.TabIndex = 14
        Me.Title.Text = "Mitchell's Mortgage Calculator"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TopBanner
        '
        Me.TopBanner.BackColor = System.Drawing.Color.Turquoise
        Me.TopBanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopBanner.Location = New System.Drawing.Point(0, 0)
        Me.TopBanner.Name = "TopBanner"
        Me.TopBanner.Size = New System.Drawing.Size(509, 90)
        Me.TopBanner.TabIndex = 15
        Me.TopBanner.TabStop = False
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
        Me.TabMenu.Size = New System.Drawing.Size(509, 364)
        Me.TabMenu.TabIndex = 16
        '
        'HomePage
        '
        Me.HomePage.BackColor = System.Drawing.Color.White
        Me.HomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HomePage.Controls.Add(Me.HomeBar)
        Me.HomePage.Controls.Add(Me.HomeTitle)
        Me.HomePage.Controls.Add(Me.HomeMsg)
        Me.HomePage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HomePage.Location = New System.Drawing.Point(4, 31)
        Me.HomePage.Name = "HomePage"
        Me.HomePage.Padding = New System.Windows.Forms.Padding(3)
        Me.HomePage.Size = New System.Drawing.Size(501, 329)
        Me.HomePage.TabIndex = 1
        Me.HomePage.Text = "Home Page"
        '
        'HomeBar
        '
        Me.HomeBar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.HomeBar.ErrorImage = Nothing
        Me.HomeBar.InitialImage = Nothing
        Me.HomeBar.Location = New System.Drawing.Point(4, 78)
        Me.HomeBar.Name = "HomeBar"
        Me.HomeBar.Size = New System.Drawing.Size(450, 5)
        Me.HomeBar.TabIndex = 2
        Me.HomeBar.TabStop = False
        '
        'HomeTitle
        '
        Me.HomeTitle.Font = New System.Drawing.Font("Arial", 24.0!)
        Me.HomeTitle.Location = New System.Drawing.Point(0, 0)
        Me.HomeTitle.Name = "HomeTitle"
        Me.HomeTitle.Size = New System.Drawing.Size(259, 86)
        Me.HomeTitle.TabIndex = 1
        Me.HomeTitle.Text = "Welcome!"
        Me.HomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HomeMsg
        '
        Me.HomeMsg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeMsg.AutoSize = True
        Me.HomeMsg.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.HomeMsg.Location = New System.Drawing.Point(5, 86)
        Me.HomeMsg.MaximumSize = New System.Drawing.Size(480, 200)
        Me.HomeMsg.MinimumSize = New System.Drawing.Size(480, 200)
        Me.HomeMsg.Name = "HomeMsg"
        Me.HomeMsg.Size = New System.Drawing.Size(480, 200)
        Me.HomeMsg.TabIndex = 0
        Me.HomeMsg.Text = resources.GetString("HomeMsg.Text")
        '
        'MortTab
        '
        Me.MortTab.BackColor = System.Drawing.Color.White
        Me.MortTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MortTab.Controls.Add(Me.TermBox)
        Me.MortTab.Controls.Add(Me.InterestBox)
        Me.MortTab.Controls.Add(Me.TextMort)
        Me.MortTab.Controls.Add(Me.TextPrice)
        Me.MortTab.Controls.Add(Me.TextPay)
        Me.MortTab.Controls.Add(Me.Clear)
        Me.MortTab.Controls.Add(Me.Calculate)
        Me.MortTab.Controls.Add(Me.TextInterest)
        Me.MortTab.Controls.Add(Me.Term)
        Me.MortTab.Controls.Add(Me.TextTerm)
        Me.MortTab.Controls.Add(Me.InterestRate)
        Me.MortTab.Controls.Add(Me.HousePrice)
        Me.MortTab.Controls.Add(Me.HousePayment)
        Me.MortTab.Controls.Add(Me.MortLabel)
        Me.MortTab.Location = New System.Drawing.Point(4, 31)
        Me.MortTab.Name = "MortTab"
        Me.MortTab.Padding = New System.Windows.Forms.Padding(3)
        Me.MortTab.Size = New System.Drawing.Size(501, 329)
        Me.MortTab.TabIndex = 0
        Me.MortTab.Text = "Mortgage Payment"
        '
        'TermBox
        '
        Me.TermBox.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TermBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TermBox.FormattingEnabled = True
        Me.TermBox.ItemHeight = 22
        Me.TermBox.Items.AddRange(New Object() {"30 years", "20 years", "15 years", "10 years"})
        Me.TermBox.Location = New System.Drawing.Point(170, 140)
        Me.TermBox.Name = "TermBox"
        Me.TermBox.Size = New System.Drawing.Size(120, 90)
        Me.TermBox.TabIndex = 14
        Me.TermBox.Visible = False
        '
        'InterestBox
        '
        Me.InterestBox.BackColor = System.Drawing.Color.PaleTurquoise
        Me.InterestBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InterestBox.FormattingEnabled = True
        Me.InterestBox.ItemHeight = 22
        Me.InterestBox.Items.AddRange(New Object() {"3.5%", "3.75%", "4%", "4.25%", "4.5%"})
        Me.InterestBox.Location = New System.Drawing.Point(170, 108)
        Me.InterestBox.Name = "InterestBox"
        Me.InterestBox.Size = New System.Drawing.Size(120, 90)
        Me.InterestBox.TabIndex = 13
        Me.InterestBox.Visible = False
        '
        'HowMuch
        '
        Me.HowMuch.BackColor = System.Drawing.Color.White
        Me.HowMuch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HowMuch.Controls.Add(Me.TermBoxA)
        Me.HowMuch.Controls.Add(Me.InterestBoxA)
        Me.HowMuch.Controls.Add(Me.Adown)
        Me.HowMuch.Controls.Add(Me.TextPayA)
        Me.HowMuch.Controls.Add(Me.TextAfford)
        Me.HowMuch.Controls.Add(Me.TextSalary)
        Me.HowMuch.Controls.Add(Me.TextBills)
        Me.HowMuch.Controls.Add(Me.CalculateA)
        Me.HowMuch.Controls.Add(Me.ClearA)
        Me.HowMuch.Controls.Add(Me.TextInterestA)
        Me.HowMuch.Controls.Add(Me.Aterm)
        Me.HowMuch.Controls.Add(Me.TextTermA)
        Me.HowMuch.Controls.Add(Me.Ainterest)
        Me.HowMuch.Controls.Add(Me.Salary)
        Me.HowMuch.Controls.Add(Me.Bills)
        Me.HowMuch.Controls.Add(Me.AffordLabel)
        Me.HowMuch.Cursor = System.Windows.Forms.Cursors.Default
        Me.HowMuch.Location = New System.Drawing.Point(4, 31)
        Me.HowMuch.Name = "HowMuch"
        Me.HowMuch.Size = New System.Drawing.Size(501, 329)
        Me.HowMuch.TabIndex = 2
        Me.HowMuch.Text = "How Much Can I Afford?"
        '
        'TermBoxA
        '
        Me.TermBoxA.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TermBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TermBoxA.FormattingEnabled = True
        Me.TermBoxA.ItemHeight = 22
        Me.TermBoxA.Items.AddRange(New Object() {"30 years", "20 years", "15 years", "10 years"})
        Me.TermBoxA.Location = New System.Drawing.Point(170, 140)
        Me.TermBoxA.Name = "TermBoxA"
        Me.TermBoxA.Size = New System.Drawing.Size(120, 90)
        Me.TermBoxA.TabIndex = 26
        Me.TermBoxA.Visible = False
        '
        'InterestBoxA
        '
        Me.InterestBoxA.BackColor = System.Drawing.Color.PaleTurquoise
        Me.InterestBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InterestBoxA.FormattingEnabled = True
        Me.InterestBoxA.ItemHeight = 22
        Me.InterestBoxA.Items.AddRange(New Object() {"3.5%", "3.75%", "4%", "4.25%", "4.5%"})
        Me.InterestBoxA.Location = New System.Drawing.Point(170, 108)
        Me.InterestBoxA.Name = "InterestBoxA"
        Me.InterestBoxA.Size = New System.Drawing.Size(120, 90)
        Me.InterestBoxA.TabIndex = 25
        Me.InterestBoxA.Visible = False
        '
        'Adown
        '
        Me.Adown.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Adown.ForeColor = System.Drawing.Color.Black
        Me.Adown.Location = New System.Drawing.Point(9, 154)
        Me.Adown.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Adown.Name = "Adown"
        Me.Adown.Size = New System.Drawing.Size(153, 22)
        Me.Adown.TabIndex = 28
        Me.Adown.Text = "Down Payment"
        Me.Adown.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextPayA
        '
        Me.TextPayA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextPayA.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextPayA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextPayA.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextPayA.Location = New System.Drawing.Point(170, 154)
        Me.TextPayA.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextPayA.Name = "TextPayA"
        Me.TextPayA.Size = New System.Drawing.Size(322, 22)
        Me.TextPayA.TabIndex = 27
        '
        'TextAfford
        '
        Me.TextAfford.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextAfford.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextAfford.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextAfford.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextAfford.Location = New System.Drawing.Point(170, 237)
        Me.TextAfford.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextAfford.Name = "TextAfford"
        Me.TextAfford.ReadOnly = True
        Me.TextAfford.Size = New System.Drawing.Size(322, 22)
        Me.TextAfford.TabIndex = 24
        Me.TextAfford.Visible = False
        '
        'TextSalary
        '
        Me.TextSalary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextSalary.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextSalary.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextSalary.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextSalary.Location = New System.Drawing.Point(170, 18)
        Me.TextSalary.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextSalary.Name = "TextSalary"
        Me.TextSalary.Size = New System.Drawing.Size(322, 22)
        Me.TextSalary.TabIndex = 13
        '
        'TextBills
        '
        Me.TextBills.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBills.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBills.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBills.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextBills.Location = New System.Drawing.Point(170, 52)
        Me.TextBills.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextBills.Name = "TextBills"
        Me.TextBills.Size = New System.Drawing.Size(322, 22)
        Me.TextBills.TabIndex = 14
        '
        'CalculateA
        '
        Me.CalculateA.BackColor = System.Drawing.Color.Turquoise
        Me.CalculateA.FlatAppearance.BorderSize = 0
        Me.CalculateA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CalculateA.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.CalculateA.Location = New System.Drawing.Point(170, 188)
        Me.CalculateA.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.CalculateA.Name = "CalculateA"
        Me.CalculateA.Size = New System.Drawing.Size(124, 37)
        Me.CalculateA.TabIndex = 22
        Me.CalculateA.Text = "Calculate"
        Me.CalculateA.UseVisualStyleBackColor = False
        '
        'ClearA
        '
        Me.ClearA.BackColor = System.Drawing.Color.Turquoise
        Me.ClearA.FlatAppearance.BorderSize = 0
        Me.ClearA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearA.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.ClearA.Location = New System.Drawing.Point(170, 271)
        Me.ClearA.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ClearA.Name = "ClearA"
        Me.ClearA.Size = New System.Drawing.Size(124, 37)
        Me.ClearA.TabIndex = 21
        Me.ClearA.Text = "Clear"
        Me.ClearA.UseVisualStyleBackColor = False
        '
        'TextInterestA
        '
        Me.TextInterestA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextInterestA.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextInterestA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextInterestA.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextInterestA.Location = New System.Drawing.Point(170, 86)
        Me.TextInterestA.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextInterestA.Name = "TextInterestA"
        Me.TextInterestA.Size = New System.Drawing.Size(322, 22)
        Me.TextInterestA.TabIndex = 15
        '
        'Aterm
        '
        Me.Aterm.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Aterm.ForeColor = System.Drawing.Color.Black
        Me.Aterm.Location = New System.Drawing.Point(9, 120)
        Me.Aterm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Aterm.Name = "Aterm"
        Me.Aterm.Size = New System.Drawing.Size(153, 22)
        Me.Aterm.TabIndex = 20
        Me.Aterm.Text = "Term (in years)"
        Me.Aterm.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextTermA
        '
        Me.TextTermA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextTermA.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextTermA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextTermA.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.TextTermA.Location = New System.Drawing.Point(170, 120)
        Me.TextTermA.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TextTermA.Name = "TextTermA"
        Me.TextTermA.Size = New System.Drawing.Size(322, 22)
        Me.TextTermA.TabIndex = 16
        '
        'Ainterest
        '
        Me.Ainterest.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Ainterest.ForeColor = System.Drawing.Color.Black
        Me.Ainterest.Location = New System.Drawing.Point(9, 86)
        Me.Ainterest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ainterest.Name = "Ainterest"
        Me.Ainterest.Size = New System.Drawing.Size(153, 22)
        Me.Ainterest.TabIndex = 19
        Me.Ainterest.Text = "Interest Rate"
        Me.Ainterest.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Salary
        '
        Me.Salary.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Salary.ForeColor = System.Drawing.Color.Black
        Me.Salary.Location = New System.Drawing.Point(9, 18)
        Me.Salary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(153, 22)
        Me.Salary.TabIndex = 17
        Me.Salary.Text = "Monthly Salary"
        Me.Salary.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Bills
        '
        Me.Bills.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.Bills.ForeColor = System.Drawing.Color.Black
        Me.Bills.Location = New System.Drawing.Point(9, 52)
        Me.Bills.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Bills.Name = "Bills"
        Me.Bills.Size = New System.Drawing.Size(153, 22)
        Me.Bills.TabIndex = 18
        Me.Bills.Text = "Monthly Bills"
        Me.Bills.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AffordLabel
        '
        Me.AffordLabel.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.AffordLabel.ForeColor = System.Drawing.Color.Black
        Me.AffordLabel.Location = New System.Drawing.Point(9, 237)
        Me.AffordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AffordLabel.Name = "AffordLabel"
        Me.AffordLabel.Size = New System.Drawing.Size(153, 22)
        Me.AffordLabel.TabIndex = 23
        Me.AffordLabel.Text = "Affordable Price"
        Me.AffordLabel.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(509, 521)
        Me.Controls.Add(Me.TabMenu)
        Me.Controls.Add(Me.HouseIcon)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.TopBanner)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(525, 560)
        Me.Name = "Form1"
        Me.Text = "Mitchell's Mortgage Manager"
        CType(Me.HouseIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMenu.ResumeLayout(False)
        Me.HomePage.ResumeLayout(False)
        Me.HomePage.PerformLayout()
        CType(Me.HomeBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MortTab.ResumeLayout(False)
        Me.MortTab.PerformLayout()
        Me.HowMuch.ResumeLayout(False)
        Me.HowMuch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextPrice As TextBox
    Friend WithEvents TextPay As TextBox
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
    Friend WithEvents TopBanner As PictureBox
    Friend WithEvents TabMenu As TabControl
    Friend WithEvents HomePage As TabPage
    Friend WithEvents MortTab As TabPage
    Friend WithEvents HowMuch As TabPage
    Friend WithEvents HomeMsg As Label
    Friend WithEvents HomeTitle As Label
    Friend WithEvents HomeBar As PictureBox
    Friend WithEvents InterestBox As ListBox
    Friend WithEvents TextAfford As TextBox
    Friend WithEvents TextSalary As TextBox
    Friend WithEvents TextBills As TextBox
    Friend WithEvents CalculateA As Button
    Friend WithEvents ClearA As Button
    Friend WithEvents TextInterestA As TextBox
    Friend WithEvents Aterm As Label
    Friend WithEvents TextTermA As TextBox
    Friend WithEvents Ainterest As Label
    Friend WithEvents Salary As Label
    Friend WithEvents Bills As Label
    Friend WithEvents AffordLabel As Label
    Friend WithEvents TermBox As ListBox
    Friend WithEvents InterestBoxA As ListBox
    Friend WithEvents TermBoxA As ListBox
    Friend WithEvents Adown As Label
    Friend WithEvents TextPayA As TextBox
End Class
