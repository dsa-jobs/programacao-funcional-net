using System;
using System.Collections.Generic;
using System.Text;

namespace Cap2.CSharp
{
    public class PeriodoDeTempo
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public bool VerificarSeDataEstaEntreOPeriodo(DateTime dataParaTestar)
        {
            return dataParaTestar.CompareTo(DataInicial) >= 0 &&
                dataParaTestar.CompareTo(DataFinal) <= 0;
        }
    }
}
