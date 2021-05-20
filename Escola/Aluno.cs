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
            Console.WriteLine("Qual o nome do aluno?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua nota?");
            double nota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantas faltas ele(a) teve?");
            double falta = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual é o RM do aluno: ");
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

                
                for (int i = 0;  i < lista_de_alunos.Count;)
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
            if (lista_de_alunos.Count > 0)
            {
                Console.WriteLine("Qual o ID do aluno que você quer mudar a RM?");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(
                    "Qual a novo RM do aluno(a) de ID {0} ,o RM atual do aluno(a) {0} ",
                    lista_de_alunos[a].RM
                 );


                lista_de_alunos[a].RM = Convert.ToDouble(Console.ReadLine());

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("RM Editado com Sucesso!");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("Deseja voltar ao menu inicial? S/n");
                bool voltar_menu_inicial = false;
                voltar_menu_inicial = (Console.ReadLine().ToUpper() == "S") ? true : false;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum Aluno(a) foi adicionado(a)  ainda.");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            if (lista_de_alunos.Count > 0)
            {
                Console.WriteLine("Qual o ID do aluno que você quer mudar a nota?");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(
                    "Qual a nova nota do aluno(a) de ID {0} , a nota atual do aluno(a) {0} ",
                    lista_de_alunos[i].Nota
                 );

                lista_de_alunos[i].Nota = Convert.ToDouble(Console.ReadLine());

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Nota Editado com Sucesso!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum Aluno(a) foi adicionado(a)  ainda.");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            if (lista_de_alunos.Count > 0)
            {
                Console.WriteLine("Qual o ID do aluno(a) que você quer mudar as faltas?");
                int f = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(
                    "Qual a quantidade de faltas do aluno(a) {0} , a quantidade de faltas do aluno(a) {0} é {0} ",
                    lista_de_alunos[f].Falta
                 );

                lista_de_alunos[f].Falta = Convert.ToDouble(Console.ReadLine());

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Falta Editada com Sucesso!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum Aluno(a) foi adicionado(a)  ainda.");
                Console.BackgroundColor = ConsoleColor.Black;

            }
        }

        public void remover()
        {
            if (lista_de_alunos.Count > 0)
            {
                Console.WriteLine("Qual o ID do Aluno que você quer remover a nota?");
                int i = Convert.ToInt32(Console.ReadLine());

                lista_de_alunos.RemoveAt(i);

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Nota do Aluno (a) Removido (a) com Sucesso!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum Aluno(a) foi adicionado(a)  ainda.");
                Console.BackgroundColor = ConsoleColor.Black;

            }

            if (lista_de_alunos.Count > 0)
            {
                Console.WriteLine("Qual o ID do Aluno que você quer remover?");
                int a = Convert.ToInt32(Console.ReadLine());

                lista_de_alunos.RemoveAt(a);

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Aluno (a) Removido (a) com Sucesso!");
                Console.BackgroundColor = ConsoleColor.Black;

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum Aluno(a) foi adicionado(a)  ainda.");
                Console.BackgroundColor = ConsoleColor.Black;

            }


            if (lista_de_alunos.Count > 0)
            {
                Console.WriteLine("Qual o ID do Aluno que você quer remover a falta?");
                int f = Convert.ToInt32(Console.ReadLine());

                lista_de_alunos.RemoveAt(f);

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Falta do Aluno (a) Removido (a) com Sucesso!");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Nenhum Aluno(a) foi adicionado(a)  ainda.");
                Console.BackgroundColor = ConsoleColor.Black;

            }



        }
    }
}
      

    
       


            
    
