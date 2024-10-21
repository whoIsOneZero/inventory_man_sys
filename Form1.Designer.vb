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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cmbAcc_Status = New ComboBox()
        btnEnd = New Button()
        btnDelete = New Button()
        btnPrevious = New Button()
        btnNext = New Button()
        btnSave = New Button()
        btnAdd = New Button()
        GroupBox1 = New GroupBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        btnExit = New Button()
        BtnReset = New Button()
        btnLogin = New Button()
        lblPassword = New Label()
        lblUsername = New Label()
        lblTitle = New Label()
        txtEmail = New TextBox()
        txtFax = New TextBox()
        txtTelephone = New TextBox()
        txtwww = New TextBox()
        txtMobile = New TextBox()
        txtPostCode = New TextBox()
        txtAddress = New TextBox()
        txtBalance = New TextBox()
        txtName = New TextBox()
        txtVatNum = New TextBox()
        txtContactName = New TextBox()
        txtAccountNum = New TextBox()
        lblAccStatus = New Label()
        lblwww = New Label()
        lblEmail = New Label()
        lblFax = New Label()
        lblTelephone = New Label()
        lblMobile = New Label()
        lblBalance = New Label()
        lblVATNum = New Label()
        lblContactName = New Label()
        lblPostCode = New Label()
        lblAddress = New Label()
        lblName = New Label()
        lblAccountNum = New Label()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        DataGridView1 = New DataGridView()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(44, 21)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1296, 628)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = SystemColors.Control
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Controls.Add(cmbAcc_Status)
        TabPage1.Controls.Add(btnEnd)
        TabPage1.Controls.Add(btnDelete)
        TabPage1.Controls.Add(btnPrevious)
        TabPage1.Controls.Add(btnNext)
        TabPage1.Controls.Add(btnSave)
        TabPage1.Controls.Add(btnAdd)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(txtEmail)
        TabPage1.Controls.Add(txtFax)
        TabPage1.Controls.Add(txtTelephone)
        TabPage1.Controls.Add(txtwww)
        TabPage1.Controls.Add(txtMobile)
        TabPage1.Controls.Add(txtPostCode)
        TabPage1.Controls.Add(txtAddress)
        TabPage1.Controls.Add(txtBalance)
        TabPage1.Controls.Add(txtName)
        TabPage1.Controls.Add(txtVatNum)
        TabPage1.Controls.Add(txtContactName)
        TabPage1.Controls.Add(txtAccountNum)
        TabPage1.Controls.Add(lblAccStatus)
        TabPage1.Controls.Add(lblwww)
        TabPage1.Controls.Add(lblEmail)
        TabPage1.Controls.Add(lblFax)
        TabPage1.Controls.Add(lblTelephone)
        TabPage1.Controls.Add(lblMobile)
        TabPage1.Controls.Add(lblBalance)
        TabPage1.Controls.Add(lblVATNum)
        TabPage1.Controls.Add(lblContactName)
        TabPage1.Controls.Add(lblPostCode)
        TabPage1.Controls.Add(lblAddress)
        TabPage1.Controls.Add(lblName)
        TabPage1.Controls.Add(lblAccountNum)
        TabPage1.Location = New Point(4, 39)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1288, 585)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Customer Details"
        ' 
        ' cmbAcc_Status
        ' 
        cmbAcc_Status.FormattingEnabled = True
        cmbAcc_Status.Location = New Point(713, 311)
        cmbAcc_Status.Name = "cmbAcc_Status"
        cmbAcc_Status.Size = New Size(276, 38)
        cmbAcc_Status.TabIndex = 36
        ' 
        ' btnEnd
        ' 
        btnEnd.Location = New Point(1062, 311)
        btnEnd.Name = "btnEnd"
        btnEnd.Size = New Size(137, 36)
        btnEnd.TabIndex = 34
        btnEnd.Text = "End"
        btnEnd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(1062, 247)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(137, 36)
        btnDelete.TabIndex = 33
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(1062, 190)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(137, 36)
        btnPrevious.TabIndex = 32
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(1062, 129)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(137, 36)
        btnNext.TabIndex = 31
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(1062, 77)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(137, 36)
        btnSave.TabIndex = 30
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(1062, 27)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(137, 36)
        btnAdd.TabIndex = 29
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtPassword)
        GroupBox1.Controls.Add(txtUsername)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(BtnReset)
        GroupBox1.Controls.Add(btnLogin)
        GroupBox1.Controls.Add(lblPassword)
        GroupBox1.Controls.Add(lblUsername)
        GroupBox1.Controls.Add(lblTitle)
        GroupBox1.Location = New Point(3, 545)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1321, 633)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(248, 207)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(260, 35)
        txtPassword.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(248, 139)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(260, 35)
        txtUsername.TabIndex = 6
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(433, 274)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Location = New Point(317, 274)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(75, 23)
        BtnReset.TabIndex = 4
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(194, 274)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(185, 215)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(105, 30)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(185, 142)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(110, 30)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(6, 19)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(982, 86)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Inventory Management System"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(713, 190)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(276, 35)
        txtEmail.TabIndex = 28
        ' 
        ' txtFax
        ' 
        txtFax.Location = New Point(713, 127)
        txtFax.Name = "txtFax"
        txtFax.Size = New Size(276, 35)
        txtFax.TabIndex = 27
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Location = New Point(713, 78)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(276, 35)
        txtTelephone.TabIndex = 25
        ' 
        ' txtwww
        ' 
        txtwww.Location = New Point(713, 247)
        txtwww.Name = "txtwww"
        txtwww.Size = New Size(276, 35)
        txtwww.TabIndex = 23
        ' 
        ' txtMobile
        ' 
        txtMobile.Location = New Point(713, 28)
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(276, 35)
        txtMobile.TabIndex = 22
        ' 
        ' txtPostCode
        ' 
        txtPostCode.Location = New Point(179, 280)
        txtPostCode.Name = "txtPostCode"
        txtPostCode.Size = New Size(323, 35)
        txtPostCode.TabIndex = 21
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(179, 127)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(323, 122)
        txtAddress.TabIndex = 20
        ' 
        ' txtBalance
        ' 
        txtBalance.Location = New Point(179, 456)
        txtBalance.Name = "txtBalance"
        txtBalance.Size = New Size(323, 35)
        txtBalance.TabIndex = 19
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(179, 78)
        txtName.Name = "txtName"
        txtName.Size = New Size(323, 35)
        txtName.TabIndex = 18
        ' 
        ' txtVatNum
        ' 
        txtVatNum.Location = New Point(179, 401)
        txtVatNum.Name = "txtVatNum"
        txtVatNum.Size = New Size(323, 35)
        txtVatNum.TabIndex = 17
        ' 
        ' txtContactName
        ' 
        txtContactName.Location = New Point(179, 337)
        txtContactName.Name = "txtContactName"
        txtContactName.Size = New Size(323, 35)
        txtContactName.TabIndex = 16
        ' 
        ' txtAccountNum
        ' 
        txtAccountNum.Location = New Point(179, 28)
        txtAccountNum.Name = "txtAccountNum"
        txtAccountNum.Size = New Size(323, 35)
        txtAccountNum.TabIndex = 15
        ' 
        ' lblAccStatus
        ' 
        lblAccStatus.AutoSize = True
        lblAccStatus.Location = New Point(568, 311)
        lblAccStatus.Name = "lblAccStatus"
        lblAccStatus.Size = New Size(120, 30)
        lblAccStatus.TabIndex = 13
        lblAccStatus.Text = "Acc. Status"
        ' 
        ' lblwww
        ' 
        lblwww.AutoSize = True
        lblwww.Location = New Point(568, 247)
        lblwww.Name = "lblwww"
        lblwww.Size = New Size(64, 30)
        lblwww.TabIndex = 12
        lblwww.Text = "www"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(568, 190)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(66, 30)
        lblEmail.TabIndex = 11
        lblEmail.Text = "Email"
        ' 
        ' lblFax
        ' 
        lblFax.AutoSize = True
        lblFax.Location = New Point(568, 132)
        lblFax.Name = "lblFax"
        lblFax.Size = New Size(46, 30)
        lblFax.TabIndex = 10
        lblFax.Text = "Fax"
        ' 
        ' lblTelephone
        ' 
        lblTelephone.AutoSize = True
        lblTelephone.Location = New Point(568, 78)
        lblTelephone.Name = "lblTelephone"
        lblTelephone.Size = New Size(114, 30)
        lblTelephone.TabIndex = 9
        lblTelephone.Text = "Telephone"
        ' 
        ' lblMobile
        ' 
        lblMobile.AutoSize = True
        lblMobile.Location = New Point(568, 25)
        lblMobile.Name = "lblMobile"
        lblMobile.Size = New Size(82, 30)
        lblMobile.TabIndex = 8
        lblMobile.Text = "Mobile"
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Location = New Point(22, 459)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(88, 30)
        lblBalance.TabIndex = 7
        lblBalance.Text = "Balance"
        ' 
        ' lblVATNum
        ' 
        lblVATNum.AutoSize = True
        lblVATNum.Location = New Point(22, 401)
        lblVATNum.Name = "lblVATNum"
        lblVATNum.Size = New Size(139, 30)
        lblVATNum.TabIndex = 6
        lblVATNum.Text = "VAT Number"
        ' 
        ' lblContactName
        ' 
        lblContactName.AutoSize = True
        lblContactName.Location = New Point(22, 337)
        lblContactName.Name = "lblContactName"
        lblContactName.Size = New Size(153, 30)
        lblContactName.TabIndex = 5
        lblContactName.Text = "Contact Name"
        ' 
        ' lblPostCode
        ' 
        lblPostCode.AutoSize = True
        lblPostCode.Location = New Point(22, 280)
        lblPostCode.Name = "lblPostCode"
        lblPostCode.Size = New Size(111, 30)
        lblPostCode.TabIndex = 4
        lblPostCode.Text = "Post Code"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Location = New Point(22, 132)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(91, 30)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Address"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(22, 78)
        lblName.Name = "lblName"
        lblName.Size = New Size(71, 30)
        lblName.TabIndex = 2
        lblName.Text = "Name"
        ' 
        ' lblAccountNum
        ' 
        lblAccountNum.AutoSize = True
        lblAccountNum.Location = New Point(22, 25)
        lblAccountNum.Name = "lblAccountNum"
        lblAccountNum.Size = New Size(50, 30)
        lblAccountNum.TabIndex = 1
        lblAccountNum.Text = "A/C"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = SystemColors.Control
        TabPage2.Location = New Point(4, 39)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1288, 585)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Default Settings"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = SystemColors.Control
        TabPage3.Location = New Point(4, 39)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1288, 585)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Credit Control"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(568, 376)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(714, 174)
        DataGridView1.TabIndex = 37
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1352, 661)
        Controls.Add(TabControl1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox

    Friend WithEvents lblBalance As Label
    Friend WithEvents lblVATNum As Label
    Friend WithEvents lblContactName As Label
    Friend WithEvents lblPostCode As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAccountNum As Label
    Friend WithEvents lblAccStatus As Label
    Friend WithEvents lblwww As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblFax As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblMobile As Label
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtVatNum As TextBox
    Friend WithEvents txtContactName As TextBox
    Friend WithEvents txtAccountNum As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtwww As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents cmbAcc_Status As ComboBox

    Friend WithEvents btnEnd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "password" Then
            GroupBox1.Visible = False
        Else
            MessageBox.Show("You have entered incorrect login details", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtPassword.Clear()
            txtUsername.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Message",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Message",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Friend WithEvents DataGridView1 As DataGridView

End Class
