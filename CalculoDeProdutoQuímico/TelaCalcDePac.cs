using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeProdutoQuímico
{
    public partial class TelaCalcDePac : Form
    {
        #region Propriedades privadas
        private PAC _PAC;
        #endregion
        public TelaCalcDePac()
        {
            InitializeComponent();
            _PAC = new PAC();
        }

        private void btnCalcularVolume_Click(object sender, EventArgs e)
        {
            if (cbxCalc2Bombas.Checked == true)
            {
                txtResultadoVolume.Text = _PAC.calculoDuasBombasPAC(Convert.ToInt16(txtConcPac.Text)).ToString("n1");
            }
            else
            {
                txtResultadoVolume.Text = _PAC.calculoUmaBombaPAC(Convert.ToInt16(txtConcPac.Text)).ToString("n1");
            }
        }

        private void cbxCalc2Bombas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcularSinal_Click(object sender, EventArgs e)
        {
            txtResultadoSinal.Text =
                _PAC.calcularSinal(Convert.ToDouble(txtSinalAnt.Text),
                Convert.ToInt16(txtVolumeAnt.Text),
                Convert.ToInt16(txtNovoVol.Text)).ToString("n1");
        }
    }
}
