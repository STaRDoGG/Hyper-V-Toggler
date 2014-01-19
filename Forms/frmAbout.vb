Public Class frmAbout

    Private Sub llGD_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llGD.LinkClicked
        ' Navigate to a GeekDrop.
        frmMain.NavigateToGd()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Set title label
        lblTitle.Text = "About GeekDrop Hyper-V Toggler " & Application.ProductVersion

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llJSE.LinkClicked
        System.Diagnostics.Process.Start("http://about.me/scott.elblein")
    End Sub
End Class