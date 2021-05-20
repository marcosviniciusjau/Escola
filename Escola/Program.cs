using System;

namespace Escola
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            bool voltar_menu_inicial = false;

            int opcao_menu;

            Aluno dados_aluno = new Aluno();

            do
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("        NSA ETEC     ");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("Selecione uma Opção para Continuar:");
                Console.WriteLine("1 => Ver a lista de Alunos com Notas e Faltas");
                Console.WriteLine("2 => Adicionar um Aluno");
                Console.WriteLine("3 => Remover um Aluno");
                Console.WriteLine("4 => Editar o RM de um Aluno");
                Console.WriteLine("5 => Editar a nota de um Aluno");
                Console.WriteLine("6 => Remover a nota de um Aluno");
                Console.WriteLine("7 => Editar a falta de um Aluno");
                Console.WriteLine("8 => Remover a falta de um Aluno");
                Console.WriteLine("9 => Sair do Sistema");

                bool digitacao_valida_opcao_menu = false;
                do
                {
                    digitacao_valida_opcao_menu = int.TryParse(Console.ReadLine(), out opcao_menu);

                    if (opcao_menu < 1 || opcao_menu > 9 || digitacao_valida_opcao_menu == false)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Opção inválida, redigite uma opção:");
                        Console.BackgroundColor = ConsoleColor.Black;

                        digitacao_valida_opcao_menu = false;
                    }
                } while (!digitacao_valida_opcao_menu);


                switch (opcao_menu)
                {
                    case 1:
                        dados_aluno.listar();
                        break;

                    case 2:
                        dados_aluno.inserir();
                        break;

                    case 3:
                        dados_aluno.remover();
                        break;

                   
                    case 4:
                        dados_aluno.editar();
                        break;

                    case 5:
                        dados_aluno.editar();
                        break;

                    case 6:
                        dados_aluno.remover();
                        break;

                    case 7:
                        dados_aluno.editar();
                        break;


                    case 8:
                        dados_aluno.remover();
                        break;

                    case 9:
                        Console.WriteLine("Vai sair do sistema.");
                        break;
                      
                }

                Console.WriteLine("Deseja voltar ao menu inicial? S/n");
                voltar_menu_inicial = (Console.ReadLine().ToUpper() == "S") ? true : false;

            } while (voltar_menu_inicial);

            Console.WriteLine("Fim do Programa.");
            Console.ReadKey();
        }
    }
}
