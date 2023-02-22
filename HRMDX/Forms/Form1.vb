Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.ShowDialog()
    End Sub
End Class
