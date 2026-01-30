using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MC__ITCheckoutApi.Models;
using MC__ITCheckoutApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace MC__ITCheckoutApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService= studentService;
        }

        //Read all
        [HttpGet("GetStudentList")]
        public List<Student>GetStudents()
        {
            return _studentService.GetStudents();
        }

        //Read Id 
        [HttpGet("GetStudentById/{id}")]
        public Student?GetStudentById(int id)
        {
            return _studentService.GetStudentById(id);
        }

        //Create
        [HttpPost("AddStudent")]
        public Student AddStudent(Student student)
        {
            return _studentService.AddStudent(student);
        }

        //Update
        [HttpPut("updateStudent/{id}")]
        public Student ? UpdateStudent(int id, Student student)
        {
            return _studentService.UpdateStudent(id, student);
        }

        //Delete
        [HttpDelete("removeStudent/{id}")]
        public bool DeleteStudent(int id)
        {
            return _studentService.DeleteStudent(id);
        }
    }
}