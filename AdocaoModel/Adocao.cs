using System;

namespace AdocaoModel {
    public class Adocao {

        #region Constant
        public readonly static string INSERT = $"INSERT INTO ADOCAO (CPF,Chip,SITUACAO) VALUES (@CPF,@CHIP,@SITUACAO);";
        public readonly static string SELECT = "SELECT ID,CPF,CHIP,Situacao FROM ADOCAO";
        public readonly static string DELETE = "DELETE FROM ADOCAO WHERE ID=@ID";
        public readonly static string UPDATE = "UPDATE ADOCAO SET SITUACAO=@SITUACAO WHERE ID=@ID";

        #endregion

        public int ID { get; set; }

        public String Cpf { get; set; }
        public int Chip { get; set; }
        public char Resposta { get; set; }
        public String Situacao { get; set; }


        public Adocao() { }

        public Adocao(int ID, String Cpf, int Chip, char Resposta, String Situacao) {

            this.Cpf = Cpf;
            this.Chip = Chip;
            this.Resposta = Resposta;
            this.Situacao = Situacao;
        }

        public override string ToString() {

            return "ID " + this.ID +
                   "\nCPF " + this.Cpf +
                   "\nChip: " + this.Chip +
                   "\nSituacao: " + this.Situacao;
        }
    }
}
