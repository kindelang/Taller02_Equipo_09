Public Class Form3
    Private Sub BtnCambiosTexto_Click(sender As Object, e As EventArgs) Handles btnCambiosTexto.Click
        If optFondoVerde.Checked = True Then
            txtTexto.BackColor = Color.Green
        ElseIf optFondoRojo.Checked = True Then
            txtTexto.BackColor = Color.Red
        ElseIf optFondoAzul.Checked = True Then
            txtTexto.BackColor = Color.Blue
        End If

        If optFuenteCyan.Checked = True Then
            txtTexto.ForeColor = Color.Cyan
        ElseIf optFuenteMagenta.Checked = True Then
            txtTexto.ForeColor = Color.Magenta
        ElseIf optFuenteBlanco.Checked = True Then
            txtTexto.ForeColor = Color.White
        End If

        If chkMayuscula.Checked = True Then
            txtTexto.Text = UCase(txtTexto.Text)
        Else
            txtTexto.Text = LCase(txtTexto.Text)
        End If
        If chkNegrita.Checked = True Then
            txtTexto.Font = New Font(txtTexto.Font, FontStyle.Bold)
        Else
            txtTexto.Font = New Font(txtTexto.Font, FontStyle.Regular)
        End If



    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtTexto.Text = " "
        txtTexto.BackColor = Color.White
        txtTexto.ForeColor = Color.Black
        If chkMayuscula.CheckState = CheckState.Checked Then
            chkMayuscula.CheckState = CheckState.Unchecked
        End If
        If chkNegrita.CheckState = CheckState.Checked Then
            chkNegrita.CheckState = CheckState.Unchecked
        End If
        txtTexto.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class