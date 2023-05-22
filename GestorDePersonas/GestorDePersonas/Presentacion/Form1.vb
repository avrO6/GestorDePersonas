Public Class Form1
    Private Sub añadir_Click(sender As Object, e As EventArgs) Handles añadir.Click
        If dni.Text IsNot Nothing Then
            Dim newPersona As New Persona
            Dim selPersona As New Persona
            selPersona.leerpersona(dni.Text)
            If dni.Text <> selPersona.NDNI1 Then
                newPersona.NDNI1 = dni.Text
                newPersona.NOM = nombre.Text
                newPersona.insertarPersona()
                Actualizar()
                MessageBox.Show("Se ha añadido la persona " + newPersona.NDNI1 + " satisfactoriamente")
            End If
        End If
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        If dni.Text IsNot Nothing Then
            Dim newPersona As New Persona
            Dim selPersona As New Persona
            selPersona.leerpersona(dni.Text)
            If dni.Text <> selPersona.NDNI1 Then
                newPersona.NDNI1 = dni.Text
                newPersona.NOM = dni.Text
                newPersona.modificarPersona()
                MessageBox.Show("Se ha modificado la persona " + newPersona.NDNI1 + " satisfactoriamente")
            End If
        End If
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If dni.Text IsNot Nothing Then
            Dim newPersona As New Persona
            Dim selPersona As New Persona
            selPersona.leerpersona(dni.Text)
            If dni.Text <> selPersona.NDNI1 Then
                newPersona.NDNI1 = dni.Text
                newPersona.NOM = dni.Text
                newPersona.eliminarPersona()
                MessageBox.Show("Se ha eliminado la persona " + newPersona.NDNI1 + " satisfactoriamente")
            End If
        End If
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

    Sub Actualizar()

    End Sub
End Class
