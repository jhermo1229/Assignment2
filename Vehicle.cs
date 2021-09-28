using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Vehicle
    {

        public enum VehicleType { Car=1, SchoolBus=2, Pickup=3, Tractor=4 };
        private string brandName;
        private string yearOfMake;
        private string model;

        public string BrandName { get => brandName; set => brandName = value; }
        public string YearOfMake { get => yearOfMake; set => yearOfMake = value; }
        public string Model { get => model; set => model = value; }


        public virtual void ChangeOil()
        {
            Console.WriteLine("Oil Change done.....");
        }

        public virtual void EngineTuneUp()
        {
            Console.WriteLine("Engine tune up done.....");
        }

        public virtual void TransmissionCleanUp()
        {
            Console.WriteLine("Transmission clean up done.....");
        }

    }

  
}
