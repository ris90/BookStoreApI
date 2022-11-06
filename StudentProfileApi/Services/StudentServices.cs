using MongoDB.Driver;
using StudentProfileApi.Models;
using System.Collections.Generic;
using StudentProfileApi.Data;

namespace StudentProfileApi.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IMongoCollection<Student> _studentsCollections;


        public StudentServices(IDbClient dbClient)
        {
            _studentsCollections = dbClient.GetDatabase().GetCollection<Student>("Student");
        }

        public Student CreateStudentProfile(Student addStudent)
        {
            var students = _studentsCollections.AsQueryable();
            var mxRoll = 0;
            foreach (var studentData in students)
            {
                if (mxRoll < studentData.Roll)
                {
                    mxRoll = studentData.Roll;
                }
            }
            addStudent.Roll = mxRoll + 1;
            _studentsCollections.InsertOne(addStudent);
            return addStudent;
        }



        public void DeleteStudentProfile(int roll)
        {
            _studentsCollections.DeleteOne(student => student.Roll == roll);
        }

        public List<Student> GetAllStudentsProfile()
        {
            return _studentsCollections.Find(student => true).ToList();
        }

        public Student GetStudentProfileByRole(int roll)
        {
            return _studentsCollections.Find(student => student.Roll == roll).First();
        }

        public Student UpdateStudentProfile(Student editStudent)
        {
            editStudent.Id = GetStudentProfileByRole(editStudent.Roll).Id;
            _studentsCollections.ReplaceOne(student => student.Roll == editStudent.Roll, editStudent);
            return editStudent;
        }
    }
}
