using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrugsAPI.Models;


namespace DrugsAPI.TempDatabase
{
    public class DrugData
    {
        public List<Drug> drugs = new List<Drug>();


        public DrugData()
        {
            Drug drug = new Drug()
            {
                Id = 1,
                Name = "crocin",
                Manufacturer = "ab medicals",
                ManufacturedDate = Convert.ToDateTime("2/2/2020"),
                ExpiryDate = Convert.ToDateTime("2/2/2022"),
                QtyLocation = new List<DrugLocation>()
                {
                    new DrugLocation() { Location = "bangalore", Quantity = 1200 },

                    new DrugLocation() { Location = "mysore", Quantity = 300 },

                    new DrugLocation() { Location = "mangalore", Quantity = 0 },

                    new DrugLocation() { Location = "chennai", Quantity = 5000 },

                    new DrugLocation() { Location = "dharwad", Quantity = 800 }

                }

            };


            Drug drug2= new Drug()
            {
                Id = 2,
                Name = "combiflame",
                Manufacturer = "Cipla medicals",
                ManufacturedDate = Convert.ToDateTime("2/2/2020"),
                ExpiryDate = Convert.ToDateTime("2/2/2022"),
                QtyLocation = new List<DrugLocation>()
                {
                    new DrugLocation() { Location = "bangalore", Quantity = 1200 },

                    new DrugLocation() { Location = "mysore", Quantity = 310 },

                    new DrugLocation() { Location = "mangalore", Quantity = 0 },

                    new DrugLocation() { Location = "chennai", Quantity = 5300 },

                    new DrugLocation() { Location = "dharwad", Quantity = 400 }

                }

            };


            Drug drug3 = new Drug()
            {
                Id = 3,
                Name = "pcm",
                Manufacturer = "CD medicals",
                ManufacturedDate = Convert.ToDateTime("2/2/2020"),
                ExpiryDate = Convert.ToDateTime("2/2/2022"),
                QtyLocation = new List<DrugLocation>()
                {
                    new DrugLocation() { Location = "bangalore", Quantity = 0 },

                    new DrugLocation() { Location = "mysore", Quantity = 1300 },

                    new DrugLocation() { Location = "mangalore", Quantity = 2100 },

                    new DrugLocation() { Location = "chennai", Quantity = 1500 },

                    new DrugLocation() { Location = "dharwad", Quantity = 900 }

                }

            };
            Drug drug4 = new Drug()
            {
                Id = 4,
                Name = "aspirine",
                Manufacturer = "EF medicals",
                ManufacturedDate = Convert.ToDateTime("2/4/2020"),
                ExpiryDate = Convert.ToDateTime("2/2/2023"),
                QtyLocation = new List<DrugLocation>()
                {
                    new DrugLocation() { Location = "bangalore", Quantity = 1100 },

                    new DrugLocation() { Location = "mysore", Quantity = 2300 },

                    new DrugLocation() { Location = "mangalore", Quantity = 100 },

                    new DrugLocation() { Location = "chennai", Quantity = 0 },

                    new DrugLocation() { Location = "dharwad", Quantity = 1900 }

                }

            };
            Drug drug5 = new Drug()
            {
                Id = 5,
                Name = "penicillin",
                Manufacturer = "GH medicals",
                ManufacturedDate = Convert.ToDateTime("8/4/2020"),
                ExpiryDate = Convert.ToDateTime("2/2/2023"),
                QtyLocation = new List<DrugLocation>()
                {
                    new DrugLocation() { Location = "bangalore", Quantity = 1120 },

                    new DrugLocation() { Location = "mysore", Quantity = 2330 },

                    new DrugLocation() { Location = "mangalore", Quantity = 120 },

                    new DrugLocation() { Location = "chennai", Quantity = 10 },

                    new DrugLocation() { Location = "dharwad", Quantity = 1900 }

                }

            };

            drugs.Add(drug);
            drugs.Add(drug2);
            drugs.Add(drug3);
            drugs.Add(drug4);
            drugs.Add(drug5);

        }
      





    }
}
