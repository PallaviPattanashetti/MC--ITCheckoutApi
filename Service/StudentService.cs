using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MC__ITCheckoutApi.Models;

namespace MC__ITCheckoutApi.Service
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _studentList = new();
        public StudentService()
        {

            _studentList.Add(new Student
            {
                Id = 1,
                Name = "Juhi",
                Email = "Juhi.juhi@gmail.com",
                DeviceCheckedOutId = true

            });

            _studentList.Add(new Student
            {
                Id = 2,
                Name = "Barbara",
                Email = "Barbara.@gmail.com",
                DeviceCheckedOutId = true

            });
        }

        // ----Create---
        public Student AddStudent(Student newStudent)
        {
            int newId = _studentList.Count == 0 ? 1 : _studentList.Max(s => s.Id) + 1;
            newStudent.Id = newId;
            _studentList.Add(newStudent);
            return newStudent;
        }

        //----Delete----
        public bool DeleteStudent(int id)
        {
            Student? student= _studentList.FirstOrDefault(s=>s.Id==id);
            if (student == null)
            {
                return false;
            }
            _studentList.Remove(student);
            return true;
        }

        public Student? GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        //---Read----
        public List<Student>GetStudents()
        {
            return _studentList;
        }
        //---Update-----
        public Student? updateStudent(int id, Student updateStudent)
        {
            Student? existingStudent = _studentList.FirstOrDefault(s =>s.Id==id);
            if(existingStudent==null)
            {
                return null;
            }
            existingStudent.Name=updateStudent.Name;
             existingStudent.Email=updateStudent.Email;
              existingStudent. DeviceCheckedOutId =updateStudent. DeviceCheckedOutId ;
              return existingStudent;
        }

        public Student? UpdateStudent(int id, Student updateStudent)
        {
            throw new NotImplementedException();
        }
    }
}