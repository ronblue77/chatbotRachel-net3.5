
Imports System.ComponentModel

Public Class frmOpening
    Public r As Integer = 255
    Dim user As String
    'Dim count As Integer = 10
    Private Sub tmrExit_Tick(sender As Object, e As EventArgs) Handles tmrExit.Tick
        'user = InputBox("what is your name?")
        'Dim loginform1 As New frmMain
        'loginform1.user = user
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub frmOpening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FadeIn()
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        r = r - 1
        If r <= 0 Then r = 255
        Label2.ForeColor = System.Drawing.Color.FromArgb(r, 0, 0)
    End Sub

    Private Sub frmOpening_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Timer1.Stop()
        FadeOut()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(12)
    End Sub
End Class