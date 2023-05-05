Imports System.Data.OleDb


Public Class Persona

    'Atributos de la clase Persona'
    Private mDNI As String
    Private mNombre As String
    Private Gestor As PersonaDao


    ' Constructor '
    Sub New(ByVal dni As String, ByVal nombre As String)
        Me.mDNI = dni
        Me.mNombre = nombre
        Gestor = New PersonaDao
    End Sub


    'Propertys'
    Public Property NDNI1 As String
        Get
            Return mDNI
        End Get
        Set(value As String)
            mDNI = value
        End Set
    End Property


    ' Funcion para leer todos ' 
    Function leertodos()
        Dim todos As Collection
        Me.Gestor.readAll()
        todos = GestorDePersonas.listaPersonas
        Return todos
    End Function

    ' Metodo insertar Persona '
    Sub insertarPersona()
        Me.Gestor.insert(Me)
    End Sub

    ' Metodo modigicar Persona ' 
    Sub modificarPersona()
        Me.Gestor.update(Me)
    End Sub


End Class
