Imports System.Data.SqlClient

'Derek Bradshaw
'11/30/21
'CPT 341 -  VB.NET NJIT Fall 2021 Semester

Public Class Form1
    'File needs to not be in "root" directory so we can write to the file
    Dim connstr As String = "Provider = Microsoft.Jet.OleDB.4.0; Data Source = C:\Users\Derek\Documents\StudentData.mdb"
    Dim dt As New DataTable





    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Loads the table
        Try
            dt.Clear()
            Dim sqlStr = "Select * From Students"
            Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, connstr)
            dataAdapter.Fill(dt)
            dgDisplay.DataSource = dt
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("File Not Found", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnOrderAsc_Click(sender As Object, e As EventArgs) Handles btnOrderAsc.Click
        'Orders the table by last name in Ascending Order
        Try
            dt.Clear()
            Dim sqlStr = "Select * From Students ORDER BY LastName Asc"
            Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, connstr)
            dataAdapter.Fill(dt)
            dgDisplay.DataSource = dt
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("File Not Found", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnOrderDesc_Click(sender As Object, e As EventArgs) Handles btnOrderDesc.Click
        'Orders the table by last name in Descending Order
        Try
            dt.Clear()
            Dim sqlStr = "Select * From Students ORDER BY LastName Desc"
            Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, connstr)
            dataAdapter.Fill(dt)
            dgDisplay.DataSource = dt
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("File Not Found", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnFullTime_Click(sender As Object, e As EventArgs) Handles btnFullTime.Click
        'Finds the students with more than 4 classes
        Try
            dt.Clear()
            'Opening the db causes this to not work, weird but okay
            Dim sqlStr = "Select * From Students WHERE Classes >= '4'"
            Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, connstr)
            dataAdapter.Fill(dt)
            dgDisplay.DataSource = dt
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("File Not Found", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Saves the table information
        Dim changes As Integer
        Dim sqlStr1 As String = "SELECT * FROM Students"
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr1, connstr)
        Dim commandBuilder As New OleDb.OleDbCommandBuilder(dataAdapter)
        changes = dataAdapter.Update(dt)
        dataAdapter.Dispose()
        If changes > 0 Then
            Dim Message As String = changes & " changes made"
            Dim Caption As String = " Records were Saved"
            Dim Buttons As MessageBoxButtons =
            MessageBoxButtons.OK
            Dim Result As DialogResult
            'Displays the MessageBox
            Result = MessageBox.Show(Message, Caption, Buttons)
        Else
            Dim Message As String = changes & " changes made"
            Dim Caption As String = "No Records were Saved"
            Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK
            Dim Result As DialogResult
            'Displays the MessageBox
            Result = MessageBox.Show(Message, Caption, Buttons)
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Lets user search for student by last name
        Try
            Dim LastName As String = txtSearch.Text()
            dt.Clear()
            Dim sqlStr = "Select * From Students WHERE LastName = '" & LastName & "'"
            Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, connstr)
            dataAdapter.Fill(dt)
            dgDisplay.DataSource = dt
        Catch
            'Creates pop-up to tell user what is wrong & clears the approprite field
            MessageBox.Show("File Not Found", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip1 As New ToolTip()
        Dim toolTip2 As New ToolTip()
        Dim toolTip3 As New ToolTip()
        Dim toolTip4 As New ToolTip()
        Dim toolTip5 As New ToolTip()
        Dim toolTip6 As New ToolTip()
        Dim toolTip7 As New ToolTip()
        toolTip1.ShowAlways = True
        toolTip2.ShowAlways = True
        toolTip3.ShowAlways = True
        toolTip4.ShowAlways = True
        toolTip5.ShowAlways = True
        toolTip6.ShowAlways = True
        toolTip7.ShowAlways = True
        toolTip1.SetToolTip(txtSearch, "Enter a student's last name to search")
        toolTip2.SetToolTip(btnLoad, "Load the table")
        toolTip3.SetToolTip(btnOrderAsc, "Sort the table by last name in Ascending Order")
        toolTip4.SetToolTip(btnOrderDesc, "Sort the table by last name in Descending Order")
        toolTip5.SetToolTip(btnFullTime, "Show only students with more than 3 classes")
        toolTip6.SetToolTip(btnSave, "Save Any changes made to the table")
        toolTip7.SetToolTip(btnSearch, "Search the table for students with the given Last Name")
    End Sub
End Class

