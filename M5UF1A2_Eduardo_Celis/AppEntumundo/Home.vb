Public Class Home
    Private Sub JobInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobInformationToolStripMenuItem.Click
        Me.Hide()
        Form.Show()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub InicioDeLaAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioDeLaAppToolStripMenuItem.Click
        Inicio.Show()
    End Sub
End Class