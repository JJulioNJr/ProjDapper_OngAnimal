using System;

namespace PessoaModel {
    public class Pessoa {

        #region Constant

        public readonly static string INSERT = "INSERT INTO PESSOA (CPF,NOME,SEXO,DATANASCIMENTO,LOGRADOURO,NUMERO,CEP,BAIRRO,UF,CIDADE,COMPLEMENTO)" +
                                               "VALUES(@CPF,@NOME,@SEXO,@DATANASCIMENTO,@LOGRADOURO,@NUMERO,@CEP,@BAIRRO,@UF,@CIDADE,@COMPLEMENTO)";
        public readonly static string SELECT = "SELECT CPF,NOME,SEXO,DATANASCIMENTO,LOGRADOURO,NUMERO,CEP,BAIRRO,UF,CIDADE,COMPLEMENTO FROM PESSOA";
        public readonly static string DELETE = "DELETE FROM PESSOA WHERE CPF=@CPF";
        public readonly static string UPDATE_NOME = "UPDATE PESSOA SET NOME=@NOME WHERE CPF=@CPF";
        public readonly static string UPDATE_SEXO = "UPDATE PESSOA SET SEXO=@SEXO WHERE CPF=@CPF";
        public readonly static string UPDATE_DATANASCIMENTO = "UPDATE PESSOA SET DATANASCIMENTO=@DATANASCIMENTO WHERE CPF=@CPF";
        public readonly static string UPDATE_LOGRADOURO = "UPDATE PESSOA SET LOGRADOURO=@LOGRADOURO WHERE CPF=@CPF";
        public readonly static string UPDATE_NUMERO = "UPDATE PESSOA SET NUMERO=@NUMERO WHERE CPF=@CPF";
        public readonly static string UPDATE_CEP = "UPDATE PESSOA SET CEP=@CEP WHERE CPF=@CPF";
        public readonly static string UPDATE_BAIRRO = "UPDATE PESSOA SET BAIRRO=@BAIRRO WHERE CPF=@CPF";
        public readonly static string UPDATE_UF = "UPDATE PESSOA SET UF=@UF WHERE CPF=@CPF";
        public readonly static string UPDATE_CIDADE = "UPDATE PESSOA SET CIDADE=@CIDADE WHERE CPF=@CPF";
        public readonly static string UPDATE_COMPLEMENTO = "UPDATE PESSOA SET COMPLEMENTO=@COMPLEMENTO WHERE CPF=@CPF";

        #endregion

        public String Cpf { get; set; }
        public String Nome { get; set; }
        public char Sexo { get; set; }
        public String DataNascimento { get; set; }
        public String Logradouro { get; set; }
        public String Numero { get; set; }
        public String Cep { get; set; }
        public String Bairro { get; set; }
        public String UF { get; set; }
        public String Cidade { get; set; }
        public String Complemento { get; set; }


        public Pessoa() { }

        public Pessoa(String cpf, String nome, char sexo, String dataNc, String logr, String numero, String cep,
                      String bairro, String uf, String cidade, String complemento) {

            this.Cpf = cpf;
            this.Nome = nome;
            this.Sexo = sexo;
            this.DataNascimento = dataNc;
            this.Logradouro = logr;
            this.Numero = numero;
            this.Cep = cep;
            this.Bairro = bairro;
            this.UF = uf;
            this.Cidade = cidade;
            this.Complemento = complemento;

        }

        public override string ToString() {

            return "\nCPF: " + this.Cpf +
                   "\nNome: " + this.Nome +
                   "\nSexo: " + this.Sexo +
                   "\nData Nascimento: " + this.DataNascimento +
                   "\nLogradouro: " + this.Logradouro +
                   "\nNumero: " + this.Numero +
                   "\nCep: " + this.Cep +
                   "\nBairro: " + this.Bairro +
                   "\nUF: " + this.UF +
                   "\nCidade: " + this.Cidade +
                   "\nComplemento: " + this.Complemento;
        }
    }
}
