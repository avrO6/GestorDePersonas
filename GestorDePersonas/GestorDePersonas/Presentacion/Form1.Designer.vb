<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.añadir = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.borrarBBDD = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dni = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'añadir
        '
        Me.añadir.Location = New System.Drawing.Point(425, 212)
        Me.añadir.Name = "añadir"
        Me.añadir.Size = New System.Drawing.Size(104, 70)
        Me.añadir.TabIndex = 0
        Me.añadir.Text = "Añadir"
        Me.añadir.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(546, 212)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(104, 70)
        Me.modificar.TabIndex = 1
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(668, 212)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(104, 70)
        Me.eliminar.TabIndex = 2
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(425, 305)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(104, 70)
        Me.limpiar.TabIndex = 3
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(546, 305)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(104, 70)
        Me.salir.TabIndex = 4
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'borrarBBDD
        '
        Me.borrarBBDD.Location = New System.Drawing.Point(668, 305)
        Me.borrarBBDD.Name = "borrarBBDD"
        Me.borrarBBDD.Size = New System.Drawing.Size(104, 70)
        Me.borrarBBDD.TabIndex = 5
        Me.borrarBBDD.Text = "Borrar BBDD"
        Me.borrarBBDD.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(47, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PERSONAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(480, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Aplicación realizada por Álvaro Gª de la Torre, Sergio Mendoza y Adrian Panes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(422, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(422, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nombre"
        '
        'dni
        '
        Me.dni.Location = New System.Drawing.Point(487, 70)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(198, 22)
        Me.dni.TabIndex = 10
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(487, 121)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(198, 22)
        Me.nombre.TabIndex = 11
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(50, 70)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(230, 308)
        Me.ListBox1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.dni)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.borrarBBDD)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.modificar)
        Me.Controls.Add(Me.añadir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents añadir As Button
    Friend WithEvents modificar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents salir As Button
    Friend WithEvents borrarBBDD As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dni As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class
