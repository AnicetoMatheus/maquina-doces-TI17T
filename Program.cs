using System;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlCalculadora control = new ControlCalculadora();
            control.Operacao();
            Console.ReadLine();

        }// fim do método main
    }//fim da classe program
}//fim do projeto calculadora
