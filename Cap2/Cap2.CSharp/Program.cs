using System;

namespace Cap2.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PeriodoDeTempoImutavel periodo = new PeriodoDeTempoImutavel(
                DateTime.Parse("20/08/2016"), DateTime.Parse("31/08/2016"));

            DateTime[] datasParaTeste = new DateTime[]
            {
                DateTime.Parse("18/08/2016"),
                DateTime.Parse("22/08/2016"),
                DateTime.Parse("01/09/2016")
            };

            foreach (DateTime dataParaTestar in datasParaTeste)
            {
                bool resultadoDaVerificacao = PeriodoDeTempoImutavel.VerificarSeDataEstaEntreOPeriodo(periodo, dataParaTestar);
                Console.WriteLine(resultadoDaVerificacao);
            }

            PeriodoDeTempoImutavel.AdicionarDias(periodo, 30);
            Console.WriteLine("Resultado após a operação:");

            foreach (DateTime dataParaTestar in datasParaTeste)
            {
                bool resultadoDaVerificacao = PeriodoDeTempoImutavel.VerificarSeDataEstaEntreOPeriodo(periodo, dataParaTestar);
                Console.WriteLine(resultadoDaVerificacao);
            }

            Console.ReadKey();
        }

        void ExemploUsoDeDeclaracao(int numero)
        {
            int resultado = 0;
            bool numeroPar = numero % 2 == 0;

            if (numeroPar)
            {
                resultado = 2;
            }

            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        void ExemploUsoDeExpressao(int numero)
        {
            bool numeroPar = numero % 2 == 0;
            int resultado = numeroPar ? 2 : 0;
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
