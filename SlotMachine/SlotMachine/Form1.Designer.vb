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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.piclab1 = New System.Windows.Forms.Label()
        Me.piclab2 = New System.Windows.Forms.Label()
        Me.piclab3 = New System.Windows.Forms.Label()
        Me.doButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Reelcontrol3 = New SlotMachine.Reelcontrol()
        Me.Reelcontrol2 = New SlotMachine.Reelcontrol()
        Me.Reelcontrol1 = New SlotMachine.Reelcontrol()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.Location = New System.Drawing.Point(333, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SPIN!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'piclab1
        '
        Me.piclab1.AutoSize = True
        Me.piclab1.Location = New System.Drawing.Point(132, 301)
        Me.piclab1.Name = "piclab1"
        Me.piclab1.Size = New System.Drawing.Size(10, 16)
        Me.piclab1.TabIndex = 4
        Me.piclab1.Text = " "
        Me.piclab1.Visible = False
        '
        'piclab2
        '
        Me.piclab2.AutoSize = True
        Me.piclab2.Location = New System.Drawing.Point(375, 301)
        Me.piclab2.Name = "piclab2"
        Me.piclab2.Size = New System.Drawing.Size(10, 16)
        Me.piclab2.TabIndex = 5
        Me.piclab2.Text = " "
        Me.piclab2.Visible = False
        '
        'piclab3
        '
        Me.piclab3.AutoSize = True
        Me.piclab3.Location = New System.Drawing.Point(623, 301)
        Me.piclab3.Name = "piclab3"
        Me.piclab3.Size = New System.Drawing.Size(10, 16)
        Me.piclab3.TabIndex = 6
        Me.piclab3.Text = " "
        Me.piclab3.Visible = False
        '
        'doButton
        '
        Me.doButton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.doButton.BackgroundImage = Global.SlotMachine.My.Resources.Resources.US_one_dollar_bill__obverse__series_2009
        Me.doButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.doButton.Location = New System.Drawing.Point(555, 319)
        Me.doButton.Name = "doButton"
        Me.doButton.Size = New System.Drawing.Size(186, 87)
        Me.doButton.TabIndex = 7
        Me.doButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(132, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Spin!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(132, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Spin!"
        '
        'Reelcontrol3
        '
        Me.Reelcontrol3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Reelcontrol3.itemValue = 0
        Me.Reelcontrol3.Location = New System.Drawing.Point(561, 73)
        Me.Reelcontrol3.Name = "Reelcontrol3"
        Me.Reelcontrol3.Size = New System.Drawing.Size(201, 206)
        Me.Reelcontrol3.spinTime = 2000
        Me.Reelcontrol3.TabIndex = 3
        '
        'Reelcontrol2
        '
        Me.Reelcontrol2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Reelcontrol2.itemValue = 0
        Me.Reelcontrol2.Location = New System.Drawing.Point(299, 73)
        Me.Reelcontrol2.Name = "Reelcontrol2"
        Me.Reelcontrol2.Size = New System.Drawing.Size(201, 206)
        Me.Reelcontrol2.spinTime = 2000
        Me.Reelcontrol2.TabIndex = 2
        '
        'Reelcontrol1
        '
        Me.Reelcontrol1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Reelcontrol1.itemValue = 0
        Me.Reelcontrol1.Location = New System.Drawing.Point(37, 73)
        Me.Reelcontrol1.Name = "Reelcontrol1"
        Me.Reelcontrol1.Size = New System.Drawing.Size(201, 206)
        Me.Reelcontrol1.spinTime = 2000
        Me.Reelcontrol1.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.doButton)
        Me.Controls.Add(Me.piclab3)
        Me.Controls.Add(Me.piclab2)
        Me.Controls.Add(Me.piclab1)
        Me.Controls.Add(Me.Reelcontrol3)
        Me.Controls.Add(Me.Reelcontrol2)
        Me.Controls.Add(Me.Reelcontrol1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Reelcontrol1 As Reelcontrol
    Friend WithEvents Reelcontrol2 As Reelcontrol
    Friend WithEvents Reelcontrol3 As Reelcontrol
    Friend WithEvents piclab1 As Label
    Friend WithEvents piclab2 As Label
    Friend WithEvents piclab3 As Label
    Friend WithEvents doButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
