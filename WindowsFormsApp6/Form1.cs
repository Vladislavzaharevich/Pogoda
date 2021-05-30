using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://api.openweathermap.org/data/2.5/find?q=" + "Taganrog" + "&type=like&APPID=bba3286b84833f8d1ba07ec4a814d4b8";
            System.Net.WebRequest reqGET = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = reqGET.GetResponse();
            System.IO.Stream stream = resp.GetResponseStream();
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            string s = sr.ReadToEnd();
            JObject o = JObject.Parse(s);
            JToken b = o["list"][0]["main"]["temp"];
            int tempr = Convert.ToInt32(b);
            tempr = tempr - 273;
            label1.Text = tempr.ToString();

            JToken q = o["list"][0]["main"]["feels_like"];
            int tempr2 = Convert.ToInt32(q);
            tempr2 = tempr2 - 273;
            label2.Text = tempr2.ToString();


            JObject w = JObject.Parse(s);
            JToken t = o["list"][0]["wind"]["speed"];
            double u = Convert.ToDouble(t);
            u = u * 2.237;
            label3.Text = u.ToString();



            JObject degree = JObject.Parse(s);
            JToken k = o["list"][0]["wind"]["deg"];
            int winddegree = Convert.ToInt32(b);
            int Winddegree = Convert.ToInt32(t);
            













        }

      
    }
}
