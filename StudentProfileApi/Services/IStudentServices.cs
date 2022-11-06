using System.Collections.Generic;
using StudentProfileApi.Models;

namespace StudentProfileApi.Services
{
    public interface IStudentServices
    {
        List<Student> GetAllStudentsProfile();
        Student GetStudentProfileByRole(int role);
        Student CreateStudentProfile(Student addStudent);
        Student UpdateStudentProfile(Student editStudent);
        void DeleteStudentProfile(int role);
    }
}
