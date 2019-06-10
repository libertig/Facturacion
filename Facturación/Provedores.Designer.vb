<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nombre_proveedor = New System.Windows.Forms.Label()
        Me.lbl_cuill_cuit_provedor = New System.Windows.Forms.Label()
        Me.txt_nombre_proveedor = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbl_dirccion_provedor = New System.Windows.Forms.Label()
        Me.lbl_telefono_provedor = New System.Windows.Forms.Label()
        Me.txt_telefono_provedor = New System.Windows.Forms.TextBox()
        Me.txt_direccion_provedor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos del Proveedor"
        '
        'lbl_nombre_proveedor
        '
        Me.lbl_nombre_proveedor.AutoSize = True
        Me.lbl_nombre_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_proveedor.Location = New System.Drawing.Point(90, 89)
        Me.lbl_nombre_proveedor.Name = "lbl_nombre_proveedor"
        Me.lbl_nombre_proveedor.Size = New System.Drawing.Size(110, 16)
        Me.lbl_nombre_proveedor.TabIndex = 1
        Me.lbl_nombre_proveedor.Text = "Apellido, nombre"
        '
        'lbl_cuill_cuit_provedor
        '
        Me.lbl_cuill_cuit_provedor.AutoSize = True
        Me.lbl_cuill_cuit_provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuill_cuit_provedor.Location = New System.Drawing.Point(128, 123)
        Me.lbl_cuill_cuit_provedor.Name = "lbl_cuill_cuit_provedor"
        Me.lbl_cuill_cuit_provedor.Size = New System.Drawing.Size(72, 16)
        Me.lbl_cuill_cuit_provedor.TabIndex = 2
        Me.lbl_cuill_cuit_provedor.Text = "CUIL/CUIT"
        '
        'txt_nombre_proveedor
        '
        Me.txt_nombre_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_proveedor.Location = New System.Drawing.Point(221, 86)
        Me.txt_nombre_proveedor.Name = "txt_nombre_proveedor"
        Me.txt_nombre_proveedor.Size = New System.Drawing.Size(172, 22)
        Me.txt_nombre_proveedor.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(221, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(172, 22)
        Me.TextBox2.TabIndex = 6
        '
        'lbl_dirccion_provedor
        '
        Me.lbl_dirccion_provedor.AutoSize = True
        Me.lbl_dirccion_provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dirccion_provedor.Location = New System.Drawing.Point(454, 89)
        Me.lbl_dirccion_provedor.Name = "lbl_dirccion_provedor"
        Me.lbl_dirccion_provedor.Size = New System.Drawing.Size(65, 16)
        Me.lbl_dirccion_provedor.TabIndex = 7
        Me.lbl_dirccion_provedor.Text = "Dirección"
        '
        'lbl_telefono_provedor
        '
        Me.lbl_telefono_provedor.AutoSize = True
        Me.lbl_telefono_provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono_provedor.Location = New System.Drawing.Point(457, 126)
        Me.lbl_telefono_provedor.Name = "lbl_telefono_provedor"
        Me.lbl_telefono_provedor.Size = New System.Drawing.Size(62, 16)
        Me.lbl_telefono_provedor.TabIndex = 8
        Me.lbl_telefono_provedor.Text = "Teléfono"
        '
        'txt_telefono_provedor
        '
        Me.txt_telefono_provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telefono_provedor.Location = New System.Drawing.Point(539, 120)
        Me.txt_telefono_provedor.Name = "txt_telefono_provedor"
        Me.txt_telefono_provedor.Size = New System.Drawing.Size(172, 22)
        Me.txt_telefono_provedor.TabIndex = 9
        '
        'txt_direccion_provedor
        '
        Me.txt_direccion_provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_direccion_provedor.Location = New System.Drawing.Point(539, 86)
        Me.txt_direccion_provedor.Name = "txt_direccion_provedor"
        Me.txt_direccion_provedor.Size = New System.Drawing.Size(172, 22)
        Me.txt_direccion_provedor.TabIndex = 10
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 164)
        Me.Controls.Add(Me.txt_direccion_provedor)
        Me.Controls.Add(Me.txt_telefono_provedor)
        Me.Controls.Add(Me.lbl_telefono_provedor)
        Me.Controls.Add(Me.lbl_dirccion_provedor)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txt_nombre_proveedor)
        Me.Controls.Add(Me.lbl_cuill_cuit_provedor)
        Me.Controls.Add(Me.lbl_nombre_proveedor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nombre_proveedor As Label
    Friend WithEvents lbl_cuill_cuit_provedor As Label
    Friend WithEvents txt_nombre_proveedor As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbl_dirccion_provedor As Label
    Friend WithEvents lbl_telefono_provedor As Label
    Friend WithEvents txt_telefono_provedor As TextBox
    Friend WithEvents txt_direccion_provedor As TextBox
End Class
