Imports System.Windows.Forms
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits Form

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

    ' Token: 0x0600001F RID: 31 RVA: 0x00018980 File Offset: 0x00016D80
    <Global.System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnMain = New System.Windows.Forms.Button()
        Me.timMain = New System.Windows.Forms.Timer(Me.components)
        Me.lblRemain = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numWait = New System.Windows.Forms.NumericUpDown()
        Me.myStatus = New System.Windows.Forms.StatusStrip()
        Me.ToolCurLink = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpLinks = New System.Windows.Forms.GroupBox()
        Me.btnLinksClear = New System.Windows.Forms.Button()
        Me.btnLinksLoad = New System.Windows.Forms.Button()
        Me.listLinks = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRem = New System.Windows.Forms.Button()
        Me.grpProxy = New System.Windows.Forms.GroupBox()
        Me.btnProxiesClear = New System.Windows.Forms.Button()
        Me.btnProxiesLoad = New System.Windows.Forms.Button()
        Me.listProxy = New System.Windows.Forms.ListBox()
        Me.iconNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkLoop = New System.Windows.Forms.CheckBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.WebPreview = New System.Windows.Forms.WebBrowser()
        Me.myToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.numWait2 = New System.Windows.Forms.NumericUpDown()
        Me.linkHome = New System.Windows.Forms.LinkLabel()
        Me.picBanner = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.numWait, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.myStatus.SuspendLayout()
        Me.grpLinks.SuspendLayout()
        Me.grpProxy.SuspendLayout()
        Me.cMenu.SuspendLayout()
        CType(Me.numWait2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMain
        '
        Me.btnMain.BackColor = System.Drawing.Color.Transparent
        Me.btnMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMain.Location = New System.Drawing.Point(7, 251)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(57, 27)
        Me.btnMain.TabIndex = 1
        Me.btnMain.Text = "Start"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'timMain
        '
        Me.timMain.Interval = 1000
        '
        'lblRemain
        '
        Me.lblRemain.AutoSize = True
        Me.lblRemain.BackColor = System.Drawing.Color.Transparent
        Me.lblRemain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRemain.Location = New System.Drawing.Point(249, 261)
        Me.lblRemain.Name = "lblRemain"
        Me.lblRemain.Size = New System.Drawing.Size(0, 13)
        Me.lblRemain.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(122, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Wait:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(192, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "-"
        '
        'numWait
        '
        Me.numWait.Location = New System.Drawing.Point(152, 256)
        Me.numWait.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.numWait.Name = "numWait"
        Me.numWait.Size = New System.Drawing.Size(40, 20)
        Me.numWait.TabIndex = 15
        Me.numWait.TabStop = False
        Me.myToolTip.SetToolTip(Me.numWait, "Waiting time (in seconds) after a Link is browsed")
        Me.numWait.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'myStatus
        '
        Me.myStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.myStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolCurLink, Me.ToolStatus, Me.ToolCount})
        Me.myStatus.Location = New System.Drawing.Point(0, 294)
        Me.myStatus.Name = "myStatus"
        Me.myStatus.Size = New System.Drawing.Size(357, 22)
        Me.myStatus.SizingGrip = False
        Me.myStatus.TabIndex = 18
        '
        'ToolCurLink
        '
        Me.ToolCurLink.BackColor = System.Drawing.Color.Transparent
        Me.ToolCurLink.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolCurLink.Name = "ToolCurLink"
        Me.ToolCurLink.Size = New System.Drawing.Size(342, 17)
        Me.ToolCurLink.Spring = True
        Me.ToolCurLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStatus
        '
        Me.ToolStatus.BackColor = System.Drawing.Color.Transparent
        Me.ToolStatus.Name = "ToolStatus"
        Me.ToolStatus.Size = New System.Drawing.Size(0, 17)
        Me.ToolStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolCount
        '
        Me.ToolCount.BackColor = System.Drawing.Color.Transparent
        Me.ToolCount.Name = "ToolCount"
        Me.ToolCount.Size = New System.Drawing.Size(0, 17)
        '
        'grpLinks
        '
        Me.grpLinks.BackColor = System.Drawing.Color.Transparent
        Me.grpLinks.Controls.Add(Me.btnLinksClear)
        Me.grpLinks.Controls.Add(Me.btnLinksLoad)
        Me.grpLinks.Controls.Add(Me.listLinks)
        Me.grpLinks.Controls.Add(Me.btnAdd)
        Me.grpLinks.Controls.Add(Me.btnRem)
        Me.grpLinks.Location = New System.Drawing.Point(5, 88)
        Me.grpLinks.Name = "grpLinks"
        Me.grpLinks.Size = New System.Drawing.Size(211, 154)
        Me.grpLinks.TabIndex = 23
        Me.grpLinks.TabStop = False
        Me.grpLinks.Text = "Links"
        '
        'btnLinksClear
        '
        Me.btnLinksClear.Location = New System.Drawing.Point(155, 13)
        Me.btnLinksClear.Name = "btnLinksClear"
        Me.btnLinksClear.Size = New System.Drawing.Size(50, 25)
        Me.btnLinksClear.TabIndex = 26
        Me.btnLinksClear.TabStop = False
        Me.btnLinksClear.Text = "Clear"
        Me.myToolTip.SetToolTip(Me.btnLinksClear, "Clear all Links")
        Me.btnLinksClear.UseVisualStyleBackColor = True
        '
        'btnLinksLoad
        '
        Me.btnLinksLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnLinksLoad.Location = New System.Drawing.Point(5, 13)
        Me.btnLinksLoad.Name = "btnLinksLoad"
        Me.btnLinksLoad.Size = New System.Drawing.Size(54, 25)
        Me.btnLinksLoad.TabIndex = 25
        Me.btnLinksLoad.TabStop = False
        Me.btnLinksLoad.Text = "Load..."
        Me.myToolTip.SetToolTip(Me.btnLinksLoad, "Load a List of Links")
        Me.btnLinksLoad.UseVisualStyleBackColor = False
        '
        'listLinks
        '
        Me.listLinks.AllowDrop = True
        Me.listLinks.FormattingEnabled = True
        Me.listLinks.Location = New System.Drawing.Point(6, 40)
        Me.listLinks.Name = "listLinks"
        Me.listLinks.Size = New System.Drawing.Size(199, 108)
        Me.listLinks.TabIndex = 24
        Me.listLinks.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Image = Global.AdFlyer.My.Resources.Resources.Create
        Me.btnAdd.Location = New System.Drawing.Point(63, 13)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(38, 25)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.TabStop = False
        Me.myToolTip.SetToolTip(Me.btnAdd, "Add a new Link")
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnRem
        '
        Me.btnRem.BackColor = System.Drawing.Color.Transparent
        Me.btnRem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRem.Image = Global.AdFlyer.My.Resources.Resources.Noentry
        Me.btnRem.Location = New System.Drawing.Point(108, 13)
        Me.btnRem.Name = "btnRem"
        Me.btnRem.Size = New System.Drawing.Size(41, 25)
        Me.btnRem.TabIndex = 22
        Me.btnRem.TabStop = False
        Me.myToolTip.SetToolTip(Me.btnRem, "Remove selected Link")
        Me.btnRem.UseVisualStyleBackColor = False
        '
        'grpProxy
        '
        Me.grpProxy.BackColor = System.Drawing.Color.Transparent
        Me.grpProxy.Controls.Add(Me.btnProxiesClear)
        Me.grpProxy.Controls.Add(Me.btnProxiesLoad)
        Me.grpProxy.Controls.Add(Me.listProxy)
        Me.grpProxy.Location = New System.Drawing.Point(225, 88)
        Me.grpProxy.Name = "grpProxy"
        Me.grpProxy.Size = New System.Drawing.Size(128, 154)
        Me.grpProxy.TabIndex = 24
        Me.grpProxy.TabStop = False
        Me.grpProxy.Text = "Proxies"
        '
        'btnProxiesClear
        '
        Me.btnProxiesClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnProxiesClear.Location = New System.Drawing.Point(63, 13)
        Me.btnProxiesClear.Name = "btnProxiesClear"
        Me.btnProxiesClear.Size = New System.Drawing.Size(58, 25)
        Me.btnProxiesClear.TabIndex = 23
        Me.btnProxiesClear.TabStop = False
        Me.btnProxiesClear.Text = "Clear"
        Me.myToolTip.SetToolTip(Me.btnProxiesClear, "Clear All Proxies")
        Me.btnProxiesClear.UseVisualStyleBackColor = True
        '
        'btnProxiesLoad
        '
        Me.btnProxiesLoad.BackColor = System.Drawing.Color.Transparent
        Me.btnProxiesLoad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnProxiesLoad.Location = New System.Drawing.Point(4, 13)
        Me.btnProxiesLoad.Name = "btnProxiesLoad"
        Me.btnProxiesLoad.Size = New System.Drawing.Size(56, 25)
        Me.btnProxiesLoad.TabIndex = 22
        Me.btnProxiesLoad.TabStop = False
        Me.btnProxiesLoad.Text = "Load..."
        Me.myToolTip.SetToolTip(Me.btnProxiesLoad, "Load a list of Proxies")
        Me.btnProxiesLoad.UseVisualStyleBackColor = False
        '
        'listProxy
        '
        Me.listProxy.AllowDrop = True
        Me.listProxy.FormattingEnabled = True
        Me.listProxy.Location = New System.Drawing.Point(5, 40)
        Me.listProxy.Name = "listProxy"
        Me.listProxy.Size = New System.Drawing.Size(116, 108)
        Me.listProxy.TabIndex = 21
        Me.listProxy.TabStop = False
        '
        'iconNotify
        '
        Me.iconNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.iconNotify.ContextMenuStrip = Me.cMenu
        Me.iconNotify.Text = "AdFlyer v1.0"
        Me.iconNotify.Visible = True
        '
        'cMenu
        '
        Me.cMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mShow, Me.ToolStripSeparator1, Me.mExit})
        Me.cMenu.Name = "cMenu"
        Me.cMenu.Size = New System.Drawing.Size(147, 54)
        '
        'mShow
        '
        Me.mShow.Name = "mShow"
        Me.mShow.Size = New System.Drawing.Size(146, 22)
        Me.mShow.Text = "Show AdFlyer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'mExit
        '
        Me.mExit.Name = "mExit"
        Me.mExit.Size = New System.Drawing.Size(146, 22)
        Me.mExit.Text = "Exit"
        '
        'chkLoop
        '
        Me.chkLoop.AutoSize = True
        Me.chkLoop.Location = New System.Drawing.Point(68, 258)
        Me.chkLoop.Name = "chkLoop"
        Me.chkLoop.Size = New System.Drawing.Size(50, 17)
        Me.chkLoop.TabIndex = 27
        Me.chkLoop.TabStop = False
        Me.chkLoop.Text = "Loop"
        Me.chkLoop.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Webdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnShow.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnShow.Location = New System.Drawing.Point(317, 12)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(29, 27)
        Me.btnShow.TabIndex = 28
        Me.btnShow.TabStop = False
        Me.btnShow.Text = "8"
        Me.myToolTip.SetToolTip(Me.btnShow, "Show Preview")
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'WebPreview
        '
        Me.WebPreview.Location = New System.Drawing.Point(359, 3)
        Me.WebPreview.Name = "WebPreview"
        Me.WebPreview.ScriptErrorsSuppressed = True
        Me.WebPreview.Size = New System.Drawing.Size(214, 278)
        Me.WebPreview.TabIndex = 29
        Me.WebPreview.Url = New System.Uri("", System.UriKind.Relative)
        '
        'numWait2
        '
        Me.numWait2.Location = New System.Drawing.Point(203, 256)
        Me.numWait2.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.numWait2.Name = "numWait2"
        Me.numWait2.Size = New System.Drawing.Size(40, 20)
        Me.numWait2.TabIndex = 15
        Me.numWait2.TabStop = False
        Me.myToolTip.SetToolTip(Me.numWait2, "Waiting time (in seconds) after a Link is browsed")
        Me.numWait2.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'linkHome
        '
        Me.linkHome.AutoSize = True
        Me.linkHome.Location = New System.Drawing.Point(188, 4)
        Me.linkHome.Name = "linkHome"
        Me.linkHome.Size = New System.Drawing.Size(106, 13)
        Me.linkHome.TabIndex = 30
        Me.linkHome.TabStop = True
        Me.linkHome.Text = "Hackcommunity.com"
        Me.myToolTip.SetToolTip(Me.linkHome, "The best ethical hacking forums")
        '
        'picBanner
        '
        Me.picBanner.BackColor = System.Drawing.Color.Transparent
        Me.picBanner.Cursor = System.Windows.Forms.Cursors.Help
        Me.picBanner.Image = Global.AdFlyer.My.Resources.Resources.picBanner_Image
        Me.picBanner.Location = New System.Drawing.Point(58, 0)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(240, 88)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBanner.TabIndex = 22
        Me.picBanner.TabStop = False
        Me.myToolTip.SetToolTip(Me.picBanner, "About adFlyer 1.0")
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.cMenu
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "AdFlyer v1.0"
        Me.NotifyIcon1.Visible = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(357, 316)
        Me.Controls.Add(Me.linkHome)
        Me.Controls.Add(Me.chkLoop)
        Me.Controls.Add(Me.grpProxy)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.grpLinks)
        Me.Controls.Add(Me.WebPreview)
        Me.Controls.Add(Me.myStatus)
        Me.Controls.Add(Me.btnMain)
        Me.Controls.Add(Me.numWait2)
        Me.Controls.Add(Me.lblRemain)
        Me.Controls.Add(Me.numWait)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(593, 345)
        Me.MinimumSize = New System.Drawing.Size(363, 345)
        Me.Name = "frmMain"
        Me.Text = "AdFlyer"
        CType(Me.numWait, System.ComponentModel.ISupportInitialize).EndInit()
        Me.myStatus.ResumeLayout(False)
        Me.myStatus.PerformLayout()
        Me.grpLinks.ResumeLayout(False)
        Me.grpProxy.ResumeLayout(False)
        Me.cMenu.ResumeLayout(False)
        CType(Me.numWait2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolCurLink As ToolStripStatusLabel
    Friend WithEvents ToolStatus As ToolStripStatusLabel
    Friend WithEvents ToolCount As ToolStripStatusLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents numWait As NumericUpDown
    Friend WithEvents myStatus As StatusStrip
    Friend WithEvents lblRemain As Label
    Friend WithEvents timMain As Timer
    Friend WithEvents btnMain As Button
    Friend WithEvents btnLinksClear As Button
    Friend WithEvents btnLinksLoad As Button
    Friend WithEvents btnProxiesClear As Button
    Friend WithEvents btnProxiesLoad As Button
    Friend WithEvents btnShow As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRem As Button
    Friend WithEvents linkHome As LinkLabel
    Friend WithEvents numWait2 As NumericUpDown
    Friend WithEvents picBanner As PictureBox
    Friend WithEvents myToolTip As ToolTip '(New System.ComponentModel.Container())
    Friend WithEvents WebPreview As WebBrowser
    Friend WithEvents chkLoop As CheckBox
    Friend WithEvents mExit As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mShow As ToolStripMenuItem
    Friend WithEvents cMenu As ContextMenuStrip
    Friend WithEvents iconNotify As NotifyIcon
    Friend WithEvents listProxy As ListBox
    Friend WithEvents grpLinks As GroupBox
    Friend WithEvents grpProxy As GroupBox
    Friend WithEvents listLinks As ListBox

    ' Token: 0x04000009 RID: 9
    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
End Class
