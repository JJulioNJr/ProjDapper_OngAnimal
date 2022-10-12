using AdocaoModel;
using ConfigDataBase;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public class AdocaoRepository : IAdocaoRepository {

        private string _conn;

        public AdocaoRepository () {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Adocao adocao) {
            bool result = false;
            using (var db = new SqlConnection(_conn)) {
                db.Open();
                db.Execute(Adocao.INSERT, adocao);
                result = true;
            }
            return result;
        }

        public bool Delete(Adocao adocao) {
            bool result = false;
            using (var db = new SqlConnection(_conn)) {
                db.Open();
                db.Execute(Adocao.DELETE, adocao);
                result = true;
            }
            return result;
        }

        public List<Adocao> GetAll() {
            using (var db = new SqlConnection(_conn)) {

                db.Open();
                var adocao = db.Query<Adocao>(Adocao.SELECT);
                return (List<Adocao>)adocao;
            }
        }

        public bool Update(Adocao adocao) {
            bool result = false;
            using (var db = new SqlConnection(_conn)) {
                db.Open();
                db.Execute(Adocao.UPDATE, adocao);
                result = true;

            }
            return result;
        }
    }
}
