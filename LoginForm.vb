Imports System.Data.SqlClient
Public Class LoginForm
    Dim sqlStr As String
    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alain\source\repos\Prod\bin\Debug\productdb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub BtbSignIn_Click(sender As Object, e As EventArgs) Handles BtbSignIn.Click
        conn.Open()
        sqlStr = "select * from users where username='" & TxtUserName.Text & "'"
        Dim cmd As SqlCommand = New SqlCommand(sqlStr, conn)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        If dr.Read Then
            Form1.ViewProductToolStripMenuItem.Enabled = True
            Form1.AddProductToolStripMenuItem.Enabled = True
            Me.Hide()
        Else
            MessageBox.Show("Username or Passowd are not correct")
        End If
        conn.Close()

    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        SignUpForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUserName.Text = ""
        TextPassWord.Text = ""
    End Sub
End Class