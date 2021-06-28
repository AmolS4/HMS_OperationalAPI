using HMS.DBO.Models;
using HMS.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class PatientController : ControllerBase
    {

        private readonly IPatient<Patient, int> patServ;


        public PatientController(IPatient<Patient, int> service)
        {
            patServ = service;
        }


       [HttpGet]
       [Route("patient-listing")]
        public async Task<IActionResult> GetAsync()
        {
            var result = await patServ.GetAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("getpatient/{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var result = await patServ.GetAsync(id);
            return Ok(result);
        }

        [HttpPut]
        [Route("update-patient/{id}")]
        public async Task<IActionResult> PutAsync(int id, Patient data)
        {
            if (ModelState.IsValid)
            {
                var result = await patServ.UpdateAsync(id, data);
                return Ok(result);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("delete-patient/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await patServ.DeleteAsync(id);
            return Ok(result);
        }



    }
}
