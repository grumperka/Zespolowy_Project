using Projekt_Zespolowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Zespolowy_Project.DAL
{
    public class CarServiceInitializer : DropCreateDatabaseIfModelChanges<CarServiceContext>
    {
        protected override void Seed(CarServiceContext context)
        {

            var cars = new List<Car> {

                new Car{ OwnerName = "Jan Kowalski", OwnerAddress = "Siedlce ul. 3 maja 55", RegistrationDate = new DateTime(2020, 11, 20, 15, 30, 00), Mileage = 250000, NumerPlate = "KDA2877" },
                new Car{ OwnerName = "Teofila Piątek", OwnerAddress = "Toruń ul. Szkolna 15", RegistrationDate = new DateTime(2020, 11, 15, 14, 15, 00), Mileage = 215000, NumerPlate = "TKI6138" },
                new Car{ OwnerName = "Błażej Ciesielski", OwnerAddress = "Lublin ul. Kasztanowa 1/2", RegistrationDate = new DateTime(2020, 11, 18, 14, 15, 00), Mileage = 320000, NumerPlate = "KCH8983" },
                new Car{ OwnerName = "Natan Wieczorek", OwnerAddress = "Szczecin ul. Łąkowa 2", RegistrationDate = new DateTime(2020, 11, 19, 10, 00, 00), Mileage = 5000, NumerPlate = "SJZ0822" },
                new Car{ OwnerName = "Kazimierz Kalinowski", OwnerAddress = "Gliwice ul. Skromna 15", RegistrationDate = new DateTime(2020, 11, 21, 12, 49, 00), Mileage = 80000, NumerPlate = "ZSW3850" }

            };

            cars.ForEach(cr => context.Cars.Add(cr));
            context.SaveChanges();


            var carServices = new List<CarService>
            {

                new CarService { NameService = "Mechanika Pojazdowa", AddressService = "Siedlce ul. Altyleryjska 38" },
                new CarService { NameService = "Warsztat samochodowy Kompleks Zbigniew Skup", AddressService = "Siedlce ul. Arcybiskupa Ignacego Krasickiego 4" },
                new CarService { NameService = "MJG Auto Serwis", AddressService = "Siedlce ul. Łukowska 15" },
                new CarService { NameService = "Elektromechanika Pojazdowa", AddressService = "Siedlce ul. Południowa 101" }

            };

            carServices.ForEach(cr => context.CarServices.Add(cr));
            context.SaveChanges();

            var carRepairs = new List<CarRepair> {

                new CarRepair { RepairDescryption = "Wymiana klocków hamulcowych.", RepairStartDate = new DateTime(2020, 11, 21, 7, 30, 00), RepairEndDate = new DateTime(2020, 11, 21, 17, 55, 00), ManHours = 9, Cost = 350, Car = cars[0], CarId = cars[0].Id, CarService = carServices[0], CarServiceId = carServices[0].Id  },
                new CarRepair { RepairDescryption = "Wymiana akumulatora.", RepairStartDate = new DateTime(2020, 11, 15, 14, 15, 00), RepairEndDate = new DateTime(2020, 11, 16, 10, 15, 00), ManHours = 5, Cost = 500, Car = cars[1], CarId = cars[1].Id, CarService = carServices[1], CarServiceId = carServices[1].Id  },
                new CarRepair { RepairDescryption = "Piaskowanie.", RepairStartDate = new DateTime(2020, 11, 18, 14, 15, 00), RepairEndDate = new DateTime(2020, 11, 19, 19, 15, 00), ManHours = 8, Cost = 700, Car = cars[2], CarId = cars[2].Id, CarService = carServices[2], CarServiceId = carServices[2].Id },
                new CarRepair { RepairDescryption = "Wodorowanie silnika.", RepairStartDate = new DateTime(2020, 11, 19, 10, 00, 00), RepairEndDate = new DateTime(2020, 11, 20, 10, 00, 00), ManHours = 7, Cost = 600, Car = cars[3], CarId = cars[3].Id, CarService = carServices[3], CarServiceId = carServices[3].Id },
                new CarRepair { RepairDescryption = "WAwaria automatycznej skrzyni biegów.", RepairStartDate = new DateTime(2020, 11, 21, 12, 49, 00), RepairEndDate = new DateTime(2020, 11, 21, 18, 30, 00), ManHours = 5, Cost = 500, Car = cars[4], CarId = cars[4].Id, CarService = carServices[4], CarServiceId = carServices[4].Id }
            };

            carRepairs.ForEach(cr => context.CarRepairs.Add(cr));
            context.SaveChanges();


            var carPhotos = new List<CarPhoto> {

                new CarPhoto { PathFile = "car1.png", MimeType = "image/png", CarRepair = carRepairs[0], CarRepairId = carRepairs[0].Id, SendDate = new DateTime(2020, 11, 21, 7, 30, 00) },
                new CarPhoto { PathFile = "car2.jpeg", MimeType = "image/jpeg", CarRepair = carRepairs[1], CarRepairId = carRepairs[1].Id, SendDate = new DateTime(2020, 11, 15, 14, 15, 00) },
                new CarPhoto { PathFile = "car3.png", MimeType = "image/png", CarRepair = carRepairs[2], CarRepairId = carRepairs[2].Id, SendDate = new DateTime(2020, 11, 18, 14, 15, 00) },
                new CarPhoto { PathFile = "car4.jpeg", MimeType = "image/jpeg", CarRepair = carRepairs[3], CarRepairId = carRepairs[3].Id, SendDate = new DateTime(2020, 11, 19, 10, 00, 00) },
                new CarPhoto { PathFile = "car4.png", MimeType = "image/png", CarRepair = carRepairs[4], CarRepairId = carRepairs[4].Id, SendDate = new DateTime(2020, 11, 21, 12, 49, 00) }

            };

            carPhotos.ForEach(cr => context.CarPhotos.Add(cr));
            context.SaveChanges();

        }

    }
}