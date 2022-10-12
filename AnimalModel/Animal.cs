using System;

namespace AnimalModel {
    public class Animal {
       
        #region Constant
        public readonly static string INSERT = "INSERT INTO ANIMAL (ESPECIE,RACA,SEXO)VALUES(@ESPECIE,@RACA,@SEXO)";
        public readonly static string SELECT = "SELECT CHIP,ESPECIE,RACA,SEXO FROM ANIMAL";
        public readonly static string DELETE = "DELETE FROM ANIMAL WHERE CHIP=@CHIP";
        public readonly static string UPDATE_ESPECIE = "UPDATE ANIMAL SET ESPECIE=@ESPECIE WHERE CHIP=@CHIP";
        public readonly static string UPDATE_RACA = "UPDATE ANIMAL SET RACA=@RACA WHERE CHIP=@CHIP";
        public readonly static string UPDATE_SEXO = "UPDATE ANIMAL SET SEXO=@SEXO WHERE CHIP=@CHIP";
        #endregion

        public int Chip { get; set; }
        public String Especie { get; set; }
        public String Raca { get; set; }
        public char Sexo { get; set; }

        public Animal() { }

        public Animal(String especie, String raca, char sexo) {

            this.Especie = especie;
            this.Raca = raca;
            this.Sexo = sexo;
        }

        public override string ToString() {

            return "CHIP: " + this.Chip +
                   "\nESPECIE: " + this.Especie +
                   "\nRACA: " + this.Raca +
                   "\nSEXO: " + this.Sexo;
        }
    }
}
