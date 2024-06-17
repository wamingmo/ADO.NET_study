using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace WebApplication1
{
    public class Stu
    {
        private string _student_no;
        private string _student_name;
        private string _gender;
        private string _faculty;

        public string student_no
        {
            get { return _student_name; }
            set { _student_name = value; }
        }
        public string student_name
        {
            get { return _student_name; }
            set { _student_name = value; }
        }
        public string gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public string faculty
        {
            get { return _faculty; }
            set { _faculty = value; }
        }

        //下面是构造函数
        public Stu(string sno, string sname, string gender, string faculty)
        {
            this.student_no = sno;
            this.student_name = sname;
            this.gender = gender;
            this.faculty = faculty;
        }


        public void Insert()
        {
            string cnnStr = "data source=.;initial catalog=student;integrated security=True;";
            SqlConnection cnn = new SqlConnection(cnnStr);
            string cmdStr = "insert into person(name,gender) values ('" + this.student_name + "','" + this.gender + "')";
            SqlCommand cmd = new SqlCommand(cmdStr, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void Show()
        {
            string cnnStr = "data source=.;initial catalog=student;integrated security=True;";
            SqlConnection cnn = new SqlConnection(cnnStr);
            string cmdStr = "select * from person";
            SqlCommand cmd = new SqlCommand(cmdStr, cnn);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                HttpContext.Current.Response.Write("姓名：" + reader["name"].ToString() + ",性别：" + reader["gender"].ToString() + "</br>");
            }
            cnn.Close();
        }

        public void Delete(string name)
        {
            string cnnStr = "data source=.;initial catalog=student;integrated security=True;";
            SqlConnection cnn = new SqlConnection(cnnStr);
            string cmdStr = "delete from person where name='" + name + "'";
            SqlCommand cmd = new SqlCommand(cmdStr, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


    }
    public class Car
    {
        static public string carName;//静态成员只能由类名调用
        public int speed;
    }

    //声明类时，在类名前面加上static，该类为静态类。静态类要求其内部成员必须都是静态的
    static public class Pet
    {
        static public string petname;
        static public int age;//语句编译时出错，改为：static public int age;
        static public void Bark()//语句编译时出错，改为：static public void Bark();
        { 
       
        }
    }

}
