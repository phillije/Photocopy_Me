Public Class Form2
    Dim En2Fr As String
    Dim Fr2En As String
    Dim En2Sp As String
    Dim Sp2En As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            French.Clear()
            Spanish.Clear()
            En2Fr = English.Text
            Select Case En2Fr.ToLower()
                Case "hello"
                    French.Text = "bonjour"
                Case "bye"
                    French.Text = "au revoir"
            End Select
        End If
        If RadioButton2.Checked = True Then
            English.Clear()
            Spanish.Clear()
            Fr2En = French.Text
            Select Case Fr2En.ToLower()
                Case "bonjour"
                    English.Text = "hello"
                Case "au revoir"
                    English.Text = "bye"
            End Select
        End If
        If RadioButton3.Checked = True Then
            French.Clear()
            Spanish.Clear()
            En2Sp = English.Text
            Select Case En2Sp.ToLower()
                Case "hello"
                    Spanish.Text = "hola"
                Case "bye"
                    Spanish.Text = "adios"
            End Select
        End If
        If RadioButton4.Checked = True Then
            English.Clear()
            French.Clear()
            Sp2En = Spanish.Text
            Select Case Sp2En.ToLower()
                Case "hola"
                    English.Text = "hello"
                Case "adios"
                    English.Text = "bye"
            End Select
        End If
    End Sub
End Class