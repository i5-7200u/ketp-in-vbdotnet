Imports System.Globalization
Imports Microsoft.VisualBasic.Devices
Imports System.ComponentModel
Imports System.IO
Imports IWshRuntimeLibrary
Public Class Form1
    Public qwj As Integer = 0
    Dim huh As Integer = 0
    Public a As String = "ardakc"
    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumworkingsetsize As Integer, ByVal maximumworkingsetsize As Integer) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not Button1.Text.Contains("Durdur") Then
            Timer1.Start()
            Timer2.Start()
            Button1.Text = "Durdur"
        Else
            Timer1.Stop()
            Timer2.Stop()
            Panel1.BackColor = Color.Black
            Panel2.BackColor = Color.Black
            Button1.Text = "Baslat"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim qwe As Color() = {Color.Red, Color.Green, Color.Blue, Color.Black, Color.White, Color.YellowGreen, Color.GreenYellow, Color.DarkBlue, Color.Gold, Color.Yellow, Color.Aqua, Color.DarkRed, Color.LightSeaGreen, Color.DarkGray, Color.DarkSlateGray, Color.DimGray, Color.LightSlateGray, Color.LightGray, Color.SlateGray}
        Dim ewq As New Random()
        Panel1.BackColor = qwe(ewq.Next(0, qwe.Length))
        Panel2.BackColor = qwe(ewq.Next(0, qwe.Length))
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Timer1.Enabled = True Then
            If Not Button1.Text.Contains("60") Then
                For gug As Integer = 0 To 60
                    huh = huh + 1
                Next
            Else
                Timer1.Stop()
                Timer2.Stop()
                Panel1.BackColor = Color.Black
                Panel2.BackColor = Color.Black
                MsgBox("you are epilepsy")
            End If
            Dim qwwe As Integer = huh / 1000
            Button1.Text = "Durdur ( " & Convert.ToString(qwwe) & " )"
            If Not Timer1.Enabled = True Then
                Timer2.Stop()
                Button1.Text = "Baslat"
            End If
        End If
    End Sub
End Class
