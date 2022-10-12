using AnimalModel;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services {
    internal class AnimalServices {


        private IAnimalReporsitory _animalRepository;
        public AnimalServices() {

            _animalRepository = new AnimalRepository();
        }

        public bool Add(Animal animal) {
            return _animalRepository.Add(animal);
        }

        public List<Animal> GetAll() {

            return _animalRepository.GetAll();

        }

        public bool Delete(Animal animal) {

            return _animalRepository.Delete(animal);

        }

        public bool Update(Animal animal, int op) {

            return _animalRepository.Update(animal, op);

        }
    }
}
