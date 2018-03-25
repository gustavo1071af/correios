Module Module1

    Sub Main()
        'System.Console.Write("Digite o CEP: ")
        'Dim Valor = System.Console.ReadLine()
        'Try
        '    Dim WS = New WSCorreios.AtendeClienteClient()
        '    Dim Resposta = WS.consultaCEP(Valor)
        '    System.Console.WriteLine()
        '    System.Console.WriteLine("Endereço: {0}", Resposta.end)
        '    System.Console.WriteLine("Complemento: {0}", Resposta.complemento)
        '    System.Console.WriteLine("Complemento 2: {0}", Resposta.complemento2)
        '    System.Console.WriteLine("Bairro: {0}", Resposta.bairro)
        '    System.Console.WriteLine("Cidade: {0}", Resposta.cidade)
        '    System.Console.WriteLine("Estado: {0}", Resposta.uf)
        '    System.Console.WriteLine("Unidades de Postagem: {0}", Resposta.unidadesPostagem)
        'Catch Ex As Exception
        '    System.Console.WriteLine("Erro ao efetuar busca do CEP: {0}", Ex.Message)
        'End Try
        'System.Console.ReadLine()

        System.Console.Write("Digite o código do tipo de envio: ")
        Dim TipoEnvio = System.Console.ReadLine()
        System.Console.Write("Digite o CEP de origem: ")
        Dim CepOrigem = System.Console.ReadLine()
        System.Console.Write("Digite o CEP de destino: ")
        Dim CepDestino = System.Console.ReadLine()
        System.Console.Write("Digite o peso (kg): ")
        Dim Peso = System.Console.ReadLine()
        System.Console.Write("Digite o código do formato (caixa, envelope, etc): ")
        Dim CodigoFormato = System.Console.ReadLine()
        System.Console.Write("Digite o comprimento: ")
        Dim Comprimento = System.Console.ReadLine()
        System.Console.Write("Digite a altura: ")
        Dim Altura = System.Console.ReadLine()
        System.Console.Write("Digite a largura: ")
        Dim Largura = System.Console.ReadLine()
        System.Console.Write("Digite o diâmetro: ")
        Dim Diametro = System.Console.ReadLine()
        System.Console.Write("Entrega em mão própria (S/N)?: ")
        Dim MaoPropria = System.Console.ReadLine()
        System.Console.Write("Digite o valor declarado: ")
        Dim ValorDeclarado = System.Console.ReadLine()
        System.Console.Write("Aviso de recebimento (S/N)?: ")
        Dim AvisoRecebimento = System.Console.ReadLine()

        Try
            Dim CodigoFormatoInt As Integer
            If (Not Integer.TryParse(CodigoFormato, CodigoFormatoInt)) Then
                Throw New Exception("Código do formato inválido")
            End If
            Dim ComprimentoDecimal As Decimal
            If (Not Decimal.TryParse(Comprimento, ComprimentoDecimal)) Then
                Throw New Exception("Comprimento inválido")
            End If
            Dim AlturaDecimal As Decimal
            If (Not Decimal.TryParse(Altura, AlturaDecimal)) Then
                Throw New Exception("Altura inválida")
            End If
            Dim LarguraDecimal As Decimal
            If (Not Decimal.TryParse(Largura, LarguraDecimal)) Then
                Throw New Exception("Largura inválida")
            End If
            Dim DiametroDecimal As Decimal
            If (Not Decimal.TryParse(Diametro, DiametroDecimal)) Then
                Throw New Exception("Diâmetro inválido")
            End If
            Dim ValorDeclaradoDecimal As Decimal
            If (Not Decimal.TryParse(ValorDeclarado, ValorDeclaradoDecimal)) Then
                Throw New Exception("Valor declarado inválido")
            End If

            Dim WS As New WSCorreiosPreco.CalcPrecoPrazoWSSoapClient()
            Dim Resposta = WS.CalcPrecoPrazo(String.Empty, String.Empty, TipoEnvio, CepOrigem, CepDestino, Peso, CodigoFormatoInt, ComprimentoDecimal, AlturaDecimal, LarguraDecimal, DiametroDecimal, MaoPropria, ValorDeclaradoDecimal, AvisoRecebimento)
            Dim RespostaReal = Resposta.Servicos.FirstOrDefault()
            If (RespostaReal IsNot Nothing) Then
                System.Console.WriteLine()
                System.Console.WriteLine("Prazo: {0} dia", RespostaReal.PrazoEntrega)
                System.Console.WriteLine("Valor: R$ {0}", RespostaReal.Valor)
            Else
                Throw New Exception("Não foi possível encontrar os valores dentro da resposta do serviço")
            End If
        Catch Ex As Exception
            System.Console.WriteLine("Erro ao efetuar cálculos: {0}", Ex.Message)
        End Try

        System.Console.ReadLine()
    End Sub

End Module