using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Nissan : Pickup
    {
        public enum NissanModelList { Navara = 1, Frontier = 2, Platinum = 3 }

        public string GetModel(int choice)
        {
            var values = Enum.GetValues(typeof(NissanModelList));
            string model = string.Empty;
            foreach (NissanModelList nissanModel in values)
            {

                if (choice == (int)nissanModel)
                {
                    model = Enum.GetName(typeof(NissanModelList), (int)nissanModel);
                }
            }

            return model;
        }
    }
}
