using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Modbus.Device;



namespace TIA02_MOD
{
    

   
    public partial class Form1 : Form
    {
        SerialPort ports = new SerialPort();

        public static class valores
        {
            public static float valor1;

        }

        
        

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            
        }

        private void portaDeComunicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                Form2 form2 = new Form2();
                form2.ShowDialog();
            try
            {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            ports.Open();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(ports);

            if (ports.IsOpen)
            {
                ushort[] holding_register = master.ReadHoldingRegisters(1, 0, 1);

                float valor = Convert.ToSingle(holding_register[0]);

                valores.valor1 = valor;
            }
                       
        }
    }
}
