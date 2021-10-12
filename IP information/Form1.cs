using System;
using Leaf.xNet;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace IP_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Disable your antivirus before you use this application.", "Important", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpRequest request = new HttpRequest();
            string ipAddress = textBox1_IP.Text;
            string response = request.Get("http://ip-api.com/json/" + ipAddress).ToString();

            JObject jsonObject = JObject.Parse(response);

            label_Country.Text = jsonObject.SelectToken("country").ToString();
            label3_Region.Text = jsonObject.SelectToken("regionName").ToString();
            label4_City.Text = jsonObject.SelectToken("city").ToString();
            label5_Zip.Text = jsonObject.SelectToken("zip").ToString();
            label6_ISP.Text = jsonObject.SelectToken("isp").ToString();
            label2_ORG.Text = jsonObject.SelectToken("org").ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tprojects.me");
        }
    }
}
