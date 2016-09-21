Imports System.IO.Ports
Public Class H_UART
    Private recvcount As Integer '接收计数
    Private sendcount As Integer '发送计数
    Private recvdat As String '接收的数据
    Private senddat As String '发送的数据
    Private Commprote As Integer
    Private botelv As String
    Private check As Integer
    Private datbit As Integer
    Private stopbit As Double
    Private isopen As Boolean
    Private isautosend As Boolean
    Private Sub b_clearrecv_Click(sender As Object, e As EventArgs) Handles b_clearrecv.Click
        Me.t_recv.Text = " "
        Me.recvdat = ""
    End Sub

    Private Sub b_clearsend_Click(sender As Object, e As EventArgs) Handles b_clearsend.Click
        Me.t_send.Text = " "
    End Sub

    Private Sub H_UART_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isopen = False
        Commprote = -1
        Me.c_botelv.SelectedIndex = 3
        Me.c_checkbit.SelectedIndex = 0
        Me.c_stopbit.SelectedIndex = 0
        Me.c_recvshow.SelectedIndex = 0
        Me.c_sendshow.SelectedIndex = 0
        Me.c_databit.SelectedIndex = 0
        recvcount = 0
        sendcount = 0
        Me.l_sendcount.Text = sendcount
        Me.l_recvcount.Text = recvcount
        recvdat = " "
        senddat = " "
        getPortsList()
    End Sub


    Private Sub b_clearcount_Click(sender As Object, e As EventArgs) Handles b_clearcount.Click
        recvcount = 0
        sendcount = 0
    End Sub



    Private Sub b_scan_Click(sender As Object, e As EventArgs) Handles b_scan.Click
        ' Me.AxMSComm1.CommPort = Me.Commprote
        Me.c_comid.Items.Clear()
        getPortsList()
    End Sub
    Private Function Test_com(ByVal comid As String) As Boolean
        On Error GoTo Comm_Error
        ' AxMSComm1.CommPort = comid
        'AxMSComm1.PortOpen = True
        ' AxMSComm1.PortOpen = False
        Test_com = True
        Exit Function
Comm_Error:
        If Err.Number = 8002 Then
            MsgBox("串口错误，请重新选择串口", vbOKOnly, "错误提示!")
        ElseIf Err.Number = 8005 Then
            MessageBox.Show("您所选择的串口已经打开请重新选择串口号！")
        Else
            MessageBox.Show("未处理错误！")
        End If
    End Function


    Private Function prot_open() As Boolean

        If (_choose() = -1) Then
            MessageBox.Show("串口不存在")
            Return False
        End If
        Try
            Dim dat As String
            dat = Me.botelv & "," & Me.check & "," & CStr(Me.datbit) & "," & CStr(Me.stopbit)
            'Me.AxMSComm1.Settings = dat
            Me.SerialPort1 = New SerialPort(Me.c_comid.Text, Me.botelv, Me.check, Me.datbit, Me.stopbit)
            Me.SerialPort1.Open()
            'AddHandler Me.SerialPort1.DataReceived, AddressOf DataReceivedHandler
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return True
    End Function
    Private Sub prot_close()
        Try
            If Me.SerialPort1.IsOpen = True Then
                Me.SerialPort1.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub open_close()

        If isopen = True Then
            Me.b_open_close.Text = "关闭串口"
            Me.b_open_close.BackColor = Color.DarkViolet
        Else
            Me.b_open_close.Text = "打开串口"
            Me.b_open_close.BackColor = Color.Orange
        End If
    End Sub
    Private Sub getPortsList()
        Dim portlist() As String
        portlist = SerialPort.GetPortNames()

        Dim port As String
        For Each port In portlist
            Me.c_comid.Items.Add(port)
        Next
        If (portlist.Length = 0) Then
            Me.c_comid.Items.Clear()
            Me.c_comid.Text = ""
        Else
            Me.c_comid.SelectedIndex = 0
        End If
    End Sub
    Private Function _choose() As Integer
        If Me.c_comid.Text.Trim = "" Then
            MessageBox.Show("串口号为空！")
            Return -1
            Exit Function
        End If
        Me.Commprote = Val(Me.c_comid.Text.ElementAt(3))
        If (Commprote = -1) Then
            Return -1
        End If
        Me.botelv = c_botelv.Text
        Dim scheck As Integer
        scheck = c_checkbit.SelectedIndex
        Select Case scheck
            Case 0
                Me.check = System.IO.Ports.Parity.None
            Case 1
                Me.check = System.IO.Ports.Parity.Odd
            Case 2
                Me.check = System.IO.Ports.Parity.Even
        End Select
        Me.datbit = Val(c_databit.Text)
        Me.stopbit = Val(c_stopbit.Text)
        Return 1
    End Function
    Private Sub b_open_close_Click(sender As Object, e As EventArgs) Handles b_open_close.Click
        isopen = Not isopen
        If isopen = True Then
            If prot_open() = False Then
                Exit Sub
            End If
        Else
            autosendTimer.Enabled = False
            b_autosend.BackColor = Color.Orange
            isautosend = False
            prot_close()
        End If
        open_close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '数据更新定时器，所有数据将在这里更新
        Me.l_sendcount.Text = sendcount
        Me.l_recvcount.Text = recvcount
        If recvdat.Length > 1024 Then
            recvdat = String.Empty
        End If
        Me.t_sta.Text = Date.Now

        Me.t_recv.Text = recvdat
        ' senddat = Me.t_send.Text

        If Me.MSG_labe.Left <= Me.Width Then
            MSG_labe.Left = MSG_labe.Left + 1
        Else
            MSG_labe.Left = 0
        End If
    End Sub


    Private Sub send()
        Dim send_str As String
        senddat = t_send.Text
        If senddat.Length Mod 2 <> 0 Then
            senddat += "0"
        End If
        send_str = senddat  '获取字符串

        Dim hexdat() As Byte
        If c_sendshow.SelectedIndex = 0 Then
            Me.SerialPort1.Write(send_str)
            sendcount = sendcount + 1
        Else
            ReDim hexdat(send_str.Length / 2 - 1)
            Dim i As Integer
            For i = 0 To send_str.Length - 1 Step 2
                hexdat(i / 2) = Val("&H" & Mid(send_str, i + 1, 2))
            Next
            Me.SerialPort1.Write(hexdat, 0, i / 2) '要发送字节型数据
            sendcount = sendcount + 1
        End If
    End Sub
    Private Sub b_send_Click(sender As Object, e As EventArgs) Handles b_send.Click
        If Me.SerialPort1.IsOpen = True Then
            senddat = t_send.Text
            If senddat.Length Mod 2 <> 0 Then
                MessageBox.Show("输入的十六进制数不符合规则，我们将在最后一位用0补齐")
                ' senddat += "0"
                send()
            End If

        Else
            MessageBox.Show("串口未打开，请先打开串口呦！")
        End If

    End Sub

    Private Sub b_autosend_Click(sender As Object, e As EventArgs) Handles b_autosend.Click

        isautosend = Not isautosend
        If isautosend = True Then
            senddat = t_send.Text
            If senddat.Length Mod 2 <> 0 Then
                MessageBox.Show("输入的十六进制数不符合规则，我们将在最后一位用0补齐")
            End If
            autosendTimer.Interval = Me.n_autotimeval.Value
            autosendTimer.Enabled = True
            b_autosend.BackColor = Color.DarkViolet
        Else
            autosendTimer.Enabled = False
            b_autosend.BackColor = Color.Orange
        End If


    End Sub

    Private Sub autosendTimer_Tick(sender As Object, e As EventArgs) Handles autosendTimer.Tick
        If Me.SerialPort1.IsOpen = True Then
            send()
        Else
            autosendTimer.Enabled = False
            MessageBox.Show("串口未打开，请先打开串口呦！")
            b_autosend.BackColor = Color.Orange
            isautosend = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("http://nimitzdev.org")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        LinkLabel1.LinkVisited = True
        System.Diagnostics.Process.Start("https://github.com/UItraNode")
    End Sub

    '接收数据事件处理部分
    Private Sub DataRecv(ByVal serder As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Me.Invoke(New EventHandler(AddressOf DataReceivedHandler))
    End Sub

    Private Sub DataReceivedHandler(sender As Object, e As EventArgs)
        Try
            If c_recvshow.SelectedIndex = 0 Then
                If (Me.SerialPort1.BytesToRead > 0) Then
                    Me.recvdat += Me.SerialPort1.ReadExisting().ToString()
                    Me.recvcount += 1
                End If
            ElseIf c_recvshow.SelectedIndex = 1 Then
                Dim n As Integer
                n = Me.SerialPort1.BytesToRead
                If (Me.SerialPort1.BytesToRead > 0) Then
                    Dim i As Integer
                    For i = 1 To n
                        recvdat += CStr(Hex(Me.SerialPort1.ReadByte))
                    Next
                    Me.recvcount += 1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        '在此处区分,字符和数值型
    End Sub

    Private Sub l_ver_Click(sender As Object, e As EventArgs) Handles l_ver.Click

    End Sub
End Class