using System;
using ConsoleAbstractFactory.Bases;
using ConsoleAbstractFactory.Caracteristicas.Energia;
using ConsoleAbstractFactory.Caracteristicas.Revestimento;

namespace ConsoleAbstractFactory.FabricaRacas
{
    public class FabricaBaseZerg : IFabricaBases
    {
        public FabricaBaseZerg()
        {
            CriarBase();
        }
        public void CriarBase()
        {
            Console.WriteLine("Base	Zerg criada	com	sucesso!");
            RevestimentoBaseZerg revestimento = new RevestimentoBaseZerg();
            revestimento.Composicao();
            EnergiaBaseZerg energia = new EnergiaBaseZerg();
            energia.Composicao();
        }
    }
}