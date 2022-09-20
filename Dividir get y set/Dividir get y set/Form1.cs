using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dividir_get_y_set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dividirclass divi = new dividirclass();

            divi.N11 = int.Parse(textBox1.Text);
            divi.N21 = int.Parse(textBox2.Text);

         

            textBox3.Text = divi.divicion().ToString();
        }
    }
}
