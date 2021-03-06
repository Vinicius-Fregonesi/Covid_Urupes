using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaspagemWind
{
    public class Dados
    {
        public int totalConfirmado { get; set; }
        public int receberamAlta { get; set; }
        public int ConfirmadoTratamento { get; set; }
        public int ConfirmadoHospital { get; set; }
        public int Obitos { get; set; }
        public int aguardandoCasa { get; set; }
        public int aguardandoHospital { get; set; }
        public int obitoInvestigacao { get; set; }
        public double TaxaMortalidade { get; set; }
    }
}
