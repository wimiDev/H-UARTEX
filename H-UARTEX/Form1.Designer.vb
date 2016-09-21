<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class H_UART
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(H_UART))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.t_com = New System.Windows.Forms.TabPage()
        Me.l_databitname = New System.Windows.Forms.Label()
        Me.c_databit = New System.Windows.Forms.ComboBox()
        Me.b_scan = New System.Windows.Forms.Button()
        Me.b_open_close = New System.Windows.Forms.Button()
        Me.l_recvcount = New System.Windows.Forms.Label()
        Me.l_sendcount = New System.Windows.Forms.Label()
        Me.b_clearcount = New System.Windows.Forms.Button()
        Me.l_recvcountn = New System.Windows.Forms.Label()
        Me.l_sendcountn = New System.Windows.Forms.Label()
        Me.l_stopbit = New System.Windows.Forms.Label()
        Me.c_stopbit = New System.Windows.Forms.ComboBox()
        Me.l_checkbit = New System.Windows.Forms.Label()
        Me.l_botelv = New System.Windows.Forms.Label()
        Me.l_comid = New System.Windows.Forms.Label()
        Me.c_checkbit = New System.Windows.Forms.ComboBox()
        Me.c_botelv = New System.Windows.Forms.ComboBox()
        Me.c_comid = New System.Windows.Forms.ComboBox()
        Me.l_sendname = New System.Windows.Forms.Label()
        Me.l_recvname = New System.Windows.Forms.Label()
        Me.n_autotimeval = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b_clearsend = New System.Windows.Forms.Button()
        Me.c_sendshow = New System.Windows.Forms.ComboBox()
        Me.b_send = New System.Windows.Forms.Button()
        Me.b_autosend = New System.Windows.Forms.Button()
        Me.c_recvshow = New System.Windows.Forms.ComboBox()
        Me.b_clearrecv = New System.Windows.Forms.Button()
        Me.t_send = New System.Windows.Forms.TextBox()
        Me.t_recv = New System.Windows.Forms.TextBox()
        Me.t_about = New System.Windows.Forms.TabPage()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.l_ver = New System.Windows.Forms.Label()
        Me.AppName = New System.Windows.Forms.Label()
        Me.MSG_labe = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.t_sta = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.autosendTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.t_com.SuspendLayout()
        CType(Me.n_autotimeval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.t_about.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.t_com)
        Me.TabControl1.Controls.Add(Me.t_about)
        Me.TabControl1.Location = New System.Drawing.Point(0, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(701, 460)
        Me.TabControl1.TabIndex = 0
        '
        't_com
        '
        Me.t_com.BackColor = System.Drawing.Color.Green
        Me.t_com.Controls.Add(Me.l_databitname)
        Me.t_com.Controls.Add(Me.c_databit)
        Me.t_com.Controls.Add(Me.b_scan)
        Me.t_com.Controls.Add(Me.b_open_close)
        Me.t_com.Controls.Add(Me.l_recvcount)
        Me.t_com.Controls.Add(Me.l_sendcount)
        Me.t_com.Controls.Add(Me.b_clearcount)
        Me.t_com.Controls.Add(Me.l_recvcountn)
        Me.t_com.Controls.Add(Me.l_sendcountn)
        Me.t_com.Controls.Add(Me.l_stopbit)
        Me.t_com.Controls.Add(Me.c_stopbit)
        Me.t_com.Controls.Add(Me.l_checkbit)
        Me.t_com.Controls.Add(Me.l_botelv)
        Me.t_com.Controls.Add(Me.l_comid)
        Me.t_com.Controls.Add(Me.c_checkbit)
        Me.t_com.Controls.Add(Me.c_botelv)
        Me.t_com.Controls.Add(Me.c_comid)
        Me.t_com.Controls.Add(Me.l_sendname)
        Me.t_com.Controls.Add(Me.l_recvname)
        Me.t_com.Controls.Add(Me.n_autotimeval)
        Me.t_com.Controls.Add(Me.Label1)
        Me.t_com.Controls.Add(Me.b_clearsend)
        Me.t_com.Controls.Add(Me.c_sendshow)
        Me.t_com.Controls.Add(Me.b_send)
        Me.t_com.Controls.Add(Me.b_autosend)
        Me.t_com.Controls.Add(Me.c_recvshow)
        Me.t_com.Controls.Add(Me.b_clearrecv)
        Me.t_com.Controls.Add(Me.t_send)
        Me.t_com.Controls.Add(Me.t_recv)
        Me.t_com.Location = New System.Drawing.Point(4, 28)
        Me.t_com.Name = "t_com"
        Me.t_com.Padding = New System.Windows.Forms.Padding(3)
        Me.t_com.Size = New System.Drawing.Size(693, 428)
        Me.t_com.TabIndex = 0
        Me.t_com.Text = "串口调试窗口"
        '
        'l_databitname
        '
        Me.l_databitname.AutoSize = True
        Me.l_databitname.Location = New System.Drawing.Point(477, 39)
        Me.l_databitname.Name = "l_databitname"
        Me.l_databitname.Size = New System.Drawing.Size(51, 19)
        Me.l_databitname.TabIndex = 38
        Me.l_databitname.Text = "数据位"
        '
        'c_databit
        '
        Me.c_databit.BackColor = System.Drawing.Color.DarkViolet
        Me.c_databit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.c_databit.FormattingEnabled = True
        Me.c_databit.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.c_databit.Location = New System.Drawing.Point(538, 36)
        Me.c_databit.Name = "c_databit"
        Me.c_databit.Size = New System.Drawing.Size(121, 27)
        Me.c_databit.TabIndex = 37
        '
        'b_scan
        '
        Me.b_scan.BackColor = System.Drawing.Color.Orange
        Me.b_scan.Location = New System.Drawing.Point(340, 34)
        Me.b_scan.Name = "b_scan"
        Me.b_scan.Size = New System.Drawing.Size(121, 29)
        Me.b_scan.TabIndex = 36
        Me.b_scan.Text = "扫描"
        Me.b_scan.UseVisualStyleBackColor = False
        '
        'b_open_close
        '
        Me.b_open_close.BackColor = System.Drawing.Color.Orange
        Me.b_open_close.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.b_open_close.Location = New System.Drawing.Point(487, 228)
        Me.b_open_close.Name = "b_open_close"
        Me.b_open_close.Size = New System.Drawing.Size(75, 32)
        Me.b_open_close.TabIndex = 35
        Me.b_open_close.Text = "打开串口"
        Me.b_open_close.UseVisualStyleBackColor = False
        '
        'l_recvcount
        '
        Me.l_recvcount.AutoSize = True
        Me.l_recvcount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l_recvcount.Location = New System.Drawing.Point(580, 197)
        Me.l_recvcount.Name = "l_recvcount"
        Me.l_recvcount.Size = New System.Drawing.Size(18, 19)
        Me.l_recvcount.TabIndex = 34
        Me.l_recvcount.Text = "0"
        '
        'l_sendcount
        '
        Me.l_sendcount.AutoSize = True
        Me.l_sendcount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l_sendcount.Location = New System.Drawing.Point(579, 159)
        Me.l_sendcount.Name = "l_sendcount"
        Me.l_sendcount.Size = New System.Drawing.Size(18, 19)
        Me.l_sendcount.TabIndex = 33
        Me.l_sendcount.Text = "0"
        '
        'b_clearcount
        '
        Me.b_clearcount.BackColor = System.Drawing.Color.Orange
        Me.b_clearcount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.b_clearcount.Location = New System.Drawing.Point(589, 228)
        Me.b_clearcount.Name = "b_clearcount"
        Me.b_clearcount.Size = New System.Drawing.Size(75, 34)
        Me.b_clearcount.TabIndex = 32
        Me.b_clearcount.Text = "清除计数"
        Me.b_clearcount.UseVisualStyleBackColor = False
        '
        'l_recvcountn
        '
        Me.l_recvcountn.AutoSize = True
        Me.l_recvcountn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l_recvcountn.Location = New System.Drawing.Point(497, 196)
        Me.l_recvcountn.Name = "l_recvcountn"
        Me.l_recvcountn.Size = New System.Drawing.Size(65, 19)
        Me.l_recvcountn.TabIndex = 31
        Me.l_recvcountn.Text = "接收计数"
        '
        'l_sendcountn
        '
        Me.l_sendcountn.AutoSize = True
        Me.l_sendcountn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l_sendcountn.Location = New System.Drawing.Point(497, 158)
        Me.l_sendcountn.Name = "l_sendcountn"
        Me.l_sendcountn.Size = New System.Drawing.Size(65, 19)
        Me.l_sendcountn.TabIndex = 30
        Me.l_sendcountn.Text = "发送计数"
        '
        'l_stopbit
        '
        Me.l_stopbit.AutoSize = True
        Me.l_stopbit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l_stopbit.Location = New System.Drawing.Point(477, 97)
        Me.l_stopbit.Name = "l_stopbit"
        Me.l_stopbit.Size = New System.Drawing.Size(51, 19)
        Me.l_stopbit.TabIndex = 29
        Me.l_stopbit.Text = "停止位"
        '
        'c_stopbit
        '
        Me.c_stopbit.BackColor = System.Drawing.Color.DarkViolet
        Me.c_stopbit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.c_stopbit.FormattingEnabled = True
        Me.c_stopbit.Items.AddRange(New Object() {"1", "1.5"})
        Me.c_stopbit.Location = New System.Drawing.Point(538, 94)
        Me.c_stopbit.Name = "c_stopbit"
        Me.c_stopbit.Size = New System.Drawing.Size(121, 27)
        Me.c_stopbit.TabIndex = 28
        '
        'l_checkbit
        '
        Me.l_checkbit.AutoSize = True
        Me.l_checkbit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l_checkbit.Location = New System.Drawing.Point(285, 217)
        Me.l_checkbit.Name = "l_checkbit"
        Me.l_checkbit.Size = New System.Drawing.Size(51, 19)
        Me.l_checkbit.TabIndex = 27
        Me.l_checkbit.Text = "校验位"
        '
        'l_botelv
        '
        Me.l_botelv.AutoSize = True
        Me.l_botelv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l_botelv.Location = New System.Drawing.Point(283, 158)
        Me.l_botelv.Name = "l_botelv"
        Me.l_botelv.Size = New System.Drawing.Size(51, 19)
        Me.l_botelv.TabIndex = 26
        Me.l_botelv.Text = "波特率"
        '
        'l_comid
        '
        Me.l_comid.AutoSize = True
        Me.l_comid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l_comid.Location = New System.Drawing.Point(283, 97)
        Me.l_comid.Name = "l_comid"
        Me.l_comid.Size = New System.Drawing.Size(51, 19)
        Me.l_comid.TabIndex = 25
        Me.l_comid.Text = "串口号"
        '
        'c_checkbit
        '
        Me.c_checkbit.BackColor = System.Drawing.Color.DarkViolet
        Me.c_checkbit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.c_checkbit.FormattingEnabled = True
        Me.c_checkbit.Items.AddRange(New Object() {"None", "奇校验", "偶检验"})
        Me.c_checkbit.Location = New System.Drawing.Point(340, 214)
        Me.c_checkbit.Name = "c_checkbit"
        Me.c_checkbit.Size = New System.Drawing.Size(121, 27)
        Me.c_checkbit.TabIndex = 24
        '
        'c_botelv
        '
        Me.c_botelv.BackColor = System.Drawing.Color.DarkViolet
        Me.c_botelv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.c_botelv.FormattingEnabled = True
        Me.c_botelv.Items.AddRange(New Object() {"28800", "19200", "14400", "9600", "4800", "2400", "1200", "600"})
        Me.c_botelv.Location = New System.Drawing.Point(340, 155)
        Me.c_botelv.Name = "c_botelv"
        Me.c_botelv.Size = New System.Drawing.Size(121, 27)
        Me.c_botelv.TabIndex = 23
        '
        'c_comid
        '
        Me.c_comid.BackColor = System.Drawing.Color.DarkViolet
        Me.c_comid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.c_comid.FormattingEnabled = True
        Me.c_comid.Location = New System.Drawing.Point(340, 94)
        Me.c_comid.Name = "c_comid"
        Me.c_comid.Size = New System.Drawing.Size(121, 27)
        Me.c_comid.TabIndex = 22
        '
        'l_sendname
        '
        Me.l_sendname.AutoSize = True
        Me.l_sendname.Location = New System.Drawing.Point(313, 256)
        Me.l_sendname.Name = "l_sendname"
        Me.l_sendname.Size = New System.Drawing.Size(93, 19)
        Me.l_sendname.TabIndex = 11
        Me.l_sendname.Text = "发送数据区："
        '
        'l_recvname
        '
        Me.l_recvname.AutoSize = True
        Me.l_recvname.Location = New System.Drawing.Point(16, 86)
        Me.l_recvname.Name = "l_recvname"
        Me.l_recvname.Size = New System.Drawing.Size(93, 19)
        Me.l_recvname.TabIndex = 10
        Me.l_recvname.Text = "数据接收区："
        '
        'n_autotimeval
        '
        Me.n_autotimeval.BackColor = System.Drawing.Color.DarkViolet
        Me.n_autotimeval.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.n_autotimeval.Location = New System.Drawing.Point(564, 384)
        Me.n_autotimeval.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.n_autotimeval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.n_autotimeval.Name = "n_autotimeval"
        Me.n_autotimeval.Size = New System.Drawing.Size(100, 26)
        Me.n_autotimeval.TabIndex = 9
        Me.n_autotimeval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(455, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "自动发送周期："
        '
        'b_clearsend
        '
        Me.b_clearsend.BackColor = System.Drawing.Color.Orange
        Me.b_clearsend.Location = New System.Drawing.Point(308, 382)
        Me.b_clearsend.Name = "b_clearsend"
        Me.b_clearsend.Size = New System.Drawing.Size(107, 36)
        Me.b_clearsend.TabIndex = 7
        Me.b_clearsend.Text = "清空发送区"
        Me.b_clearsend.UseVisualStyleBackColor = False
        '
        'c_sendshow
        '
        Me.c_sendshow.BackColor = System.Drawing.Color.DarkViolet
        Me.c_sendshow.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.c_sendshow.FormattingEnabled = True
        Me.c_sendshow.Items.AddRange(New Object() {"字符显示", "十六进制显示"})
        Me.c_sendshow.Location = New System.Drawing.Point(308, 344)
        Me.c_sendshow.Name = "c_sendshow"
        Me.c_sendshow.Size = New System.Drawing.Size(107, 27)
        Me.c_sendshow.TabIndex = 6
        '
        'b_send
        '
        Me.b_send.BackColor = System.Drawing.Color.Orange
        Me.b_send.Location = New System.Drawing.Point(583, 337)
        Me.b_send.Name = "b_send"
        Me.b_send.Size = New System.Drawing.Size(81, 34)
        Me.b_send.TabIndex = 5
        Me.b_send.Text = "发送"
        Me.b_send.UseVisualStyleBackColor = False
        '
        'b_autosend
        '
        Me.b_autosend.BackColor = System.Drawing.Color.Orange
        Me.b_autosend.Location = New System.Drawing.Point(446, 337)
        Me.b_autosend.Name = "b_autosend"
        Me.b_autosend.Size = New System.Drawing.Size(99, 34)
        Me.b_autosend.TabIndex = 4
        Me.b_autosend.Text = "自动发送"
        Me.b_autosend.UseVisualStyleBackColor = False
        '
        'c_recvshow
        '
        Me.c_recvshow.BackColor = System.Drawing.Color.DarkViolet
        Me.c_recvshow.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.c_recvshow.FormattingEnabled = True
        Me.c_recvshow.Items.AddRange(New Object() {"字符显示", "十六进制显示"})
        Me.c_recvshow.Location = New System.Drawing.Point(156, 382)
        Me.c_recvshow.Name = "c_recvshow"
        Me.c_recvshow.Size = New System.Drawing.Size(104, 27)
        Me.c_recvshow.TabIndex = 3
        '
        'b_clearrecv
        '
        Me.b_clearrecv.BackColor = System.Drawing.Color.Orange
        Me.b_clearrecv.Location = New System.Drawing.Point(20, 375)
        Me.b_clearrecv.Name = "b_clearrecv"
        Me.b_clearrecv.Size = New System.Drawing.Size(117, 38)
        Me.b_clearrecv.TabIndex = 2
        Me.b_clearrecv.Text = "清空接收区"
        Me.b_clearrecv.UseVisualStyleBackColor = False
        '
        't_send
        '
        Me.t_send.BackColor = System.Drawing.Color.Green
        Me.t_send.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.t_send.Location = New System.Drawing.Point(308, 278)
        Me.t_send.Multiline = True
        Me.t_send.Name = "t_send"
        Me.t_send.Size = New System.Drawing.Size(356, 46)
        Me.t_send.TabIndex = 1
        '
        't_recv
        '
        Me.t_recv.BackColor = System.Drawing.Color.Green
        Me.t_recv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.t_recv.Location = New System.Drawing.Point(20, 108)
        Me.t_recv.Multiline = True
        Me.t_recv.Name = "t_recv"
        Me.t_recv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.t_recv.Size = New System.Drawing.Size(240, 254)
        Me.t_recv.TabIndex = 0
        '
        't_about
        '
        Me.t_about.BackColor = System.Drawing.Color.Green
        Me.t_about.Controls.Add(Me.LinkLabel2)
        Me.t_about.Controls.Add(Me.LinkLabel1)
        Me.t_about.Controls.Add(Me.Label2)
        Me.t_about.Controls.Add(Me.l_ver)
        Me.t_about.Controls.Add(Me.AppName)
        Me.t_about.Location = New System.Drawing.Point(4, 28)
        Me.t_about.Name = "t_about"
        Me.t_about.Padding = New System.Windows.Forms.Padding(3)
        Me.t_about.Size = New System.Drawing.Size(693, 428)
        Me.t_about.TabIndex = 1
        Me.t_about.Text = "About"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(394, 310)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(60, 19)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "GitHub"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(217, 355)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(232, 19)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "特别感谢：nimitzdev给予技术支持"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(257, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "author:  wimiDEV"
        '
        'l_ver
        '
        Me.l_ver.AutoSize = True
        Me.l_ver.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l_ver.Location = New System.Drawing.Point(256, 254)
        Me.l_ver.Name = "l_ver"
        Me.l_ver.Size = New System.Drawing.Size(163, 19)
        Me.l_ver.TabIndex = 4
        Me.l_ver.Text = "ver:   0.0.2.3    2015/7"
        '
        'AppName
        '
        Me.AppName.AutoSize = True
        Me.AppName.Font = New System.Drawing.Font("Microsoft NeoGothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AppName.Location = New System.Drawing.Point(148, 106)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(396, 128)
        Me.AppName.TabIndex = 3
        Me.AppName.Text = "H-UART"
        '
        'MSG_labe
        '
        Me.MSG_labe.AutoSize = True
        Me.MSG_labe.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MSG_labe.ForeColor = System.Drawing.Color.ForestGreen
        Me.MSG_labe.Location = New System.Drawing.Point(-1, 13)
        Me.MSG_labe.Name = "MSG_labe"
        Me.MSG_labe.Size = New System.Drawing.Size(181, 27)
        Me.MSG_labe.TabIndex = 3
        Me.MSG_labe.Text = "欢迎使用  H-UART"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.t_sta})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 520)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(701, 25)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        't_sta
        '
        Me.t_sta.BackColor = System.Drawing.SystemColors.HotTrack
        Me.t_sta.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.t_sta.Name = "t_sta"
        Me.t_sta.Size = New System.Drawing.Size(119, 20)
        Me.t_sta.Text = "欢迎使用H-UART"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'SerialPort1
        '
        '
        'autosendTimer
        '
        '
        'H_UART
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(701, 545)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MSG_labe)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "H_UART"
        Me.Text = "H-UART"
        Me.TabControl1.ResumeLayout(False)
        Me.t_com.ResumeLayout(False)
        Me.t_com.PerformLayout()
        CType(Me.n_autotimeval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.t_about.ResumeLayout(False)
        Me.t_about.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents t_com As System.Windows.Forms.TabPage
    Friend WithEvents t_send As System.Windows.Forms.TextBox
    Friend WithEvents t_recv As System.Windows.Forms.TextBox
    Friend WithEvents t_about As System.Windows.Forms.TabPage
    Friend WithEvents c_recvshow As System.Windows.Forms.ComboBox
    Friend WithEvents b_clearrecv As System.Windows.Forms.Button
    Friend WithEvents c_sendshow As System.Windows.Forms.ComboBox
    Friend WithEvents b_send As System.Windows.Forms.Button
    Friend WithEvents b_autosend As System.Windows.Forms.Button
    Friend WithEvents l_sendname As System.Windows.Forms.Label
    Friend WithEvents l_recvname As System.Windows.Forms.Label
    Friend WithEvents n_autotimeval As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b_clearsend As System.Windows.Forms.Button
    Friend WithEvents b_open_close As System.Windows.Forms.Button
    Friend WithEvents l_recvcount As System.Windows.Forms.Label
    Friend WithEvents l_sendcount As System.Windows.Forms.Label
    Friend WithEvents b_clearcount As System.Windows.Forms.Button
    Friend WithEvents l_recvcountn As System.Windows.Forms.Label
    Friend WithEvents l_sendcountn As System.Windows.Forms.Label
    Friend WithEvents l_stopbit As System.Windows.Forms.Label
    Friend WithEvents c_stopbit As System.Windows.Forms.ComboBox
    Friend WithEvents l_checkbit As System.Windows.Forms.Label
    Friend WithEvents l_botelv As System.Windows.Forms.Label
    Friend WithEvents l_comid As System.Windows.Forms.Label
    Friend WithEvents c_checkbit As System.Windows.Forms.ComboBox
    Friend WithEvents c_botelv As System.Windows.Forms.ComboBox
    Friend WithEvents c_comid As System.Windows.Forms.ComboBox
    Friend WithEvents MSG_labe As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents l_ver As System.Windows.Forms.Label
    Friend WithEvents AppName As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents t_sta As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents b_scan As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents c_databit As System.Windows.Forms.ComboBox
    Friend WithEvents l_databitname As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents autosendTimer As System.Windows.Forms.Timer
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
End Class
