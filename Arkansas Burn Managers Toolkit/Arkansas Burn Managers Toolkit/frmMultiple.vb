Imports System.IO

Public Class frmMultiple
    Private Sub frmMultiple_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            ' Add the block information to the grid
            Dim bs As Integer = Val(BlockSize.Text)
            Dim bft As String = BlockFtype.SelectedItem?.ToString() ' Use null-conditional to avoid errors
            Dim bfl As String = BlockFload.SelectedItem?.ToString()

            Dim AV As Double = GetAvFuels(bft, bfl)
            Dim TT As Integer = bs * AV

            dgv1.Rows.Add(bs, bft, bfl, AV, TT)

            ' Update totals after adding a new row
            UpdateTotals()


            ' Clear the fields to add another block
            BlockSize.Clear()
            BlockFtype.SelectedIndex = -1
            BlockFload.SelectedIndex = -1
            BlockSize.Focus()
        Catch ex As Exception
            eLog("3XMGBY2", ex.Message)
        End Try
    End Sub


    ' Method to update totals
    Private Sub UpdateTotals()

        Try
            Dim totalSize As Integer = 0
            Dim totalTons As Double = 0

            ' Iterate through DataGridView rows and sum the values of columns 0 and 4
            For Each row As DataGridViewRow In dgv1.Rows
                ' Ensure the row is not a new row placeholder
                If Not row.IsNewRow Then
                    totalSize += Convert.ToInt32(row.Cells(0).Value)
                    totalTons += Convert.ToDouble(row.Cells(4).Value)
                End If
            Next

            ' Update the labels with the calculated totals
            txTotalSize.Text = totalSize.ToString()
            txTotalTons.Text = totalTons.ToString()
        Catch ex As Exception
            eLog("3XBSJKP", ex.Message)
        End Try

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            Dim rezults As String
            Dim smpc As Integer = smpCalc(txCatDay.Value, txDistance.Text)

            If Val(txTotalTons.Text) > Val(smpc) Then
                rezults = "This burn will exceed the guidelines because the TOTAL TONS: " & txTotalTons.Text & " is greater than the allowed tonnage: " & smpc &
                    " for the given category day: " & txCatDay.Value & " and the distance to target: " & txDistance.Text & " miles." & Environment.NewLine & "Please adjust the acres for one or more of your blocks and try again."
                MessageBox.Show(rezults, "EXCEEDS", MessageBoxButtons.OK)
            End If
        Catch ex As Exception
            eLog("3XV7WPS", ex.Message)
        End Try






    End Sub
End Class