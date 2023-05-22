Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class PersonaDao

    ' Atributos de la clase gestorPersona ' 
    Private mlistaPersonas As Collection
    Private Agente As AgenteBD
    'Constructor ' 

    Sub New()
        mlistaPersonas = New Collection
    End Sub

    Public Property listaPersona As Collection
        Get
            Return listaPersona
        End Get
        Set(value As Collection)

        End Set
    End Property

    ' Iserta una persona en la base de datos ' 
    Sub insert(ByVal newPersona As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "INSERT INTO PERSONAS VALUE ('" + newPersona.NDNI1 + "')"   'Cabiar line de insert'
        Agente.create(sSQL)
    End Sub

    ' Actualizar una persona en la base de datos ' 
    Sub update(ByVal newPersona As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "UPDATE PERSONAS SET '" + newPersona.NDNI1 + "'"  'cambiar update'
        Agente.update(sSQL)
    End Sub


    'Borrar la persona elegida de la base de datos'
    Sub delete(ByVal noPersona As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM PERSONAS WHERE DNI='" + noPersona.NDNI1 + "'"
        Agente.delete(sSQL)
    End Sub

    'Borrar todas las personas de la base de datos'
    Sub deleteAll(ByVal noPersona As Persona)
        Agente = AgenteBD.getInstancia()
        Dim sSQL As String = "DELETE * FROM PERSONAS"
        Agente.delete(sSQL)
    End Sub

    Friend Sub readAll()
        Throw New NotImplementedException()
    End Sub
End Class
