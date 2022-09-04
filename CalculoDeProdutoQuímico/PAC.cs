using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeProdutoQuímico
{
    class PAC
    {
        #region Propriedades
        public double UmaBomba { get; private set; } = 0.67;
        public double DuasBombas { get; private set; } = 0.94;
        #endregion

        #region funcões do calculo do produto químico
        public Double calculoUmaBombaPAC(int ConcPac)
        {
            return UmaBomba * ConcPac * 20;
            //0.67      //

        }

        public Double calculoDuasBombasPAC(int ConcPac)
        {
            return DuasBombas * ConcPac * 20;
        }

        public Double calcularSinal(double SinalAnt, int NovoVol, int VolumeAnt)
        {
            return (SinalAnt * VolumeAnt) / NovoVol;
        }
        #endregion
    }
}
