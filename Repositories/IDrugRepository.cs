using DrugsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugsAPI.Repositories
{
    public interface IDrugRepository
    {
        Drug GetById(int id);

        Drug GetByName(string name);

        DispatchableDrug GetDispatchableDrugStock(int id, string location);
        List<Drug> GetAllDrugs();
    }
}
