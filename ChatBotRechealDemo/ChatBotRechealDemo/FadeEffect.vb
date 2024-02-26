Module FadeEffect
    Public Sub FadeIn()
        Dim fade As Double
        For fade = 0.0 To 1.1 Step 0.1
            frmOpening.Opacity = fade
            frmOpening.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Public Sub FadeOut()
        Dim fade As Double
        For fade = 1.1 To 0.0 Step -0.1
            frmOpening.Opacity = fade
            frmOpening.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

End Module
