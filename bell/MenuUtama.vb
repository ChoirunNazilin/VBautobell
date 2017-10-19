Imports System.Data.SqlClient
Public Class MenuUtama
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim conn As New SqlConnection("Server = zilin-pc\sqlexpress; Database = bell; Integrated Security = true")

    Private Sub UserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        Me.Hide()
        User.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Ljam.Text = Format(Now, "hh:mm:ss")
        TextBox1.Text = Format(Now, "dddd")

        For Each item As ListViewItem In Me.Lv.Items
            If item.SubItems(1).Text = Me.Ljam.Text Then
                My.Computer.Audio.Play(My.Resources.bell1, AudioPlayMode.Background)
                ' My.Computer.Audio.Play(AxWindowsMediaPlayer1.Name)
            End If
        Next

    End Sub

    Private Sub MenuUtama_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from jadwal where hari = '" & Format(Now, "dddd") & "' order by jam", conn)
        ds = New DataSet
        da.Fill(ds)

        'membersihkan list
        Lv.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = Lv.Items.Add(dr(2).ToString)
            lvw.SubItems.Add(dr(3).ToString)
            lvw.SubItems.Add(dr(5).ToString)
        Next
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
        Login.Close()


    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub JadwalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JadwalToolStripMenuItem.Click
        Me.Close()
        Jadwal.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Close()
        about1.Show()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub BMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMasuk.Click

        My.Computer.Audio.Play(My.Resources.bell1, AudioPlayMode.Background)
        'My.Computer.Audio.Play(System.AppDomain.CurrentDomain.BaseDirectory & "")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Const DATA_FILE_EXTENSION As String = ".mp3"
        ' Dim dlgFileDialog As New OpenFileDialog
        'With dlgFileDialog
        '.Filter = DATA_FILE_EXTENSION & _
        '" files (*" & DATA_FILE_EXTENSION & "|*" & DATA_FILE_EXTENSION
        '.FilterIndex = 1
        '.RestoreDirectory = True
        'TxtM.Text = dlgFileDialog.FilterIndex
        'If .ShowDialog() = DialogResult.OK Then
        ''Play the sound file
        'Me.AxWindowsMediaPlayer1.URL = dlgFileDialog.FileName
        'End If
        'End With
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Lv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Stop()

    End Sub
End Class
