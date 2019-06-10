<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.lbl_factura = New System.Windows.Forms.Label()
        Me.lbl_direccion_factura = New System.Windows.Forms.Label()
        Me.lbl_apellido_factura = New System.Windows.Forms.Label()
        Me.lbl_lista_tipo_factura = New System.Windows.Forms.Label()
        Me.lbl_cuil_cuit_cliente = New System.Windows.Forms.Label()
        Me.lbl_telefono_cliente = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_factura
        '
        Me.lbl_factura.AutoSize = True
        Me.lbl_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_factura.Location = New System.Drawing.Point(639, 16)
        Me.lbl_factura.Name = "lbl_factura"
        Me.lbl_factura.Size = New System.Drawing.Size(111, 25)
        Me.lbl_factura.TabIndex = 0
        Me.lbl_factura.Text = "FACTURA"
        '
        'lbl_direccion_factura
        '
        Me.lbl_direccion_factura.AutoSize = True
        Me.lbl_direccion_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direccion_factura.Location = New System.Drawing.Point(12, 132)
        Me.lbl_direccion_factura.Name = "lbl_direccion_factura"
        Me.lbl_direccion_factura.Size = New System.Drawing.Size(129, 16)
        Me.lbl_direccion_factura.TabIndex = 3
        Me.lbl_direccion_factura.Text = "txt_direccion_factura"
        '
        'lbl_apellido_factura
        '
        Me.lbl_apellido_factura.AutoSize = True
        Me.lbl_apellido_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_apellido_factura.Location = New System.Drawing.Point(12, 96)
        Me.lbl_apellido_factura.Name = "lbl_apellido_factura"
        Me.lbl_apellido_factura.Size = New System.Drawing.Size(123, 16)
        Me.lbl_apellido_factura.TabIndex = 4
        Me.lbl_apellido_factura.Text = "txt_apellido_factura"
        '
        'lbl_lista_tipo_factura
        '
        Me.lbl_lista_tipo_factura.AutoSize = True
        Me.lbl_lista_tipo_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lista_tipo_factura.Location = New System.Drawing.Point(752, 16)
        Me.lbl_lista_tipo_factura.Name = "lbl_lista_tipo_factura"
        Me.lbl_lista_tipo_factura.Size = New System.Drawing.Size(176, 25)
        Me.lbl_lista_tipo_factura.TabIndex = 5
        Me.lbl_lista_tipo_factura.Text = "lista_tipo_factura"
        '
        'lbl_cuil_cuit_cliente
        '
        Me.lbl_cuil_cuit_cliente.AutoSize = True
        Me.lbl_cuil_cuit_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuil_cuit_cliente.Location = New System.Drawing.Point(12, 114)
        Me.lbl_cuil_cuit_cliente.Name = "lbl_cuil_cuit_cliente"
        Me.lbl_cuil_cuit_cliente.Size = New System.Drawing.Size(120, 16)
        Me.lbl_cuil_cuit_cliente.TabIndex = 6
        Me.lbl_cuil_cuit_cliente.Text = "txt_cuil_cuit_cliente"
        '
        'lbl_telefono_cliente
        '
        Me.lbl_telefono_cliente.AutoSize = True
        Me.lbl_telefono_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono_cliente.Location = New System.Drawing.Point(12, 150)
        Me.lbl_telefono_cliente.Name = "lbl_telefono_cliente"
        Me.lbl_telefono_cliente.Size = New System.Drawing.Size(121, 16)
        Me.lbl_telefono_cliente.TabIndex = 7
        Me.lbl_telefono_cliente.Text = "txt_telefono_cliente"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_telefono_cliente)
        Me.Controls.Add(Me.lbl_cuil_cuit_cliente)
        Me.Controls.Add(Me.lbl_lista_tipo_factura)
        Me.Controls.Add(Me.lbl_apellido_factura)
        Me.Controls.Add(Me.lbl_direccion_factura)
        Me.Controls.Add(Me.lbl_factura)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_factura As Label
    Friend WithEvents lbl_direccion_factura As Label
    Friend WithEvents lbl_apellido_factura As Label
    Friend WithEvents lbl_lista_tipo_factura As Label
    Friend WithEvents lbl_cuil_cuit_cliente As Label
    Friend WithEvents lbl_telefono_cliente As Label
End Class
