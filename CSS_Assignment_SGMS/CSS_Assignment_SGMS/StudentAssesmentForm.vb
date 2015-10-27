Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient

Public Class StudentAssesmentForm

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

    End Sub

    Private Sub TabChangePass_Click(sender As Object, e As EventArgs) Handles TabChangePass.Click

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub UserProfileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UserProfileBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UserProfileBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SGMSDataSet)

    End Sub

    Private Sub StudentAssesmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SGMSDataSet.UserProfile' table. You can move, or remove it, as needed.
        Me.UserProfileTableAdapter.Fill(Me.SGMSDataSet.UserProfile)

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ASIA PACIFIC UNIVERSITY\Computer System Security\CSS_Assignment_SGMS\CSS_Assignment_SGMS\SGMS.accdb"
        Dim con As New OleDb.OleDbConnection(connString)
        Dim DA As New OleDbDataAdapter
        Dim DS As New DataSet
        Dim Cmd As New OleDbCommand ' Add/Del/edit/Save'


    End Sub
End Class