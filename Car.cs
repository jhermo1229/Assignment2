using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Car : Vehicle
    {
    
        public enum Brand { Honda=1, Toyota=2, Subaru=3 }

        public override void SpecialProcess()
        {
            Console.WriteLine("Car body tuneup done...");
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
