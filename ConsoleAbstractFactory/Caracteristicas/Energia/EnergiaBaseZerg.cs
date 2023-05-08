using System;
using ConsoleAbstractFactory.Interfaces;

namespace ConsoleAbstractFactory.Caracteristicas.Energia
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base pela terra");
        }
    }
}