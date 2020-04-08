Imports System
Imports System.IO
Imports System.Drawing
Imports System.Threading
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.CompilerServices
Public Class frmMain
    Private Declare Function InternetSetOption Lib "wininet.dll" (ByVal hInternet As IntPtr, ByVal dwOption As Integer, ByVal lpBuffer As IntPtr, ByVal lpdwBufferLength As Integer) As Boolean
    Dim Browsed, isMin As Integer
    Dim waiting As Byte
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim text As String = String.Empty
        text = Strings.Trim(Interaction.InputBox("Enter an Adf.Ly Link:", "Add", "", -1, -1))
        If Operators.CompareString(text, String.Empty, False) <> 0 Then
            Me.listLinks.Items.Add(text)
        End If
        If Me.listLinks.Items.Count > 0 Then
            Me.btnMain.Enabled = True
        Else
            Me.btnMain.Enabled = False
        End If
    End Sub

    Private Sub btnLinksClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLinksClear.Click
        listLinks.Items.Clear()
        btnMain.Enabled = False
    End Sub

    Private Sub btnLinksLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLinksLoad.Click
        Me.LoadTXT(Me.listLinks)
        If Me.listLinks.Items.Count > 0 Then
            Me.btnMain.Enabled = True
        Else
            Me.btnMain.Enabled = False
        End If
    End Sub

    Private Sub btnMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Try
            If Operators.CompareString(Me.btnMain.Text, "Start", False) = 0 Then
                Me.timMain.Enabled = True
                Me.lblRemain.Text = "Time Left: " + Conversions.ToString(Math.Round(Decimal.Divide(Decimal.Divide(Decimal.Multiply(New Decimal(Me.listProxy.Items.Count), Decimal.Add(Me.numWait.Value, Me.numWait2.Value)), 2D), 60D), 2)) + " Minutes"
                Dim thread = New Thread(AddressOf Me.ViewLink)
                thread.Start()
                Me.btnMain.Text = "Stop"
            Else
                Me.timMain.Enabled = False
                Me.chkLoop.Checked = False
                Me.waiting = 0
                Me.WebPreview.[Stop]()
                Me.btnMain.Text = "Start"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnProxiesClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProxiesClear.Click
        listProxy.Items.Clear()
    End Sub

    Private Sub btnProxiesLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProxiesLoad.Click
        Me.LoadTXT(Me.listProxy)
    End Sub

    Private Sub btnRem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRem.Click
        Dim items As ListBox.ObjectCollection = Me.listLinks.Items
        If Me.listLinks.SelectedIndex >= 0 Then
            items.Remove(RuntimeHelpers.GetObjectValue(Me.listLinks.SelectedItem))
        End If
        If items.Count > 0 Then
            Me.listLinks.SelectedItem = RuntimeHelpers.GetObjectValue(items(0))
        End If
        If items.Count > 0 Then
            Me.btnMain.Enabled = True
        Else
            Me.btnMain.Enabled = False
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If Operators.CompareString(Me.btnShow.Text, "8", False) = 0 Then
            size = New Size(583, 345)
            btnShow.Text = "7"
        Else
            size = New Size(363, 345)
            btnShow.Text = "8"
        End If
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            btnMain.Text = "Start"
            iconNotify.Dispose()
        Catch ex As Exception
            iconNotify.Dispose()
        End Try
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Gradient(Me.myStatus, Color.FromKnownColor(KnownColor.GradientActiveCaption), Color.FromArgb(155, 179, 204), LinearGradientMode.Vertical)
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim form As Form = CType(sender, Form)
        If form.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        Else
            Me.Show()
            Me.Gradient(Me.myStatus, Color.FromKnownColor(KnownColor.GradientActiveCaption), Color.FromArgb(155, 179, 204), LinearGradientMode.Vertical)
        End If
    End Sub

    Public Sub Gradient(ByVal aControl As StatusStrip, ByVal Color1 As Color, ByVal Color2 As Color, Optional ByVal mode As LinearGradientMode = LinearGradientMode.Vertical)
        Dim bitmap As Bitmap = New Bitmap(aControl.Width, aControl.Height)
        Dim graphics As Graphics = Graphics.FromImage(bitmap)
        Dim rect As RectangleF = New RectangleF(0.0F, 0.0F, CSng(aControl.Width), CSng(aControl.Height))
        Dim linearGradientBrush As LinearGradientBrush = New LinearGradientBrush(rect, Color1, Color2, mode)
        Dim graphics2 As Graphics = graphics
        Dim brush As Brush = linearGradientBrush
        Dim rect2 As RectangleF = New RectangleF(0.0F, 0.0F, CSng(aControl.Width), CSng(aControl.Height))
        graphics2.FillRectangle(brush, rect2)
        aControl.BackgroundImage = bitmap
        graphics.Dispose()
    End Sub

    Private Sub linkHome_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkHome.LinkClicked
        Process.Start("http://www." + Me.linkHome.Text)
    End Sub

    Private Sub LoadTXT(ByVal listBox As ListBox)
        Using openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Filter = "Text Files|*.txt"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                listBox.Items.AddRange(File.ReadAllLines(openFileDialog.FileName))
            End If
        End Using
    End Sub

    Private Sub listLinks_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listLinks.DragDrop
        Try
            Dim text As String = CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString()
            If Operators.CompareString(text, "", False) <> 0 Then
                Me.listLinks.Items.AddRange(File.ReadAllLines(text))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub listLinks_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listLinks.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub listLinks_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listLinks.MouseUp
        listLinks.DoDragDrop(Me.listLinks, DragDropEffects.Copy)
    End Sub

    Private Sub listProxy_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listProxy.DragDrop
        Try
            Dim text As String = CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString()
            If Operators.CompareString(text, "", False) <> 0 Then
                Me.listProxy.Items.AddRange(File.ReadAllLines(text))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub listProxy_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles listProxy.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub listProxy_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles listProxy.MouseUp
        Me.listProxy.DoDragDrop(Me.listProxy, DragDropEffects.Copy)
    End Sub

    Private Sub mExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mExit.Click
        Close()
    End Sub

    Private Sub mShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mShow.Click
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub NotifyIcon1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = MouseButtons.Left Then
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Show()
                Me.WindowState = FormWindowState.Normal
            Else
                Me.Hide()
                Me.WindowState = FormWindowState.Minimized
            End If
        End If
    End Sub

    Private Sub picBanner_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picBanner.Click
        MsgBox("AdFlyer v 1.1" & vbCrLf & vbCrLf & "Although it's named AdFlyer, this should work on all websites." & vbCrLf & "No, clicking Skip button is not necessary to count the visit as legit" & vbCrLf & "Thanks to KoRRuPt3ds for his Proxy source." & vbCrLf & vbCrLf & "Coder-San", MsgBoxStyle.Information, "Help")
    End Sub

    Private Sub timMain_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timMain.Tick
        If Me.waiting >= 1 Then
            Me.waiting -= 1
        Else
            Me.waiting = 0
        End If
        Me.ToolStatus.Text = "Waiting: " + Conversions.ToString(Me.waiting)
    End Sub

    Private Sub UseProxy(ByVal strProxy As String)
        Dim struct_INTERNET_PROXY_INFO As Struct_INTERNET_PROXY_INFO
        struct_INTERNET_PROXY_INFO.dwAccessType = 3
        struct_INTERNET_PROXY_INFO.proxy = Marshal.StringToHGlobalAnsi(strProxy)
        struct_INTERNET_PROXY_INFO.proxyBypass = Marshal.StringToHGlobalAnsi("local")
        Dim intPtr As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(struct_INTERNET_PROXY_INFO))
        Marshal.StructureToPtr(struct_INTERNET_PROXY_INFO, intPtr, True)
        Dim flag As Boolean = frmMain.InternetSetOption(IntPtr.Zero, 38, intPtr, Marshal.SizeOf(struct_INTERNET_PROXY_INFO))
    End Sub

    Public Structure Struct_INTERNET_PROXY_INFO
        ' Token: 0x0400002D RID: 45
        Public dwAccessType As Integer

        ' Token: 0x0400002E RID: 46
        Public proxy As IntPtr

        ' Token: 0x0400002F RID: 47
        Public proxyBypass As IntPtr
    End Structure

    Private Sub ViewLink()
        ' The following expression was wrapped in a checked-statement
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            While Operators.CompareString(Me.btnMain.Text, "Stop", False) = 0
                Do
                    Dim num As Integer = 0
                    Dim num2 As Integer = Me.listLinks.Items.Count - 1
                    For i As Integer = num To num2
                        Dim j As Integer = 0
                        If Me.listProxy.Items.Count > 0 Then
                            Dim num3 As Integer = 0
                            Dim num4 As Integer = Me.listProxy.Items.Count - 1
                            j = num3
                            While j <= num4
                                Me.listProxy.SelectedItem = RuntimeHelpers.GetObjectValue(Me.listProxy.Items(j))
                                Me.UseProxy(Conversions.ToString(Me.listProxy.SelectedItem))
                                Me.VisitLink(i, j, True)
                                If Operators.CompareString(Me.btnMain.Text, "Start", False) = 0 Then
                                    Me.WebPreview.[Stop]()
                                    Exit While
                                End If
                                j += 1
                            End While
                        End If
                        Me.VisitLink(i, j, False)
                        If Operators.CompareString(Me.btnMain.Text, "Start", False) = 0 Then
                            Me.WebPreview.[Stop]()
                            Exit For
                        End If
                    Next
                Loop While Me.chkLoop.Checked
                Me.WebPreview.[Stop]()
                Me.btnMain.Text = "Start"
                Me.timMain.Enabled = False
            End While
            Me.ToolStatus.Text = If((Operators.CompareString(Me.btnMain.Text, "Stop", False) = 0), "All Links visited", "Stopped")
        Catch ex As Exception
            Dim contents As String = DateTime.Now.ToString() + vbCrLf + ex.Message.ToString() + vbCrLf
            If Not File.Exists(FileSystem.CurDir() + "\ErrorLog.txt") Then
                File.WriteAllText(FileSystem.CurDir() + "\ErrorLog.txt", contents)
            Else
                File.AppendAllText(FileSystem.CurDir() + "\ErrorLog.txt", contents)
            End If
        End Try
    End Sub
    Private Sub VisitLink(ByVal intLink As Integer, ByVal intProxy As Integer, ByVal UseProxy As Boolean)
        If Operators.CompareString(Me.btnMain.Text, "Start", False) = 0 Then
            Return
        End If
        Me.listLinks.SelectedItem = RuntimeHelpers.GetObjectValue(Me.listLinks.Items(intLink))
        Dim webPreview As Object = Me.WebPreview
        Dim type As Type = Nothing
        Dim memberName As String = "Navigate"
        Dim array As Object() = New Object(0) {}
        Dim array2 As Object() = array
        Dim num As Integer = 0
        Dim listLinks As ListBox = Me.listLinks
        array2(num) = RuntimeHelpers.GetObjectValue(listLinks.SelectedItem)
        Dim array3 As Object() = array
        Dim arguments As Object() = array3
        Dim argumentNames As String() = Nothing
        Dim typeArguments As Type() = Nothing
        Dim array4 As Boolean() = New Boolean() {True}
        NewLateBinding.LateCall(webPreview, type, memberName, arguments, argumentNames, typeArguments, array4, True)
        If array4(0) Then
            listLinks.SelectedItem = RuntimeHelpers.GetObjectValue(array3(0))
        End If
        Me.ToolCurLink.Text = Conversions.ToString(Me.listLinks.SelectedItem)
        Me.ToolCurLink.ToolTipText = Conversions.ToString(Me.listLinks.SelectedItem)
        If UseProxy Then
            Me.grpProxy.Text = "Proxies: " + Conversions.ToString(Me.listProxy.Items.Count)
            Me.lblRemain.Text = "Time Left: " + Conversions.ToString(Math.Round(Decimal.Divide(Decimal.Multiply(New Decimal(Me.listProxy.Items.Count - intProxy + Me.listLinks.Items.Count), Decimal.Divide(Decimal.Add(Me.numWait.Value, Me.numWait2.Value), 2D)), 60D), 2)) + " Min"
        Else
            Me.grpProxy.Text = ""
            Me.lblRemain.Text = "Time Left: " + Conversions.ToString(Math.Round(Decimal.Divide(Decimal.Multiply(New Decimal(Me.listLinks.Items.Count), Decimal.Divide(Decimal.Add(Me.numWait.Value, Me.numWait2.Value), 2D)), 60D), 2)) + " Min"
        End If
        Dim random As Random = New Random()
        Me.waiting = CByte(If((Me.Browsed = 0), 15, random.[Next](Convert.ToInt32(Me.numWait.Value), Convert.ToInt32(Me.numWait2.Value))))
        Thread.Sleep(CInt(Me.waiting) * 1000)
        Me.Browsed += 1
        Me.ToolCount.Text = "Browsed: " + Conversions.ToString(Me.Browsed)
        Me.grpLinks.Text = "Links: " + Conversions.ToString(Me.listLinks.Items.Count)
    End Sub
End Class