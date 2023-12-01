using System;

namespace tabelaprojarq;
    
        class Program
        {
            static void Main(string[] args)
            {
                    int perfil;
                    double valorproj, met;
                    Console.WriteLine(" TABELA PARA PROJETO \n\n");
                    Console.WriteLine(" Escolha uma das opções de projeto:\n" +
                    "1- Alto Padrão\n" +
                    "2- Classe Média\n" +
                    "3- Projeto Social");
                    perfil = Convert.ToInt32(Console.ReadLine());

                    switch (perfil)
                    {
                        case 1:
                            Console.WriteLine("Digite a metragem (m2) do imóvel.\n");
                            met = Convert.ToDouble(Console.ReadLine());
                            valorproj = met * 100;
                            Console.WriteLine("Perfil 1 - Alto Padrão: Projeto em R$ {0}", valorproj);
                            break;

                        case 2:
                            Console.WriteLine("Digite a metragem (m2) do imóvel.\n");
                            met = Convert.ToDouble(Console.ReadLine());
                            valorproj = met * 50;
                            Console.WriteLine("Perfil 2 - Classe Média: Projeto em R$ {0}", valorproj);
                            break;

                        case 3:
                            Console.WriteLine("Digite a metragem (m2) do imóvel.\n");
                            met = Convert.ToDouble(Console.ReadLine());
                            valorproj = met * 40;
                            Console.WriteLine("Perfil 3 - Projeto Social: Projeto em R$ {0}", valorproj);
                            break;

                        default:
                            Console.WriteLine("Valor inválido. Tente de novo!");
                            break;
                    }
            }
        }

        
    

