using AnimalModel;
using Repository;
using System;
using System.Threading;

namespace ControllerAnimal {
    public class AnimalController {
        #region Inserir Animal
        public void InserirAnimal(Animal animal) {

            Console.WriteLine("\n*** Cadastrar Animal ***\n");

            Console.Write("Especie: ");
            animal.Especie = Console.ReadLine();

            Console.Write("Raca: ");
            animal.Raca = Console.ReadLine();

            Console.Write("Sexo: ");
            animal.Sexo = char.Parse(Console.ReadLine().ToUpper());

            new AnimalRepository().Add(animal);

            Console.WriteLine("\n\nAnimal Cadastrado com Sucesso...");
            Thread.Sleep(3000);
            Console.Clear();
        }
        #endregion

        #region Deletar Animal
        public void Deletarnaimal(Animal animal) {
            try {
                Console.WriteLine("\n*** Deletar Animal ***");
                Console.WriteLine("\nInforme o Chip do animal que deseja Deletar");
                Console.Write("CHIP: ");
                animal.Chip = int.Parse(Console.ReadLine());
                new AnimalRepository().Delete(animal);
                Console.WriteLine("\n\nAnimal Deletado com Sucesso...");
            } catch (Exception) {
                Console.WriteLine("\nAnimal Não foi Deletado!!!");
            }


            Thread.Sleep(3000);
            Console.Clear();
        }
        #endregion

        #region Consultar Todos Animais
        public void ConsultarAnimal(Animal animal) {
            try {
                Console.WriteLine("\n***  Animais Cadastrados ***\n");

                new AnimalRepository().GetAll().ForEach(anm => Console.WriteLine(anm + "\n"));
            } catch (Exception) {
                Console.WriteLine("\nNão Existe Animais Cadastrados!!!!");
            }
            Thread.Sleep(3000);
            Console.Clear();

        }
        #endregion


        #region Editar Animais
        public void EditarAnimal(Animal animal) {
            int op = 0;
            try {
                Console.WriteLine("\n*** Editar Animal ***");
                Console.WriteLine("\nInforme o Chip do animal que deseja Deletar");
                Console.Write("CHIP: ");
                animal.Chip = int.Parse(Console.ReadLine());

                Console.WriteLine("\n*** Editar Animal ***");
                Console.WriteLine("\n1-Especie" +
                                  "\n2-Raca" +
                                  "\n3-Sexo");
                Console.Write("\nDigite: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {

                    case 1:

                        Console.WriteLine("Editar Especie: ");
                        Console.Write("\nDigite: ");
                        animal.Especie = Console.ReadLine();
                        new AnimalRepository().Update(animal, 1);
                        break;

                    case 2:

                        Console.WriteLine("Editar Raca: ");
                        Console.Write("\nDigite: ");
                        animal.Raca = Console.ReadLine();
                        new AnimalRepository().Update(animal, 2);
                        break;
                    case 3:

                        Console.WriteLine("Editar Sexo: ");
                        Console.Write("\nDigite: ");
                        animal.Sexo = char.Parse(Console.ReadLine().ToUpper());
                        new AnimalRepository().Update(animal, 3);
                        break;
                    default:
                        Console.WriteLine("Opcao Inválida!!!");
                        break;

                }

                Console.WriteLine("\n\nAnimal Editado com Sucesso...");
                Thread.Sleep(3000);
                Console.Clear();
            } catch (Exception) {

                Console.WriteLine("\nChip ou dados do Animal foram Informados Incorretamente....");
            }
        }
        #endregion

        #region Menu Animal
        public void MenuAnimal(Animal animal) {
            int op = 0;
            animal = new Animal();

            do {
                Console.WriteLine("\n*** Sistema de Gerenciamento de Cadastro de Animais ***");
                Console.WriteLine("\n1-Cadastrar Animais" +
                                  "\n2-Consultar Animais de forma Geral" +
                                  "\n3-Editar Campos do cadastro do Animal " +
                                  "\n4-Deletar Animal Especifico" +
                                  "\n0 Sair do Cadastro de Animal");
                Console.Write("\nDigitar: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {

                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("*** Inserir Animais ***\n");
                        InserirAnimal(animal);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("*** Consulta Geral de Animais ***\n");
                        ConsultarAnimal(animal);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("*** Editar Campos do cadastro do Animal ***\n");
                        EditarAnimal(animal);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("*** Deletar um Animal Especifico ***\n");
                        Deletarnaimal(animal);
                        break;
                    default:
                        if (op < 0 || op > 4) {
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
