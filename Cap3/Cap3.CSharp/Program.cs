using System;
using System.Collections.Generic;
using System.Linq;

namespace Cap3.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numerosPares;
            IEnumerable<int> numeros = Enumerable.Range(0, 10);
            numerosPares = numeros.Where(numero => numero % 2 == 0);
        }

        public void EscreveSeNumeroEParOuImpar(int numero)
        {
            bool verificaSeONumeroEPar() => numero % 2 == 0;
            void escreveNumeroPar() => Console.WriteLine(String.Format("O número {0} é par", numero));
            void escreveNumeroImpar() => Console.WriteLine(String.Format("O número {0} é ímpar", numero));

            if (verificaSeONumeroEPar())
                escreveNumeroPar();
            else
                escreveNumeroImpar();
        }

        public static void ExecutarAcaoSobreElementos<TipoElemento>(List<TipoElemento> lista, Action<TipoElemento> acao)
        {
            lista.ForEach(acao);
        }

        public static void ImprimirNomes(List<string> nomes)
        {
            ExecutarAcaoSobreElementos(nomes, Console.WriteLine);
        }

        public static void ImprimirDobroDosNumeros(List<int> numeros)
        {
            ExecutarAcaoSobreElementos(numeros, numero => Console.WriteLine(numero * 2));
        }

        public static Action<int> MultiplicarEImprimirNumero(int multiplicador)
        {
            return (numero) => Console.WriteLine(numero * multiplicador);
        }

        public static void ImprimirNumeros(List<int> numeros, int multiplicador)
        {
            Action<int> multiplicaEDepoisImprime = MultiplicarEImprimirNumero(multiplicador);
            ExecutarAcaoSobreElementos(numeros, multiplicaEDepoisImprime);
        }

        public static void Programa()
        {
            Action<int> multiplicaPorCincoEDeposImprime = MultiplicarEImprimirNumero(5);
            Action<int> multiplicaPorTresEDeposImprime = MultiplicarEImprimirNumero(3);

            int numeroQueSeraMultiplicado = 10;

            multiplicaPorTresEDeposImprime(numeroQueSeraMultiplicado);
            multiplicaPorCincoEDeposImprime(numeroQueSeraMultiplicado);
        }
    }
}
