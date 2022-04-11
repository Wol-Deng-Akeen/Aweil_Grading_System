Imports MySql.Data.MySqlClient

Public Class login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from  grading.users where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1
            End If
            If (count = 1) Then
                MessageBox.Show("LOGIN SUCCESSFUL")
                TextBox1.Text = ""
                TextBox2.Text = ""
                Form1.Show()
                Me.Visible = False
            ElseIf (count > 1) Then
                MessageBox.Show("ACCESS DENIED")
            Else
                MessageBox.Show("LOGIN DOES NOT MATCH")
            End If
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        register.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class