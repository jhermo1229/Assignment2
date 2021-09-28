using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Subaru:Car
    { 
        public enum SubaruModelList { WRX = 1, BRZ = 2, Forester = 3 }

    public string GetModel(int choice)
    {
        var values = Enum.GetValues(typeof(SubaruModelList));
        string model = string.Empty;
        foreach (SubaruModelList subaruModel in values)
        {

            if (choice == (int)subaruModel)
            {
                model = Enum.GetName(typeof(SubaruModelList), (int)subaruModel);
            }
        }

        return model;
    }
}
}

