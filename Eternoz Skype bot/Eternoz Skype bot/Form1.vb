Imports SKYPE4COMLib
Public Class Form1
    Public WithEvents skype As New SKYPE4COMLib.Skype
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        

    End Sub
End Class
