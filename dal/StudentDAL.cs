using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DAL;
using Model;
namespace dal
{
    public class StudentDAL
    {
        public List<Student> GetAllStudents() {
            string sql = "select * from student";
            List<Student> studentlist = new List<Student>();
            using (SqlDataReader dr = SqlHelper.ExecuteReader(sql)) {
                if (dr.HasRows) { 
                 while (dr.Read())
                    {
                        Student stu = new Student();
                        stu.ID = dr.GetInt32(0);
                        stu.Num = dr.GetString(1);
                        stu.Name = dr.GetString(2);
                        stu.Sex = Convert.IsDBNull(dr[3]) ? null : dr.GetString(3);
                        stu.Age= Convert.IsDBNull(dr[4]) ? null : (int?)dr.GetInt32(4);
                        stu.Class = dr.GetString(5);
                        stu.Speciality = dr.GetString(6);
                        stu.Phone = Convert.IsDBNull(dr[7]) ? null : dr.GetString(7);
                        studentlist.Add(stu);
                    }
                
                }
            
            }
            return studentlist;
        }
        public int InsertStudent(Student stu) {
            string sql = "insert into student values(@stunum,@stuname,@stusex,@stuage,@stuClass,@stuSpeciality,@stuphone)";
            SqlParameter[] pm = new SqlParameter[]
            {
                new SqlParameter("stunum",stu.Num),
                new SqlParameter("stuname",stu.Name),
                new SqlParameter("stusex",stu.Sex),
                new SqlParameter("stuage",stu.Age==null?DBNull.Value:(object)stu.Age),
                new SqlParameter("stuClass",stu.Class),
                new SqlParameter("stuSpeciality",stu.Speciality),
                new SqlParameter("stuphone",stu.Phone),
            };
            int count = SqlHelper.ExecuteNonQuery(sql, pm);
            return count;
        }
        public int SelectCount(string Stunum)
        {
            string sql = "select count(*) from student where Num=@stunum";
            SqlParameter pm = new SqlParameter("@stunum", Stunum);
            int count = Convert.ToInt32(SqlHelper.ExecuteScalar(sql, pm));
            return count;
        }

        public int DeleteStudent(int ID)
        {
            string sql = "delete from student where ID=@ID";
            SqlParameter pm = new SqlParameter("@ID", ID);
            return SqlHelper.ExecuteNonQuery(sql, pm);
        }

        public int UpdateStudent(Student stu)
        {
            string sql = "update student set Num=@stunum,Name=@stuname,Sex=@stusex,Age=@stuage,Class=@stuClass,Speciality=@stuSpeciality,Phone=@stuphone where ID=@ID";
            SqlParameter[] pm = new SqlParameter[]
            {
                new SqlParameter("@stunum",stu.Num),
                new SqlParameter("@stuname",stu.Name),
                new SqlParameter("@stusex",stu.Sex),
                new SqlParameter("@stuage",stu.Age==null?DBNull.Value:(object)stu.Age),
                new SqlParameter("@stuClass",stu.Class),
                new SqlParameter("@stuSpeciality",stu.Speciality),
                new SqlParameter("@stuphone",stu.Phone),
                new SqlParameter("@ID",stu.ID),
            };
            return SqlHelper.ExecuteNonQuery(sql, pm);
        }

        public Student SelectStudent(int ID)
        {
            string sql = "select * from student where ID=@ID";
            SqlParameter pm = new SqlParameter("@ID", ID);
            SqlDataReader dr = SqlHelper.ExecuteReader(sql, pm);
            Student stu = new Student();
            if (dr.Read())
            {
                stu.ID = dr.GetInt32(0);
                stu.Num = dr.GetString(1);
                stu.Name = dr.GetString(2);
                stu.Sex = dr.GetString(3);
                stu.Age = Convert.IsDBNull(dr[4]) ? null : (int?)dr.GetInt32(4);
                stu.Class = dr.GetString(5);
                stu.Speciality = dr.GetString(6);
                stu.Phone = dr.GetString(7);
            }
            return stu;
        }

    }
}
