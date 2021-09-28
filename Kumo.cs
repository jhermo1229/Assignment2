using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Kumo : Tractor
    {
        public enum KumoModelList { Vario724 = 1, Ferguson7624 = 2, ChallengerMt55E = 3 }

        public string GetModel(int choice)
        {
            var values = Enum.GetValues(typeof(KumoModelList));
            string model = string.Empty;
            foreach (KumoModelList kumoModel in values)
            {

                if (choice == (int)kumoModel)
                {
                    model = Enum.GetName(typeof(KumoModelList), (int)kumoModel);
                }
            }

            return model;
        }
    }
}
