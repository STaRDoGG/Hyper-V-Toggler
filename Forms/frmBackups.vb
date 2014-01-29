Public Class frmBackups

    Private Sub frmBackups_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Clears the listbox; enumerates any .bcdx (our custom extension) & shows them in the listbox

        If frmMain.radRestore.Tag.ToString = "Checking" Then
            ' We don't want the user to see this form while we check for backups
            Me.Visible = False
        End If

        lstBackups.Items.Clear()

        Dim folderInfo As New IO.DirectoryInfo(Environment.SystemDirectory.ToString())
        Dim arrFilesInFolder() As IO.FileInfo
        Dim fileInFolder As IO.FileInfo

        arrFilesInFolder = folderInfo.GetFiles("*.bcdx")

        For Each fileInFolder In arrFilesInFolder
            If fileInFolder.Name.Contains("BCDBackup-") Then
                lstBackups.Items.Add(fileInFolder.Name)
                If frmMain.radRestore.Tag.ToString = "Checking" Then
                    ' Set a "flag" so we tell frmMain there are some BCD backups
                    frmMain.radRestore.Tag = "Found"
                End If
            End If
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstBackups_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstBackups.MouseDoubleClick
        ' Upon double-click: 
        '   string together the System path & selected .bcdx file name
        '   use radRestore.tag on the main form as a place to pass/store the string
        '   close this window

        frmMain.radRestore.Tag = Environment.SystemDirectory.ToString() & "\" & lstBackups.SelectedItem.ToString
        Me.Close()

    End Sub

End Class