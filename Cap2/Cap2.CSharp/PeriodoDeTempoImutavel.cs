using System;
using System.Collections.Generic;
using System.Text;

namespace Cap2.CSharp
{
    public class PeriodoDeTempoImutavel
    {
        private readonly DateTime _dataInicial;
        private readonly DateTime _dataFinal;
        
        public DateTime DataInicial { get { return _dataInicial; } }
        public DateTime DataFinal { get { return _dataFinal; } }

        public PeriodoDeTempoImutavel(DateTime dataInicial, DateTime dataFinal)
        {
            _dataInicial = dataInicial;
            _dataFinal = dataFinal;
        }

        public static bool VerificarSeDataEstaEntreOPeriodo(PeriodoDeTempoImutavel periodo, DateTime dataParaTestar)
        {
            return dataParaTestar.CompareTo(periodo.DataInicial) >= 0 &&
                dataParaTestar.CompareTo(periodo.DataFinal) <= 0;
        }

        public static PeriodoDeTempoImutavel AdicionarDias(PeriodoDeTempoImutavel periodo, int dias)
        {
            return new PeriodoDeTempoImutavel(periodo.DataInicial.AddDays(dias), periodo.DataFinal.AddDays(dias));
        }
    }
}
