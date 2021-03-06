using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaspagemWind
{
    public class DadosUrupes : Dados
    {
        
        public DadosUrupes()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("http://www.urupes.sp.gov.br/coronavirus/");
            var HeaderNames = doc.DocumentNode
                .SelectNodes("//td[@class='numeros_casos']").ToList();
            var totalCasos = doc.DocumentNode
                .SelectNodes("//div[@class='numeros_casos']").ToList();
            this.totalConfirmado = Convert.ToInt32(totalCasos[0].InnerText);
            this.receberamAlta = Convert.ToInt32(HeaderNames[0].InnerText);
            this.ConfirmadoTratamento = Convert.ToInt32(HeaderNames[1].InnerText);
            this.ConfirmadoHospital = Convert.ToInt32(HeaderNames[2].InnerText);
            this.Obitos = Convert.ToInt32(HeaderNames[3].InnerText);
            this.aguardandoCasa = Convert.ToInt32(HeaderNames[4].InnerText);
            this.aguardandoHospital = Convert.ToInt32(HeaderNames[5].InnerText);
            this.obitoInvestigacao = Convert.ToInt32(HeaderNames[6].InnerText);
            this.TaxaMortalidade = (double.Parse(HeaderNames[3].InnerText) / double.Parse(totalCasos[0].InnerText)) * 100;
        }
    }
}
