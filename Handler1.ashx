using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace {
    public void ProcessRequest(HttpContext context)            {                context.Response.ContentType = "text/plain";                SqlConnection cnn = new SqlConnection("server=.;database=students;uid=sa;pwd=3500");                SqlDataAdapter adapter1 = new SqlDataAdapter("select * from student", cnn);                DataTable dt = new DataTable();                adapter1.Fill(dt);                 string jsonString = JsonConvert.SerializeObject(dt);                context.Response.Write(jsonString);    }}