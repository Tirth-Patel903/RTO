Imports System.Data.SqlClient
Partial Class forgot_password
    Inherits System.Web.UI.Page
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("update reg set password='" + TextBox2.Text + "',retypepassword='" + TextBox3.Text + "' where adhar_no='" + TextBox1.Text + "'", con)
        cmd.ExecuteNonQuery()
        MsgBox("Record update successfully")
        Response.Redirect("Login.aspx")
        con.Close()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\RTO.aspx\App_Data\Database.mdf;Integrated Security=True;User Instance=True")
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

    End Sub
End Class
