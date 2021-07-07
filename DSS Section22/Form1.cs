using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS_Section22
{
    public partial class Form1 : Form
    {
        private double best;
        
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d1_s1 = double.Parse(textBox2.Text);
            double d1_s2 = double.Parse(textBox3.Text);
            double d1_s3 = double.Parse(textBox4.Text);
            double d2_s1 = double.Parse(textBox5.Text);
            double d2_s2 = double.Parse(textBox6.Text);
            double d2_s3 = double.Parse(textBox7.Text);
            double d3_s1 = double.Parse(textBox8.Text);
            double d3_s2 = double.Parse(textBox9.Text);
            double d3_s3 = double.Parse(textBox10.Text);
            double s1 = double.Parse(textBox11.Text);
            double s2 = double.Parse(textBox12.Text);
            double s3 = double.Parse(textBox13.Text);

            double EV_under_Risk1 = (d1_s1 * s1) + (d1_s2 * s2) + (d1_s3 * s3);
            double EV_under_Risk2 = (d2_s1 * s1) + (d2_s2 * s2) + (d2_s3 * s3);
            double EV_under_Risk3 = (d3_s1 * s1) + (d3_s2 * s2) + (d3_s3 * s3);
           
            if (EV_under_Risk1 > EV_under_Risk2 && EV_under_Risk1 > EV_under_Risk3)
            {
                MessageBox.Show("The best alternative is " + Convert.ToString(EV_under_Risk1));

                  best = EV_under_Risk1;

            }
            else if (EV_under_Risk2 > EV_under_Risk1 && EV_under_Risk2 > EV_under_Risk3)
            {
                MessageBox.Show("The best alternative is " + Convert.ToString(EV_under_Risk2));
                 best = EV_under_Risk2;
            }
            else
            {
                MessageBox.Show("The best alternative is " + Convert.ToString(EV_under_Risk3));
                  best = EV_under_Risk3;
            }
        }

       
        
        private void button2_Click(object sender, EventArgs e)
        {
            double d1_s1 = double.Parse(textBox2.Text);
            double d1_s2 = double.Parse(textBox3.Text);
            double d1_s3 = double.Parse(textBox4.Text);
            double d2_s1 = double.Parse(textBox5.Text);
            double d2_s2 = double.Parse(textBox6.Text);
            double d2_s3 = double.Parse(textBox7.Text);
            double d3_s1 = double.Parse(textBox8.Text);
            double d3_s2 = double.Parse(textBox9.Text);
            double d3_s3 = double.Parse(textBox10.Text);
            double s1 = double.Parse(textBox11.Text);
            double s2 = double.Parse(textBox12.Text);
            double s3 = double.Parse(textBox13.Text);
            double EV1;
            double EV2;
            double EV3;
            if (d1_s1>d2_s1 && d1_s1 > d3_s1)
            {
                EV1 = d1_s1 * s1;
            }
            else if (d2_s1 > d1_s1 && d2_s2 > d3_s1)
            {
                EV1 = d2_s1 * s1;
            }
            else
            {
                EV1 = d3_s1 * s1;
            }

            if (d1_s2 > d2_s2 && d1_s2 > d3_s2)
            {
                EV2 = d1_s2 * s2;
            }
            else if (d2_s2 > d1_s2 && d2_s2 > d3_s2)
            {
                EV2 = d2_s2 * s2;
            }
            else
            {
                EV2 = d3_s2 * s2;
            }

            if (d1_s3 > d2_s3 && d1_s3 > d3_s3)
            {
                EV3 = d1_s3 * s3;
            }
            else if (d2_s3 > d1_s3 && d2_s3 > d3_s3)
            {
                EV3 = d2_s3 * s3;
            }
            else
            {
                EV3 = d3_s3 * s3;
            }

            double EV_Under_Certainty = EV1 + EV2 + EV3;

            double EVPI = EV_Under_Certainty - best;

            MessageBox.Show("The expected value of perefect information " + EVPI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
