using AdocaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface IAdocaoRepository {
        bool Add(Adocao adocao);
        List<Adocao> GetAll();
        bool Delete(Adocao adocao);
        bool Update(Adocao adocao);
    }
}
