using AnimalModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository {
    public interface IAnimalReporsitory {

        bool Add(Animal animal);
        List<Animal> GetAll();
        bool Delete(Animal animal);
        bool Update(Animal animal, int op);
    }
}
