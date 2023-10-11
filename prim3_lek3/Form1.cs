using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prim3_lek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n=Convert.ToInt32(textBox1.Text);
            var a = new Figura3D[n * 3];
            dataGridView1.Rows.Clear();
            for (int i = 0; i < a.Length; i=i+3)
            {
                a[i] = new Figura3D();
                a[i + 1] = new Conus(i+1, (i+1) * 2);
                a[i+2]=new Piramid(i+2, (i+2) * 2);
               
            }
            for (int i = 0; i < a.Length; i++)
            {
                dataGridView1.Rows.Add(a[i].Show(), a[i].S().ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
