using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depreciacion_PaolaPadilla
{
    internal class Activos
    {
        

        public float P_Anual { get; set; }
        public int VidaUtil { get; set; }
        public int N_Meses { get; set; }



        public Activos(int p_Anual, int vidaUtil, int n_Meses)
        {
            P_Anual = p_Anual;
            VidaUtil = vidaUtil;
            N_Meses = n_Meses;
        }

        public Activos()
        {

        }

    }
}
