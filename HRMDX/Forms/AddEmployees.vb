Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports DevExpress.AspNetCore.Reporting.ReportDesigner

Public Class AddEmployees
    'Rest
    Private Sub Clear()
        Firstname.Text = String.Empty
        Lastname.Text = String.Empty
        Phone.Text = String.Empty
        LocalAddress.Text = String.Empty
        Birthday.Value = Today
        EmployeeID.Text = String.Empty
        Salary.Text = String.Empty
    End Sub


    Private Sub Guna2Shapes3_Click(sender As Object, e As EventArgs)
        Me.Close()
        Employees.Show()
    End Sub



    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        'Chek 4 nulled 
        If Firstname.Text = String.Empty Then
            MsgBox("First Name Cant be Null !", MsgBoxStyle.Exclamation)
        ElseIf Lastname.Text = String.Empty Then
            MsgBox("last Name Cant be Null !", MsgBoxStyle.Exclamation)
        ElseIf Department.Text = String.Empty Then
            MsgBox("Department Cant be Null !", MsgBoxStyle.Exclamation)
        ElseIf Designation.Text = String.Empty Then
            MsgBox("Designation Cant be Null !", MsgBoxStyle.Exclamation)
        Else
            Try
                Dim SQLCMD As New SqlCommand($"select EmployeeID from Employees_TBL where EmployeeID = '{EmployeeID.Text}' ", SQLCONN)
                Dim adapter As New SqlDataAdapter(SQLCMD)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count = 0 Then
                    Dim SQLCMDADD As New SqlCommand($"INSERT INTO Employees_TBL ([FirstName],[LastName],[Gender],[Phone],[LocalAddress],[Birthday],[EmployeeID],[Status],[Department],[Designation],[DateOfJoining],[ExitDate],[Salary],[CCP]) 
                                               VALUES ('{Firstname.Text}','{Lastname.Text}','{gender.Text}','{Phone.Text}','{LocalAddress.Text}','{Birthday.Value}','{EmployeeID.Text}', '{Status.Text}','{Department.Text}','{Designation.Text}','{JoinDate.Value}','{ExitDate.Value}','{Salary.Text}','{CCPinfo.Text}') ", SQLCONN)
                    SQLCONN.Open()
                    SQLCMDADD.ExecuteNonQuery()
                    SQLCONN.Close()
                    MsgBox($"The employee has ben add successfully!", MsgBoxStyle.Information)

                    ' Fill the SqlDataSource asynchronously
                    Form1.SqlDataSource1.FillAsync()
                Else
                    MsgBox($"The employee already exists!", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Employees.Show()
        Me.Close()

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Clear()
    End Sub

    Private Sub Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Status.SelectedIndexChanged
        If Status.Text = "Inactive" Then
            ExitDate.Enabled = False
        ElseIf Status.Text = "Active" Then
            ExitDate.Enabled = True
        End If
    End Sub
End Class