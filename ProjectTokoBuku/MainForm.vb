Public Class MainForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub DataBukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBukuToolStripMenuItem.Click
        FormDataBuku.Show()
    End Sub
End Class