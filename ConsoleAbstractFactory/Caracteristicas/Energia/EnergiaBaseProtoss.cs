using System;
using ConsoleAbstractFactory.Interfaces;

namespace ConsoleAbstractFactory.Caracteristicas.Energia
{
    public class EnergiaBaseProtoss : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base com cristais");
        }
    }
}