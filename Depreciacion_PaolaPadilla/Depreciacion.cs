using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depreciacion_PaolaPadilla
{
    public class Depreciacion
    {
        

        public int Numero { get; set; }
        public int Periodo { get; set; }
        public int NumeroMeses { get; set; }
        public double ValorHistorico { get; set; }
        public float D_Periodo { get; set; }
        public float D_Acumulada { get; set; }
        public double Saldo { get; set; }



        public Depreciacion(int numero, int periodo, int numeroMeses, double valorHistorico,
            float d_Periodo, float d_Acumulada, double saldo)
        {
            Numero = numero;
            Periodo = periodo;
            NumeroMeses = numeroMeses;
            ValorHistorico = valorHistorico;
            D_Periodo = d_Periodo;
            D_Acumulada = d_Acumulada;
            Saldo = saldo;
        }

    }
}
