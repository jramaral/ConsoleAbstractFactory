using System;
using ConsoleAbstractFactory.Interfaces;

namespace ConsoleAbstractFactory.Caracteristicas.Revestimento
{
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor vermelha");
        }
    }
}