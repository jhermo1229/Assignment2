using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Navistar : Schoolbus
    {
        public enum NavistarModelList { FreightLiner = 1, Harvester = 2, Sseries = 3 }

        public string GetModel(int choice)
        {
            var values = Enum.GetValues(typeof(NavistarModelList));
            string model = string.Empty;
            foreach (NavistarModelList navistarModel in values)
            {

                if (choice == (int)navistarModel)
                {
                    model = Enum.GetName(typeof(NavistarModelList), (int)navistarModel);
                }
            }

            return model;
        }
    }
}

