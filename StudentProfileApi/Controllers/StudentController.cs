using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StudentProfileApi.Models;
using StudentProfileApi.Services;

namespace StudentProfileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _studentServices;
        public StudentController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }
        // see all student profile
        [HttpGet]
        public IActionResult GetAllStudentsProfile()
        { 
            return Ok(_studentServices.GetAllStudentsProfile());
        }
        // see a specific student profile
        [HttpGet("{roll}")]
        public IActionResult GetStudentProfileByRoll(int roll)
        {
            try
            {
               return Ok( _studentServices.GetStudentProfileByRole(roll));
            }
            catch (Exception )
            {
                return NotFound();
            }
        }
        // create a student profile
        [HttpP  ost]
        public IActionResult CreateStudentProfile(Student addStudent)
        {
            return Ok(_studentServices.CreateStudentProfile(addStudent));
        }
        // update a student profile
        [HttpPut]
        public IActionResult UpdateStudentProfile(Student editStudent)
        {
            return Ok(_studentServices.UpdateStudentProfile(editStudent));
        }
        // delete a student profile
        [HttpDelete("{roll}")]
        public IActionResult DeleteStudentProfile(int roll)
        {
            _studentServices.DeleteStudentProfile(roll);
            return Ok();
        }
    }
}
