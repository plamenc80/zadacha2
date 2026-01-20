using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<int> list = textBox1.Text.Trim().Split(' ').Select(int.Parse).ToList();
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.DataBindY(list);
            double sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            double avg = sum / list.Count;
            lable1.Text ="Avg = " + avg.ToString();

            var moda = list.GroupBy(g => g)
                        .OrderByDescending(g => g.Count()).Select(g => g.Key)
                        .First();
                        
            Console.WriteLine(moda);

            label2.Text ="Moda = "+ moda.ToString();


            list .Sort();
            double mediana;
            int n = list.Count;
            if (n % 2 == 0)
            {
                mediana = (list[n / 2 - 1] + list[n / 2]) / 2.0;
            }
            else
            {
                mediana = list[n / 2];
            }
            label3.Text ="Mediana = "+ mediana.ToString();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
