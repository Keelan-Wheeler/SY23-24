<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.idlabel = New System.Windows.Forms.Label()
        Me.pricelabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'idlabel
        '
        Me.idlabel.AutoSize = True
        Me.idlabel.Location = New System.Drawing.Point(3, 79)
        Me.idlabel.Name = "idlabel"
        Me.idlabel.Size = New System.Drawing.Size(48, 16)
        Me.idlabel.TabIndex = 1
        Me.idlabel.Text = "Label1"
        '
        'pricelabel
        '
        Me.pricelabel.AutoSize = True
        Me.pricelabel.Location = New System.Drawing.Point(52, 79)
        Me.pricelabel.Name = "pricelabel"
        Me.pricelabel.Size = New System.Drawing.Size(48, 16)
        Me.pricelabel.TabIndex = 2
        Me.pricelabel.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VendingMachine.My.Resources.Resources.water2
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ProductControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.pricelabel)
        Me.Controls.Add(Me.idlabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ProductControl"
        Me.Size = New System.Drawing.Size(98, 111)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents idlabel As Label
    Friend WithEvents pricelabel As Label
End Class
