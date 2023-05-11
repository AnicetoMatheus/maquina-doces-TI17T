using System;

namespace MaquinaDeDoces
{
    class ControlProduto
    {
        Produto prod;
        private int opcao;

        // metodo consrtutor
        public ControlProduto()
        {
            prod = new Produto();
            ModificarOpcao = -1;

        }// fim do modo construtor


        // modo getset
        public int ModificarOpcao
        {

            get { return opcao; }
            set { opcao = value; }
        }// fim do modo get set 
        public void menu()
        {


            Console.WriteLine("\n\n\n escolha uma das opções abaixo \n" +
                "0. sair\n" +
                "1.cadastrar produto\n" +
                "2.consultar produto\n" +
                "3.atualizar produto\n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());

        }//fim do metodo menu

        // realizar operação

        public void Operacao()
        {
            do
            {
                menu();   // mostrando menu na tela 

                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("obrigado");
                        break;
                        Console.Clear();
                    case 1:
                        ColetarDados();
                        break;
                        Console.Clear();
                    case 2:
                        Consultar();
                        Console.Clear();
                        break;
                        Console.Clear();
                    case 3:
                        atualizar();
                        break;
                        Console.Clear();
                    case 4:
                        AlterarSituacao();
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("opção escolhida não e válida!");
                        break;

                }// fim escolha
            } while (ModificarOpcao != 0);
        }// fim do medoto operacao 

        public void AlterarSituacao()
        {
            Console.WriteLine("informe o código que deseja alterar o status:");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //chamar metodo alterarSituação - classe produto 
            prod.AlterarSituacao(codigo);
            Console.WriteLine("alterado!");


        }// fim do metodo 



        // criar um metodo de solicitação de dados
        public void ColetarDados()
        {
            // coletar dados do usuario
            Console.WriteLine("informe um código");

            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("faça um breve descrição do produto");
            string descricao = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("informe a quantidade de produtos no estoque");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe a data de validade do produto");
            DateTime dtvalidade = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("informe a situação : true - ativo // false - desativo");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());



            // cadastrar produtos
            prod.CadastrarProduto(codigo, nome, descricao, preco, dtvalidade, quantidade, situacao);
            Console.WriteLine("Dados Registrado !");

        }

        // consultar 

        public void Consultar()
        {

            Console.WriteLine("\n\n\n informe o código do produto que deseja consultar");
            int codigo = Convert.ToInt32(Console.ReadLine());
            // escrever os resultados na tela 
            Console.WriteLine("os dados do produto escolhido são: \n\n\n" + prod.ConsultarProduto(codigo));


        }// fim do consultar

        public void atualizar()
        {

            Console.WriteLine("\n\n informe o código do produto que deseja atualizar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            short campo = 0;
            do
            {
                Console.WriteLine("informe o campo que deseja atualiar de acordo com a regra abaixo; \n" +
                                "1.nome\n" +
                                "2. descrição\n" +
                                "3. preço\n" +
                                "4.Quantidade\n" +
                                "5.data de validade\n" +
                                "6. situação");
                campo = Convert.ToInt16(Console.ReadLine());

                // avisar o úsuario 
                if ((campo < 1) || (campo > 6))
                {
                    Console.WriteLine("Erro. escolha um nomero entre 1 e 6");
                }
            } while ((campo < 1) || (campo > 6));
            Console.WriteLine("informe o dao que será atualizado :");
            string novoDado = Console.ReadLine();

            // chamar o medoto da atulização

            prod.AtualizarProduto(codigo, campo, novoDado);


        }// fim do metodo atualizar

    }//fim da classe
}// fim do projeto
