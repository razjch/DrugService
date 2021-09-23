using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugsAPI.Models
{
    public class DispatchableDrug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }

        public int Stock { get; set; }
    }
}
