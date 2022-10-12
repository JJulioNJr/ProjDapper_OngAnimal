using PessoaModel;
using System;
using System.Collections.Generic;

namespace Repository {
    public interface IPessoaRepository {

        bool Add(Pessoa pessoa);
        List<Pessoa> GetAll();
        bool Delete(Pessoa pessoa);
        bool Update(Pessoa pessoa, int op);
    }
}
