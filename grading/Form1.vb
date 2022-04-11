Imports MySql.Data.MySqlClient

Public Class Form1

    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM aweil WHERE grade_id=" & id & ""
            cmd.ExecuteNonQuery()


            disp_data()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE aweil SET mathematics='" + TextBox1.Text + "',english='" + TextBox2.Text + "',biology='" + TextBox3.Text + "',physics='" + TextBox4.Text + "',cre='" + TextBox5.Text + "',chemistry='" + TextBox6.Text + "',commerce='" + TextBox7.Text + "',agriculture='" + TextBox8.Text + "',history='" + TextBox9.Text + "',geography='" + TextBox10.Text + "',maths='" + TextBox11.Text + "',eng='" + TextBox12.Text + "',bio='" + TextBox13.Text + "',phys='" + TextBox15.Text + "',c_r_e='" + TextBox16.Text + "',chem='" + TextBox17.Text + "',comm='" + TextBox18.Text + "',agric='" + TextBox19.Text + "',hist='" + TextBox20.Text + "',geo='" + TextBox21.Text + "',total_marks='" + TextBox22.Text + "',average='" + TextBox23.Text + "',student_name='" + TextBox24.Text + "',index_no='" + TextBox25.Text + "' WHERE grade_id=" & id & ""
            cmd.ExecuteNonQuery()


            disp_data()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "INSERT INTO grading.aweil(mathematics,english,biology,physics,cre,chemistry,commerce,agriculture,history,geography,maths,eng,bio,phys,c_r_e,chem,comm,agric,hist,geo,total_marks,average,student_name,index_no) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox15.Text + "','" + TextBox16.Text + "','" + TextBox17.Text + "','" + TextBox18.Text + "','" + TextBox19.Text + "','" + TextBox20.Text + "','" + TextBox21.Text + "','" + TextBox22.Text + "','" + TextBox23.Text + "','" + TextBox25.Text + "','" + TextBox24.Text + "')"
        cmd.ExecuteNonQuery()

        disp_data()
        MessageBox.Show("Marks Added Successfully")

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
        TextBox13.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox25.Text = ""

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        TextBox22.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text) + Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text)

        TextBox23.Text = Val(TextBox22.Text) / 10

        Try

            If CDbl(TextBox1.Text) >= 90 Then
                TextBox11.Text = "D1"
            ElseIf (TextBox1.Text) >= 80 Then
                TextBox11.Text = "D2"
            ElseIf (TextBox1.Text) >= 70 Then
                TextBox11.Text = "C3"
            ElseIf (TextBox1.Text) >= 60 Then
                TextBox11.Text = "C4"
            ElseIf (TextBox1.Text) >= 50 Then
                TextBox11.Text = "Pass"
            ElseIf (TextBox1.Text) <= 49 Then
                TextBox11.Text = "F9"
            End If

            If CDbl(TextBox2.Text) >= 90 Then
                TextBox12.Text = "D1"
            ElseIf (TextBox2.Text) >= 80 Then
                TextBox12.Text = "D2"
            ElseIf (TextBox2.Text) >= 70 Then
                TextBox12.Text = "C3"
            ElseIf (TextBox2.Text) >= 60 Then
                TextBox12.Text = "C4"
            ElseIf (TextBox2.Text) >= 50 Then
                TextBox12.Text = "Pass"
            ElseIf (TextBox2.Text) <= 49 Then
                TextBox12.Text = "F9"
            End If

            If CDbl(TextBox3.Text) >= 90 Then
                TextBox13.Text = "D1"
            ElseIf (TextBox3.Text) >= 80 Then
                TextBox13.Text = "D2"
            ElseIf (TextBox3.Text) >= 70 Then
                TextBox13.Text = "C3"
            ElseIf (TextBox3.Text) >= 60 Then
                TextBox13.Text = "C4"
            ElseIf (TextBox3.Text) >= 50 Then
                TextBox13.Text = "Pass"
            ElseIf (TextBox3.Text) <= 49 Then
                TextBox13.Text = "F9"
            End If
            If CDbl(TextBox4.Text) >= 90 Then
                TextBox15.Text = "D1"
            ElseIf (TextBox4.Text) >= 80 Then
                TextBox15.Text = "D2"
            ElseIf (TextBox4.Text) >= 70 Then
                TextBox15.Text = "C3"
            ElseIf (TextBox4.Text) >= 60 Then
                TextBox15.Text = "C4"
            ElseIf (TextBox4.Text) >= 50 Then
                TextBox15.Text = "Pass"
            ElseIf (TextBox4.Text) <= 49 Then
                TextBox15.Text = "F9"
            End If
            If CDbl(TextBox5.Text) >= 90 Then
                TextBox16.Text = "D1"
            ElseIf (TextBox5.Text) >= 80 Then
                TextBox16.Text = "D2"
            ElseIf (TextBox5.Text) >= 70 Then
                TextBox16.Text = "C3"
            ElseIf (TextBox5.Text) >= 60 Then
                TextBox16.Text = "C4"
            ElseIf (TextBox5.Text) >= 50 Then
                TextBox16.Text = "Pass"
            ElseIf (TextBox5.Text) <= 49 Then
                TextBox16.Text = "F9"
            End If
            If CDbl(TextBox6.Text) >= 90 Then
                TextBox17.Text = "D1"
            ElseIf (TextBox6.Text) >= 80 Then
                TextBox17.Text = "D2"
            ElseIf (TextBox6.Text) >= 70 Then
                TextBox17.Text = "C3"
            ElseIf (TextBox6.Text) >= 60 Then
                TextBox17.Text = "C4"
            ElseIf (TextBox6.Text) >= 50 Then
                TextBox17.Text = "Pass"
            ElseIf (TextBox6.Text) <= 49 Then
                TextBox17.Text = "F9"
            End If
            If CDbl(TextBox7.Text) >= 90 Then
                TextBox18.Text = "D1"
            ElseIf (TextBox7.Text) >= 80 Then
                TextBox18.Text = "D2"
            ElseIf (TextBox7.Text) >= 70 Then
                TextBox18.Text = "C3"
            ElseIf (TextBox7.Text) >= 60 Then
                TextBox18.Text = "C4"
            ElseIf (TextBox7.Text) >= 50 Then
                TextBox18.Text = "Pass"
            ElseIf (TextBox7.Text) <= 49 Then
                TextBox18.Text = "F9"
            End If
            If CDbl(TextBox8.Text) >= 90 Then
                TextBox19.Text = "D1"
            ElseIf (TextBox8.Text) >= 80 Then
                TextBox19.Text = "D2"
            ElseIf (TextBox8.Text) >= 70 Then
                TextBox19.Text = "C3"
            ElseIf (TextBox8.Text) >= 60 Then
                TextBox19.Text = "C4"
            ElseIf (TextBox8.Text) >= 50 Then
                TextBox19.Text = "Pass"
            ElseIf (TextBox8.Text) <= 49 Then
                TextBox19.Text = "F9"
            End If
            If CDbl(TextBox9.Text) >= 90 Then
                TextBox20.Text = "D1"
            ElseIf (TextBox9.Text) >= 80 Then
                TextBox20.Text = "D2"
            ElseIf (TextBox9.Text) >= 70 Then
                TextBox20.Text = "C3"
            ElseIf (TextBox9.Text) >= 60 Then
                TextBox20.Text = "C4"
            ElseIf (TextBox9.Text) >= 50 Then
                TextBox20.Text = "Pass"
            ElseIf (TextBox9.Text) <= 49 Then
                TextBox20.Text = "F9"
            End If
            If CDbl(TextBox10.Text) >= 90 Then
                TextBox21.Text = "D1"
            ElseIf (TextBox10.Text) >= 80 Then
                TextBox21.Text = "D2"
            ElseIf (TextBox10.Text) >= 70 Then
                TextBox21.Text = "C3"
            ElseIf (TextBox10.Text) >= 60 Then
                TextBox21.Text = "C4"
            ElseIf (TextBox10.Text) >= 50 Then
                TextBox21.Text = "Pass"
            ElseIf (TextBox10.Text) <= 49 Then
                TextBox21.Text = "F9"
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        End
        MessageBox.Show("Do You To Exit")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

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
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox23.Text = ""
        TextBox24.Text = ""
        TextBox25.Text = ""



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Server=localhost;Database=grading;Username=root;Password=''"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        disp_data()
    End Sub

    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM aweil"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM aweil WHERE grade_id='" + TextBox14.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        id = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM aweil WHERE grade_id=" & id & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read
            TextBox1.Text = dr.GetString(1).ToString()
            TextBox2.Text = dr.GetString(2).ToString()
            TextBox3.Text = dr.GetString(3).ToString()
            TextBox4.Text = dr.GetString(4).ToString()
            TextBox5.Text = dr.GetString(5).ToString()
            TextBox6.Text = dr.GetString(6).ToString()
            TextBox7.Text = dr.GetString(7).ToString()
            TextBox8.Text = dr.GetString(8).ToString()
            TextBox9.Text = dr.GetString(9).ToString()
            TextBox10.Text = dr.GetString(10).ToString()
            TextBox11.Text = dr.GetString(11).ToString()
            TextBox12.Text = dr.GetString(12).ToString()
            TextBox13.Text = dr.GetString(13).ToString()
            TextBox15.Text = dr.GetString(14).ToString()
            TextBox16.Text = dr.GetString(15).ToString()
            TextBox17.Text = dr.GetString(16).ToString()
            TextBox18.Text = dr.GetString(17).ToString()
            TextBox19.Text = dr.GetString(18).ToString()
            TextBox20.Text = dr.GetString(19).ToString()
            TextBox21.Text = dr.GetString(20).ToString()
            TextBox22.Text = dr.GetString(21).ToString()
            TextBox23.Text = dr.GetString(22).ToString()
            TextBox24.Text = dr.GetString(23).ToString()
            TextBox25.Text = dr.GetString(24).ToString()



        End While
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If RichTextBox1.Text = "" Then
            MsgBox(" there is nothing to print")
        Else
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        End If


    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click


        RichTextBox1.Clear()
        RichTextBox1.AppendText(vbTab + "GRADING SYSTEM FOR AWEIL SECONDARY SCHOOL" + vbNewLine)
        RichTextBox1.AppendText("===========================================" + vbNewLine)
        RichTextBox1.AppendText("student_name:" + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox24.Text + vbNewLine)
        RichTextBox1.AppendText("index_no:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox25.Text + vbNewLine)
        RichTextBox1.AppendText("mathematics:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox1.Text + vbNewLine)
        RichTextBox1.AppendText("english:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox2.Text + vbNewLine)
        RichTextBox1.AppendText("biology:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox3.Text + vbNewLine)
        RichTextBox1.AppendText("physics:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox4.Text + vbNewLine)
        RichTextBox1.AppendText("cre:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox5.Text + vbNewLine)
        RichTextBox1.AppendText("chemistry:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox6.Text + vbNewLine)
        RichTextBox1.AppendText("commerce:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox7.Text + vbNewLine)
        RichTextBox1.AppendText("agriculture:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox8.Text + vbNewLine)
        RichTextBox1.AppendText("history:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox9.Text + vbNewLine)
        RichTextBox1.AppendText("geography:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox10.Text + vbNewLine)
        RichTextBox1.AppendText("maths:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox11.Text + vbNewLine)
        RichTextBox1.AppendText("eng:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox12.Text + vbNewLine)
        RichTextBox1.AppendText("bio:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox13.Text + vbNewLine)
        RichTextBox1.AppendText("phys:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox15.Text + vbNewLine)
        RichTextBox1.AppendText("c_r_e:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox16.Text + vbNewLine)
        RichTextBox1.AppendText("chem:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox17.Text + vbNewLine)
        RichTextBox1.AppendText("comm:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox18.Text + vbNewLine)
        RichTextBox1.AppendText("agric:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox19.Text + vbNewLine)
        RichTextBox1.AppendText("hist:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox20.Text + vbNewLine)
        RichTextBox1.AppendText("geo:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox21.Text + vbNewLine)
        RichTextBox1.AppendText("total_marks:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox22.Text + vbNewLine)
        RichTextBox1.AppendText("average:" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + TextBox23.Text + vbNewLine)
        RichTextBox1.AppendText("===========================================" + vbNewLine)
        RichTextBox1.AppendText(vbTab + vbTab + "THANK YOU FOR CHOOSING US " + vbNewLine)



    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim Font As New Font("Arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, Font, Brushes.Black, 100, 100)


    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class
