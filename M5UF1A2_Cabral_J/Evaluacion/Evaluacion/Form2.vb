Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_suma.Click
        Dim f2 As New Form_SUMA
        f2.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.auidio1, playMode:=AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btn_resta_Click(sender As Object, e As EventArgs) Handles btn_resta.Click
        Dim f3 As New Form_Resta
        f3.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.auidio1, playMode:=AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_multiplicacion.Click
        Dim f4 As New Form_Multiplicacion
        f4.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.auidio1, playMode:=AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btn_division_Click(sender As Object, e As EventArgs) Handles btn_division.Click
        Dim f5 As New Form_Division
        f5.Show()
        Me.Hide()

        My.Computer.Audio.Play(My.Resources.auidio1, playMode:=AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class