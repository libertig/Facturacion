<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_Articulos
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
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.lbl_precio_unitario = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.txt_precio_unitario = New System.Windows.Forms.TextBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_carga_articulo = New System.Windows.Forms.Button()
        Me.bt_finalizar_carga_articulo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.Location = New System.Drawing.Point(323, 86)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(80, 16)
        Me.lbl_descripcion.TabIndex = 0
        Me.lbl_descripcion.Text = "Descripción"
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad.Location = New System.Drawing.Point(65, 148)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(62, 16)
        Me.lbl_cantidad.TabIndex = 1
        Me.lbl_cantidad.Text = "Cantidad"
        '
        'lbl_precio_unitario
        '
        Me.lbl_precio_unitario.AutoSize = True
        Me.lbl_precio_unitario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_precio_unitario.Location = New System.Drawing.Point(323, 148)
        Me.lbl_precio_unitario.Name = "lbl_precio_unitario"
        Me.lbl_precio_unitario.Size = New System.Drawing.Size(96, 16)
        Me.lbl_precio_unitario.TabIndex = 2
        Me.lbl_precio_unitario.Text = "Precio Unitario"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(434, 85)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(100, 20)
        Me.txt_descripcion.TabIndex = 3
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(181, 147)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 4
        '
        'txt_precio_unitario
        '
        Me.txt_precio_unitario.Location = New System.Drawing.Point(434, 147)
        Me.txt_precio_unitario.Name = "txt_precio_unitario"
        Me.txt_precio_unitario.Size = New System.Drawing.Size(100, 20)
        Me.txt_precio_unitario.TabIndex = 5
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(181, 85)
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(100, 20)
        Me.txt_codigo.TabIndex = 6
        '
        'lbl_codigo
        '
        Me.lbl_codigo.AutoSize = True
        Me.lbl_codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_codigo.Location = New System.Drawing.Point(65, 86)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(99, 16)
        Me.lbl_codigo.TabIndex = 7
        Me.lbl_codigo.Text = "Código Artículo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ingreso de Artículos"
        '
        'bt_carga_articulo
        '
        Me.bt_carga_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_carga_articulo.Location = New System.Drawing.Point(175, 217)
        Me.bt_carga_articulo.Name = "bt_carga_articulo"
        Me.bt_carga_articulo.Size = New System.Drawing.Size(115, 24)
        Me.bt_carga_articulo.TabIndex = 9
        Me.bt_carga_articulo.Text = "Cargar Articulo"
        Me.bt_carga_articulo.UseVisualStyleBackColor = True
        '
        'bt_finalizar_carga_articulo
        '
        Me.bt_finalizar_carga_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_finalizar_carga_articulo.Location = New System.Drawing.Point(326, 218)
        Me.bt_finalizar_carga_articulo.Name = "bt_finalizar_carga_articulo"
        Me.bt_finalizar_carga_articulo.Size = New System.Drawing.Size(115, 23)
        Me.bt_finalizar_carga_articulo.TabIndex = 10
        Me.bt_finalizar_carga_articulo.Text = "Finalizar"
        Me.bt_finalizar_carga_articulo.UseVisualStyleBackColor = True
        '
        'Lista_Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 261)
        Me.Controls.Add(Me.bt_finalizar_carga_articulo)
        Me.Controls.Add(Me.bt_carga_articulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.txt_codigo)
        Me.Controls.Add(Me.txt_precio_unitario)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.txt_descripcion)
        Me.Controls.Add(Me.lbl_precio_unitario)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Name = "Lista_Articulos"
        Me.Text = "Lista_Articulos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents lbl_cantidad As Label
    Friend WithEvents lbl_precio_unitario As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_cantidad As TextBox
    Friend WithEvents txt_precio_unitario As TextBox
    Friend WithEvents txt_codigo As TextBox
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bt_carga_articulo As Button
    Friend WithEvents bt_finalizar_carga_articulo As Button
End Class
