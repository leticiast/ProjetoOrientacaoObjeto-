using System;
using ProjetoOrientacaoObjeto.src.Entities;

namespace ProjetoOrientacaoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            knight arus = new knight("Arus", 23, "knight"); 
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            ninja wedge = new ninja("Wedge", 23, "Ninja");
            blackWizard topapa = new blackWizard("Topapa", 23, "Black Wizard");  

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(wedge.Blow());
            Console.WriteLine(topapa.Attack(1));
        }
    }
}
