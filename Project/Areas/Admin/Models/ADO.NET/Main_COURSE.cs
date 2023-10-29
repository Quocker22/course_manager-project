using Project.Models.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project.Areas.Admin.Models.ADO.NET
{
    /*public class Main_COURSE
    {
        public static string constr = "Data Source=DESKTOP-637MHOH\\SQLSEVER;Initial Catalog=QL_COURSE;Integrated Security=True";

        public List<Course> getdata()
        {
            List<Course> ListCourse_MAIN = new List<Course>();
            SqlConnection con = new SqlConnection(constr);
            string sql = "SELECT * FROM COURSE";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Course course = new Course();
                course.MA_COURSE = rdr.GetValue(0).ToString();
                course.NAME_COURSE = rdr.GetValue(1).ToString();
                course.DESCRIPTION_COURSE = rdr.GetValue(2).ToString();
                course.PRICE_COURSE = Convert.ToInt32(rdr.GetValue(3).ToString());
                course.STATUS_COURSE = rdr.GetValue(4).ToString();
                course.THUMBNAIL = rdr.GetValue(5).ToString();
                course.COUNT_LESSON_COURSE = Convert.ToInt32(rdr.GetValue(6).ToString());
                course.CREATED_AT_COURSE = Convert.ToDateTime(rdr.GetValue(7).ToString());
                course.UPDATE_AT_COURSE = Convert.ToDateTime(rdr.GetValue(8).ToString());
                course.LEVEL_COURSE = rdr.GetValue(9).ToString();
                course.TYPE_COURSE = rdr.GetValue(10).ToString();
                ListCourse_MAIN.Add(course);
            }
            return (ListCourse_MAIN);
        }
        
    }
     */
    class CourseList
    {
        public static string constr = "Data Source=DESKTOP-637MHOH\\SQLSEVER;Initial Catalog=QL_COURSE;Integrated Security=True";
        public List<Course> getCourse(string MA_COURSE)
        {
            string sql;
            if (string.IsNullOrEmpty(MA_COURSE))
            {
                sql = "SELECT * FROM Course";
            }
            else
            {
                sql = "SELECT * FROM Course WHERE MA_COURSE = " + MA_COURSE;
            }
            List<Course> listCour = new List<Course>();
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            da.Fill(dt);
            da.Dispose();
            con.Close();
            Course tmpSour;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tmpSour = new Course();
                tmpSour.MA_COURSE = dt.Rows[i]["MA_COURSE"].ToString();
                tmpSour.NAME_COURSE = dt.Rows[i]["NAME_COURSE"].ToString();
                tmpSour.DESCRIPTION_COURSE = dt.Rows[i]["DESCRIPTION_COURSE"].ToString();
                tmpSour.PRICE_COURSE = Convert.ToInt32(dt.Rows[i]["PRICE_COURSE"].ToString());
                tmpSour.STATUS_COURSE = dt.Rows[i]["STATUS_COURSE"].ToString();
                tmpSour.THUMBNAIL = dt.Rows[i]["THUMBNAIL"].ToString();
                tmpSour.COUNT_LESSON_COURSE = Convert.ToInt32(dt.Rows[i]["COUNT_LESSON_COURSE"]);
                tmpSour.CREATED_AT_COURSE = Convert.ToDateTime(dt.Rows[i]["CREATED_AT_COURSE"]);
                tmpSour.UPDATE_AT_COURSE = Convert.ToDateTime(dt.Rows[i]["UPDATE_AT_COURSE"]);
                tmpSour.LEVEL_COURSE = dt.Rows[i]["LEVEL_COURSE"].ToString();
                tmpSour.TYPE_COURSE = dt.Rows[i]["TYPE_COURSE"].ToString();
                listCour.Add(tmpSour);
            }
            return listCour;
        }
        public void addCourseNew(Course cour)
        {
            string sql_add = "INSERT INTO Course VALUES('" + cour.MA_COURSE + "', N'" + cour.NAME_COURSE + "', N'" + cour.DESCRIPTION_COURSE + "'," + cour.PRICE_COURSE + ", N'" + cour.STATUS_COURSE + "', '" + cour.THUMBNAIL + "', " + cour.COUNT_LESSON_COURSE + ", '" + cour.CREATED_AT_COURSE + "','" + cour.UPDATE_AT_COURSE + "', N'" + cour.LEVEL_COURSE + "', N'" + cour.TYPE_COURSE + "')";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql_add, con);
            con.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

    }
}