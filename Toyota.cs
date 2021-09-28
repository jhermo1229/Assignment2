using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Toyota:Car
    { 
        public enum ToyotaModelList { Corolla = 1, Rav4 = 2, Camry = 3 }

        public string GetModel(int choice)
        {
        var values = Enum.GetValues(typeof(ToyotaModelList));
        string model = string.Empty;
        foreach (ToyotaModelList toyotaModel in values)
        {

            if (choice == (int)toyotaModel)
            {
                model = Enum.GetName(typeof(ToyotaModelList), (int)toyotaModel);
            }
        }

        return model;
        }
    }
}
