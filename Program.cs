using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        private const string Y = "y";
        private const string Brand = "brand";
        private const string Model = "model";
        private List<String> customerList = new();
        bool nextAppointment = true;

        static void Main(string[] args)
        {
            
            Program p = new();
            p.Go();
            Console.ReadKey();
        }

        private void Go()
        {

                while (nextAppointment)
            {
                Customer customer = new();

                Console.Write("Customer's name: ");
                customer.CustomerName = Console.ReadLine();
                customer.CreditCardNo = GetCreditCardInfo();

                Vehicle vehicle = ProcessVehicle();
                customer.Vehicle = vehicle;                

                //Every single customer will output like this
                Console.WriteLine("************************************");
                Console.WriteLine($"{customer.CustomerName} - {customer.Vehicle.BrandName} {customer.Vehicle.Model} " +
                    $"{customer.Vehicle.YearOfMake} paid by {customer.CreditCardNo}");
                Console.WriteLine("************************************");

                //This is for the list of customer that was processed the whole day
                customerList.Add($"{customer.CustomerName} - {customer.Vehicle.BrandName} {customer.Vehicle.Model} " +
                    $"{customer.Vehicle.YearOfMake} paid by {customer.CreditCardNo}");

                Console.WriteLine("Do for another client (input y for yes)? ");
                nextAppointment = (String.Compare(Console.ReadLine(), Y, StringComparison.OrdinalIgnoreCase)) == 0;
            }

            Console.WriteLine("********************************");
            Console.WriteLine("Total Customers for the day:");
            for (int i = 0; i < customerList.Count; i++)
            {                
                Console.WriteLine($"{customerList[i]}");
            }
        }

        //Process the vehicle of the customer
        //Done polymorphism and overriding here
        //SpecialProcess() - override method
        public Vehicle ProcessVehicle()
        {
            int value = 0;
            string brand = String.Empty;
            Vehicle vehicle = new();
            var vehicleTypeValues = Enum.GetNames(typeof(Vehicle.VehicleType));
            value = LoopingChoices("vehicle type", vehicleTypeValues);

            switch (value)
            {
                case 1:
                    vehicle = new Car();                    
                    var carBrandList = Enum.GetNames(typeof(Car.Brand));
                    value = LoopingChoices(Brand, carBrandList);
                    brand = ((Car)vehicle).GetBrand(value);
                    vehicle.BrandName = brand;
                    vehicle.Model = GetCarModel(brand);
                    vehicle.YearOfMake = GetYearModel();
                    ConstantProcess();
                    vehicle.SpecialProcess();
                    
                    return vehicle;

                case 2:
                    vehicle = new Schoolbus();
                    var schoolBusBrandList = Enum.GetNames(typeof(Schoolbus.Brand));
                    value = LoopingChoices(Brand, schoolBusBrandList);
                    brand = ((Schoolbus)vehicle).GetBrand(value);
                    vehicle.BrandName = brand;
                    vehicle.Model = GetSchoolbusModel(brand);
                    vehicle.YearOfMake = GetYearModel();
                    ConstantProcess();
                    vehicle.SpecialProcess();
                    return vehicle;

                case 3:
                    vehicle = new Pickup();
                    var pickupBrandList = Enum.GetNames(typeof(Pickup.Brand));
                    value = LoopingChoices(Brand, pickupBrandList);
                    brand = ((Pickup)vehicle).GetBrand(value);
                    vehicle.BrandName = brand;
                    vehicle.Model = GetPickupModel(brand);
                    vehicle.YearOfMake = GetYearModel();
                    ConstantProcess();
                    vehicle.SpecialProcess();
                    return vehicle;

                case 4:
                    vehicle = new Tractor();
                    var tractorBrandList = Enum.GetNames(typeof(Tractor.Brand));
                    value = LoopingChoices(Brand, tractorBrandList);
                    brand = ((Tractor)vehicle).GetBrand(value);
                    vehicle.BrandName = brand;
                    vehicle.Model = GetTractorModel(brand);
                    vehicle.YearOfMake = GetYearModel();
                    ConstantProcess();
                    vehicle.SpecialProcess();
                    return vehicle;

                default:
                    return vehicle;

            }
        }

        //Get car models based on brand
        private string GetCarModel(string brand)
        {
            string model = string.Empty;
            int value = 0;
            if (brand.Equals("Honda"))
            {
                Honda honda = new();
                var hondaModelList = Enum.GetNames(typeof(Honda.HondaModelList));
                value = LoopingChoices(Model, hondaModelList);                
                model = honda.GetModel(value);
            }
            else if (brand.Equals("Toyota"))
            {
                Toyota toyota = new();
                var toyotaModelList = Enum.GetNames(typeof(Toyota.ToyotaModelList));
                value = LoopingChoices(Model, toyotaModelList);
                model = toyota.GetModel(value);
            }
            else if (brand.Equals("Subaru"))
            {
                Subaru subaru = new();
                var subaruModelList = Enum.GetNames(typeof(Subaru.SubaruModelList));
                value = LoopingChoices(Model, subaruModelList);
                model = subaru.GetModel(value);
            }

            return model;
        }

        //Get schoolbus model based on brand
        private string GetSchoolbusModel(string brand)
        {
            string model = string.Empty;
            int value = 0;
            if (brand.Equals("Navistar"))
            {
                var navistarModelList = Enum.GetNames(typeof(Navistar.NavistarModelList));
                value = LoopingChoices(Model, navistarModelList);
                Navistar navistar = new();
                model = navistar.GetModel(value);
            }
            else if (brand.Equals("Collins"))
            {
                Collins collins = new();
                var collinsModelList = Enum.GetNames(typeof(Collins.CollinsModelList));
                value = LoopingChoices(Model, collinsModelList);                
                model = collins.GetModel(value);
            }
            else if (brand.Equals("Rev"))
            {
                Rev rev = new();
                var revModelList = Enum.GetNames(typeof(Rev.RevModelList));
                value = LoopingChoices(Model, revModelList);                
                model = rev.GetModel(value);
            }

            return model;
        }

        //Get pickup models based on brand
        private string GetPickupModel(string brand)
        {
            string model = string.Empty;
            int value = 0;
            if (brand.Equals("Ford"))
            {
                Ford ford = new();
                var fordModelList = Enum.GetNames(typeof(Ford.FordModelList));
                value = LoopingChoices(Model, fordModelList);                
                model = ford.GetModel(value);
            }
            else if (brand.Equals("Nissan"))
            {
                Nissan nissan = new();
                var nissanModelList = Enum.GetNames(typeof(Nissan.NissanModelList));
                value = LoopingChoices(Model, nissanModelList);                
                model = nissan.GetModel(value);
            }
            else if (brand.Equals("Chevrolet"))
            {
                Chevrolet chevy = new();
                var chevyModelList = Enum.GetNames(typeof(Chevrolet.ChevyModelList));
                value = LoopingChoices(Model, chevyModelList);                
                model = chevy.GetModel(value);
            }

            return model;
        }

        //Get tractor models based on brand
        private string GetTractorModel(string brand)
        {
            string model = string.Empty;
            int value = 0;
            if (brand.Equals("Caterpillar"))
            {
                Caterpillar caterpillar = new();
                var catModelList = Enum.GetNames(typeof(Caterpillar.CatModelList));
                value = LoopingChoices(Model, catModelList);                
                model = caterpillar.GetModel(value);
            }
            else if (brand.Equals("Kumo"))
            {
                Kumo kumo = new();
                var kumoModelList = Enum.GetNames(typeof(Kumo.KumoModelList));
                value = LoopingChoices(Model, kumoModelList);                
                model = kumo.GetModel(value);
            }
            else if (brand.Equals("Kubota"))
            {
                Kubota kubota = new();
                var kubotaModelList = Enum.GetNames(typeof(Kubota.KubotaModelList));
                value = LoopingChoices(Model, kubotaModelList);                
                model = kubota.GetModel(value);
            }

            return model;
        }

        //Constant process on all vehicles
        private static void ConstantProcess()
        {
            Console.WriteLine("*****CAR MAINTENANCE PROCESS BEGINS*****");
            Vehicle vehicle = new();
            vehicle.ChangeOil();
            vehicle.EngineTuneUp();
            vehicle.TransmissionCleanUp();
        }

        //This is to check if user input is valid
        private bool CheckingInput(string input, int dataCount)
        {
            int value = 0;
            bool isValid = int.TryParse(input, out value) && int.Parse(input) <= dataCount;
            return isValid;
        }

        //This method is for all the looping choices that is only repetitive
        private int LoopingChoices(string name, string[] data)
        {
            string temp = String.Empty;
            bool isValid = false;
            while (!isValid) {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {data[i]}");
                }
                Console.Write($"Please choose the number of the {name}:");
                temp = Console.ReadLine();
                isValid = CheckingInput(temp, data.Length);
            }
            return int.Parse(temp);
        }

        //Get the year model of the vehicle
        private string GetYearModel()
        {
            string temp = String.Empty;
            int value = 0;
            bool isValid = false;
            while (!isValid) {
                
                Console.Write("What is the year model? ");
                temp = Console.ReadLine();
                isValid = int.TryParse(temp, out value);
            }
            return temp;

        }

        //Get credit card info of customer
        private string GetCreditCardInfo()
        {
            bool isValid  = false;
            string temp = String.Empty;
            decimal value = 0;
            while (!isValid)
            {
                Console.Write("Please enter your 12 digit credit card number: ");
                temp = Console.ReadLine();
                isValid = temp.Length == 12 && decimal.TryParse(temp, out value); //Make sure input is 12 digits and numeric
            }

            //Change the value of string return of credit card
            string firstFour = temp.Substring(0, 4);
            string lastFour = temp.Substring(8, 4);

            return $"{firstFour} XXXX XXXX {lastFour}";
        }

    }   
}
