<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Carga_Cliente
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
        Me.lbl_titulo_cliente = New System.Windows.Forms.Label()
        Me.lbl_apellido_nombre_cliente = New System.Windows.Forms.Label()
        Me.lbl_cuil_cuit_cliente = New System.Windows.Forms.Label()
        Me.lbl_direccion_cliente = New System.Windows.Forms.Label()
        Me.lbl_telefono_cliente = New System.Windows.Forms.Label()
        Me.lbl_tipo_factura_cliente = New System.Windows.Forms.Label()
        Me.txt_apellido_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.txt_cuil_cuit_cliente = New System.Windows.Forms.TextBox()
        Me.txt_direccion_cliente = New System.Windows.Forms.TextBox()
        Me.txt_telefono_cliente = New System.Windows.Forms.TextBox()
        Me.lista_tipo_factura = New System.Windows.Forms.ComboBox()
        Me.bt_carga_cliente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_titulo_cliente
        '
        Me.lbl_titulo_cliente.AutoSize = True
        Me.lbl_titulo_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo_cliente.Location = New System.Drawing.Point(330, 19)
        Me.lbl_titulo_cliente.Name = "lbl_titulo_cliente"
        Me.lbl_titulo_cliente.Size = New System.Drawing.Size(176, 25)
        Me.lbl_titulo_cliente.TabIndex = 0
        Me.lbl_titulo_cliente.Text = "Datos del Cliente"
        '
        'lbl_apellido_nombre_cliente
        '
        Me.lbl_apellido_nombre_cliente.AutoSize = True
        Me.lbl_apellido_nombre_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido_nombre_cliente.Location = New System.Drawing.Point(95, 82)
        Me.lbl_apellido_nombre_cliente.Name = "lbl_apellido_nombre_cliente"
        Me.lbl_apellido_nombre_cliente.Size = New System.Drawing.Size(110, 16)
        Me.lbl_apellido_nombre_cliente.TabIndex = 1
        Me.lbl_apellido_nombre_cliente.Text = "Apellido, nombre"
        '
        'lbl_cuil_cuit_cliente
        '
        Me.lbl_cuil_cuit_cliente.AutoSize = True
        Me.lbl_cuil_cuit_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuil_cuit_cliente.Location = New System.Drawing.Point(440, 84)
        Me.lbl_cuil_cuit_cliente.Name = "lbl_cuil_cuit_cliente"
        Me.lbl_cuil_cuit_cliente.Size = New System.Drawing.Size(72, 16)
        Me.lbl_cuil_cuit_cliente.TabIndex = 2
        Me.lbl_cuil_cuit_cliente.Text = "CUIL/CUIT"
        '
        'lbl_direccion_cliente
        '
        Me.lbl_direccion_cliente.AutoSize = True
        Me.lbl_direccion_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion_cliente.Location = New System.Drawing.Point(140, 154)
        Me.lbl_direccion_cliente.Name = "lbl_direccion_cliente"
        Me.lbl_direccion_cliente.Size = New System.Drawing.Size(65, 16)
        Me.lbl_direccion_cliente.TabIndex = 3
        Me.lbl_direccion_cliente.Text = "Dirección"
        '
        'lbl_telefono_cliente
        '
        Me.lbl_telefono_cliente.AutoSize = True
        Me.lbl_telefono_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono_cliente.Location = New System.Drawing.Point(450, 156)
        Me.lbl_telefono_cliente.Name = "lbl_telefono_cliente"
        Me.lbl_telefono_cliente.Size = New System.Drawing.Size(62, 16)
        Me.lbl_telefono_cliente.TabIndex = 4
        Me.lbl_telefono_cliente.Text = "Teléfono"
        '
        'lbl_tipo_factura_cliente
        '
        Me.lbl_tipo_factura_cliente.AutoSize = True
        Me.lbl_tipo_factura_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_factura_cliente.Location = New System.Drawing.Point(322, 241)
        Me.lbl_tipo_factura_cliente.Name = "lbl_tipo_factura_cliente"
        Me.lbl_tipo_factura_cliente.Size = New System.Drawing.Size(84, 16)
        Me.lbl_tipo_factura_cliente.TabIndex = 5
        Me.lbl_tipo_factura_cliente.Text = "Tipo Factura"
        '
        'txt_apellido_nombre_cliente
        '
        Me.txt_apellido_nombre_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_apellido_nombre_cliente.Location = New System.Drawing.Point(223, 81)
        Me.txt_apellido_nombre_cliente.Name = "txt_apellido_nombre_cliente"
        Me.txt_apellido_nombre_cliente.Size = New System.Drawing.Size(188, 22)
        Me.txt_apellido_nombre_cliente.TabIndex = 6
        '
        'txt_cuil_cuit_cliente
        '
        Me.txt_cuil_cuit_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cuil_cuit_cliente.Location = New System.Drawing.Point(518, 81)
        Me.txt_cuil_cuit_cliente.Name = "txt_cuil_cuit_cliente"
        Me.txt_cuil_cuit_cliente.Size = New System.Drawing.Size(188, 22)
        Me.txt_cuil_cuit_cliente.TabIndex = 7
        '
        'txt_direccion_cliente
        '
        Me.txt_direccion_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion_cliente.Location = New System.Drawing.Point(223, 153)
        Me.txt_direccion_cliente.Name = "txt_direccion_cliente"
        Me.txt_direccion_cliente.Size = New System.Drawing.Size(188, 22)
        Me.txt_direccion_cliente.TabIndex = 8
        '
        'txt_telefono_cliente
        '
        Me.txt_telefono_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono_cliente.Location = New System.Drawing.Point(518, 153)
        Me.txt_telefono_cliente.Name = "txt_telefono_cliente"
        Me.txt_telefono_cliente.Size = New System.Drawing.Size(188, 22)
        Me.txt_telefono_cliente.TabIndex = 9
        '
        'lista_tipo_factura
        '
        Me.lista_tipo_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lista_tipo_factura.FormattingEnabled = True
        Me.lista_tipo_factura.Items.AddRange(New Object() {"A", "B", "C"})
        Me.lista_tipo_factura.Location = New System.Drawing.Point(418, 238)
        Me.lista_tipo_factura.Name = "lista_tipo_factura"
        Me.lista_tipo_factura.Size = New System.Drawing.Size(121, 24)
        Me.lista_tipo_factura.TabIndex = 10
        '
        'bt_carga_cliente
        '
        Me.bt_carga_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_carga_cliente.Location = New System.Drawing.Point(712, 294)
        Me.bt_carga_cliente.Name = "bt_carga_cliente"
        Me.bt_carga_cliente.Size = New System.Drawing.Size(76, 58)
        Me.bt_carga_cliente.TabIndex = 11
        Me.bt_carga_cliente.Text = "Cargar Cliente"
        Me.bt_carga_cliente.UseVisualStyleBackColor = True
        '
        'Carga_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 364)
        Me.Controls.Add(Me.bt_carga_cliente)
        Me.Controls.Add(Me.lista_tipo_factura)
        Me.Controls.Add(Me.txt_telefono_cliente)
        Me.Controls.Add(Me.txt_direccion_cliente)
        Me.Controls.Add(Me.txt_cuil_cuit_cliente)
        Me.Controls.Add(Me.txt_apellido_nombre_cliente)
        Me.Controls.Add(Me.lbl_tipo_factura_cliente)
        Me.Controls.Add(Me.lbl_telefono_cliente)
        Me.Controls.Add(Me.lbl_direccion_cliente)
        Me.Controls.Add(Me.lbl_cuil_cuit_cliente)
        Me.Controls.Add(Me.lbl_apellido_nombre_cliente)
        Me.Controls.Add(Me.lbl_titulo_cliente)
        Me.Name = "Carga_Cliente"
        Me.Text = "Car"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_titulo_cliente As Label
    Friend WithEvents lbl_apellido_nombre_cliente As Label
    Friend WithEvents lbl_cuil_cuit_cliente As Label
    Friend WithEvents lbl_direccion_cliente As Label
    Friend WithEvents lbl_telefono_cliente As Label
    Friend WithEvents lbl_tipo_factura_cliente As Label
    Friend WithEvents txt_apellido_nombre_cliente As TextBox
    Friend WithEvents txt_cuil_cuit_cliente As TextBox
    Friend WithEvents txt_direccion_cliente As TextBox
    Friend WithEvents txt_telefono_cliente As TextBox
    Friend WithEvents lista_tipo_factura As ComboBox
    Friend WithEvents bt_carga_cliente As Button
End Class
