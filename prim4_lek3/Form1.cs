using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prim4_lek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = Convert.ToInt32(textBox1.Text);
            var a = new Figura3D[n * 2];
            dataGridView1.Rows.Clear();
            for (int i = 0; i < a.Length; i = i + 2)
            {
                a[i] = new Conus(i + 1, (i + 1) * 2);
                a[i + 1] = new Piramid(i + 2, (i + 2) * 2);

            }
            var maxS = 0.0;
            for (int i = 0; i < a.Length; i++)
            {
                dataGridView1.Rows.Add(a[i].Show(), a[i].S().ToString());
                if (a[i].S()>maxS)
                {
                    maxS = a[i].S();
                }
            }
            label2.Text = maxS.ToString();
        }
    }
}
