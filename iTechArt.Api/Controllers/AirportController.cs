﻿using iTechArt.Domain.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace iTechArt.Api.Controllers
{
    [Route("api/airport")]
    [ApiController]
    public sealed class AirportController : ControllerBase
    {
        private readonly IAirportsService _airportsService;
        private readonly string[] fileExtensions = {".xlsx", ".xls", ".csv", "application/vnd.ms-excel", "officedocument.spreadsheetml.sheet" };

        public AirportController(IAirportsService airportsService)
        {
            _airportsService = airportsService;
        }

        [HttpPost(ApiConstants.IMPORT)]
        public async Task<IActionResult> ImportAirportExcel(IFormFile file)
        {
            var fileExtension = Path.GetExtension(file.FileName);   

            if (fileExtensions.Contains(fileExtension))
            {
                return Ok(_airportsService.ImportAirportExcel());
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet(ApiConstants.EXPORT)]
        public async Task<IActionResult> ExportAirportExcel()
        {
            return Ok(_airportsService.ExportAirportExcel());
        }
    }
}
