using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Escola
{
    public class Aluno
    {
        NumberFormatInfo nfi = new CultureInfo("pt-BR").NumberFormat;

        List<ItemAluno> lista_de_alunos = new List<ItemAluno>();

        public void inserir()
        {
            Console.WriteLine("Qual o nome do aluno(a)?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua nota?");
            double nota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantas faltas ele(a) teve?");
            double falta = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual é o RM do aluno(a): ");
            double rm = Convert.ToInt32(Console.ReadLine());

            lista_de_alunos.Add(new ItemAluno()
            {
                Nome = nome,
                Nota = nota,
                Falta = falta,
                RM = rm
            });

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Aluno(a) Adicionado(a) com Sucesso!");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public void listar()
        {
            if (lista_de_alunos.Count > 0)
            {
                Console.WriteLine("ID      Nome      Notas     Faltas     RM");


                for (int i = 0; i < lista_de_alunos.Count; i++)
                {

                    Console.WriteLine(
                                  "{0}    {1}       {2}          {3}      {4}",
                        i,
                        lista_de_alunos[i].Nome,
                        lista_de_alunos[i].Nota,
                        lista_de_alunos[i].Falta,
                        lista_de_alunos[i].RM
                    );
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum Aluno(a) foi adicionado(a)  ainda.");
                Console.BackgroundColor = ConsoleColor.Black;

            }

        }
        public void editar()
        {
            if (lista_de_alunos.Count < 0)
            {
                Console.WriteLine("Nenhum Aluno(a) ainda.");

            }

            if (lista_de_alunos.Count > 0)
            {
                bool digitacao_valida;

                int rm;
                double nota;
                int faltas;
                int i;
                int OpcaoMiniMenu;

                Console.WriteLine("Qual o ID do aluno(a)?");
                do
                {
                    digitacao_valida = int.TryParse(Console.ReadLine(), out i);

                    if (i < 0 || digitacao_valida == false || i > lista_de_alunos.Count - 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Valor inválido, redigite um numero válido:");
                        Console.BackgroundColor = ConsoleColor.Black;

                        digitacao_valida = false;
                    }
                } while (!digitacao_valida);


                digitacao_valida = false;
                Console.WriteLine("O que você quer Alterar?");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("1-Notas");
                Console.WriteLine("2-Faltas");
                Console.WriteLine("3-RM");
                Console.BackgroundColor = ConsoleColor.Black;



                do
                {

                    digitacao_valida = int.TryParse(Console.ReadLine(), out OpcaoMiniMenu);

                    if (OpcaoMiniMenu > 3 || digitacao_valida == false || OpcaoMiniMenu < 1)
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("1-Notas");
                        Console.WriteLine("2-Faltas");
                        Console.WriteLine("3-RM");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Valor inválido, redigite um numero válido:");
                        Console.BackgroundColor = ConsoleColor.Black;

                        digitacao_valida = false;
                    }

                } while (!digitacao_valida);

                switch (OpcaoMiniMenu)
                {

                    case 1:

                        Console.WriteLine("Qual a nova nota do aluno(a)? A nota atual é : {0}", lista_de_alunos[i].Nota);
                        do
                        {

                            digitacao_valida = double.TryParse(Console.ReadLine(), out nota);

                            if (nota < 0 || digitacao_valida == false || nota > 1000)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Valor inválido, redigite um numero válido:");
                                Console.BackgroundColor = ConsoleColor.Black;

                                digitacao_valida = false;
                            }
                        } while (!digitacao_valida);

                        lista_de_alunos[i].Nota = nota;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Nota do Aluno(a) editada com sucesso.");
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;

                    case 2:

                        Console.WriteLine("Qual a nova quantidade de faltas do aluno(a)? A quantidade atual é : {0} faltas", lista_de_alunos[i].Falta);
                        do
                        {

                            digitacao_valida = int.TryParse(Console.ReadLine(), out faltas);

                            if (faltas < 0 || digitacao_valida == false || faltas > 1000)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Valor inválido, redigite um numero válido:");
                                Console.BackgroundColor = ConsoleColor.Black;

                                digitacao_valida = false;
                            }
                        } while (!digitacao_valida);

                        lista_de_alunos[i].Falta = faltas;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Falta do Aluno(a) editada com sucesso.");
                        Console.BackgroundColor = ConsoleColor.Black;

                        break;

                   


                    case 3:
                        Console.WriteLine("Qual o novo valor da RM? O valor atual é: {0}", lista_de_alunos[i].RM);
                        do
                        {

                            digitacao_valida = int.TryParse(Console.ReadLine(), out rm);

                            if (rm < 0 || digitacao_valida == false)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Valor inválido, redigite um numero válido:");
                                Console.BackgroundColor = ConsoleColor.Black;

                                digitacao_valida = false;
                            }
                        } while (!digitacao_valida);

                        lista_de_alunos[i].RM = rm;
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("RM do Aluno(a) editada com sucesso.");
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;


                }
            }
        }
        public void remover()
        {
            if (lista_de_alunos.Count < 0)
            {
                Console.WriteLine("Nenhum Aluno(a) foi adicionado ainda.");

            }else
            {
                bool digitacao_valida;
               
                int i;

                Console.WriteLine("Qual o ID do aluno(a)?");
                do
                {
                    digitacao_valida = int.TryParse(Console.ReadLine(), out i);

                    if (i < 0 || digitacao_valida == false || i > lista_de_alunos.Count - 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Valor inválido, redigite um numero válido:");
                        Console.BackgroundColor = ConsoleColor.Black;

                        digitacao_valida = false;
                    }
                } while (!digitacao_valida);

                    lista_de_alunos.RemoveAt(i);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Aluno(a) removido com sucesso.");
                    Console.BackgroundColor = ConsoleColor.Black;

                  

                }

            }

        }

    }

    








