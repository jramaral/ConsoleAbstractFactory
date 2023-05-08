using System;
using ConsoleAbstractFactory.Bases;
using ConsoleAbstractFactory.Caracteristicas.Energia;
using ConsoleAbstractFactory.Caracteristicas.Revestimento;

namespace ConsoleAbstractFactory.FabricaRacas
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public FabricaBaseTerran()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base	Terran	criada	com	sucesso!");
            RevestimentoBaseTerran revestimento = new RevestimentoBaseTerran();
            revestimento.Composicao();
            EnergiaBaseTarran energia = new EnergiaBaseTarran();
            energia.Composicao();
        }
    }
}