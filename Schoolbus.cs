using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Schoolbus: Vehicle
    {
        public enum Brand { Navistar = 1, Collins = 2, REV = 3 }

        public override void SpecialProcess()
        {
            Console.WriteLine("School Bus interior cleaning done...");
        }

        public string GetBrand(int choice)
        {
            var values = Enum.GetValues(typeof(Brand));
            string model = string.Empty;
            foreach (Brand brand in values)
            {

                if (choice == (int)brand)
                {
                    model = Enum.GetName(typeof(Brand), (int)brand);
                }
            }

            return model;
        }

    }


}