Imports System.Data.SqlClient
Public Class User
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim conn As New SqlConnection("Server = zilin-pc\sqlexpress; Database = bell; Integrated Security = true")

    Private Sub BTambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTambah.Click
        Dim Insert As String = "INSERT INTO admin ([ID],[user],[pass]) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"

        ExecuteQuery(Insert)
        MessageBox.Show("selamat...berhasil..")

        ' menampilkan data
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from admin", conn)
        ds = New DataSet
        da.Fill(ds)

        TextBox3.Clear()
        TextBox1.Clear()
        TextBox2.Clear()

        'membersihkan list
        LV.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = LV.Items.Add(dr(0).ToString)
            lvw.SubItems.Add(dr(1).ToString)
            lvw.SubItems.Add(dr(2).ToString)
        Next
    End Sub
    Public Sub ExecuteQuery(ByVal query As String)
        Dim Cmd As New SqlCommand(query, conn)
        conn.Open()
        Cmd.ExecuteNonQuery()
        conn.Close()


    End Sub

    Private Sub User_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from admin", conn)
        ds = New DataSet
        da.Fill(ds)

        'membersihkan list
        LV.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = LV.Items.Add(dr(0).ToString)
            lvw.SubItems.Add(dr(1).ToString)
            lvw.SubItems.Add(dr(2).ToString)
        Next
    End Sub

    Private Sub BUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BUpdate.Click
        Dim Update As String = "Update admin SET [user] = '" & TextBox2.Text & "',[pass] ='" & TextBox3.Text & "' WHERE [ID] = " & TextBox1.Text & ""
        ExecuteQuery(Update)
        MessageBox.Show("Yeeess")

        ' menampilkan data
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from admin", conn)
        ds = New DataSet
        da.Fill(ds)

        TextBox3.Clear()
        TextBox1.Clear()
        TextBox2.Clear()

        'membersihkan list
        LV.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = LV.Items.Add(dr(0).ToString)
            lvw.SubItems.Add(dr(1).ToString)
            lvw.SubItems.Add(dr(2).ToString)
        Next
    End Sub

    Private Sub BHapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BHapus.Click
        Dim Delete As String = "DELETE FROM admin WHERE [ID] = " & TextBox1.Text
        ExecuteQuery(Delete)
        MessageBox.Show("Iyyaaak")

        ' menampilkan data
        Dim dr As DataRow
        da = New SqlDataAdapter("Select * from admin", conn)
        ds = New DataSet
        da.Fill(ds)

        TextBox3.Clear()
        TextBox1.Clear()
        TextBox2.Clear()

        'membersihkan list
        LV.Items.Clear()

        'menambahkan list dari database ke listview
        For Each dr In ds.Tables(0).Rows
            Dim lvw As ListViewItem
            lvw = LV.Items.Add(dr(0).ToString)
            lvw.SubItems.Add(dr(1).ToString)
            lvw.SubItems.Add(dr(2).ToString)
        Next
    End Sub

    Private Sub BKembali_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BKembali.Click
        Me.Close()
        MenuUtama.Show 
    End Sub
End Class