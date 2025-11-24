using dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentBLL
    {
        StudentDAL dal = new StudentDAL();
        public List<Student> GetAllStudents() 
        {
           return dal.GetAllStudents();
        }
        public bool InsertStudent(Student stu)
        {
            return dal.InsertStudent(stu) > 0;

        }
        public bool SelectCount(string stuNum)
        {
            return dal.SelectCount(stuNum) > 0;
        }
        public bool DeleteStudent(int id)
        {
            return dal.DeleteStudent(id) > 0;
        }
        public bool UpdateStudent(Student stu)
        {
            return dal.UpdateStudent(stu) > 0;
        }
        public Student SelectStudent(int id)
        {
            return dal.SelectStudent(id);
        }
    }
}
