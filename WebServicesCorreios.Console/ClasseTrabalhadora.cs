using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServicesCorreios.Console.WSCorreios;
using WebServicesCorreios.Console.WSCorreiosPreco;

namespace WebServicesCorreios.Console
{
    public class ClasseTrabalhadora
    {

        public static enderecoERP ConsultaCEP(string valor)
        {
            var ws = new WSCorreios.AtendeClienteClient();
            var resposta = ws.consultaCEP(valor);
            return resposta;
        }

        public static cServico CalcPrecoPrazo(string empresa, string senha, string servico, string cepOrigem, string cepDestino, string vlPeso, int cdFormato, decimal vlComprimento, decimal vlAltura, decimal vlLargura, decimal vlDiametro, string cdMaoPropria, decimal vlValorDeclarado, string cdAvisoRecebimento)
        {
              var ws = new WSCorreiosPreco.CalcPrecoPrazoWSSoapClient();
              var resposta = ws.CalcPrecoPrazo(empresa, senha, empresa, cepOrigem, cepDestino, vlPeso, cdFormato, vlComprimento, vlAltura, vlLargura, vlDiametro, cdMaoPropria, vlValorDeclarado, cdAvisoRecebimento);
              var respostaReal = resposta.Servicos.FirstOrDefault();
            return respostaReal;
        }
    }
}
