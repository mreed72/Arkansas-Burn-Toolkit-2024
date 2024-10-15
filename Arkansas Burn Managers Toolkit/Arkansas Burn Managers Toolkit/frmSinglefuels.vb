Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmSinglefuels
    Private Sub frmSinglefuels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Single Fuels Calculator"
        txRecom.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            txBurnSize.Clear()
            txCatDay.Value = "0"
            txDistance.Clear()
            txFtype.SelectedIndex = -1
            txFload.SelectedIndex = -1

            txAvFuels.Text = "0"
            txAllowed.Text = "0"
            txTotalTons.Text = "0"
            txRecom.Text = "0"
            txRecom.Visible = False
            txResults.Clear()
        Catch ex As Exception
            eLog("3XVDHTI", ex.Message)
        End Try
        txBurnSize.Focus()

    End Sub

    Public Function ValidateAllFields() As Boolean
        Dim AllClear As Boolean = True

        ' Validate txAcres as an integer greater than zero
        If Not Integer.TryParse(txBurnSize.Text.Trim(), Nothing) OrElse CInt(txBurnSize.Text.Trim()) <= 0 Then
            AllClear = False
            txBurnSize.BackColor = Color.LightPink
        Else
            txBurnSize.BackColor = Color.White
        End If

        ' Validate txDistance as a decimal number greater than zero
        Dim distance As Decimal
        If Not Decimal.TryParse(txDistance.Text.Trim(), distance) OrElse distance <= 0 Then
            AllClear = False
            txDistance.BackColor = Color.LightPink
        Else
            txDistance.BackColor = Color.White
        End If

        ' Validate txCatDay (NumericUpDown) to ensure it is greater than zero
        If txCatDay.Value <= 0 Then
            AllClear = False
            txCatDay.BackColor = Color.LightPink
        Else
            txCatDay.BackColor = Color.White
        End If

        ' Validate FuelTypeComboBox is not "unknown" or empty
        If String.IsNullOrWhiteSpace(txFtype.Text) OrElse txFtype.Text.Trim().ToLower() = "unknown" Then
            txFtype.BackColor = Color.LightPink
            AllClear = False
        Else
            txFtype.BackColor = Color.White
        End If

        ' Validate FuelLoadComboBox is not "unknown" or empty
        If String.IsNullOrWhiteSpace(txFload.Text) OrElse txFload.Text.Trim().ToLower() = "unknown" Then
            txFload.BackColor = Color.LightPink
            AllClear = False
        Else
            txFload.BackColor = Color.White
        End If

        ' Return the validation status
        Return AllClear
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            If ValidateAllFields() Then
                txAvFuels.Text = GetAvFuels(txFtype.SelectedItem, txFload.SelectedItem)
                txTotalTons.Text = Val(txBurnSize.Text) * Val(txAvFuels.Text)
                txAllowed.Text = smpCalc(txCatDay.Value, txDistance.Text)

                If Val(txTotalTons.Text) >= Val(txAllowed.Text) Then
                    Dim RC As Integer = Val(txAllowed.Text) / Val(txAvFuels.Text) - 3
                    txRecom.Visible = True
                    txRecom.Text = RC & " - MAX ACRES..."
                    txResults.Text = "This burn will exceed because the TOTAL TONS: " & Val(txTotalTons.Text) & " is greater than the ALLOWED TONNAGE: " &
                                    Val(txAllowed.Text) & " for the distance to target: " & txDistance.Text & " and the category day: " & txCatDay.Value & "."
                Else
                    txResults.Clear()
                    txRecom.Text = "0"
                    txRecom.Visible = False

                End If

            End If
        Catch ex As Exception
            eLog("3XQGTW8", ex.Message)
        End Try

    End Sub

    Private Sub txBurnSize_Leave(sender As Object, e As EventArgs) Handles txBurnSize.Leave

        Try
            Dim Num As Double
            If Double.TryParse(txBurnSize.Text, Num) Then
                Num = Math.Round(Num)
                txBurnSize.Text = Num.ToString
            End If
        Catch ex As Exception
            eLog("3XETQCI", ex.Message)
        End Try

    End Sub

    Private Sub txAllowed_TextChanged(sender As Object, e As EventArgs) Handles txAllowed.TextChanged


        Try
            Dim Num As Double
            If Double.TryParse(txAllowed.Text, Num) Then
                Num = Math.Round(Num)
                txAllowed.Text = Num.ToString()
            End If
        Catch ex As Exception
            eLog("3XKRJC0", ex.Message)
        End Try




    End Sub

    Private Sub txTotalTons_TextChanged(sender As Object, e As EventArgs) Handles txTotalTons.TextChanged

        Try
            Dim Num As Double
            If Double.TryParse(txTotalTons.Text, Num) Then
                Num = Math.Round(Num)
                txTotalTons.Text = Num.ToString()
            End If
        Catch ex As Exception
            eLog("3X4BUAK", ex.Message)
        End Try

    End Sub

End Class