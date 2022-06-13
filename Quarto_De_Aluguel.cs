using System;


namespace quarto_de_aluguel
{
    class Programa
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Projeto  -  Aluguel Quarto");
            Console.WriteLine();

            Console.WriteLine("***************************************************************************************");
            Console.WriteLine("Bem vindos ao hotel");
            Console.WriteLine("***************************************************************************************");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Digite o número de quartos que deseja alugar:");
            int numeroquartos = int.Parse(Console.ReadLine());

            Quarto[] hospede = new Quarto[numeroquartos];

            for (int i = 0; i < numeroquartos; i++)
            {
                Console.WriteLine("-------------HOSPEDE " + (i + 1) + "DIGITE SEUS DADOS------------");
                Console.WriteLine();
                Console.Write("Qual é o seu nome?");
                string nome = Console.ReadLine();
                Console.Write("Qual é o seu genero?");
                string sexo = Console.ReadLine();
                Console.Write("Qual é sua data de nascimento?");
                string datanascimento = Console.ReadLine();
                Console.Write("Qual é seu CPF?");
                string cpf = Console.ReadLine();
                Console.Write("Qual é o seu E-Mail?");
                string email = Console.ReadLine();
                Console.Write("Qual é o seu telefone?");
                string telefone = Console.ReadLine();
                Console.WriteLine();

                hospede[i] = new Quarto(nome, cpf, telefone, email, sexo, datanascimento);
            }

            dadosquarto[] pagamento = new dadosquarto[numeroquartos];

            for (int i = 0; i < numeroquartos; i++)
            {
                Console.WriteLine("---------------HOSPEDE " + (i + 1) + ", DIGITE O VALOR DO QUARTO ------------------------");
                Console.WriteLine();
                Console.WriteLine("Qual é o valor do quarto por mês?");
                double valor = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantos meses?");
                double meses = double.Parse(Console.ReadLine());

                pagamento[i] = new dadosquarto(valor, meses);
            }

            for (int i = 0; i < numeroquartos; i++)
            {
                Console.WriteLine("---------------RELATÓRIO DE DADOS DO HOSPEDE " + (i + 1) + " ------------------------");
                Console.WriteLine();
                Console.WriteLine(hospede[i]);
                Console.WriteLine();
                Console.WriteLine(pagamento[i]);

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para prosseguir.");
                Console.ReadLine();
            }
        }
    }
}