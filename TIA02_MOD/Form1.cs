using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

    

namespace TIA02_MOD
{
    public partial class Form1 : Form
    {
        SerialPort ports = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void portaDeComunicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();

                ports.PortName = form2.comboBox1.Text;
                ports.BaudRate = Convert.ToInt16(form2.comboBox2.Text);
                ports.DataBits = Convert.ToByte(form2.comboBox3.Text);
                ports.Parity = (Parity)Enum.Parse(typeof(Parity), form2.comboBox4.Text);
                ports.StopBits = (StopBits)Enum.Parse(typeof(StopBits), form2.comboBox5.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Introduza Valores de Comunicação");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ports.Close();
            Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ports.Close();
            Close();
        }

        
    }
}
