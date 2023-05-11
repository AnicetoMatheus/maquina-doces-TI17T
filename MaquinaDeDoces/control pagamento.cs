using System;

namespace MaquinaDeDoces
{
    internal class control_pagamento
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor total da compra: ");
            double valorTotal = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor pago pelo cliente: ");
            double valorPago = double.Parse(Console.ReadLine());

            double troco = valorPago - valorTotal;

            if (troco < 0)
            {
                Console.WriteLine("Valor pago é insuficiente!");
            }
            else
            {
                Console.WriteLine("Troco a ser dado: " + troco.ToString("C2"));
            }
        }
    }
}
}
