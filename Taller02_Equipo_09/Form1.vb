Public Class Form1
    Dim nombres As String
    Dim contador As Integer = 1
    Private Sub cmdIngresarD_Click(sender As Object, e As EventArgs) Handles cmdIngresarD.Click
        'Declaramos la variable nombre
        Dim nombre As String



        'Entrada de datos mediante un inputbox
        nombre = InputBox("Ingrese su Nombre ", "Registro de datos personales", "", 100, 50)
        nombres = nombres & contador & ". " + nombre + vbCrLf
        If nombre IsNot "" Then
            MsgBox("Bienvenido Usuario: " + nombre + vbCrLf & nombres, vbOKOnly, "Registro de datos")
            contador += 1
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