using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MC__ITCheckoutApi.Models;

namespace MC__ITCheckoutApi.Service
{
    public interface IStudentService 
    {
        Student AddStudent(Student newStudent);
        List<Student>GetStudents();
        Student?GetStudentById(int id);
        Student?UpdateStudent(int id, Student updateStudent);
        bool DeleteStudent(int id);


    }
}