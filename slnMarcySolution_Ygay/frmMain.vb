' Name:         Gross Project
' Purpose:      Displays gross pay
' Programmer:   <Jhonniel Ygay> on <Sep 3,2020>

Option Explicit On
Option Infer Off
Option Strict On


Public Class frmMain
    Private Sub txtItem1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItem1.Enter
        txtItem1.SelectAll()

    End Sub
    Private Sub txtItem2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItem2.Enter
        txtItem2.SelectAll()

    End Sub
    Private Sub txtItem1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItem1.KeyPress

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If

    End Sub
    Private Sub txtItem2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItem2.KeyPress

        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then

        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtItem1_TextChanged(sender As Object, e As EventArgs) Handles txtItem1.TextChanged

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
        Dim Item1, Item2, Total, Ftotal As Decimal

        Dim a, b As String
        Dim dlgok As DialogResult



        Decimal.TryParse(txtItem1.Text, Item1)
        Decimal.TryParse(txtItem2.Text, Item2)

        If Item1 > Item2 Then
            Total = Item2 / 2
            Ftotal = Total + Item1
            a = Ftotal.ToString("c2")
            b = Total.ToString("c2")

            MessageBox.Show("Total: " + a & vbCrLf & "You Save: " + b, "", MessageBoxButtons.OK, MessageBoxIcon.Information)


        ElseIf Item1 < Item2 Then
            Total = Item1 / 2
            Ftotal = Total + Item2
            a = Ftotal.ToString("c2")
            b = Total.ToString("c2")

            MessageBox.Show("Total: " + a & vbCrLf & "You Save: " + b, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else Item1 = Item2
            Total = Item2 / 2
            Ftotal = Total + Item1
            a = Ftotal.ToString("c2")
            b = Total.ToString("c2")

            MessageBox.Show("Total: " + a & vbCrLf & "You Save: " + b, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        txtItem1.Focus()
    End Sub

    Private Sub txtItem2_TextChanged(sender As Object, e As EventArgs) Handles txtItem2.TextChanged

    End Sub




End Class
