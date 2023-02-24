Imports System.Data.SqlClient

Public Class EditeEmployee
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If FullName.Text = "Employee not found !" Or EmployeeID.Text = String.Empty Then
            MsgBox("Please enter a valid employee ID !", MsgBoxStyle.Information)
        Else
            If MsgBox($" Are you sure to Edite {FullName.Text} !", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Edite.ShowDialog()
                Edite.EmployeeID.Text = EmployeeID.Text
                Me.Close()

            End If
        End If
    End Sub

    Private Sub EditeEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EmployeeID_TextChanged(sender As Object, e As EventArgs) Handles EmployeeID.TextChanged

        If EmployeeID.Text = String.Empty Then

        Else

            Try
                Dim selectSQLCMD As New SqlCommand($"SELECT CONCAT(FirstName, ' ', LastName) AS FullName FROM Employees_tbl WHERE EmployeeID = '{EmployeeID.Text}'  ", SQLCONN)
                Dim adapter As New SqlDataAdapter(selectSQLCMD)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count <= 0 Then
                    FullName.Text = "Employee not found !"
                Else
                    FullName.Text = table.Rows(0)("FullName")
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try


        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub
End Class