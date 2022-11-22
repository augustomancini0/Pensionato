using Pensionato.Models;
using System;
using System.Globalization;

namespace Pensionato
{
    class program
    {
        static void Main(string[] args)
        {
            var hotelaria = new Hotelaria();

            Console.Write("Quantos quartos voce vai alugar? : ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());
            while (quantidadeQuartos > 10)
            {
                Console.WriteLine("Temos somente 10 quartos");
                Console.Write("Quantos quartos voce deseja alugar ? :");
                quantidadeQuartos = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < quantidadeQuartos; i++)
            {

                Console.Write("Informe o nome do estudante : ");
                string nome = Console.ReadLine();
                while (nome.Length < 3 && string.IsNullOrEmpty(nome))
                {
                    Console.Write("Informe o nome do estudante : ");
                    nome = Console.ReadLine();
                }

                Console.Write("Informe o email do estudante : ");
                string email = Console.ReadLine();
                while (email.Length < 8 && string.IsNullOrEmpty(email))
                {
                    Console.Write("Informe o email do estudante : ");
                    email = Console.ReadLine();
                }

                Console.Write("Informe o numero do quarto : ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                while (numeroQuarto > 9)
                {
                    Console.WriteLine("Temos quartos de 1 a 9 ");
                    Console.Write("Informe o numero do quarto : ");
                    numeroQuarto = int.Parse(Console.ReadLine());
                }

                // O quarto que o estudante quer
                var quartoEscolhido = hotelaria.Quartos[numeroQuarto];
                while (quartoEscolhido.TotalEstudantes > 1)
                {
                    Console.WriteLine("O Quarto escolhido ja contem hospedes ");
                    Console.Write("Informe o numero de outro quarto : ");
                    numeroQuarto = int.Parse(Console.ReadLine());
                }

                //Preenche pensionato
                var estudante = new Estudante(nome, email);
                quartoEscolhido.Estudante = estudante;
                quartoEscolhido.TotalEstudantes = 1;

                foreach (var item in hotelaria.Quartos)
                {
                    if (item.Estudante == null)
                    {
                        Console.WriteLine("===========================================================");
                        Console.WriteLine($"Numero do quarto : {item.Id} ");
                        Console.WriteLine($"Numero de estudantes : {item.TotalEstudantes} ");
                        Console.WriteLine($"Quarto N°:{item.Id} Sem estudante");
                    }
                    else
                    {
                        Console.WriteLine("===========================================================");
                        Console.WriteLine($"Numero do quarto : {item.Id} ");
                        Console.WriteLine($"Numero de estudantes : {item.TotalEstudantes} ");
                        Console.WriteLine($"Nome do estudante : {item.Estudante.Nome} ");
                        Console.WriteLine($"Email do estudante : {item.Estudante.Email} ");
                    }
                }

            }
        }
    }
}
