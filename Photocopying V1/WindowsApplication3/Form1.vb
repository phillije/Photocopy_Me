Public Class LogIn
    Dim username() As String = {"josh", "bum"}
    Dim password() As String = {"philliban", "bum"}


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = username(0) And TextBox2.Text = password(0) Then
            Timer1.Enabled = False
            Form2.Show()
            Me.Close()
        ElseIf TextBox1.Text = username(1) And TextBox2.Text = password(1) Then
            Timer1.Enabled = False
            Form2.Show()
            Me.Close()
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please enter all details")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        TextBox1.Select()
    End Sub
End Class
