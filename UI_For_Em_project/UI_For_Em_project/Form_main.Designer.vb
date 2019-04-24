<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.V_car_1 = New System.Windows.Forms.VScrollBar()
        Me.dis = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lab_v1 = New System.Windows.Forms.Label()
        Me.lab2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lab_dis = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lab_dis_2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lab_dis_2_2 = New System.Windows.Forms.Label()
        Me.lab_v1_2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lab_v2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.to_pic = New System.IO.Ports.SerialPort(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(-1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  The Meeting Car"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkRed
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(-1, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(386, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "By Group 2.7 "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(275, 91)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'V_car_1
        '
        Me.V_car_1.Location = New System.Drawing.Point(5, 41)
        Me.V_car_1.Name = "V_car_1"
        Me.V_car_1.Size = New System.Drawing.Size(21, 167)
        Me.V_car_1.TabIndex = 4
        '
        'dis
        '
        Me.dis.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dis.Location = New System.Drawing.Point(67, 163)
        Me.dis.Maximum = 14
        Me.dis.Name = "dis"
        Me.dis.Size = New System.Drawing.Size(246, 45)
        Me.dis.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(119, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ระยะทาง = 78 cm"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(30, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "รถคันที่ 1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(272, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "รถคันที่ 2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(2, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = " V1 = "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab_v1
        '
        Me.lab_v1.BackColor = System.Drawing.Color.DodgerBlue
        Me.lab_v1.Location = New System.Drawing.Point(30, 221)
        Me.lab_v1.Name = "lab_v1"
        Me.lab_v1.Size = New System.Drawing.Size(35, 19)
        Me.lab_v1.TabIndex = 10
        Me.lab_v1.Text = "4.2"
        Me.lab_v1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab2
        '
        Me.lab2.BackColor = System.Drawing.Color.DodgerBlue
        Me.lab2.Location = New System.Drawing.Point(55, 221)
        Me.lab2.Name = "lab2"
        Me.lab2.Size = New System.Drawing.Size(43, 19)
        Me.lab2.TabIndex = 11
        Me.lab2.Text = "cm / s"
        Me.lab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(119, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ระยะทางที่เจอกัน ="
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab_dis
        '
        Me.lab_dis.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lab_dis.Location = New System.Drawing.Point(212, 110)
        Me.lab_dis.Name = "lab_dis"
        Me.lab_dis.Size = New System.Drawing.Size(36, 15)
        Me.lab_dis.TabIndex = 13
        Me.lab_dis.Text = "27"
        Me.lab_dis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(241, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "cm"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(30, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 32)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "V2 = "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(64, 273)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 32)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "( 78   -         )"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab_dis_2
        '
        Me.lab_dis_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lab_dis_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_dis_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lab_dis_2.Location = New System.Drawing.Point(98, 273)
        Me.lab_dis_2.Name = "lab_dis_2"
        Me.lab_dis_2.Size = New System.Drawing.Size(23, 32)
        Me.lab_dis_2.TabIndex = 17
        Me.lab_dis_2.Text = "27"
        Me.lab_dis_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(127, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 32)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "X"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(137, 273)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 32)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "(            /             )"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab_dis_2_2
        '
        Me.lab_dis_2_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lab_dis_2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_dis_2_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lab_dis_2_2.Location = New System.Drawing.Point(189, 273)
        Me.lab_dis_2_2.Name = "lab_dis_2_2"
        Me.lab_dis_2_2.Size = New System.Drawing.Size(23, 32)
        Me.lab_dis_2_2.TabIndex = 20
        Me.lab_dis_2_2.Text = "27"
        Me.lab_dis_2_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab_v1_2
        '
        Me.lab_v1_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lab_v1_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_v1_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lab_v1_2.Location = New System.Drawing.Point(144, 273)
        Me.lab_v1_2.Name = "lab_v1_2"
        Me.lab_v1_2.Size = New System.Drawing.Size(33, 32)
        Me.lab_v1_2.TabIndex = 21
        Me.lab_v1_2.Text = "4.2"
        Me.lab_v1_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(229, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 32)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "="
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab_v2
        '
        Me.lab_v2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lab_v2.ForeColor = System.Drawing.Color.Maroon
        Me.lab_v2.Location = New System.Drawing.Point(241, 273)
        Me.lab_v2.Name = "lab_v2"
        Me.lab_v2.Size = New System.Drawing.Size(44, 32)
        Me.lab_v2.TabIndex = 23
        Me.lab_v2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(275, 273)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 32)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "cm/s"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(119, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 50)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'to_pic
        '
        Me.to_pic.PortName = "COM3"
        '
        'Form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(384, 411)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lab_v2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lab_v1_2)
        Me.Controls.Add(Me.lab_dis_2_2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lab_dis_2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lab_dis)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lab2)
        Me.Controls.Add(Me.lab_v1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dis)
        Me.Controls.Add(Me.V_car_1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_main"
        Me.Text = "GUI_FOR_Em_Project"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents V_car_1 As VScrollBar
    Friend WithEvents dis As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lab_v1 As Label
    Friend WithEvents lab2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lab_dis As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lab_dis_2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lab_dis_2_2 As Label
    Friend WithEvents lab_v1_2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lab_v2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents to_pic As IO.Ports.SerialPort
End Class
