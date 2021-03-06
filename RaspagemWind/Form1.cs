using System;
using System.Windows.Forms;

namespace RaspagemWind
{
    public partial class Form1 : Form
    {
        
        DadosUrupes dados = new DadosUrupes();
        public void ConstruirUrupes()
        {
            lblTotal.Text = dados.totalConfirmado.ToString();
            lblAguardando.Text = (dados.aguardandoCasa + dados.aguardandoHospital).ToString();
            lblAtivosCasa.Text = dados.ConfirmadoTratamento.ToString();
            lblInternados.Text = dados.ConfirmadoHospital.ToString();
            lblCurados.Text = dados.receberamAlta.ToString();
            lblObitos.Text = dados.Obitos.ToString();
            lblTotalCasos.Text = dados.totalConfirmado.ToString();
            lblTaxaMortalidade.Text = dados.TaxaMortalidade.ToString("F") + "%";
        }
        public Form1()
        {
            InitializeComponent();
            ConstruirUrupes();
        }

    }
}
