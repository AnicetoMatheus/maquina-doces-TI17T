using System;

namespace MaquinaDeDoces
{
    class Program
    {
        static void Main(string[] args)
        {
            // conecta a class do produto 
            ControlProduto controlProd = new ControlProduto();
            // chamar o metodo principal doaquela classe
            controlProd.Operacao();

            Console.WriteLine();


        }//fim do metodo main 
    }// fim do projeto 
}// fim do projeto 
