using DrugsAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugsAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DrugController : ControllerBase
    {
        private readonly IDrugRepository drugRepository;

        public DrugController(IDrugRepository drugRepository)
        {
            this.drugRepository = drugRepository;
        }

        [HttpGet("getById/{id}")]
        public  IActionResult SearchDrugsByID(int id)
        {
            var res = drugRepository.GetById(id);
            if(res!= null)
            {
                return Ok(res);
            }
            return NotFound("Enter Valid ID!!");
        }

        [HttpGet("getByName/{name}")]
        public IActionResult SearchDrugsByName(string name)
        {
            var res = drugRepository.GetByName(name);
            if (res != null)
            {
                return Ok(res);
            }
            return NotFound("Enter Valid Name!!");
        }


        [HttpPost("getStock/{id}/{location}")]
        public IActionResult getDispatchableDrugStock(int id, string location)
        {
            if(id<0 || location ==null)
            {
                return BadRequest("Enter Valid data!!");
            }
            var res = drugRepository.GetDispatchableDrugStock(id, location);

            if(res != null)
            {
                return Ok(res);
            }

            return NotFound("No record!!");
        }

        [HttpGet("getalldrugs")]
        public IActionResult GetAllDrugs()
        {
            var drugs = drugRepository.GetAllDrugs();
            if (drugs.Count == 0)
                return BadRequest("No Drugs Found");
            return Ok(drugs);
        }
    }
}
