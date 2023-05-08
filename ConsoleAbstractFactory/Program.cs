using System;
using System.Diagnostics;
using ConsoleAbstractFactory.Bases;
using ConsoleAbstractFactory.FabricaRacas;

namespace ConsoleAbstractFactory
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int b = 0;
            do
            {
                Console.WriteLine("Escolha um dos personagens: 1-Protoss | 2-Zergs | 3-Terranos: ");
                var num =int.Parse(Console.ReadLine());
                b = num;
                switch(num)
                {
                    case  1:
                        new FabricaBaseProtoss();
                        break;
                    case 2:
                        new FabricaBaseZerg();
                        break;
                    case 3:
                        new FabricaBaseTerran();
                        break;
                    
                }
                
            } while (b<3 && b>0);
           
            Console.ReadLine();
        }
    }
}