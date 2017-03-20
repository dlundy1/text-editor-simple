Public Class childForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        content_box.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim file As String = "C:\Users\D.Velop\Desktop\test.txt"
        Dim text As String = content_box.Text
        Dim save As Boolean = False

        If (content_box.Text = "") Then
            Dim result As DialogResult
            result = MessageBox.Show("Because the text field is empty -- You Are About to Erase all Contet,
                            Are you Sure you want to do this? Y/N",
                            "Wait", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If (result = DialogResult.Yes) Then
                'Save text
                Debug.WriteLine("Overwrite Text")
                saveFile(file, text, save)
            End If
        Else
            saveFile(file, text, save)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles browse_btn.Click
        OpenFileDialog1.InitialDirectory = CurDir()
        OpenFileDialog1.ShowDialog()

        Dim file As String = OpenFileDialog1.FileName()
        Try
            content_box.Text = My.Computer.FileSystem.ReadAllText(file)
        Catch ex As Exception
            MessageBox.Show("File Not Found", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub saveFile(ByVal file As String, text As String, save As Boolean)
        Try
            My.Computer.FileSystem.WriteAllText(file, text, False)
            MessageBox.Show("Success, File Saved.", "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Something went wrong. Please Try again", "Whoops", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub childForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class