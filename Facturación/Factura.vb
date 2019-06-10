Public Class Factura
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lista_Articulos.Hide()
        lbl_apellido_factura.Text = txt_apellido_nombre_cliente
        lbl_cuil_cuit_cliente.Text = txt_cuil_cuit_cliente
        lbl_direccion_factura.Text = txt_direccion_cliente
        lbl_telefono_cliente.Text = txt_telefono_cliente
        lbl_lista_tipo_factura.Text = lista_tipo_factura

    End Sub

    Private Sub Lbl_factura_Click(sender As Object, e As EventArgs) Handles lbl_factura.Click

    End Sub

    Private Sub Lbl_direccion_factura_Click(sender As Object, e As EventArgs) Handles lbl_direccion_factura.Click

    End Sub

    Private Sub Lbl_lista_tipo_factura_Click(sender As Object, e As EventArgs) Handles lbl_lista_tipo_factura.Click

    End Sub
End Class