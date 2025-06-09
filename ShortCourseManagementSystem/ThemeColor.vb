Public Class ThemeColor
    Public Shared menuBackColor As Color = Color.FromArgb(5, 43, 80)
    Public Shared activeColor As Color = Color.FromArgb(17, 139, 254)
    Public Shared DashboardColor As Color = Color.FromArgb(63, 114, 236)
    Public Shared CourseColor As Color = Color.FromArgb(143, 135, 241)
    'Public Shared btnStudenBackColor As Color = 



    Public Shared Function ChangeColorBrightness(color As Color, correctionFactor As Double) As Color
        Dim red As Double = color.R
        Dim green As Double = color.G
        Dim blue As Double = color.B

        If correctionFactor < 0 Then
            correctionFactor += 1
            red *= correctionFactor
            green *= correctionFactor
            blue *= correctionFactor
        Else
            red = (255 - red) * correctionFactor + red
            green = (255 - green) * correctionFactor + green
            blue = (255 - blue) * correctionFactor + blue
        End If
        Return Color.FromArgb(color.A, Math.Round(red), Math.Round(green), Math.Round(blue))
    End Function
End Class
