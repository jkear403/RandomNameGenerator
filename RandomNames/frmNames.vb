Public Class frmNames

    Dim RandomName As New RandomNameClass()

    Private Sub btnName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName.Click
        RandomName.GenerateName()
        Me.lblNames.Text = RandomName.Name
    End Sub

    Private Sub frmNames_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
