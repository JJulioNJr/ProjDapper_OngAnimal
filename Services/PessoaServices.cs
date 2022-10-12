using PessoaModel;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services {
    internal class PessoaServices {
        private IPessoaRepository _pessoaRepository;
        public PessoaServices() {

            _pessoaRepository = new PessoaRepository();
        }

        public bool Add(Pessoa pessoa) {
            return _pessoaRepository.Add(pessoa);
        }

        public List<Pessoa> GetAll() {

            return _pessoaRepository.GetAll();

        }

        public bool Delete(Pessoa pessoa) {

            return _pessoaRepository.Delete(pessoa);

        }

        public bool Update(Pessoa pessoa, int op) {

            return _pessoaRepository.Update(pessoa, op);

        }
    }
}
