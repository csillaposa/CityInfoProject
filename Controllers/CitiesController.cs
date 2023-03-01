﻿using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesDataStore _citiesDataStore;
        public CitiesController(CitiesDataStore citiesDataStore)
        {
            _citiesDataStore = citiesDataStore ?? throw new ArgumentNullException(nameof(citiesDataStore));
        }

        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> GetCities()
        {
            // returns a list, so null check is not necessary, an empty list is not a not found
            return Ok(_citiesDataStore.Cities);
        }

        [HttpGet("{id}")]
        public ActionResult<CityDto> GetCity(int id)
        {
            // find city
            var cityToReturn = _citiesDataStore.Cities.FirstOrDefault(c => c.Id == id);
            // check if the city with the given id exists
            if (cityToReturn == null)
            {
                return NotFound();
            }
            // return the city object with a status code
            return Ok(cityToReturn);
        }
    }
}
