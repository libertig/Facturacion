Public Class Lista_Articulos
    Private Sub Lista_Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga_Cliente.Hide()
    End Sub

    Private Sub Bt_finalizar_carga_articulo_Click(sender As Object, e As EventArgs) Handles bt_finalizar_carga_articulo.Click
        Factura.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class