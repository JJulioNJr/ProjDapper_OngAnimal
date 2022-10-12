using ControllerUtil;
using PessoaModel;
using Repository;
using System;
using System.Threading;

namespace ControllerPessoa {
    public class PessoaController {

        #region Inserir Pessoa
        public void InserirPessoa(Pessoa pessoa) {

            Console.WriteLine("\n*** Cadastro de Pessoa ***\n");
            Console.Write("CPF:");
            pessoa.Cpf = Console.ReadLine();
            while (UtilController.ValidarCpf(pessoa.Cpf) == false || pessoa.Cpf.Length < 11) {
                Console.WriteLine("\nCpf invalido, digite novamente");
                Console.Write("CPF: ");
                pessoa.Cpf = Console.ReadLine();
            }

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            while (pessoa.Nome.Length > 50) {
                Console.WriteLine("\nDigite um Nome de até 50 digitos!");
                Console.Write("Nome: ");
                pessoa.Nome = Console.ReadLine();
            }

            Console.WriteLine("\n Masculino-M/Feminino-F ");
            Console.Write("Sexo: ");
            char sx = char.Parse(Console.ReadLine().ToUpper());
            pessoa.Sexo = sx;

            Console.Write("Data de Nascimento: ");
            pessoa.DataNascimento = Console.ReadLine();

            Console.Write("Logradouro: ");
            pessoa.Logradouro = Console.ReadLine();

            Console.Write("Numero: ");
            pessoa.Numero = Console.ReadLine();

            Console.Write("CEP: ");
            pessoa.Cep = Console.ReadLine();

            Console.Write("Bairro: ");
            pessoa.Bairro = Console.ReadLine();

            Console.Write("UF : ");
            pessoa.UF = Console.ReadLine().ToUpper();
            while (pessoa.UF.Length > 2) {
                Console.WriteLine("\nDigite o UF com 2 Siglas!!!");
                Console.Write("UF: ");
                pessoa.Nome = Console.ReadLine();
            }

            Console.Write("Cidade: ");
            pessoa.Cidade = Console.ReadLine();

            Console.Write("Complemento: ");
            pessoa.Complemento = Console.ReadLine();

            new PessoaRepository().Add(pessoa);

            Console.WriteLine("\n\nPessoa Cadastrada com Sucesso...");
            Thread.Sleep(3000);
            Console.Clear();
        }
        #endregion


        #region Deletar Pessoa
        public void DeletarPessoa(Pessoa pessoa) {

            try {
                Console.WriteLine("\nInforme o CPF da pessoa que deseja Deletar");
                Console.Write("CPF: ");
                pessoa.Cpf = Console.ReadLine();
                while (UtilController.ValidarCpf(pessoa.Cpf) == false || pessoa.Cpf.Length < 11) {
                    Console.WriteLine("\nCpf invalido, digite novamente");
                    Console.Write("CPF: ");
                    pessoa.Cpf = Console.ReadLine();
                }
                new PessoaRepository().Delete(pessoa);
                Console.WriteLine("\n\nPessoa Deletada com Sucesso...");
            } catch (Exception) {
                Console.WriteLine("\nCpf não Encontrado...");
            }

            Thread.Sleep(3000);
            Console.Clear();
        }
        #endregion

        #region Consultar todas Pessoas Cadastradas
        public void ConsultarPessoa(Pessoa pessoa) {
            try {

                Console.WriteLine("\n*** Pessoas Cadastradas ***");
                new PessoaRepository().GetAll().ForEach(pss => Console.WriteLine("\n" + pss + "\n"));
                Console.WriteLine("\nAperte Qualqer Botão para Continuar...");
                Console.ReadKey();
                Console.Clear();

            } catch (Exception) {
                Console.WriteLine("\n Não Existe Pessoas Cadastradas...");
            }
        }
        #endregion

        #region Editar Pessoa
        public void EditarPessoa(Pessoa pessoa) {

            int op = 0;
            try {
                Console.WriteLine("\nInforme o CPF da pessoa que deseja Editar");
                Console.Write("CPF: ");
                pessoa.Cpf = Console.ReadLine();
                while (UtilController.ValidarCpf(pessoa.Cpf) == false || pessoa.Cpf.Length < 11) {
                    Console.WriteLine("\nCpf invalido, digite novamente");
                    Console.Write("CPF: ");
                    pessoa.Cpf = Console.ReadLine();
                }


                Console.WriteLine("\n*** Editar Pessoa ***");
                Console.WriteLine("\n1-Nome" +
                                  "\n2-Sexo" +
                                  "\n3-Data de Nascimento" +
                                  "\n4-Logradouro" +
                                  "\n5-Numero" +
                                  "\n6-CEP" +
                                  "\n7-Bairro" +
                                  "\n8-UF" +
                                  "\n9-Cidade" +
                                  "\n10-Complemento");
                Console.Write("\nDigite: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {
                    case 1:
                        Console.WriteLine("\nAlterar Nome:");
                        Console.Write("Digite: ");
                        pessoa.Nome = Console.ReadLine();
                        while (pessoa.Nome.Length > 50) {
                            Console.WriteLine("\nDigite um Nome de até 50 digitos!");
                            Console.Write("Nome: ");
                            pessoa.Nome = Console.ReadLine();
                        }
                        new PessoaRepository().Update(pessoa, 1);
                        break;
                    case 2:
                        Console.WriteLine("\nAlterar Sexo:");
                        Console.WriteLine("Masculino-M/Feminino-F:");
                        Console.Write("\nDigite: ");
                        pessoa.Sexo = char.Parse(Console.ReadLine().ToUpper());
                        new PessoaRepository().Update(pessoa, 2);
                        break;
                    case 3:
                        Console.WriteLine("\nAlterar Data de Nascimento:");
                        Console.Write("Digite: ");
                        pessoa.DataNascimento = Console.ReadLine();
                        new PessoaRepository().Update(pessoa, 3);
                        break;
                    case 4:
                        Console.WriteLine("\nlterar Logradouro:");
                        Console.Write("Digite: ");
                        pessoa.Logradouro = Console.ReadLine();
                        new PessoaRepository().Update(pessoa, 4);
                        break;
                    case 5:
                        Console.WriteLine("\nAlterar Numero:");
                        Console.Write("Digite: ");
                        pessoa.Numero = Console.ReadLine();
                        new PessoaRepository().Update(pessoa, 5);
                        break;
                    case 6:
                        Console.WriteLine("Alterar CEP:");
                        Console.Write("Digite: ");
                        pessoa.Cep = Console.ReadLine();
                        new PessoaRepository().Update(pessoa, 6);
                        break;
                    case 7:
                        Console.WriteLine("Alterar Bairro:");
                        Console.Write("Digite: ");
                        pessoa.Bairro = Console.ReadLine();
                        new PessoaRepository().Update(pessoa, 7);
                        break;
                    case 8:
                        Console.WriteLine("\nAlterar UF:");
                        Console.Write("Digite: ");
                        pessoa.UF = Console.ReadLine();
                        while (pessoa.UF.Length > 2) {
                            Console.WriteLine("\nDigite o UF com 2 Siglas!!!");
                            Console.Write("UF: ");
                            pessoa.Nome = Console.ReadLine();
                        }

                        new PessoaRepository().Update(pessoa, 8);
                        break;
                    case 9:
                        Console.WriteLine("\nAlterar Cidade:");
                        Console.Write("Digite: ");
                        pessoa.Cidade = Console.ReadLine();
                        new PessoaRepository().Update(pessoa, 9);
                        break;
                    case 10:
                        Console.WriteLine("\nAlterar Complento:");
                        Console.Write("Digite: ");
                        pessoa.Complemento = Console.ReadLine();
                        new PessoaRepository().Update(pessoa, 10);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!!!");
                        break;
                }

                Console.WriteLine("\n\nPessoa Editada com Sucesso...");
                Thread.Sleep(3000);
                Console.Clear();
            } catch (Exception) {
                Console.WriteLine("\nOs Dados Não Puderm Ser Alterados...");
            }
        }
        #endregion

        #region Menu Pessoa
        public void MenuPessoa(Pessoa pessoa) {
            int op;


            do {

                Console.WriteLine("\n*** Sistema de Gerenciamento de Cadastro de Pessoas ***");
                Console.WriteLine("\n1-Cadastrar Pessoa" +
                                  "\n2-Consultar Pessoas de forma Geral" +
                                  "\n3-Editar Cadastro de Pessoa " +
                                  "\n4-Deletar Pessoa Especifica" +
                                  "\n0-Sair do Cadastro de Pessoa");
                Console.Write("\nDigitar: ");
                op = int.Parse(Console.ReadLine());

                switch (op) {
                    case 0:
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("*** Inserir Pessoa ***\n");
                        InserirPessoa(pessoa);
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("*** Consulta Geral de Pessoas ***\n");
                        ConsultarPessoa(pessoa);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("*** Editar Campos do Cadastro da Pessoa ***\n");
                        EditarPessoa(pessoa);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("*** Deletar uma Pessoa Especifica ***\n");
                        DeletarPessoa(pessoa);
                        break;
                    default:
                        if (op < 0 || op > 4) {
                            Console.WriteLine("\nOpção Invalida !!!");
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
