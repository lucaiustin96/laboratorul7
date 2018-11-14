using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fii.BusinessLayer;
using Fii.DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityWebAPIDesign.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityRepository _repository;

        public CitiesController(ICityRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IReadOnlyList<City>> Get()
        {
            return Ok(this._repository.GetAll());
        }

        [HttpGet("{id}", Name ="GetById")]
        public ActionResult<City> GetById( Guid id)
        {
            return Ok(this._repository.GetAll());
        }

        [HttpPost]
        public ActionResult<City> Post([FromBody] City city)
        {
            if(city == null)
            {
                return BadRequest();
            }
            this._repository.Create(city);
            return CreatedAtRoute("GetById", new { id = city.Id }, city);
        }
    }
}