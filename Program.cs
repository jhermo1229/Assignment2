using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {

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
            try
            {
                while (nextAppointment)
                {
                    Customer customer = new();

                    Console.Write("Customer's name: ");
                    customer.CustomerName = Console.ReadLine();
                    decimal value = 0;
                    string temp = string.Empty;
                    bool isConditionTrue = false;
                    while (!isConditionTrue)
                    {
                        Console.Write("Please enter your 12 digit credit card number: ");
                        temp = Console.ReadLine();
                        isConditionTrue = temp.Length == 12 && decimal.TryParse(temp, out value);
                    }

                    Vehicle vehicle = ProcessVehicle(customer.CustomerName);
                    customer.Vehicle = vehicle;
                    customer.CreditCardNo = temp;
                    string firstFour = temp.Substring(0, 4);
                    string lastFour = temp.Substring(8, 4);

                    Console.WriteLine("************************************");
                    Console.WriteLine($"{customer.CustomerName} - {customer.Vehicle.BrandName} {customer.Vehicle.Model} " +
                        $"{customer.Vehicle.YearOfMake} paid by {firstFour} XXXX XXXX {lastFour}");
                    Console.WriteLine("************************************");
                    customerList.Add($"{customer.CustomerName} - {customer.Vehicle.BrandName} {customer.Vehicle.Model} " +
                        $"{customer.Vehicle.YearOfMake} paid by {firstFour} XXXX XXXX {lastFour}");

                    Console.WriteLine("Do for another client (y/n)? ");
                    nextAppointment = (String.Compare(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase)) == 0;


                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("********************************");
            Console.WriteLine("Total Customers for the day:");
            for (int i = 0; i < customerList.Count; i++)
            {
                
                Console.WriteLine($"{customerList[i]}");
            }
        }

        public Vehicle ProcessVehicle(string name)
        {
            Vehicle vehicle = new();
            var vehicleTypeValues = Enum.GetNames(typeof(Vehicle.VehicleType));

            
            Console.WriteLine("Please choose the customer's vehicle type: ");

            for (int i = 0; i < vehicleTypeValues.Length; i++)
            {
                string vehicleType = (string)vehicleTypeValues[i];
                Console.WriteLine($"{i + 1}. {vehicleType}");
            }

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Car car = new();
                    Console.WriteLine("Please choose the number of the brand from the list:");
                    var carBrandList = Enum.GetNames(typeof(Car.Brand));
                    for (int i = 0; i < carBrandList.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {carBrandList[i]}");
                    }

                    vehicle.BrandName = car.GetBrand(int.Parse(Console.ReadLine()));

                    vehicle.Model= GetCarModel(vehicle.BrandName);

                    Console.WriteLine("What year model? ");
                    vehicle.YearOfMake = Console.ReadLine();                   

                    ConstantProcess();
                    car.SpecialProcess();

                    //Console.WriteLine($"{name} - {yearModel} {vehicleBrand} {model}");
                    return vehicle;

                case 2:
                    Schoolbus schoolBus = new();
                    Console.WriteLine("Please choose the number of the brand from the list:");
                    var schoolBusBrandList = Enum.GetNames(typeof(Schoolbus.Brand));
                    for (int i = 0; i < schoolBusBrandList.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {schoolBusBrandList[i]}");
                    }

                    vehicle.BrandName = schoolBus.GetBrand(int.Parse(Console.ReadLine()));

                    vehicle.Model = GetSchoolbusModel(vehicle.BrandName);

                    Console.WriteLine("What year model? ");
                    vehicle.YearOfMake = Console.ReadLine();

                    ConstantProcess();
                    schoolBus.SpecialProcess();

                    //Console.WriteLine($"{name} - {yearModel} {vehicleBrand} {model}");
                    return vehicle;

                case 3:
                    Pickup pickup = new();
                    Console.WriteLine("Please choose the number of the brand from the list:");
                    var pickupBrandList = Enum.GetNames(typeof(Pickup.Brand));
                    for (int i = 0; i < pickupBrandList.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {pickupBrandList[i]}");
                    }

                    vehicle.BrandName = pickup.GetBrand(int.Parse(Console.ReadLine()));

                    vehicle.Model = GetPickupModel(vehicle.BrandName);

                    Console.WriteLine("What year model? ");
                    vehicle.YearOfMake = Console.ReadLine();

                    ConstantProcess();
                    pickup.SpecialProcess();

                    //Console.WriteLine($"{name} - {yearModel} {vehicleBrand} {model}");
                    return vehicle;

                case 4:
                    Tractor tractor = new();
                    Console.WriteLine("Please choose the number of the brand from the list:");
                    var tractorBrandList = Enum.GetNames(typeof(Tractor.Brand));
                    for (int i = 0; i < tractorBrandList.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tractorBrandList[i]}");
                    }

                    vehicle.BrandName = tractor.GetBrand(int.Parse(Console.ReadLine()));

                    vehicle.Model = GetTractorModel(vehicle.BrandName);

                    Console.WriteLine("What year model? ");
                    vehicle.YearOfMake = Console.ReadLine();

                    ConstantProcess();
                    tractor.SpecialProcess();

                    //Console.WriteLine($"{name} - {yearModel} {vehicleBrand} {model}");
                    return vehicle;

                default:
                    return vehicle;

            }
        }

        private string GetCarModel(string brand)
        {
            string model = string.Empty;
            if (brand.Equals("Honda"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var hondaModelList = Enum.GetNames(typeof(Honda.HondaModelList));
                for (int i = 0; i < hondaModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {hondaModelList[i]}");
                }

                Honda honda = new();
                model = honda.GetModel(int.Parse(Console.ReadLine()));
            }
            else if (brand.Equals("Toyota"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var toyotaModelList = Enum.GetNames(typeof(Toyota.ToyotaModelList));
                for (int i = 0; i < toyotaModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {toyotaModelList[i]}");
                }

                Toyota toyota = new();
                model = toyota.GetModel(int.Parse(Console.ReadLine()));
            }
            else if (brand.Equals("Subaru"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var subaruModelList = Enum.GetNames(typeof(Subaru.SubaruModelList));
                for (int i = 0; i < subaruModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {subaruModelList[i]}");
                }

                Subaru subaru = new();
                model = subaru.GetModel(int.Parse(Console.ReadLine()));
            }

            return model;
        }

        private string GetSchoolbusModel(string brand)
        {
            string model = string.Empty;
            if (brand.Equals("Navistar"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var navistarModelList = Enum.GetNames(typeof(Navistar.NavistarModelList));
                for (int i = 0; i < navistarModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {navistarModelList[i]}");
                }

                Navistar navistar = new();
                model = navistar.GetModel(int.Parse(Console.ReadLine()));
            }
            else if (brand.Equals("Collins"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var collinsModelList = Enum.GetNames(typeof(Collins.CollinsModelList));
                for (int i = 0; i < collinsModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {collinsModelList[i]}");
                }

                Collins collins = new();
                model = collins.GetModel(int.Parse(Console.ReadLine()));
            }
            else if (brand.Equals("Rev"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var revModelList = Enum.GetNames(typeof(Rev.RevModelList));
                for (int i = 0; i < revModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {revModelList[i]}");
                }

                Rev rev = new();
                model = rev.GetModel(int.Parse(Console.ReadLine()));
            }

            return model;
        }

        private string GetPickupModel(string brand)
        {
            string model = string.Empty;
            if (brand.Equals("Ford"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var fordModelList = Enum.GetNames(typeof(Ford.FordModelList));
                for (int i = 0; i < fordModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {fordModelList[i]}");
                }

                Ford ford = new();
                model = ford.GetModel(int.Parse(Console.ReadLine()));
            }
            else if (brand.Equals("Nissan"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var nissanModelList = Enum.GetNames(typeof(Nissan.NissanModelList));
                for (int i = 0; i < nissanModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {nissanModelList[i]}");
                }

                Nissan nissan = new();
                model = nissan.GetModel(int.Parse(Console.ReadLine()));
            }
            else if (brand.Equals("Chevrolet"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var chevyModelList = Enum.GetNames(typeof(Chevrolet.ChevyModelList));
                for (int i = 0; i < chevyModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {chevyModelList[i]}");
                }

                Chevrolet chevy = new();
                model = chevy.GetModel(int.Parse(Console.ReadLine()));
            }

            return model;
        }

        private string GetTractorModel(string brand)
        {
            string model = string.Empty;
            if (brand.Equals("Caterpillar"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var catModelList = Enum.GetNames(typeof(Caterpillar.CatModelList));
                for (int i = 0; i < catModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {catModelList[i]}");
                }

                Caterpillar caterpillar = new();
                model = caterpillar.GetModel(int.Parse(Console.ReadLine()));
            }
            else if (brand.Equals("Kumo"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var kumoModelList = Enum.GetNames(typeof(Kumo.KumoModelList));
                for (int i = 0; i < kumoModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {kumoModelList[i]}");
                }

                Kumo kumo = new();
                model = kumo.GetModel(int.Parse(Console.ReadLine()));
            }
            else if (brand.Equals("Kubota"))
            {
                Console.WriteLine("Please choose the number of the model from the list:");
                var kubotaModelList = Enum.GetNames(typeof(Kubota.KubotaModelList));
                for (int i = 0; i < kubotaModelList.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {kubotaModelList[i]}");
                }

                Kubota kubota = new();
                model = kubota.GetModel(int.Parse(Console.ReadLine()));
            }

            return model;
        }

        public static void ConstantProcess()
        {

            Console.WriteLine("*****CAR MAINTENANCE PROCESS BEGINS*****");
            Vehicle vehicle = new();
            vehicle.ChangeOil();
            vehicle.EngineTuneUp();
            vehicle.TransmissionCleanUp();
        }





    }   
}
