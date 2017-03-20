Public Class parent
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim child As New childForm()
        child.MdiParent = Me
        child.Show()
    End Sub

    Private Sub parent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim childx As New childForm()
        childx.MdiParent = Me
        childx.Show()
    End Sub
End Class
