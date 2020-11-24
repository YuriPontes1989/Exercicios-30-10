using System;
using System.Collections.Generic;
using System.Text;

namespace Salario
{
    class Funcionario
    {
        int id;
        string nome;
        double salario = 0;


        public int Id { get => id; set => id = value; }

        public string Nome { get => nome; set => nome = value; }

        public double Salario { get => salario; set => salario = value; }

        // aumento do salário
        public void aumentaSalario(double porcent)
        {
            salario += salario * (porcent / 100);
        }


        // impressão na tela das informações dos funcionários
        public override string ToString()
        {
            return "ID: " + Id + "   Nome: " + Nome + "  Salário: " + Salario;
        }
    }
}


namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada do Usuário informando quantos funcionários são
            Console.WriteLine("Informe a quantidade de funcionários: ");
            int qtda = int.Parse(Console.ReadLine());

            // lista de funcionarios criada a partir daqui 
            List <Funcionario>  funcionarios = new List <Funcionario> ();

            //De acordo com a quantidade de funcionário informado pelo usuário o loop é criado
            for (int i = 0; i < qtda; i++)
            {
                //Funcionário instanciado
                Funcionario func = new Funcionario();

                //variavel para verificação se o ID se repete
                bool verificaId = false;

                //Loop para verificação do ID do funcionário
                do
                {
                    if (verificaId == true)
                    {
                        Console.WriteLine(" Caso o Id já  foi utilizado, informe outro: ");
                    }
                    Console.WriteLine("Informe o ID do funcionário: ");
                    func.Id = int.Parse(Console.ReadLine());
                    verificaId = funcionarios.Exists(x => x.Id == func.Id);

                } while (verificaId == true);

                //Entrada do nome do funcionário
                Console.WriteLine("Informe o nome do funcionário por gentileza: ");
                func.Nome = Console.ReadLine();

                //Entrada do salário do funcionário
                Console.WriteLine("Informe o salário do funcionário por favor: ");
                func.Salario = double.Parse(Console.ReadLine());

                //Funcionário adicionado a lista criada
                funcionarios.Add(func);
            }

            //Entrada do ID para realizar o aumento
            Console.WriteLine("Informe o ID do funcionário que receberá aumento por favor : ");
            int id = int.Parse(Console.ReadLine());

            //Procura do ID do funcionário
            if (funcionarios.Exists(x => x.Id == id))
            {
                Console.WriteLine("Qual o aumento do funcionário: ");
                double porcent = double.Parse(Console.ReadLine());

                //Armazenamento do ID para fazer o aumento
                int pos = funcionarios.FindIndex(x => x.Id == id);
                funcionarios[pos].aumentaSalario(porcent);
            }
            else
            {
                Console.ReadKey();
            }

            // lista dos funcionarios
            foreach (Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
