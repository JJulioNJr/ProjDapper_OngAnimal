using AnimalModel;
using ConfigDataBase;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public class AnimalRepository : IAnimalReporsitory{
        private string _conn;


        public AnimalRepository() {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Animal animal) {
            bool result = false;
            using (var db = new SqlConnection(_conn)) {
                db.Open();
                db.Execute(Animal.INSERT, animal);
                result = true;
            }
            return result;
        }

        public List<Animal> GetAll() {
            using (var db = new SqlConnection(_conn)) {

                db.Open();
                var animal = db.Query<Animal>(Animal.SELECT);
                return (List<Animal>)animal;
            }
        }


        public bool Delete(Animal animal) {
            bool result = false;
            using (var db = new SqlConnection(_conn)) {
                db.Open();
                db.Execute(Animal.DELETE, animal);
                result = true;
            }
            return result;
        }

        public bool Update(Animal animal, int op) {
            bool result = false;
            using (var db = new SqlConnection(_conn)) {
                db.Open();

                switch (op) {
                    case 1:
                        db.Execute(Animal.UPDATE_ESPECIE, animal);
                        result = true;
                        break;
                    case 2:
                        db.Execute(Animal.UPDATE_RACA, animal);
                        result = true;
                        break;
                    case 3:
                        db.Execute(Animal.UPDATE_SEXO, animal);
                        result = true;
                        break;
                }
                return result;
            }
        }
    }
}
