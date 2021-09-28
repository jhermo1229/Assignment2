using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Pickup : Vehicle
    { 
        public enum Brand { Ford = 1, Nissan = 2, Chevrolet = 3 }

    public override void SpecialProcess()
    {
        Console.WriteLine("Pickup cover installation done...");
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
