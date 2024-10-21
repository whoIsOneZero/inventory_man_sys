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
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        GroupBox1 = New GroupBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        btnExit = New Button()
        BtnReset = New Button()
        btnLogin = New Button()
        lblPassword = New Label()
        lblUsername = New Label()
        lblTitle = New Label()
        TabControl1.SuspendLayout()
        GroupBox1.SuspendLayout()
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
        TabPage1.Location = New Point(4, 39)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1288, 585)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Customer Details"
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
        GroupBox1.Location = New Point(12, 12)
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
        txtPassword.Size = New Size(260, 23)
        txtPassword.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(248, 139)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(260, 23)
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
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(185, 142)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 48.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(4, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(982, 86)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Inventory Management System"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1352, 661)
        Controls.Add(GroupBox1)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "password" Then
            GroupBox1.Visible = False
        Else
            MessageBox.Show("You have entered incorrect login details", "Closing Exams",
                            MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Closing Exams",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Sub
End Class
