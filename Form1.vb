Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewProductToolStripMenuItem.Enabled = False
        AddProductToolStripMenuItem.Enabled = False
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        LoginForm.Show()
    End Sub
End Class
