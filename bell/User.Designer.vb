<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LV = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pass = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BHapus = New System.Windows.Forms.Button()
        Me.BUpdate = New System.Windows.Forms.Button()
        Me.BKembali = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(135, 65)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 26)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(135, 97)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(175, 26)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(135, 129)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(175, 26)
        Me.TextBox3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTambah
        '
        Me.BTambah.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTambah.Location = New System.Drawing.Point(326, 65)
        Me.BTambah.Name = "BTambah"
        Me.BTambah.Size = New System.Drawing.Size(88, 26)
        Me.BTambah.TabIndex = 6
        Me.BTambah.Text = "Tambah"
        Me.BTambah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LV)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 156)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data User"
        '
        'LV
        '
        Me.LV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Username, Me.pass})
        Me.LV.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(6, 30)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(401, 120)
        Me.LV.TabIndex = 8
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Username.Width = 135
        '
        'pass
        '
        Me.pass.Text = "Password"
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pass.Width = 172
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 39)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "USER MANAGEMENT"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BHapus
        '
        Me.BHapus.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHapus.Location = New System.Drawing.Point(328, 99)
        Me.BHapus.Name = "BHapus"
        Me.BHapus.Size = New System.Drawing.Size(88, 26)
        Me.BHapus.TabIndex = 10
        Me.BHapus.Text = "Hapus"
        Me.BHapus.UseVisualStyleBackColor = True
        '
        'BUpdate
        '
        Me.BUpdate.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUpdate.Location = New System.Drawing.Point(326, 129)
        Me.BUpdate.Name = "BUpdate"
        Me.BUpdate.Size = New System.Drawing.Size(88, 26)
        Me.BUpdate.TabIndex = 11
        Me.BUpdate.Text = "Update"
        Me.BUpdate.UseVisualStyleBackColor = True
        '
        'BKembali
        '
        Me.BKembali.BackColor = System.Drawing.Color.Coral
        Me.BKembali.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BKembali.Location = New System.Drawing.Point(326, 159)
        Me.BKembali.Name = "BKembali"
        Me.BKembali.Size = New System.Drawing.Size(88, 26)
        Me.BKembali.TabIndex = 12
        Me.BKembali.Text = "Kembali"
        Me.BKembali.UseVisualStyleBackColor = False
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 339)
        Me.Controls.Add(Me.BKembali)
        Me.Controls.Add(Me.BUpdate)
        Me.Controls.Add(Me.BHapus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTambah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "User"
        Me.Text = "User"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTambah As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BHapus As System.Windows.Forms.Button
    Friend WithEvents BUpdate As System.Windows.Forms.Button
    Friend WithEvents BKembali As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents pass As System.Windows.Forms.ColumnHeader
End Class
