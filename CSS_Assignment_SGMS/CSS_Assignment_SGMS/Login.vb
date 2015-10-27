Imports System.Data.SqlClient
Imports System
Imports System.Data.OleDb

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ASIA PACIFIC UNIVERSITY\Computer System Security\CSS_Assignment_SGMS\CSS_Assignment_SGMS\SGMS.accdb"
        Dim con As New OleDb.OleDbConnection(connString)
        Dim DA As New OleDbDataAdapter
        Dim DS As New DataSet
        Dim Cmd As New OleDbCommand ' Add/Del/edit/Save'

        Dim login = UserProfileTableAdapter.UserPasswordString(UsernameTextBox.Text, PasswordTextBox.Text)
        If login Is Nothing Then
            MsgBox("Check Username or Password", MsgBoxStyle.Critical)
        Else
            MsgBox("Username and Password is match", MsgBoxStyle.Information)
            StudentAssesmentForm.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub UserProfileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserProfileBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserProfileBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGMSDataSet)

    End Sub
End Class
