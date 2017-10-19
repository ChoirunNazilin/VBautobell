Imports System.Data.SqlClient
Public Class Jadwal
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim conn As New SqlConnection("Server = zilin-pc\sqlexpress; Database = bell; Integrated Security = true")

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub BTambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTambah.Click
        Dim Tambah As String = "INSERT INTO jadwal ([kode],[hari],[nama],[jam]) VALUES('" & TxtKode.Text & "','" & CmbHari.Text & "','" & TxtNmJadwal.Text & "','" & TxtJam.Text & "')"

        ExecuteQuery(Tambah)
        MessageBox.Show("selamat...berhasil..")

        ' menampilkan data
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from jadwal", conn)
        ds = New DataSet
        da.Fill(ds)

        TxtKode.Clear()
        TxtNmJadwal .Clear()
        TxtJam.Text = "00:00:00"



        'membersihkan list
        Lv1.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = Lv1.Items.Add(dr(0).ToString)
            lvw.SubItems.Add(dr(1).ToString)
            lvw.SubItems.Add(dr(2).ToString)
            lvw.SubItems.Add(dr(3).ToString)
            lvw.SubItems.Add(dr(4).ToString)
        Next
    End Sub
    Public Sub ExecuteQuery(ByVal query As String)
        Dim Cmd As New SqlCommand(query, conn)
        conn.Open()
        Cmd.ExecuteNonQuery()
        conn.Close()


    End Sub

    Private Sub Jadwal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from jadwal", conn)
        ds = New DataSet
        da.Fill(ds)

        'membersihkan list
        Lv1.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = Lv1.Items.Add(dr(0).ToString)
            lvw.SubItems.Add(dr(1).ToString)
            lvw.SubItems.Add(dr(2).ToString)
            lvw.SubItems.Add(dr(3).ToString)
            lvw.SubItems.Add(dr(4).ToString)
        Next
    End Sub

    Private Sub BKembali_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BKembali.Click
        Me.Close()
        MenuUtama.Show()

    End Sub

    Private Sub BUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BUpdate.Click
        Dim Update As String = "Update jadwal SET [hari] = '" & CmbHari.Text & "',[nama] ='" & TxtNmJadwal.Text & "',[jam] ='" & TxtJam.Text & "' WHERE [kode] = " & TxtKode.Text & ""
        ExecuteQuery(Update)
        MessageBox.Show("Yeeess")

        ' menampilkan data
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from jadwal", conn)
        ds = New DataSet
        da.Fill(ds)

        TxtKode.Clear()
        TxtNmJadwal.Clear()
        TxtJam.Text = "00:00:00"


        'membersihkan list
        Lv1.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = Lv1.Items.Add(dr(0).ToString)
            lvw.SubItems.Add(dr(1).ToString)
            lvw.SubItems.Add(dr(2).ToString)
            lvw.SubItems.Add(dr(3).ToString)
            lvw.SubItems.Add(dr(4).ToString)
        Next
    End Sub

    Private Sub BHapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BHapus.Click
        Dim Delete As String = "DELETE FROM jadwal WHERE [kode] = " & TxtKode.Text
        ExecuteQuery(Delete)
        MessageBox.Show("Iyyaaak...")


        ' menampilkan data
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from jadwal", conn)
        ds = New DataSet
        da.Fill(ds)

        TxtKode.Clear()
        TxtNmJadwal.Clear()
        TxtJam.Text = "00:00:00"


        'membersihkan list
        Lv1.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = Lv1.Items.Add(dr(0).ToString)
            lvw.SubItems.Add(dr(1).ToString)
            lvw.SubItems.Add(dr(2).ToString)
            lvw.SubItems.Add(dr(3).ToString)
            lvw.SubItems.Add(dr(4).ToString)
        Next

    End Sub

    Private Sub CmbPilih_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPilih.SelectedIndexChanged
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from jadwal where hari='" & CmbPilih.Text & "'", conn)
        ds = New DataSet
        da.Fill(ds)

        'membersihkan list
        Lv1.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = Lv1.Items.Add(dr(0).ToString)
            lvw.SubItems.Add(dr(1).ToString)
            lvw.SubItems.Add(dr(2).ToString)
            lvw.SubItems.Add(dr(3).ToString)
            lvw.SubItems.Add(dr(4).ToString)
        Next
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Ljam.Text = Format(Now, "hh:mm:ss")

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from jadwal", conn)
        ds = New DataSet
        da.Fill(ds)

        'membersihkan list
        Lv1.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = Lv1.Items.Add(dr(0).ToString)
            lvw.SubItems.Add(dr(1).ToString)
            lvw.SubItems.Add(dr(2).ToString)
            lvw.SubItems.Add(dr(3).ToString)
            lvw.SubItems.Add(dr(4).ToString)
        Next
    End Sub
End Class