Public Class Carga_Cliente
    Private Sub Bt_carga_cliente_Click(sender As Object, e As EventArgs) Handles bt_carga_cliente.Click
        Lista_Articulos.Show()
        Modulo_CLIENTE.txt_apellido_nombre_cliente = txt_apellido_nombre_cliente.Text
        Modulo_CLIENTE.txt_cuil_cuit_cliente = txt_cuil_cuit_cliente.Text
        Modulo_CLIENTE.txt_direccion_cliente = txt_direccion_cliente.Text
        Modulo_CLIENTE.txt_telefono_cliente = txt_telefono_cliente.Text
        Modulo_CLIENTE.lista_tipo_factura = lista_tipo_factura.Text

    End Sub
    Private Sub Carga_Clientevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class