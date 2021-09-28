using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Honda:Car
    {


        public enum HondaModelList { Civic=1, Accord=2, Crv=3}

        public string GetModel(int choice)
        {
            var values = Enum.GetValues(typeof(HondaModelList));
            string model = string.Empty;
            foreach (HondaModelList hondaModel in values) {

                if (choice == (int)hondaModel)
                {
                    model =  Enum.GetName(typeof(HondaModelList), (int)hondaModel);
                }
            }

            return model;
        }
    }
}
