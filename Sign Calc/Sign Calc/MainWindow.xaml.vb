Imports System.Reflection.Emit

Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles Button.Click
        Dim d As Integer
        Dim m As Integer
        m = Cal1.SelectedDate.Value.Month
        d = Cal1.SelectedDate.Value.Day
        If m = 3 And d > 20 Or m = 4 And d < 20 Then
            label1.Content = "Aries"
            AriesPB.Visibility = Visibility.Visible
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 4 And d > 19 Or m = 5 And d < 21 Then
            label1.Content = "Taurus"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Visible
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 5 And d > 20 Or m = 6 And d < 21 Then
            label1.Content = "Gemini"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Visible
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 6 And d > 20 Or m = 7 And d < 23 Then
            label1.Content = "Cancer"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Visible
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 7 And d > 22 Or m = 8 And d < 23 Then
            label1.Content = "Leo"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Visible
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 8 And d > 22 Or m = 9 And d < 23 Then
            label1.Content = "Virgo"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Visible
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 9 And d > 22 Or m = 10 And d < 23 Then
            label1.Content = "Libra"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Visible
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 10 And d > 22 Or m = 11 And d < 22 Then
            label1.Content = "Scorpio"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Visible
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 11 And d > 21 Or m = 12 And d < 22 Then
            label1.Content = "Sagittarius"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Visible
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 12 And d > 21 Or m = 1 And d < 20 Then
            label1.Content = "Capricorn"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Visible
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 1 And d > 19 Or m = 2 And d < 19 Then
            label1.Content = "Aquarius"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Visible
            PiscesPB.Visibility = Visibility.Hidden
        End If
        If m = 2 And d > 18 Or m = 3 And d < 21 Then
            label1.Content = "Pisces"
            AriesPB.Visibility = Visibility.Hidden
            TaurusPB.Visibility = Visibility.Hidden
            GeminiPB.Visibility = Visibility.Hidden
            CancerPB.Visibility = Visibility.Hidden
            LeoPB.Visibility = Visibility.Hidden
            VirgoPB.Visibility = Visibility.Hidden
            LibraPB.Visibility = Visibility.Hidden
            ScorpioPB.Visibility = Visibility.Hidden
            SagittariusPB.Visibility = Visibility.Hidden
            CapricornPB.Visibility = Visibility.Hidden
            AquariusPB.Visibility = Visibility.Hidden
            PiscesPB.Visibility = Visibility.Visible
        End If
    End Sub
End Class
