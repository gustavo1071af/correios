using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServicesCorreios.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o CEP: ");
            var valor = System.Console.ReadLine();
            try
            {
                string str = valor.ToString();
                foreach (var c in str.ToCharArray()) // Noncompliant
                {
                    System.Console.Write(c);
                }
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(valor);
                System.Console.WriteLine();
                System.Console.WriteLine("Endereço: {0}", resposta.end);
                System.Console.WriteLine("Complemento: {0}", resposta.complemento);
                System.Console.WriteLine("Complemento 2: {0}", resposta.complemento2);
                System.Console.WriteLine("Bairro: {0}", resposta.bairro);
                System.Console.WriteLine("Cidade: {0}", resposta.cidade);
                System.Console.WriteLine("Estado: {0}", resposta.uf);
                System.Console.WriteLine("Unidades de Postagem: {0}", resposta.unidadesPostagem);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Erro ao efetuar busca do CEP: {0}", ex.Message);
            }
            System.Console.ReadLine();

            //System.Console.Write("Digite o código do tipo de envio: ");
            //var tipoEnvio = System.Console.ReadLine();
            //System.Console.Write("Digite o CEP de origem: ");
            //var cepOrigem = System.Console.ReadLine();
            //System.Console.Write("Digite o CEP de destino: ");
            //var cepDestino = System.Console.ReadLine();
            //System.Console.Write("Digite o peso (kg): ");
            //var peso = System.Console.ReadLine();
            //System.Console.Write("Digite o código do formato (caixa, envelope, etc): ");
            //var codigoFormato = System.Console.ReadLine();
            //System.Console.Write("Digite o comprimento: ");
            //var comprimento = System.Console.ReadLine();
            //System.Console.Write("Digite a altura: ");
            //var altura = System.Console.ReadLine();
            //System.Console.Write("Digite a largura: ");
            //var largura = System.Console.ReadLine();
            //System.Console.Write("Digite o diâmetro: ");
            //var diametro = System.Console.ReadLine();
            //System.Console.Write("Entrega em mão própria (S/N)?: ");
            //var maoPropria = System.Console.ReadLine();
            //System.Console.Write("Digite o valor declarado: ");
            //var valorDeclarado = System.Console.ReadLine();
            //System.Console.Write("Aviso de recebimento (S/N)?: ");
            //var avisoRecebimento = System.Console.ReadLine();

            //try
            //{
            //    int codigoFormatoInt;
            //    if (!int.TryParse(codigoFormato, out codigoFormatoInt))
            //        throw new Exception("Código do formato inválido");
            //    decimal comprimentoDecimal;
            //    if (!decimal.TryParse(comprimento, out comprimentoDecimal))
            //        throw new Exception("Comprimento inválido");
            //    decimal alturaDecimal;
            //    if (!decimal.TryParse(altura, out alturaDecimal))
            //        throw new Exception("Altura inválida");
            //    decimal larguraDecimal;
            //    if (!decimal.TryParse(largura, out larguraDecimal))
            //        throw new Exception("Largura inválida");
            //    decimal diametroDecimal;
            //    if (!decimal.TryParse(diametro, out diametroDecimal))
            //        throw new Exception("Diâmetro inválido");
            //    decimal valorDeclaradoDecimal;
            //    if (!decimal.TryParse(valorDeclarado, out valorDeclaradoDecimal))
            //        throw new Exception("Valor declarado inválido");

            //    var ws = new WSCorreiosPreco.CalcPrecoPrazoWSSoapClient();
            //    var resposta = ws.CalcPrecoPrazo(string.Empty, string.Empty, tipoEnvio, cepOrigem, cepDestino, peso, codigoFormatoInt, comprimentoDecimal, alturaDecimal, larguraDecimal, diametroDecimal, maoPropria, valorDeclaradoDecimal, avisoRecebimento);
            //    var respostaReal = resposta.Servicos.FirstOrDefault();
            //    if (respostaReal != null)
            //    {
            //        System.Console.WriteLine();
            //        System.Console.WriteLine("Prazo: {0} dia", respostaReal.PrazoEntrega);
            //        System.Console.WriteLine("Valor: R$ {0}", respostaReal.Valor);
            //    }
            //    else
            //    {
            //        throw new Exception("Não foi possível encontrar os valores dentro da resposta do serviço");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    System.Console.WriteLine("Erro ao efetuar cálculos: {0}", ex.Message);
            //}
            //System.Console.ReadLine();
        }
    }
}
