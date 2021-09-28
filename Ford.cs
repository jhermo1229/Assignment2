using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Ford : Pickup
    {
        public enum FordModelList { Ranger = 1, Raptor = 2, F150 = 3 }

        public string GetModel(int choice)
        {
            var values = Enum.GetValues(typeof(FordModelList));
            string model = string.Empty;
            foreach (FordModelList fordModel in values)
            {

                if (choice == (int)fordModel)
                {
                    model = Enum.GetName(typeof(FordModelList), (int)fordModel);
                }
            }

            return model;
        }
    }
}
