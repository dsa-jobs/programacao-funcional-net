using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAplicacao
{
    class Calculadora
    {
        public int ElevarNumeroAoQuadrado(int numero)
        {
            return numero * numero;
        }

        public int SomaQuadradosDosNumerosAteDez()
        {
            return Enumerable.Range(1, 10)
                .Select(ElevarNumeroAoQuadrado)
                .Sum();
        }
    }
}
