using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ardaşık_sayıların_toplamı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //double i=0.5;
        private void button1_Click(object sender, EventArgs e)
        {
           
            double ilk, son, artis;
            double ts,ort,tsp;
             ilk=Convert.ToDouble(textBox1.Text);
             son=Convert.ToDouble(textBox2.Text);
             artis=Convert.ToDouble(textBox3.Text);
             ts = 1+( son - ilk) / artis ;
             ort = (son + ilk) / 2;
             tsp = ts * ort;
            

             
         


            label8.Text = Convert.ToString(ort);
            label7.Text=Convert.ToString(ts);
            //label8.Text=Convert.ToString(ort);
            label9.Text=Convert.ToString(tsp);
        }
    }
}
