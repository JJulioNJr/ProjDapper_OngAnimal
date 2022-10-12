using AdocaoModel;
using AnimalModel;
using ControllerUtil;
using PessoaModel;
using Repository;
using System;
using System.Threading;

namespace ControllerAdocao {
    public class AdocaoController {

        #region Fazer adocao 
        public void FazerAdocao(Adocao adocao, Pessoa pessoa, Animal animal) {


          

            Console.WriteLine("\n*** Deseja Fazer a Adocao de um Animal de Estimação? ***");
            Console.WriteLine("SIM - S / NÂO - N ");
            Console.Write("\nDigite: ");
            adocao.Resposta = char.Parse(Console.ReadLine().ToUpper());

            if (adocao.Resposta.Equals('S')) {

                adocao.Situacao = "ADOTADO";

                Console.Write("\nInforme o seu CPF: ");
                adocao.Cpf = Console.ReadLine();
                while (UtilController.ValidarCpf(adocao.Cpf) == false || adocao.Cpf.Length < 11) {
                    Console.WriteLine("\nCpf invalido, digite novamente");
                    Console.Write("CPF: ");
                    pessoa.Cpf = Console.ReadLine();
                }

                Console.Write("\nInforme o seu CHIP: ");
                adocao.Chip = int.Parse(Console.ReadLine());

                try {
                    if ((adocao.Cpf.Equals(pessoa.Cpf))) {
                        if (adocao.Chip != animal.Chip) {
                            Console.WriteLine("\n\nInformações não estão Corretas....");
                        }
                        else {
                            Console.WriteLine("\nChip de Adoção não Encontrado...");
                        }
                    }
                    else {
                        new AdocaoRepository().Add(adocao);

                        Console.WriteLine("\n\nAdoção Feito com Sucesso...");

                    }
                } catch (Exception ex) {

                    Console.WriteLine(ex.Message);
                }

            }
            else {
                Console.WriteLine("\nAnimal Continua Disponivel para Adoção!!!");

            }

            Thread.Sleep(3000);
            Console.Clear();
        }
        #endregion

        #region Deletar Adocao 
        public void DeletarAdocao(Adocao adocao) {

            Console.WriteLine("\n*** Deletar um Cadastro de Adoção ***\n");
            Console.Write("\nInforme o Numero de Indetificação Registrado no Cadastro da Adoção: ");
            Console.Write("ID: ");
            adocao.ID = int.Parse(Console.ReadLine());

            try {
                new AdocaoRepository().Delete(adocao);

                Console.WriteLine("\n\n Cadastro de Adoção Deletado com Sucesso...");
            } catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }

            Thread.Sleep(3000);
            Console.Clear();
        }
        #endregion

        #region Editar Adocao
        public void EditarAdocao(Adocao adocao) {

            Console.WriteLine("\n*** Alteração de Situação de Adoção ***\n");
            Console.Write("\nInforme o Numero de Indetificação Registrado no Cadastro da Adoção: ");
            Console.Write("ID: ");
            adocao.ID = int.Parse(Console.ReadLine());


            try {
                Console.WriteLine("\nInforme o Tipo de Situação que Deseja Alterar");
                Console.WriteLine("A-ADOTADO / D-DISPONIVEL");
                Console.Write("\nSituacao: ");
                char status = char.Parse(Console.ReadLine().ToUpper());

                if (status.Equals('A')) {
                    adocao.Situacao = "ADOTADO";
                }
                else {
                    adocao.Situacao = "DISPONIVEL";
                }
                new AdocaoRepository().Update(adocao);

            } catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n\nSituação Editada com Sucesso...");
            Thread.Sleep(3000);
            Console.Clear();
        }
        #endregion

        #region Consultar Adocao
        public void ConsultarAdocao(Adocao adocao) {

            Console.WriteLine("\n***  Animais Cadastrados ***\n");

            new AdocaoRepository().GetAll().ForEach(anm => Console.WriteLine(anm + "\n"));

            Thread.Sleep(3000);
            Console.Clear();
        }
        #endregion

        #region Menu Adocao
        public void MenuAdocao(Adocao adocao, Pessoa pessoa, Animal animal) {
            int op = 0;

            do {
                Console.WriteLine("\n*** Sistema de Gerenciamento de Adoções ***");
                Console.WriteLine("\n1-Adotar Animal" +
                                  "\n2-Consultar Animais Adotados" +
                                  "\n3-Deletar cadastros de Animais Adotados" +
                                  "\n4-Editar Situacao do Animal" +
                                  "\n0 Sair do Cadastro de Adoção");
                Console.Write("\nDigite: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {

                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("*** Fazer Adocao de Animais ***\n");
                        FazerAdocao(adocao, pessoa, animal);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("*** Consultar Adocao de Animais Adotados ***\n");
                        ConsultarAdocao(adocao);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("*** Deletar Cadastro de Animal Adotado ***\n");
                        DeletarAdocao(adocao);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("*** Alterar Situação de Adoção do Animal ***\n");
                        EditarAdocao(adocao);
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
