Public Class Form1
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        Using WS = New WSCorreios.AtendeClienteClient()
            Try
                Dim Resultado = WS.consultaCEP(TbCEP.Text)
                TbEndereco.Text = Resultado.[end]
                TbComplemento.Text = Resultado.complemento
                TbComplemento2.Text = Resultado.complemento2
                TbCidade.Text = Resultado.cidade
                TbBairro.Text = Resultado.bairro
                TbEstado.Text = Resultado.uf
            Catch Ex As Exception
                MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End Using
    End Sub
End Class
