﻿Public Class Employees
    Public Sub New()
        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' Fill the SqlDataSource asynchronously
        SqlDataSource1.FillAsync()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        AddEmployees.ShowDialog()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        EditeEmployee.ShowDialog()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        DeleteEmloyee.ShowDialog()
    End Sub

    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class