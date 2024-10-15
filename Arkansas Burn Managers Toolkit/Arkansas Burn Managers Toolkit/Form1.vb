Imports System.IO

Public Class Form1




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xv As String = My.Application.Info.Version.ToString
        Me.Text = "Arkansas Burn Managers Toolkit v" & xv
        Label1.Text = "Burn Managers Toolkit"
        Label2.Text = "v" & xv

        CheckAndCreateFoldersAndFiles()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Sub CheckAndCreateFoldersAndFiles()
        ' Define the main folder path
        Dim mainFolder As String = "C:\ABMT"
        ' Define subfolders
        Dim singleFolder As String = Path.Combine(mainFolder, "SINGLE")
        Dim multipleFolder As String = Path.Combine(mainFolder, "MULTIPLE")
        ' Define the log file paths
        Dim singleLogFile As String = Path.Combine(singleFolder, "sLog.txt")
        Dim multipleLogFile As String = Path.Combine(multipleFolder, "mLog.txt")
        Dim errorLogFile As String = Path.Combine(mainFolder, "eLog.txt")

        ' Check if the main folder exists, create if it doesn't
        If Not Directory.Exists(mainFolder) Then
            Directory.CreateDirectory(mainFolder)
        End If

        ' Check if the SINGLE folder exists, create if it doesn't
        If Not Directory.Exists(singleFolder) Then
            Directory.CreateDirectory(singleFolder)
        End If

        ' Check if the MULTIPLE folder exists, create if it doesn't
        If Not Directory.Exists(multipleFolder) Then
            Directory.CreateDirectory(multipleFolder)
        End If

        ' Check if SingleLog.txt exists, create if it doesn't
        If Not File.Exists(singleLogFile) Then
            File.Create(singleLogFile).Dispose()
        End If

        ' Check if MultipleLog.txt exists, create if it doesn't
        If Not File.Exists(multipleLogFile) Then
            File.Create(multipleLogFile).Dispose()
        End If

        If Not File.Exists(errorLogFile) Then
            File.Create(errorLogFile).Dispose()
            My.Settings.ErrorLogFile = errorLogFile
            My.Settings.Save()
        End If

        cbFL.CheckState = CheckState.Checked

    End Sub

    Private Sub btnSingle_Click(sender As Object, e As EventArgs) Handles btnSingle.Click

        Try
            If frmSinglefuels.Visible = False Then
                frmSinglefuels.Show()
            Else
                frmSinglefuels.Focus()
            End If
        Catch ex As Exception
            eLog("3XOWY3I", ex.Message)
        End Try

    End Sub

    Private Sub btnMultiple_Click(sender As Object, e As EventArgs) Handles btnMultiple.Click

        Try
            If frmMultiple.Visible = False Then
                frmMultiple.Show()
            Else
                frmMultiple.Focus()
            End If
        Catch ex As Exception
            eLog("3XMSR7W", ex.Message)
        End Try

    End Sub
End Class
