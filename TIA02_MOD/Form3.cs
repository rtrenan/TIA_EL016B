using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIA02_MOD
{
    public partial class Form3 : Form
    {
       

        public Form3()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Form1.valores.valor1);
        }
    }
}
