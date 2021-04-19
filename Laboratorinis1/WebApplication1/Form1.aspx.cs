using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class Form1 : System.Web.UI.Page
    { 
        string Data ="App_data/U3.txt";
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadData(Data);
            LoadData();
        }

        private void ReadData(string data)
        {
            using (StreamReader reader=File.Rea
        }

        private void LoadData()
        {


        }
    }
}