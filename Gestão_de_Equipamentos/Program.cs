using System.Collections;

namespace Gestão_de_Equipamentos
{
    internal class Program
    {
        static void excluir(ref ArrayList listaX, int quantCampos)
        {
            string nomeVerificador, chamOUequip;
            bool verificador = false;

            if (quantCampos == 5)
            {
                Console.Write("Digite o nome do Equipamento que você deseja excluir: ");
                nomeVerificador = Console.ReadLine();

                chamOUequip = "Equipamento";
            }
            else
            {
                Console.Write("Digite o nome do Chamado que você deseja excluir: ");
                nomeVerificador = Console.ReadLine();

                chamOUequip = "Chamado";
            }

            for (int i = 0; i < listaX.Count; i = i + quantCampos)
            {
                if (nomeVerificador.Equals(listaX[i]))
                {
                    verificador = true;

                    for (int j = 0; j < quantCampos; j++)
                    {
                        listaX.RemoveAt(i);
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{chamOUequip} excluido com sucesso!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }

            if (verificador == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Desculpe não foi possivel encontrar o que você queria!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void editor(ref ArrayList listaX, int quantCampos)
        {
            string nomeVerificador, nomeOUtitulo, precoOUdescri, numSerieOUequip, dataFabOUdataAbertura, chamOUequip;
            bool verificador = false;

            if(quantCampos == 5)
            {
                Console.Write("Digite o nome do Equipamento que você deseja alterar: ");
                nomeVerificador = Console.ReadLine();

                nomeOUtitulo = "Novo Nome do Equipamento";
                precoOUdescri = "Novo Preço de Aquisição";
                numSerieOUequip = "Novo Número de Série";
                dataFabOUdataAbertura = "Nova Data de Fabricação";
                chamOUequip = "Equipamento";
            }
            else
            {
                Console.Write("Digite o nome do Chamado que você deseja alterar: ");
                nomeVerificador = Console.ReadLine();

                nomeOUtitulo = "Novo Título do Chamado";
                precoOUdescri = "Novo Descrição do Chamado";
                numSerieOUequip = "Novo Equipamento";
                dataFabOUdataAbertura = "Novo Data de Abertura";
                chamOUequip = "Chamado";
            }

            for (int i = 0; i < listaX.Count; i = i + quantCampos)
            {
                if (nomeVerificador.Equals(listaX[i]))
                {
                    verificador = true;
                    Console.Write($"{nomeOUtitulo}: ");
                    listaX[i] = Console.ReadLine();
                    i++;

                    Console.Write($"{precoOUdescri}: ");
                    listaX[i] = Console.ReadLine();
                    i++;

                    Console.Write($"{numSerieOUequip}: ");
                    listaX[i] = Console.ReadLine();
                    i++;

                    Console.Write($"{dataFabOUdataAbertura}: ");
                    listaX[i] = Console.ReadLine();
                    i++;

                    if(quantCampos == 5)
                    {
                        Console.Write("Fabricante: ");
                        listaX[i] = Console.ReadLine();
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{chamOUequip} alterado com sucesso!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                    
                }
            }

            if (verificador == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Desculpe não foi possivel encontrar o que você queria!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void visualizador(ref ArrayList listaX, int quantCampos)
        {
            if(quantCampos == 5)
            {
                Console.WriteLine("Lista de Equipamentos");
                Console.WriteLine();
                Console.Write("Nome".PadRight(20, ' '));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Preço de Aquisição".PadRight(20, ' '));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Número de Série".PadRight(20, ' '));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Data de Fabricação".PadRight(20, ' '));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Fabricante".PadRight(20, ' '));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("|");

                for (int i = 0; i < (20 * quantCampos) + quantCampos; i++)
                {
                    Console.Write("-");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Lista de Chamados");
                Console.WriteLine();
                Console.Write("Título".PadRight(20, ' '));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Descrição".PadRight(20, ' '));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Equipamento".PadRight(20, ' '));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Data de Abertura".PadRight(20, ' '));
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("|");

                for (int i = 0; i < (20 * quantCampos) + quantCampos; i++)
                {
                    Console.Write("-");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine();

            for (int i = 0; i < listaX.Count; i = i + quantCampos)
            {
                for (int j = 0; j < quantCampos; j++)
                {
                    string mostrarLista = (string)listaX[i + j];

                    Console.Write(mostrarLista.PadLeft(20, ' '));
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("|");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }

        static void registradorCham(ref ArrayList listaX)
        {
            Console.WriteLine("Digite as informações da chamada");
            Console.Write("Título: ");
            listaX.Add(Console.ReadLine());

            Console.Write("Descrição do chamado: ");
            listaX.Add(Console.ReadLine());

            Console.Write("Equipamento: ");
            listaX.Add(Console.ReadLine());

            Console.Write("Data de Abertura: ");
            listaX.Add(Console.ReadLine());

        }

        static void registradorEquip(ref ArrayList listaX)
        {
            Console.WriteLine("Digite as informações do equipamento");
            Console.Write("Nome: ");
            listaX.Add(Console.ReadLine());

            Console.Write("Preço: ");
            listaX.Add(Console.ReadLine());

            Console.Write("Número de Série: ");
            listaX.Add(Console.ReadLine());

            Console.Write("Data de Fabricação: ");
            listaX.Add(Console.ReadLine());

            Console.Write("Fabricante: ");
            listaX.Add(Console.ReadLine());

        }

        static void menuEquipCham(char opcaoMenu1, ref ArrayList listaCham, ref ArrayList listaEquip)
        {
            int quantidadeVisualizadorCham = 4;
            int quantidadeVisualizadorEquip = 5;

            char opcao;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Qual opção você deseja?");
                Console.WriteLine("1 - Registrar");
                Console.WriteLine("2 - Visualizar");
                Console.WriteLine("3 - Editar");
                Console.WriteLine("4 - Excluir");
                Console.WriteLine("S - Sair");
                Console.Write("Opção: ");
                opcao = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                while (opcao != '1' && opcao != '2' && opcao != 's' && opcao != 'S' && opcao != '3' && opcao != '4')
                {
                    Console.Write("Digite uma opção válida: ");
                    opcao = Convert.ToChar(Console.ReadLine());
                }

                switch (opcao)
                {
                    case '1':
                        if (opcaoMenu1 == '1')
                        {
                            registradorEquip(ref listaEquip);
                        }
                        else
                        {
                            registradorCham(ref listaCham);
                        }
                        
                        break;

                    case '2':
                        if (opcaoMenu1 == '1')
                        {
                            visualizador(ref listaEquip, quantidadeVisualizadorEquip);

                        }
                        else
                        {
                            visualizador(ref listaCham, quantidadeVisualizadorCham);
                        }

                        break;

                    case '3':
                        if (opcaoMenu1 == '1')
                        {
                            editor(ref listaEquip, quantidadeVisualizadorEquip);
                        }
                        else
                        {
                            editor(ref listaCham, quantidadeVisualizadorCham);
                        }
                        
                        break;

                    case '4':
                        if (opcaoMenu1 == '1')
                        {
                            excluir(ref listaEquip, quantidadeVisualizadorEquip);
                        }
                        else
                        {
                            excluir(ref listaCham, quantidadeVisualizadorCham);
                        }
                        
                        break;
                }

            } while (opcao != 's' && opcao != 'S');

            Console.WriteLine();
            Console.WriteLine("Voltando para o menu oprincipal...");
            Console.WriteLine();
        }

        static void menuPrincipal(ref ArrayList listaCham, ref ArrayList listaEquip)
        {
            char opcao;
            do
            {
                Console.WriteLine("Qual opção você deseja?");
                Console.WriteLine("1 - Controle de Equipamentos");
                Console.WriteLine("2 - Controle de Chamadas");
                Console.WriteLine("S - Sair");
                Console.Write("Opção: ");
                opcao = Convert.ToChar(Console.ReadLine());

                while (opcao != '1' && opcao != '2' && opcao != 's' && opcao != 'S')
                {
                    Console.WriteLine();
                    Console.Write("Digite uma opção válida: ");
                    opcao = Convert.ToChar(Console.ReadLine());
                }

                if (opcao != 's' && opcao != 'S')
                {
                    menuEquipCham(opcao, ref listaCham, ref listaEquip);
                }

            } while (opcao != 's' && opcao != 'S');
        }

        static void Main(string[] args)
        {
            ArrayList listaEquip = new ArrayList();
            ArrayList listaCham = new ArrayList();

            menuPrincipal(ref listaCham, ref listaEquip);

            Console.WriteLine();
            Console.WriteLine("Fechando o programa...");
	    Console.ReadLine();
        }
    }
}