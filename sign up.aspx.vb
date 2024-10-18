Imports System.Data.SqlClient
Partial Class sign_up
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=E:\RTO.aspx\App_Data\Database.mdf;Integrated Security=True;User Instance=True")
        If Not IsPostBack Then
            For i = 1 To 31
                DropDownList1.Items.Add(i.ToString)
            Next
            For i = 1950 To 2050
                DropDownList3.Items.Add(i.ToString)
            Next
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim G As String
        If RadioButton1.Checked = True Then
            G = "Male"
        Else
            G = "Female"
        End If
        con.Open()
        cmd = New SqlCommand("insert into reg values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "', '" + CDate(DropDownList1.Text & " / " & DropDownList2.Text & " / " & DropDownList3.Text) + "', '" + G + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "', '" + TextBox12.Text + "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Record Inserted successfully")
        con.Close()
        Response.Redirect("Login.aspx")


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""

    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Protected Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub

    Protected Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class

