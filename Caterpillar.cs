using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Caterpillar : Tractor
    {
        public enum CatModelList { D6T = 1, S650 = 2, PT30 = 3 }

        public string GetModel(int choice)
        {
            var values = Enum.GetValues(typeof(CatModelList));
            string model = string.Empty;
            foreach (CatModelList caterpillarModel in values)
            {

                if (choice == (int)caterpillarModel)
                {
                    model = Enum.GetName(typeof(CatModelList), (int)caterpillarModel);
                }
            }

            return model;
        }
    }
}
