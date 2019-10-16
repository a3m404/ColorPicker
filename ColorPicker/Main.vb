Public Class Main

    Sub New()
        InitializeComponent()
        CBFormatos.SelectedIndex = My.Settings.Index
        CBMost.Checked = My.Settings.TopMost
    End Sub

    Private Sub CBFormatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFormatos.SelectedIndexChanged
        Select Case CBFormatos.SelectedIndex
            Case 0
                For Each MyItem As ListViewItem In LVCores.Items
                    MyItem.Text = ColorTranslator.ToHtml(MyItem.Tag)
                Next
            Case 1
                For Each MyItem As ListViewItem In LVCores.Items
                    Dim MyColor As Color = CType(MyItem.Tag, Color)
                    MyItem.Text = MyColor.R & ", " & MyColor.G & ", " & MyColor.B
                Next
            Case 2
                For Each MyItem As ListViewItem In LVCores.Items
                    Dim MyColor As Color = CType(MyItem.Tag, Color)
                    MyItem.Text = MyColor.R & "; " & MyColor.G & "; " & MyColor.B
                Next
            Case 3
                For Each MyItem As ListViewItem In LVCores.Items
                    Dim MyColor As Color = CType(MyItem.Tag, Color)
                    MyItem.Text = "0x" & ColorTranslator.ToHtml(MyColor).Replace("#", "")
                Next
        End Select
        My.Settings.Index = CBFormatos.SelectedIndex
    End Sub

    Private Sub LVCores_DoubleClick(sender As Object, e As EventArgs) Handles LVCores.DoubleClick
        Clipboard.SetText(LVCores.SelectedItems(0).Text)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim MyBackColor As New Bitmap(16, 16)
        Dim GG As Graphics = Graphics.FromImage(MyBackColor) : GG.FillRectangle(New SolidBrush(CM.Color), 0, 0, 16, 16) : GList.Images.Add(MyBackColor)
        Dim CL As Color = CM.Color
        Dim NewItem As New ListViewItem
        Select Case CBFormatos.SelectedIndex
            Case 0
                NewItem.Text = ColorTranslator.ToHtml(CL)
            Case 1
                NewItem.Text = CL.R & ", " & CL.G & ", " & CL.B
            Case 2
                NewItem.Text = CL.R & "; " & CL.G & "; " & CL.B
            Case 3
                NewItem.Text = "0x" & ColorTranslator.ToHtml(CL).Replace("#", "")
        End Select
        NewItem.Tag = CL
        NewItem.ImageIndex = GList.Images.Count - 1
        LVCores.Items.Add(NewItem).EnsureVisible()
    End Sub

    Private Sub CBMost_CheckedChanged(sender As Object, e As EventArgs) Handles CBMost.CheckedChanged
        TopMost = CBMost.Checked
        My.Settings.TopMost = CBMost.Checked
    End Sub

    Private Sub colorEditorManager_ColorChanged(sender As Object, e As EventArgs) Handles CM.ColorChanged
        previewPanel.BackColor = CM.Color
    End Sub
End Class
