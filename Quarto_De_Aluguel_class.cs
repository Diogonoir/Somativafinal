using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quarto_de_aluguel
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Datanascimento { get; set; }

        public Quarto(string nome, string cpf, string telefone, string email, string sexo, string datanascimento)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Sexo = sexo;
            Datanascimento = datanascimento;
        }

        public override string ToString()
        {
            return "Aluno: " + Nome.ToUpper()
                + "\n Data de Nascimento: " + Datanascimento
                + "\n CPF: " + Cpf
                + "\n Telefone: " + Telefone
                + "\n E-Mail: " + Email
                + "\n Sexo: " + Sexo;
        }

    }

    class dadosquarto
    {

        public double Valor { get; set; }
        public double Meses { get; set; }

        public dadosquarto(double valor, double meses)
        {
            Valor = valor;
            Meses = meses;
        }

        public double Alugueltotal()
        {
            return Valor * Meses;
        }

        public override string ToString()
        {
            return "Valor do Quarto Escolhido: " + Valor
                    + "\n Periodo (Meses): " + Meses
                    + "\n VALOR TOTAL DO QUARTO -----------------------------------------------------" + Alugueltotal();
        }

    }
}