Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BtnCambiosTexto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OptFondoVerde_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoVerde.CheckedChanged
        txtTexto.BackColor = Color.Green
    End Sub

    Private Sub OptFondoRojo_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoRojo.CheckedChanged
        txtTexto.BackColor = Color.Red
    End Sub

    Private Sub OptFondoAzul_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoAzul.CheckedChanged
        txtTexto.BackColor = Color.Blue
    End Sub

    Private Sub OptFuenteCyan_CheckedChanged(sender As Object, e As EventArgs) Handles optFuenteCyan.CheckedChanged
        txtTexto.ForeColor = Color.Cyan
    End Sub

    Private Sub OptFuenteMagenta_CheckedChanged(sender As Object, e As EventArgs) Handles optFuenteMagenta.CheckedChanged
        txtTexto.ForeColor = Color.Magenta
    End Sub

    Private Sub OptFuenteBlanco_CheckedChanged(sender As Object, e As EventArgs) Handles optFuenteBlanco.CheckedChanged
        txtTexto.ForeColor = Color.White
    End Sub

    Private Sub ChkMayuscula_CheckedChanged(sender As Object, e As EventArgs) Handles chkMayuscula.CheckedChanged
        If chkMayuscula.Checked = True Then
            txtTexto.Text = UCase(txtTexto.Text)
        Else
            txtTexto.Text = LCase(txtTexto.Text)
        End If
    End Sub

    Private Sub ChkNegrita_CheckedChanged(sender As Object, e As EventArgs) Handles chkNegrita.CheckedChanged
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