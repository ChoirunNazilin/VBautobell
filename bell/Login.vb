Imports System.Data.SqlClient
Public Class Login
    ' Dim conn As New SqlConnection("Server = zilin-pc\sqlexpress; Database = bell; Integrated Security = true")
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim conn As New SqlConnection("Server = zilin-pc\sqlexpress; Database = bell; Integrated Security = true")
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("Select * from admin Where [user]='" & TxtUser.Text & "' and [pass]='" & TxtPass.Text & "'", conn)
        conn.Open()
        dr = cmd.ExecuteReader
        ' If the record can be queried, it means passing verification, then open another form.   
        If (dr.Read() = True) Then
            'Me.Close()
            'MenuForm.Show()
            'Dim mainForm As New MenuForm
            'mainForm.Show()
            'Me.Hide()
            Dim menuForm As New MenuUtama
            Me.Hide()
            menuForm.Show()
            TxtUser.Text = ""
            TxtPass.Text = ""


        Else
            MessageBox.Show("Username atau Password Salah")
            TxtPass.Text = ""
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
