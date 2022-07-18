<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TextPassWord = New System.Windows.Forms.TextBox()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.BtbSignIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(261, 61)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(178, 26)
        Me.TxtUserName.TabIndex = 2
        '
        'TextPassWord
        '
        Me.TextPassWord.Location = New System.Drawing.Point(261, 125)
        Me.TextPassWord.Name = "TextPassWord"
        Me.TextPassWord.Size = New System.Drawing.Size(178, 26)
        Me.TextPassWord.TabIndex = 3
        '
        'BtnSignUp
        '
        Me.BtnSignUp.Location = New System.Drawing.Point(282, 198)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(94, 31)
        Me.BtnSignUp.TabIndex = 4
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = True
        '
        'BtbSignIn
        '
        Me.BtbSignIn.Location = New System.Drawing.Point(149, 198)
        Me.BtbSignIn.Name = "BtbSignIn"
        Me.BtbSignIn.Size = New System.Drawing.Size(75, 31)
        Me.BtbSignIn.TabIndex = 5
        Me.BtbSignIn.Text = "Sign In"
        Me.BtbSignIn.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.BtbSignIn)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.TextPassWord)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUserName As TextBox
    Friend WithEvents TextPassWord As TextBox
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents BtbSignIn As Button
End Class
