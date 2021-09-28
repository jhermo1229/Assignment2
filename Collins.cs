using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Collins : Schoolbus
    {
        public enum CollinsModelList { TypeA = 1, LowFLoor = 2, Electric = 3 }

        public string GetModel(int choice)
        {
            var values = Enum.GetValues(typeof(CollinsModelList));
            string model = string.Empty;
            foreach (CollinsModelList collinsModel in values)
            {

                if (choice == (int)collinsModel)
                {
                    model = Enum.GetName(typeof(CollinsModelList), (int)collinsModel);
                }
            }

            return model;
        }
    }
}
