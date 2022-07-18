Imports System.Data.SqlClient
Public Class SignUpForm
    Dim Con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alain\source\repos\Prod\bin\Debug\productdb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim myStr As String
    Private Sub BtnSaveBtnSave_Click(sender As Object, e As EventArgs) Handles BtnSaveBtnSave.Click
        Con.Open()
        myStr = "insert into users values ('" & TxtFName.Text & "','" & TxtLName.Text & "', '" & TxtUserName.Text & "','" & TxtPassword.Text & "')"
        Dim cmd As SqlCommand = New SqlCommand(myStr, Con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data save sucessfully...")
        Con.Close()
    End Sub
End Class