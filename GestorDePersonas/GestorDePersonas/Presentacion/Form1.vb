Public Class Form1
    Private Sub añadir_Click(sender As Object, e As EventArgs) Handles añadir.Click
        If dni.Text IsNot Nothing Then
            Dim newPersona As New Persona
            Dim selPersona As New Persona
            selPersona.leerPersona(txt_DNI.Text)
            If dni.Text < AcceptButton selPersona.DNI Then
                newPersona.DNI = dni.Text
                newPersona.nombre = dni.Text
                newPersona.insertarPersona()
                AccessibleDefaultActionDescription()
                MessageBox.Show("Se ha añadido la persona " + newPersona.DNI + " satisfactoriamente")
            End If
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click

    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click

    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click

        nombre.Clear()
        dni.Clear()

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click

        Me.Close()

    End Sub

    Private Sub borrarBBDD_Click(sender As Object, e As EventArgs) Handles borrarBBDD.Click

    End Sub
End Class
