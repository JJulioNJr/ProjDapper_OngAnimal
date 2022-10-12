using AdocaoModel;
using Repository;
using System;
using System.Collections.Generic;

namespace Services {
    public class AdocaoServices {

        private IAdocaoRepository       _adoacaoRepository;
        public AdocaoServices() {

            _adoacaoRepository = new AdocaoRepository();
        }

        public bool Add(Adocao adocao) {
            return _adoacaoRepository.Add(adocao);
        }

        public List<Adocao> GetAll() {

            return _adoacaoRepository.GetAll();

        }

        public bool Delete(Adocao adocao) {

            return _adoacaoRepository.Delete(adocao);

        }

        public bool Update(Adocao adocao) {

            return _adoacaoRepository.Update(adocao);

        }
    }
}
