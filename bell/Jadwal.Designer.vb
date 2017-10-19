<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jadwal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtJam = New System.Windows.Forms.TextBox()
        Me.TxtNmJadwal = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.CmbHari = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTambah = New System.Windows.Forms.Button()
        Me.BUpdate = New System.Windows.Forms.Button()
        Me.BHapus = New System.Windows.Forms.Button()
        Me.BKembali = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.CmbPilih = New System.Windows.Forms.ComboBox()
        Me.Lv1 = New System.Windows.Forms.ListView()
        Me.kode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.hari = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nama = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.jam = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ljam = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pengaturan Jadwal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtKode
        '
        Me.TxtKode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKode.Location = New System.Drawing.Point(12, 107)
        Me.TxtKode.Multiline = True
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(270, 31)
        Me.TxtKode.TabIndex = 2
        Me.TxtKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtJam
        '
        Me.TxtJam.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJam.Location = New System.Drawing.Point(308, 107)
        Me.TxtJam.Multiline = True
        Me.TxtJam.Name = "TxtJam"
        Me.TxtJam.Size = New System.Drawing.Size(266, 31)
        Me.TxtJam.TabIndex = 3
        Me.TxtJam.Text = "00:00:00"
        Me.TxtJam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNmJadwal
        '
        Me.TxtNmJadwal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNmJadwal.Location = New System.Drawing.Point(12, 227)
        Me.TxtNmJadwal.Multiline = True
        Me.TxtNmJadwal.Name = "TxtNmJadwal"
        Me.TxtNmJadwal.Size = New System.Drawing.Size(270, 68)
        Me.TxtNmJadwal.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(308, 168)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(118, 31)
        Me.TextBox5.TabIndex = 6
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmbHari
        '
        Me.CmbHari.DisplayMember = "senin"
        Me.CmbHari.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbHari.FormattingEnabled = True
        Me.CmbHari.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu"})
        Me.CmbHari.Location = New System.Drawing.Point(12, 168)
        Me.CmbHari.Name = "CmbHari"
        Me.CmbHari.Size = New System.Drawing.Size(270, 24)
        Me.CmbHari.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Kode "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(270, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hari"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nama Jadwal"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(304, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Suara"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(304, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(270, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Jam"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 31)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(499, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Test"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTambah
        '
        Me.BTambah.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTambah.Location = New System.Drawing.Point(597, 159)
        Me.BTambah.Name = "BTambah"
        Me.BTambah.Size = New System.Drawing.Size(100, 29)
        Me.BTambah.TabIndex = 16
        Me.BTambah.Text = "Tambah"
        Me.BTambah.UseVisualStyleBackColor = True
        '
        'BUpdate
        '
        Me.BUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUpdate.Location = New System.Drawing.Point(597, 194)
        Me.BUpdate.Name = "BUpdate"
        Me.BUpdate.Size = New System.Drawing.Size(100, 29)
        Me.BUpdate.TabIndex = 17
        Me.BUpdate.Text = "Update"
        Me.BUpdate.UseVisualStyleBackColor = True
        '
        'BHapus
        '
        Me.BHapus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHapus.Location = New System.Drawing.Point(597, 229)
        Me.BHapus.Name = "BHapus"
        Me.BHapus.Size = New System.Drawing.Size(100, 29)
        Me.BHapus.TabIndex = 18
        Me.BHapus.Text = "Hapus"
        Me.BHapus.UseVisualStyleBackColor = True
        '
        'BKembali
        '
        Me.BKembali.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BKembali.Location = New System.Drawing.Point(597, 264)
        Me.BKembali.Name = "BKembali"
        Me.BKembali.Size = New System.Drawing.Size(100, 29)
        Me.BKembali.TabIndex = 19
        Me.BKembali.Text = "Kembali"
        Me.BKembali.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.CmbPilih)
        Me.GroupBox1.Controls.Add(Me.Lv1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 311)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(685, 213)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Jadwal"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 27)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Pilih Hari"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(296, 25)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(151, 27)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Semua Hari"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'CmbPilih
        '
        Me.CmbPilih.FormattingEnabled = True
        Me.CmbPilih.Items.AddRange(New Object() {"Senin", "Selasa", "Rabu", "Kamis", "Jum'at", "Sabtu"})
        Me.CmbPilih.Location = New System.Drawing.Point(133, 25)
        Me.CmbPilih.Name = "CmbPilih"
        Me.CmbPilih.Size = New System.Drawing.Size(147, 27)
        Me.CmbPilih.TabIndex = 1
        '
        'Lv1
        '
        Me.Lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.kode, Me.hari, Me.nama, Me.jam})
        Me.Lv1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lv1.GridLines = True
        Me.Lv1.HoverSelection = True
        Me.Lv1.Location = New System.Drawing.Point(4, 58)
        Me.Lv1.Name = "Lv1"
        Me.Lv1.Size = New System.Drawing.Size(570, 155)
        Me.Lv1.TabIndex = 0
        Me.Lv1.UseCompatibleStateImageBehavior = False
        Me.Lv1.View = System.Windows.Forms.View.Details
        '
        'kode
        '
        Me.kode.Text = "Kode"
        Me.kode.Width = 61
        '
        'hari
        '
        Me.hari.Text = "Hari"
        Me.hari.Width = 100
        '
        'nama
        '
        Me.nama.Text = "Nama"
        Me.nama.Width = 100
        '
        'jam
        '
        Me.jam.Text = "Jam"
        Me.jam.Width = 218
        '
        'Ljam
        '
        Me.Ljam.AutoSize = True
        Me.Ljam.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ljam.Location = New System.Drawing.Point(596, 106)
        Me.Ljam.Name = "Ljam"
        Me.Ljam.Size = New System.Drawing.Size(101, 32)
        Me.Ljam.TabIndex = 21
        Me.Ljam.Text = "Label9"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.Tsada
        Me.PictureBox1.Location = New System.Drawing.Point(607, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Jadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 536)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ljam)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BKembali)
        Me.Controls.Add(Me.BHapus)
        Me.Controls.Add(Me.BUpdate)
        Me.Controls.Add(Me.BTambah)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbHari)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TxtNmJadwal)
        Me.Controls.Add(Me.TxtJam)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Jadwal"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents TxtJam As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmJadwal As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents CmbHari As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BTambah As System.Windows.Forms.Button
    Friend WithEvents BUpdate As System.Windows.Forms.Button
    Friend WithEvents BHapus As System.Windows.Forms.Button
    Friend WithEvents BKembali As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents CmbPilih As System.Windows.Forms.ComboBox
    Friend WithEvents Lv1 As System.Windows.Forms.ListView
    Friend WithEvents kode As System.Windows.Forms.ColumnHeader
    Friend WithEvents hari As System.Windows.Forms.ColumnHeader
    Friend WithEvents nama As System.Windows.Forms.ColumnHeader
    Friend WithEvents jam As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ljam As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
