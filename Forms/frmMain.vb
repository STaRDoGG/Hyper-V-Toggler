Public Class frmMain

    'TODO: Technically, we could tighten up this code by putting all of the message boxes in their own function, and just calling them, with a result, but it's not high priority right now.
    'TODO: Should we add confirmation messageboxes before the user toggles a Hyper-V setting?
    'TODO: We SHOULD set a registry flag (MySettings) to know, & alert the user, that a reboot is still pending from a previous toggle, including adding this alert to the lblState label.
    '      See Time-Since-Reboot code here: http://www.c-sharpcorner.com/uploadfile/scottlysle/determine-the-time-since-the-last-boot-up-in-visual-basic3/
    '      Idea is: set Last Reboot time as a reg key, Current Time as a reg key, and a "0/1 Pending Reboot" Flag as a reg key, all for comparison purposes.
    'TODO: Maybe add some Server 2012 (or whatever) code for toggling off the "Hyper-V Role"? There's no Role in regular Windows that I can tell, which is why I've use the BCDEdit method.

    ' As of now (1/20/2014 1:43 PM) this app is considered "done", unless someone points out bugs, feature requests, etc.

    ' For the form moving code
    Private mouseOffset As Point

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim strChoice As String = String.Empty
        Dim strType As String = "Hyper-V has been "

        If radDisable.Checked AndAlso lblState2.Text.Contains("Enabled") Then

            ' Backup current BCD first
            If Not BackupBCD() = 1 Then
                ' Backing up the BCD didn't work, give the user a chance to bail out
                If MessageBox.Show("The automatic back-up failed, I don't recommend proceeding but the choice is yours." & Environment.NewLine & Environment.NewLine & "Do you still want to try to disable Hyper-V?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then
                    ' User backed out by clicking the "No" button, so just exit the action
                    Return
                End If
            End If

            ' Turn off Hyper-V
            If Not BCDEdit("/set hypervisorlaunchtype Off", True) = 1 Then
                ' Disabling hypervisorlaunchtype failed, deliver the bad news
                MessageBox.Show("Disabling Hyper-V failed, sorry!" & Environment.NewLine & Environment.NewLine & "You could ensure that you're running this as Admin, maybe that's the problem.", "Dang!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                ' Successfully disabled hypervisorlaunchtype
                strChoice = "Disabled."
                ' Auto-select the opposite option
                radEnable.Checked = True
                lblState2.Text = "Disabled [Pending reboot]."
            End If

        ElseIf radEnable.Checked AndAlso lblState2.Text.Contains("Disabled") Then

            ' Backup current BCD first
            If Not BackupBCD() = 1 Then
                ' Backing up the BCD didn't work, give the user a chance to bail out
                If MessageBox.Show("The automatic back-up failed, I don't recommend proceeding but the choice is yours." & Environment.NewLine & Environment.NewLine & "Do you still want to try to enable Hyper-V?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then
                    ' User backed out by clicking the "No" button, so just exit the action
                    Return
                End If
            End If

            ' Turn On Hyper-v
            If Not BCDEdit("/set hypervisorlaunchtype Auto", True) = 1 Then
                ' Enabling hypervisorlaunchtype failed, deliver the bad news
                MessageBox.Show("Enabling Hyper-V failed, sorry!" & Environment.NewLine & Environment.NewLine & "You could ensure that you're running this as Admin, maybe that's the problem.", "Dang!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                ' Successfully enabled hypervisorlaunchtype
                strChoice = "Enabled."
                ' Auto-select the opposite option
                radDisable.Checked = True
                lblState2.Text = "Enabled [Pending reboot]."
            End If

        ElseIf radRestore.Checked Then
            ' Restore backed up BCD in case of catastrophe
            If MessageBox.Show("Are you sure you want to restore your backed-up BCD?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                If Not BCDEdit("/import " & Environment.SystemDirectory.ToString() & "\BackupBCD.bcd", True) = 1 Then
                    ' Importing the backed up bcd file failed, deliver the bad news
                    MessageBox.Show("Importing the backed up bcd file failed, sorry!" & Environment.NewLine & Environment.NewLine & "You could ensure that you're running this as Admin, maybe that's the problem.", "Dang!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                Else
                    ' Successfully imported the backed up bcd file
                    strType = "Your backed up BCD has been "
                    strChoice = "imported [Pending reboot]."
                End If
            Else
                ' User backed out by clicking the "No" button, so just exit the action
                Return
            End If
        End If

        ' --

        If strChoice.Length > 0 AndAlso MessageBox.Show(strType & strChoice & Environment.NewLine & Environment.NewLine & " You need to restart your computer for it to take effect, want to do that right now?" & Environment.NewLine & Environment.NewLine & " (Be sure to save everything you need to first.)", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            RebootComputer()
        End If

    End Sub

    Private Sub llGD_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llGD.LinkClicked
        NavigateToGd()
    End Sub

    Public Sub NavigateToGd()
        ' Navigate to a GeekDrop.
        System.Diagnostics.Process.Start("http://geekdrop.com")
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Function BCDEdit(Optional strWhich As String = "", Optional bAction As Boolean = False) As Integer
        ' Returns:
        '   1 on successful BCDEdit.exe command
        '   0 on failed BCDEdit.exe command
        '   (1, 2, 3) on the current state of "hypervisorlaunchtype" if bAction is False (Default)

        Dim intResult As Integer = 0

        Dim p As New Process()

        With p.StartInfo
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .FileName = "CMD.EXE"
            .Arguments = "/C bcdedit " & strWhich
            .UseShellExecute = False
            .CreateNoWindow = True
        End With

        p.Start()

        Dim output As String = p.StandardOutput.ReadToEnd()
        p.WaitForExit()

        If output.Contains("The boot configuration data store could not be opened") Then
            ' Must not be running this app as Admin; GOOD DAY, SIR!
            MessageBox.Show("Problem communicating with BCD, make sure to run this app as Administrator first." & Environment.NewLine & Environment.NewLine & "Exiting now.", "Mulligan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        ElseIf bAction = True Then
            If output.Contains("The operation completed successfully") Then
                ' Great success, whilst performing the BCD action
                SetChangeInfo() 'TODO: Should add a handler here to only set the change info NOT on BCD backing up
                Return 1
            Else
                ' Something pooped out
                Return 0
            End If
        End If

        ' --

        ' Parse the output. We only need to do this when checking the current state of "hypervisorlaunchtype"
        Dim strLines = output.Split(New String() {vbCr & vbLf}, StringSplitOptions.RemoveEmptyEntries).Where(Function(l) l.Length > 24)

        For Each strLine As String In strLines

            Dim strKey = strLine.Substring(0, 24).Replace(" ", String.Empty)
            Dim strValue = strLine.Substring(24).Replace(" ", String.Empty)

            If strKey = "hypervisorlaunchtype" Then
                If strValue = "Auto" Then
                    ' Hypervisor is Enabled in Windows
                    intResult = 1
                ElseIf strValue = "Off" Then
                    ' Hypervisor is Disabled in Windows
                    intResult = 2
                Else
                    ' Failsafe
                    intResult = 3
                End If

            End If
        Next

        BCDEdit = intResult

    End Function

    Private Sub RebootComputer()
        System.Diagnostics.Process.Start("shutdown", "-r -t 00")
    End Sub

    Private Function BackupBCD() As Integer
        ' Backs up the current BCD settings
        ' Returns 0 or 1 on Failure or Success, respectively

        BackupBCD = BCDEdit("/export " & Environment.SystemDirectory.ToString() & "\BackupBCD.bcd", True)

        ' Add a little GUI feedback
        If BackupBCD = 1 Then
            ToolStripStatusLabel1.Text = "BCD back-up: Successful"
        Else
            ToolStripStatusLabel1.Text = "BCD back-up: Failed"
        End If

    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Set our app title in the label, since we've removed the title bar for the sake of a theme
        lblTitle.Text = Me.Text & " [βeta]"

        ' Determine if user has rebooted since the last toggle
        ComparePending()

        ' Check the current state of Hyper-V & select the opposite option to make the user's life easier
        Dim intResult As Integer = BCDEdit()

        Select Case intResult

            Case 1
                ' Hyper-V is Enabled, 
                radDisable.Checked = True
                lblState2.Text = "Enabled"
            Case 2
                ' Hyper-V is Disabled
                radEnable.Checked = True
                lblState2.Text = "Disabled"
            Case Else
                MessageBox.Show("Unable to read current Hyper-V BCD settings, make sure to run this app as Administrator first." & Environment.NewLine & Environment.NewLine & "You could still TRY to toggle it, but I'm making no promises.", "Heads up!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Select

        ' --

        ' Check if we've backed up the .bcd during a previous change, if so, enable the Restore option
        If System.IO.File.Exists(Environment.SystemDirectory.ToString() & "\BackupBCD.bcd") Then
            Me.radRestore.Enabled = True
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblState_Click(sender As Object, e As EventArgs) Handles lblState.Click
        ' Start up the Hyper-V Manager when clicked

        Dim strSplit() As String = Split(HVCpl(), ",")

        If strSplit(0) = "1" Then
            System.Diagnostics.Process.Start(strSplit(1))
        End If

    End Sub

    Private Function HVCpl() As String
        ' Confirms that the Hyper-V Manager does in fact exist

        HVCpl = String.Empty

        Dim strHV As String = Environment.SystemDirectory.ToString() & "\virtmgmt.msc"

        If System.IO.File.Exists(strHV) Then
            ' That would be a "Yes"
            HVCpl = "1," & strHV
        End If

        Return HVCpl

    End Function

    Private Sub lblState_MouseHover(sender As Object, e As EventArgs) Handles lblState.MouseHover
        ' Change the cursor to a hand, but only if the Hyper-V Manager exists

        Dim strSplit() As String = Split(HVCpl(), ",")

        If strSplit(0) = "1" Then
            lblState.Cursor = Cursors.Hand
            ToolTips.SetToolTip(lblState, "Click to launch the Hyper-V Management Console")
        End If
    End Sub

    Private Sub picLogo_MouseDown(sender As Object, e As MouseEventArgs) Handles picLogo.MouseDown
        ' For the form moving code
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub picLogo_MouseMove(sender As Object, e As MouseEventArgs) Handles picLogo.MouseMove
        ' For the form moving code. Allows moving the form via dragging the logo image

        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub SetChangeInfo()
        ' Stores the time of the last successful BCD change by this app, and that a reboot is still pending (as of now, this is still unused, see TODO)
        My.Settings.Pending = 1
        My.Settings.LastChange = DateTime.Now.ToString
    End Sub

    Private Sub ComparePending()
        ' Determines whether the user has rebooted since the last successful BCDEdit by this app (still unused as of now. See TODO)
        ' Note: during quick setup, the storing of the Settings is working, however, while trying to read them here in app start, they appear to be reset for some reason.

        Dim intPending As Integer = My.Settings.Pending
        Dim strLastChange As String = My.Settings.LastChange
        Dim strLastReboot As String = My.Settings.LastReboot

    End Sub
End Class
