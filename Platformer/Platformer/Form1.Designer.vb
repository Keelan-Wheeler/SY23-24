<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.movebox = New System.Windows.Forms.TextBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.MoverControl2 = New Platformer.MoverControl()
        Me.MoverControl1 = New Platformer.MoverControl()
        Me.MoverControl3 = New Platformer.MoverControl()
        Me.MoverControl4 = New Platformer.MoverControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 20
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 20
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 20
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 20
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Platformer.My.Resources.Resources.StealBeam
        Me.PictureBox1.Location = New System.Drawing.Point(172, 284)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'picGround
        '
        Me.picGround.Image = Global.Platformer.My.Resources.Resources.shutterstock_1023002008
        Me.picGround.Location = New System.Drawing.Point(-40, 401)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(869, 50)
        Me.picGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGround.TabIndex = 1
        Me.picGround.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global.Platformer.My.Resources.Resources.download
        Me.picPlayer.Location = New System.Drawing.Point(12, 346)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(35, 49)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Platformer.My.Resources.Resources.StealBeam
        Me.PictureBox2.Location = New System.Drawing.Point(122, 124)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Platformer.My.Resources.Resources.StealBeam
        Me.PictureBox3.Location = New System.Drawing.Point(442, 160)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(160, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Platformer.My.Resources.Resources.StealBeam
        Me.PictureBox4.Location = New System.Drawing.Point(556, 284)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(160, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Platformer.My.Resources.Resources.istockphoto_1076708274_612x612
        Me.PictureBox6.Location = New System.Drawing.Point(429, 333)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(137, 39)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 7
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "restart"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Platformer.My.Resources.Resources.istockphoto_1076708274_612x612
        Me.PictureBox7.Location = New System.Drawing.Point(579, 66)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(137, 39)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 8
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "restart"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Platformer.My.Resources.Resources.istockphoto_1076708274_612x612
        Me.PictureBox8.Location = New System.Drawing.Point(38, 91)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(55, 125)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 9
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "restart"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Platformer.My.Resources.Resources._2024_native_american_one_dollar_uncirculated_coin_obverse
        Me.PictureBox5.Location = New System.Drawing.Point(485, 128)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "collect"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = Global.Platformer.My.Resources.Resources._2024_native_american_one_dollar_uncirculated_coin_obverse
        Me.PictureBox9.Location = New System.Drawing.Point(599, 228)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "collect"
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.Platformer.My.Resources.Resources._2024_native_american_one_dollar_uncirculated_coin_obverse
        Me.PictureBox10.Location = New System.Drawing.Point(668, 345)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 12
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "collect"
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = Global.Platformer.My.Resources.Resources._2024_native_american_one_dollar_uncirculated_coin_obverse
        Me.PictureBox11.Location = New System.Drawing.Point(234, 228)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 13
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "collect"
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.Platformer.My.Resources.Resources._2024_native_american_one_dollar_uncirculated_coin_obverse
        Me.PictureBox12.Location = New System.Drawing.Point(172, 55)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 14
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "collect"
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = Global.Platformer.My.Resources.Resources._2024_native_american_one_dollar_uncirculated_coin_obverse
        Me.PictureBox13.Location = New System.Drawing.Point(140, 92)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 15
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "collect"
        '
        'PictureBox14
        '
        Me.PictureBox14.Image = Global.Platformer.My.Resources.Resources._2024_native_american_one_dollar_uncirculated_coin_obverse
        Me.PictureBox14.Location = New System.Drawing.Point(349, 38)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox14.TabIndex = 16
        Me.PictureBox14.TabStop = False
        Me.PictureBox14.Tag = "collect"
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.Platformer.My.Resources.Resources._2024_native_american_one_dollar_uncirculated_coin_obverse
        Me.PictureBox15.Location = New System.Drawing.Point(59, 345)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox15.TabIndex = 17
        Me.PictureBox15.TabStop = False
        Me.PictureBox15.Tag = "collect"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(646, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 18
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = Global.Platformer.My.Resources.Resources._360_F_312815843_CdVm05kiBenU3YmChP1KRIzcblRgTQFV
        Me.PictureBox16.Location = New System.Drawing.Point(297, 91)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(150, 99)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 19
        Me.PictureBox16.TabStop = False
        Me.PictureBox16.Visible = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Image = Global.Platformer.My.Resources.Resources._76085c318d9669a732efbf9ca7cd6830
        Me.PictureBox17.Location = New System.Drawing.Point(418, 296)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 23
        Me.PictureBox17.TabStop = False
        Me.PictureBox17.Tag = "restart"
        '
        'movebox
        '
        Me.movebox.Location = New System.Drawing.Point(3, 416)
        Me.movebox.Name = "movebox"
        Me.movebox.Size = New System.Drawing.Size(100, 22)
        Me.movebox.TabIndex = 24
        Me.movebox.Text = "Click 2 Move"
        '
        'PictureBox18
        '
        Me.PictureBox18.Image = Global.Platformer.My.Resources.Resources._76085c318d9669a732efbf9ca7cd6830
        Me.PictureBox18.Location = New System.Drawing.Point(200, 243)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox18.TabIndex = 26
        Me.PictureBox18.TabStop = False
        Me.PictureBox18.Tag = "restart"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Control
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(183, 37)
        Me.ProgressBar1.TabIndex = 29
        Me.ProgressBar1.Value = 100
        '
        'PictureBox19
        '
        Me.PictureBox19.Image = Global.Platformer.My.Resources.Resources.losescreen
        Me.PictureBox19.Location = New System.Drawing.Point(297, 91)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(150, 99)
        Me.PictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox19.TabIndex = 30
        Me.PictureBox19.TabStop = False
        Me.PictureBox19.Visible = False
        '
        'MoverControl2
        '
        Me.MoverControl2.BackColor = System.Drawing.Color.Transparent
        Me.MoverControl2.interval = 500
        Me.MoverControl2.Location = New System.Drawing.Point(120, 153)
        Me.MoverControl2.Name = "MoverControl2"
        Me.MoverControl2.Size = New System.Drawing.Size(212, 83)
        Me.MoverControl2.speed = 10
        Me.MoverControl2.sprite = Me.PictureBox18
        Me.MoverControl2.TabIndex = 25
        '
        'MoverControl1
        '
        Me.MoverControl1.BackColor = System.Drawing.Color.Transparent
        Me.MoverControl1.interval = 500
        Me.MoverControl1.Location = New System.Drawing.Point(338, 206)
        Me.MoverControl1.Name = "MoverControl1"
        Me.MoverControl1.Size = New System.Drawing.Size(212, 83)
        Me.MoverControl1.speed = 10
        Me.MoverControl1.sprite = Me.PictureBox17
        Me.MoverControl1.TabIndex = 22
        '
        'MoverControl3
        '
        Me.MoverControl3.BackColor = System.Drawing.Color.Transparent
        Me.MoverControl3.interval = 500
        Me.MoverControl3.Location = New System.Drawing.Point(70, 2)
        Me.MoverControl3.Name = "MoverControl3"
        Me.MoverControl3.Size = New System.Drawing.Size(212, 83)
        Me.MoverControl3.speed = 10
        Me.MoverControl3.sprite = Me.PictureBox13
        Me.MoverControl3.TabIndex = 27
        '
        'MoverControl4
        '
        Me.MoverControl4.BackColor = System.Drawing.Color.Transparent
        Me.MoverControl4.interval = 500
        Me.MoverControl4.Location = New System.Drawing.Point(415, 38)
        Me.MoverControl4.Name = "MoverControl4"
        Me.MoverControl4.Size = New System.Drawing.Size(212, 83)
        Me.MoverControl4.speed = 10
        Me.MoverControl4.sprite = Me.PictureBox5
        Me.MoverControl4.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Health"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(596, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Coins:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(274, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 111)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Platformer.My.Resources.Resources.maxresdefault
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.MoverControl2)
        Me.Controls.Add(Me.movebox)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.MoverControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.MoverControl3)
        Me.Controls.Add(Me.MoverControl4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents MoverControl1 As MoverControl
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents movebox As TextBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents MoverControl2 As MoverControl
    Friend WithEvents MoverControl3 As MoverControl
    Friend WithEvents MoverControl4 As MoverControl
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
