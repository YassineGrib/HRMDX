Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Filtering

Public Class Edite
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Close()
    End Sub

    Private Sub Edite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Hide EditeEmployee DiaLog

        EditeEmployee.Hide()

        'get EmployeeID from EditeEmployee dialog
        EmployeeID.Text = EditeEmployee.EmployeeID.Text

        'Fill from DB 
        If EmployeeID.Text = String.Empty Then
            Me.Close()
        Else
            Try
                EmployeeID.ReadOnly = True

                Dim SQLCMD As New SqlCommand($"SELECT * FROM Employees_TBL WHERE EmployeeID = '{EmployeeID.Text}' ", SQLCONN)
                Dim adapter As New SqlDataAdapter(SQLCMD)
                Dim table As New DataTable()
                adapter.Fill(table)
                'fill 
                Firstname.Text = table.Rows(0)("Firstname")
                Lastname.Text = table.Rows(0)("Lastname")
                gender.Text = table.Rows(0)("gender")
                Phone.Text = table.Rows(0)("Phone")
                LocalAddress.Text = table.Rows(0)("LocalAddress")
                Designation.Text = table.Rows(0)("Designation")
                Salary.Text = table.Rows(0)("Salary")
                CCPinfo.Text = table.Rows(0)("CCP")
                Birthday.Value = table.Rows(0)("Birthday")
                JoinDate.Value = table.Rows(0)("DateOfJoining")
                ExitDate.Value = table.Rows(0)("ExitDate")
                Status.Text = table.Rows(0)("Status")
                Department.Text = table.Rows(0)("Department")




            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
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
                Dim SQLCMDADD As New SqlCommand($"UPDATE Employees_TBL  SET [FirstName]='{Firstname.Text}',[LastName]='{Lastname.Text}',[Gender]='{gender.Text}',[Phone]= '{Phone.Text}',[LocalAddress]='{LocalAddress.Text}',[Birthday]='{Birthday.Value}',[Status]= '{Status.Text}',[Department]='{Department.Text}',[Designation]= '{Designation.Text}',[DateOfJoining]='{JoinDate.Value}',[ExitDate]='{ExitDate.Value}',[Salary]= '{Salary.Text}' ,[CCP]='{CCPinfo.Text}' WHERE [EmployeeID]='{EmployeeID.Text}'  ", SQLCONN)
                SQLCONN.Open()
                SQLCMDADD.ExecuteNonQuery()
                SQLCONN.Close()

                MsgBox($"The employee has ben Edited successfully!", MsgBoxStyle.Information)

                ' Fill the SqlDataSource asynchronously
                Form1.SqlDataSource1.FillAsync()

                ' exit
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub
End Class