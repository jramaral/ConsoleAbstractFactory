using System;
using ConsoleAbstractFactory.Bases;
using ConsoleAbstractFactory.Caracteristicas.Energia;
using ConsoleAbstractFactory.Caracteristicas.Revestimento;

namespace ConsoleAbstractFactory.FabricaRacas
{
    public class FabricaBaseProtoss : IFabricaBases
    {
        public FabricaBaseProtoss()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base	Protoss	criada	com	sucesso!");
            RevestimentoBaseProtoss revestimento = new RevestimentoBaseProtoss();
            revestimento.Composicao();
            EnergiaBaseProtoss energia = new EnergiaBaseProtoss();
            energia.Composicao();
        }
    }
}