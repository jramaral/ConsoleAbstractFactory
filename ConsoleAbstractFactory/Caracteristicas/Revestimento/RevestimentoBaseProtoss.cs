using System;
using ConsoleAbstractFactory.Interfaces;

namespace ConsoleAbstractFactory.Caracteristicas.Revestimento
{
    public class RevestimentoBaseProtoss: IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Base revestida pela cor amarela");
        }
    }
}