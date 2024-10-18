Imports System.Data.SqlClient
Partial Class Login
    Inherits System.Web.UI.Page
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd = New SqlCommand("select * from reg where adhar_no='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'", con)
        dr = cmd.ExecuteReader
        If dr.Read Then
            Session("emailid") = TextBox1.Text
            Response.Redirect("Home.aspx")
        Else
            MsgBox("Login UnSuccessfull")
        End If
        con.Close()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\RTO.aspx\App_Data\Database.mdf;Integrated Security=True;User Instance=True")
    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
