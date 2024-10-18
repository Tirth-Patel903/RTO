Imports System.Data.SqlClient
Partial Class contact_us_
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("insert into contact values('" + TextBox1.Text + "','" + TextBox2.Text + "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("form send successfully")
        con.Close()

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\RTO.aspx\App_Data\Database.mdf;Integrated Security=True;User Instance=True")
    End Sub
End Class
