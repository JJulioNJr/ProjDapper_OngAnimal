using ConfigDataBase;
using Dapper;
using PessoaModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public class PessoaRepository :IPessoaRepository{

        private string _conn;


        public PessoaRepository() {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Pessoa pessoa) {
            bool result = false;
            using (var db = new SqlConnection(_conn)) {
                db.Open();
                db.Execute(Pessoa.INSERT, pessoa);
                result = true;
            }
            return result;
        }

        public bool Delete(Pessoa pessoa) {
            bool result = false;
            using (var db = new SqlConnection(_conn)) {
                db.Open();
                db.Execute(Pessoa.DELETE, pessoa);
                result = true;
            }
            return result;
        }


        public List<Pessoa> GetAll() {

            using (var db = new SqlConnection(_conn)) {
                db.Open();
                var pessoa = db.Query<Pessoa>(Pessoa.SELECT);
                return (List<Pessoa>)pessoa;
            }


        }

        public bool Update(Pessoa pessoa, int op) {
            bool result = false;
            using (var db = new SqlConnection(_conn)) {
                db.Open();

                switch (op) {
                    case 1:
                        db.Execute(Pessoa.UPDATE_NOME, pessoa);
                        result = true;
                        break;
                    case 2:
                        db.Execute(Pessoa.UPDATE_SEXO, pessoa);
                        result = true;
                        break;
                    case 3:
                        db.Execute(Pessoa.UPDATE_DATANASCIMENTO, pessoa);
                        result = true;
                        break;
                    case 4:
                        db.Execute(Pessoa.UPDATE_LOGRADOURO, pessoa);
                        result = true;
                        break;
                    case 5:
                        db.Execute(Pessoa.UPDATE_NUMERO, pessoa);
                        result = true;
                        break;
                    case 6:
                        db.Execute(Pessoa.UPDATE_CEP, pessoa);
                        result = true;
                        break;
                    case 7:
                        db.Execute(Pessoa.UPDATE_BAIRRO, pessoa);
                        result = true;
                        break;
                    case 8:
                        db.Execute(Pessoa.UPDATE_UF, pessoa);
                        result = true;
                        break;

                    case 9:
                        db.Execute(Pessoa.UPDATE_CIDADE, pessoa);
                        result = true;
                        break;
                    case 10:
                        db.Execute(Pessoa.UPDATE_COMPLEMENTO, pessoa);
                        result = true;
                        break;
                    default:
                        Console.WriteLine("\nOpcao Inválida!!!");
                        break;
                }
                return result;
            }
        }
    }
}
