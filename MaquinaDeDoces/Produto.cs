using System;

namespace MaquinaDeDoces
{
    class Produto
    {
        // definição das VAR
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;
        // método construtor 
        public Produto()
        {

            ModificarCodigo = 0;
            ModificarNome = "";
            ModificarDescricao = "";
            ModificarPreco = 0;
            ModificarQuantidade = 0;
            ModificardtValidade = new DateTime();
            ModificarSituacao = false;

        }// fim do método construtor

        // metodo construtor com parametro
        public Produto(int codigo, string nome, string descricao, double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo = codigo;
            ModificarNome = nome;
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificardtValidade = dtValidade;
            ModificarSituacao = situacao;
        }
        // fim metodo construtor com pârametro 

        // Método Get e Set

        // Método de acesso de modificação

        public int ModificarCodigo
        {
            get
            {
                return this.codigo;
            } // fim do get - retornar produto  , consultar
            set
            {
                this.codigo = value;
            }// fim do set - modificar codigo
        }

        public string ModificarNome
        {
            get { return this.nome; }
            set { this.nome = value; }
        } // fim modificar nome 

        public string ModificarDescricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }// fim modifica descrição


        public double ModificarPreco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }// fim modificar preço

        public int ModificarQuantidade
        {
            get
            {
                return this.quantidade;
            }
            set
            {
                this.quantidade = value;
            }
        }// fim modificar quantidade

        public DateTime ModificardtValidade
        {
            get { return this.dtValidade; }
            set { this.dtValidade = value; }

        }//fim modificar data de validade

        public Boolean ModificarSituacao
        {
            get { return this.situacao; }
            set { this.situacao = value; }
        }// fim modificar situação 

        public void CadastrarProduto(
            int codigo, string nome, string descricao, double preco, DateTime dtValidade, int quantidade, Boolean situacao
            )

        {
            ModificarCodigo = codigo;
            ModificarNome = nome;
            ModificarDescricao = descricao;
            ModificarPreco = preco;
            ModificarQuantidade = quantidade;
            ModificardtValidade = dtValidade;
            ModificarSituacao = situacao;

        } // fim do metodo cadastrar produto 

        // consultar produto
        public string ConsultarProduto(int codigo)
        {
            string msg = ""; // criando VAR
            if (ModificarCodigo == codigo)
            {

                msg = "codigo" + ModificarCodigo +
                 "\n Código:" + ModificarCodigo +
                 "\nNome:" + ModificarNome +
                 "\nDescrição" + ModificarDescricao +
                 "\n Preço:" + ModificarPreco +
                 "\nQuantidade" + ModificarQuantidade +
                 "\nData De Validade" + ModificardtValidade +
                 "\n Situação" + ModificarSituacao;



            }
            else
            {
                msg = "O código digitado não existe";
            }
            return msg;
        } // fim do metodo consultar produto 

        //inicio metodo atualizar produto
        public Boolean AtualizarProduto(int codigo, string campo, string novoDado)
        {
            Boolean flag = false;

            if (ModificarCodigo == codigo)

            {
                switch (campo)
                {
                    case "1":
                        ModificarNome = novoDado;
                        flag = true;
                        break;

                    case "2":
                        ModificarDescricao = novoDado;
                        flag = true;
                        break;

                    case "3":
                        ModificarPreco = Convert.ToDouble(novoDado);
                        flag = true;
                        break;

                    case "4":
                        ModificarQuantidade = Convert.ToInt32(novoDado);
                        flag = true;
                        break;
                    case "5":
                        ModificardtValidade = Convert.ToDateTime(novoDado);
                        flag = true;
                        break;
                    case 6:
                        ModificarSituacao = Convert.ToBoolean(novoDado);
                        flag = true;
                        break;

                    default:
                        break;

                }//fim do escolha
            }//fim do if
            return flag;
        }// fim metodo atualizar produto 



        public void AlterarCodigo(int codigo)

        {
            Boolean flag = false;

            if (ModificarCodigo == codigo)
            {
                if (ModificarSituacao == true)
                {
                    ModificarSituacao = false;
                }
                else
                {
                    ModificarSituacao = true;
                }
                flag = true;

            }// fim desativar produto
        }

        // solicitar produtos
        public Boolean SolicitarProduto()
        {
            if (ModificarCodigo == codigo)
            {
                if (ModificarQuantidade <= 3)
                {
                    return true;

                }
                else
                {
                    return false;

                }

            }
            return false;
        }// fim solicitar produtos



    }//fim da classe 
}// fim do projeto 
