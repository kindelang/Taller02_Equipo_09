Public Class Form1
    Private Sub cmdIngresarD_Click(sender As Object, e As EventArgs) Handles cmdIngresarD.Click
        'Declaramos la variable nombre
        Dim nombre As String
        Dim Acum As Integer

        'Entrada de datos mediante un inputbox
        nombre = InputBox("Ingrese Nombre ", "Registro de Datos Personales", "", 100, 50)
        If nombre IsNot "" Then
            MsgBox(Acum & ". " + nombre1, vbOKOnly, "Registro de Datos")

        End If

    End Sub

    Private Sub cmdTerminar_Click(sender As Object, e As EventArgs) Handles cmdTerminar.Click
        Dim opcion As DialogResult
        opcion = MsgBox("Realmente desea Salir", vbYesNo + vbQuestion, "Salir del Programa")
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If

    End Sub
End Class
