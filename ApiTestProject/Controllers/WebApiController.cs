using ApiTestProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTestProject.Controllers
{
    
    public class WebApiController : ApiController
    {
        IList<Student> Student = new List<Student>()
        {
            new Student()
                {
                    StudentId = 1, StudentName = "Mukesh Kumar", Address = "New Delhi", Course = "IT"
                },
                new Student()
                {
                    StudentId = 2, StudentName = "Banky Chamber", Address = "London", Course = "HR"
                },
                new Student()
                {
                    StudentId = 3, StudentName = "Rahul Rathor", Address = "Laxmi Nagar", Course = "IT"
                },
                new Student()
                {
                    StudentId = 4, StudentName = "YaduVeer Singh", Address = "Goa", Course = "Sales"
                },
                new Student()
                {
                    StudentId = 5, StudentName = "Manish Sharma", Address = "New Delhi", Course = "HR"
                },
        };
        

        [HttpGet]
        [Route("api/student/names")]
        public IList<Student> GetAllStudents1()
        {
            //Return list of all employees    
            return Student;
        }
        public Student GetStudentDetails(int id)
        {
            //Return a single employee detail    
            var Stu = Student.FirstOrDefault(e => e.StudentId == id);
            if (Stu == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return Stu;
        }
        [HttpPost]
        public IList<Student> GetStudentDetails(Student student)
        {
            //Return list of all employees with new entry
            IList<Student> Student = new List<Student>();
            Student.Add(student);
            Console.WriteLine("Akash");
            Console.WriteLine("Mishra");
            Console.WriteLine("New");
            Console.WriteLine("New1");
            return Student;
        }
    }
}
