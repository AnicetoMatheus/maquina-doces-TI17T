using System;

namespace calculadora
{
    class ControlCalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        public ControlCalculadora()
        {
            this.calculadora = new ModelCalculadora();
        }//fim do construtor



        public void Coletarcontar()
        {
            Console.WriteLine("Informe primeiro número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe ultimo número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());

        }

        public void ColetarTabuada()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Até onde quer calcular: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());

        }

        public void ColetarImpar()
        {
            Console.WriteLine("Informe um número ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
        }

        public void Coletar1()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
        }
        public void Coletar()
        {
            Console.WriteLine("Informe um número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());
        }//fim do coletar

        public void Coletarsalario()
        {
            Console.WriteLine("Informe um o Salário: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

        }

        public int Menu()
        {
            Console.WriteLine("------ Menu -------" +
                              "\n0. Sair" +
                              "\n1. Somar" +
                              "\n2. Subtrair" +
                              "\n3. Dividir" +
                              "\n4. Multiplicar" +
                              "\n5. Potência" +
                              "\n6. Raiz" +
                              "\n7. Tabuada" +
                              "\n8. Conversão de binário para decimal" +
                              "\n9. Conversão de decimal para binário" +
                              "\n10. Hexadecimal para decimal " +
                              "\n11. Decimal para Hexadecimal" +
                              "\n12. Bhaskara" +
                              "\n13. Calcular o dobro" +
                              "\n14. Calcular o triplo " +
                              "\n15. Calcular 30% so salário" +
                              "\n16. Impar/Par  Positivo/Negativo" +
                              "\n17. Soma dos números inteiros de 1 a 100" +
                              "\n18. Tabuada ate N"+
                              "\n19. Contar ate N"+
                              "\n\nEscolha uma das opções acima: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//fim do método Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                opcao = Menu();
                Console.Clear();//Limpa a tela
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir!");
                        }
                        else
                        {
                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine(this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    case 8:
                        Console.WriteLine("Informe um valor em binário: ");
                        Console.WriteLine(this.calculadora.ConverterDecimal(Console.ReadLine()));
                        break;
                    case 9:
                        Console.WriteLine("Informe um valor em decimal: ");
                        Console.WriteLine(this.calculadora.ConverterBinario(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 10:
                        Console.WriteLine("Informe um valor em Hexadecimal: ");
                        Console.WriteLine(this.calculadora.ConverterHexaDecimal(Console.ReadLine()));
                        break;
                    case 11:
                        Console.WriteLine("Informe um valor em Decimal: ");
                        Console.WriteLine(this.calculadora.ConverterDecimalHexa(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case 12:
                        Console.WriteLine("Informe A: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe B: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe C: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.bhaskara(a, b, c));
                        break;

                    case 13:
                        Coletar1();
                        Console.WriteLine("O dobro é : " + this.calculadora.dobro());
                        break;

                    case 14:
                        Coletar1();
                        Console.WriteLine("O triplo é : " + this.calculadora.triplo());
                        break;

                    case 15:
                        Coletarsalario();
                        Console.WriteLine("O salario é de : " + this.calculadora.salario());
                        break;
                    case 16:
                        ColetarImpar();
                        Console.WriteLine(this.calculadora.ParImpar());
                        break;

                    case 17:
                        Console.WriteLine(this.calculadora.soma1a100());
                        break;
                    
                    case 18:
                        ColetarTabuada();                    
                        int x = Convert.ToInt32(Console.ReadLine());
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.calculadora.tabuadaX(x,num));
                        break;

                        case 19:
                        Coletarcontar();
                        int numI = Convert.ToInt32(Console.ReadLine());
                        int numF = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.calculadora.contar(numI, numF));
                        break;


                    default:
                        Console.WriteLine("Opção escolhida não é valida");
                        break;
                }//fim do switch

            } while (opcao != 0);//fim do Do...while
        }//fim do operacao
    }//fim da classe
}//fim do projeto