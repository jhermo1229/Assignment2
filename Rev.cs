using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Rev : Schoolbus
    {
        public enum RevModelList { Champion = 1, LCT = 2, ElDorado = 3 }

        public string GetModel(int choice)
        {
            var values = Enum.GetValues(typeof(RevModelList));
            string model = string.Empty;
            foreach (RevModelList revModel in values)
            {

                if (choice == (int)revModel)
                {
                    model = Enum.GetName(typeof(RevModelList), (int)revModel);
                }
            }

            return model;
        }
    }
}
