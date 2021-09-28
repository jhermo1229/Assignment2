using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Chevrolet : Pickup
    {
        public enum ChevyModelList { Colorado = 1, Silverado = 2, Ram = 3 }

        public string GetModel(int choice)
        {
            var values = Enum.GetValues(typeof(ChevyModelList));
            string model = string.Empty;
            foreach (ChevyModelList chevyModel in values)
            {

                if (choice == (int)chevyModel)
                {
                    model = Enum.GetName(typeof(ChevyModelList), (int)chevyModel);
                }
            }

            return model;
        }
    }
}
