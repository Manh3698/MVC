using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetMVC.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        bool UpdateStudentInfo(Student student);
    }
    public class StudentService : IStudentService
    {
        private DataContext _context;
        public StudentService(DataContext context)
        {
            _context = context;
        }

        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(x=>x.StudentId == id);
        }
        public List<Student> GetStudents()
        {

            return _context.Students.Include(x => x.Class).ToList();
            //return _context.Students.ToList();

        }
        public bool UpdateStudentInfo(Student studentInput)
        {
            var student = _context.Students.FirstOrDefault(x => x.StudentId == studentInput.StudentId);
            if(student == null)
            {
                return false;
            }
            student.StudentName = studentInput.StudentName;
            student.BirthDate = studentInput.BirthDate;
            student.ClassId = studentInput.ClassId;
            _context.SaveChanges();
            return true;
        }
    }
}