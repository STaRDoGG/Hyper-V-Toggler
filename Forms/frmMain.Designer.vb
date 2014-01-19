<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.llGD = New System.Windows.Forms.LinkLabel()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.radRestore = New System.Windows.Forms.RadioButton()
        Me.radEnable = New System.Windows.Forms.RadioButton()
        Me.radDisable = New System.Windows.Forms.RadioButton()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblState2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'llGD
        '
        Me.llGD.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.llGD.AutoSize = True
        Me.llGD.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.llGD.Location = New System.Drawing.Point(312, 183)
        Me.llGD.Name = "llGD"
        Me.llGD.Size = New System.Drawing.Size(167, 13)
        Me.llGD.TabIndex = 5
        Me.llGD.TabStop = True
        Me.llGD.Text = "GeekDrop.com / J. Scott Elblein"
        Me.llGD.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer))
        '
        'ToolTips
        '
        Me.ToolTips.IsBalloon = True
        Me.ToolTips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTips.ToolTipTitle = "Description"
        '
        'radRestore
        '
        Me.radRestore.AutoSize = True
        Me.radRestore.Enabled = False
        Me.radRestore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.radRestore.Location = New System.Drawing.Point(20, 74)
        Me.radRestore.Name = "radRestore"
        Me.radRestore.Size = New System.Drawing.Size(96, 17)
        Me.radRestore.TabIndex = 9
        Me.radRestore.TabStop = True
        Me.radRestore.Text = "RESTORE BCD"
        Me.ToolTips.SetToolTip(Me.radRestore, resources.GetString("radRestore.ToolTip"))
        Me.radRestore.UseVisualStyleBackColor = True
        '
        'radEnable
        '
        Me.radEnable.AutoSize = True
        Me.radEnable.Checked = True
        Me.radEnable.ForeColor = System.Drawing.Color.White
        Me.radEnable.Location = New System.Drawing.Point(20, 28)
        Me.radEnable.Name = "radEnable"
        Me.radEnable.Size = New System.Drawing.Size(110, 17)
        Me.radEnable.TabIndex = 7
        Me.radEnable.TabStop = True
        Me.radEnable.Text = "ENABLE HYPER-V"
        Me.ToolTips.SetToolTip(Me.radEnable, resources.GetString("radEnable.ToolTip"))
        Me.radEnable.UseVisualStyleBackColor = True
        '
        'radDisable
        '
        Me.radDisable.AutoSize = True
        Me.radDisable.ForeColor = System.Drawing.Color.White
        Me.radDisable.Location = New System.Drawing.Point(20, 51)
        Me.radDisable.Name = "radDisable"
        Me.radDisable.Size = New System.Drawing.Size(113, 17)
        Me.radDisable.TabIndex = 8
        Me.radDisable.Text = "DISABLE HYPER-V"
        Me.ToolTips.SetToolTip(Me.radDisable, resources.GetString("radDisable.ToolTip"))
        Me.radDisable.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.picLogo.Image = Global.hyper_v_toggler.My.Resources.Resources.GeekDrop
        Me.picLogo.Location = New System.Drawing.Point(12, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(32, 32)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picLogo.TabIndex = 13
        Me.picLogo.TabStop = False
        Me.ToolTips.SetToolTip(Me.picLogo, "You can move this window around by dragging this logo.")
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblState.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblState.Location = New System.Drawing.Point(9, 183)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(106, 13)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "Hyper-V is currently"
        '
        'lblState2
        '
        Me.lblState2.AutoSize = True
        Me.lblState2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblState2.Location = New System.Drawing.Point(111, 183)
        Me.lblState2.Name = "lblState2"
        Me.lblState2.Size = New System.Drawing.Size(50, 13)
        Me.lblState2.TabIndex = 7
        Me.lblState2.Text = "Disabled"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 215)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(491, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.radRestore)
        Me.Panel1.Controls.Add(Me.btnAbout)
        Me.Panel1.Controls.Add(Me.btnGo)
        Me.Panel1.Controls.Add(Me.radEnable)
        Me.Panel1.Controls.Add(Me.radDisable)
        Me.Panel1.Location = New System.Drawing.Point(12, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(467, 117)
        Me.Panel1.TabIndex = 9
        '
        'btnAbout
        '
        Me.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAbout.FlatAppearance.BorderSize = 2
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Image = Global.hyper_v_toggler.My.Resources.Resources.about
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbout.Location = New System.Drawing.Point(302, 40)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(134, 39)
        Me.btnAbout.TabIndex = 10
        Me.btnAbout.Text = "ABOUT"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnGo.FlatAppearance.BorderSize = 2
        Me.btnGo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Image = Global.hyper_v_toggler.My.Resources.Resources.arrow
        Me.btnGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGo.Location = New System.Drawing.Point(159, 40)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(137, 39)
        Me.btnGo.TabIndex = 6
        Me.btnGo.Text = "DO IT"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGray
        Me.lblTitle.Location = New System.Drawing.Point(50, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(199, 21)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "GeekDrop Hyper-V Toggler"
        '
        'btnMinimize
        '
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Image = Global.hyper_v_toggler.My.Resources.Resources.minimize
        Me.btnMinimize.Location = New System.Drawing.Point(430, -2)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(32, 23)
        Me.btnMinimize.TabIndex = 12
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Image = Global.hyper_v_toggler.My.Resources.Resources.close
        Me.btnExit.Location = New System.Drawing.Point(459, -2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(32, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(491, 237)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblState2)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.llGD)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Microsoft Windows© Hyper-V Toggler"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents llGD As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTips As System.Windows.Forms.ToolTip
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblState2 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents radRestore As System.Windows.Forms.RadioButton
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents radEnable As System.Windows.Forms.RadioButton
    Friend WithEvents radDisable As System.Windows.Forms.RadioButton
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox

End Class
