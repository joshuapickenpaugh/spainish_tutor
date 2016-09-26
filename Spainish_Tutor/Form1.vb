Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the application:
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears the text boxes:
        txtRed.Clear()
        txtRed.BackColor = Color.White

        txtBlue.Clear()
        txtBlue.BackColor = Color.White

        txtGreen.Clear()
        txtGreen.BackColor = Color.White

    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click

        'Delcares the variables:
        Dim strRed As String

        'Assigns the variables:
        strRed = txtRed.Text.ToUpper

        'Calculates:
        If strRed = "ROJO" Then
            txtRed.Clear()
            txtRed.BackColor = Color.Red
            txtRed.Text = "Correct!"
        Else
            txtRed.Clear()
            MsgBox("The correct answer is 'Rojo'", , "WRONG!")
        End If
    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click

        'Delcares the variables:
        Dim strBlue As String

        'Assigns the variables:
        strBlue = txtBlue.Text.ToUpper

        'Calculates:
        If strBlue = "AZUL" Then
            txtBlue.Clear()
            txtBlue.BackColor = Color.Blue
            txtBlue.Text = "Correct!"
        Else
            txtBlue.Clear()
            MsgBox("The correct answer is 'Azul'", , "WRONG!")
        End If

    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click

        'Delcares the variables:
        Dim strGreen As String

        'Assigns the variables:
        strGreen = txtGreen.Text.ToUpper

        'Calculates:
        If strGreen = "VERDE" Then
            txtGreen.Clear()
            txtGreen.BackColor = Color.Green
            txtGreen.Text = "Correct!"
        Else
            txtGreen.Clear()
            MsgBox("The correct answer is 'Verde'", , "WRONG!")
        End If
    End Sub
End Class
