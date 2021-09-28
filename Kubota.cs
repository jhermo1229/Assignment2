using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Kubota : Tractor
    {
        public enum KubotaModelList { BX = 1, B01 = 2, LX = 3 }

        public string GetModel(int choice)
        {
            var values = Enum.GetValues(typeof(KubotaModelList));
            string model = string.Empty;
            foreach (KubotaModelList kubotaModel in values)
            {

                if (choice == (int)kubotaModel)
                {
                    model = Enum.GetName(typeof(KubotaModelList), (int)kubotaModel);
                }
            }

            return model;
        }
    }
}