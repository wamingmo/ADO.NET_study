using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

//data source=.;initial catalog=student;integrated security=True;
//SqlConnection cnn = new SqlConnection("server=.;database=student;uid=sa;pwd=3500");

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Stu s1 = new Stu(); 


        }
    }
}