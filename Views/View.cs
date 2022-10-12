using AdocaoModel;
using AnimalModel;
using ControllerAdocao;
using ControllerAnimal;
using ControllerPessoa;
using PessoaModel;
using System;
using System.Threading;

namespace Views {
    public class View {

        #region Menu Principal
       public static void Menu() {

            Animal animal = new();
            Pessoa pessoa = new();
            Adocao adocao = new();

            PessoaController controlePS = new();
            AnimalController controleAL = new();
            AdocaoController controleAd = new();

            int op = 0;

            do {
                Console.WriteLine("\n\t\t*** Menu ***");
                Console.WriteLine("\n1-Sistema De Gerenciamento de Pessoas" +
                                  "\n2-Sistema De Gerenciamento de Animais" +
                                  "\n3-Sistema De Gerenciamento de Adoção" +
                                  "\n0-Sair do Sistema");
                Console.Write("\nDigitar: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {
                    case 1:
                        Console.Clear();
                        controlePS.MenuPessoa(pessoa);
                        break;
                    case 2:
                        Console.Clear();
                        controleAL.MenuAnimal(animal);
                        break;
                    case 3:
                        Console.Clear();
                        controleAd.MenuAdocao(adocao, pessoa, animal);
                        break;
                    default:
                        if (op < 0 || op > 3) {

                            Console.WriteLine("\nOpção Invalida!!!");
                            Thread.Sleep(3000);
                            Console.Clear();
                        }
                        break;
                }

            } while (op != 0);

        }
        #endregion
    }
}
