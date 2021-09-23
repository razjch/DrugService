using DrugsAPI.Models;
using DrugsAPI.TempDatabase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugsAPI.Repositories
{
    public class DrugRepository : IDrugRepository
    {
        //private readonly DrugContext drugContext;
        private readonly DrugData drugdata; 



        public DrugRepository( DrugData drugData)
        {
            this.drugdata = drugData;
        }
        public Drug GetById(int id)
        {
            return drugdata.drugs.Find(d => d.Id == id);
            
            //throw new NotImplementedException();
        }

        public  Drug GetByName(string name)
        {
            //throw new NotImplementedException();
            name = name.ToLower();
            return drugdata.drugs.Find(d => d.Name == name);
        }

       public DispatchableDrug GetDispatchableDrugStock(int id, string location)
        {
            location = location.ToLower();
            Drug drug = drugdata.drugs.Find(d => d.Id == id);

            if(drug!=null)
            {
                var loc = drug.QtyLocation.Find(l => l.Location == location);

                if(loc != null)
                {
                    DispatchableDrug dispatchableDrug = new DispatchableDrug
                    {
                        Id = drug.Id,
                        Name = drug.Name,
                        ExpiryDate = drug.ExpiryDate,
                        Stock = loc.Quantity
                    };
                    return dispatchableDrug;
                }
                return null;
            }
            return null;

            
        }
        public List<Drug> GetAllDrugs()
        {
            return drugdata.drugs;
        }
    }
}
