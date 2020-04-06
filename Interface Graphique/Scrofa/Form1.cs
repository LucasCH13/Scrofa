using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Scrofa
{
    public partial class Form1 : Form
    {
        string dataIn;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //   String[] ports = SerialPort.GetPortNames();
         //   comboBox_Port.Items.AddRange(ports);
        }

       
        private void comboBox1_Click(object sender, EventArgs e)
        {

            String[] ports = SerialPort.GetPortNames();
         
            comboBox_Port.SelectedText = "    ";
            textBox1.Clear();
            comboBox_Port.Items.Clear();
            comboBox_Port.Items.AddRange(ports);
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (comboBox_Port.Items.Count != 0)
            {
                try
                {

                    serialPort1.PortName = comboBox_Port.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox_Vitesse.Text);
                    serialPort1.ReadTimeout = 1000;
                    serialPort1.WriteTimeout = 1000;

                    serialPort1.Open();
                    progressBar1.Value = 100;
                    int buffer = serialPort1.ReadBufferSize;
                    textBox1.Text = Convert.ToString(buffer);

                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Erreur d'ouverture du Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;

            }


        }

        private void button_Lire_Click(object sender, EventArgs e)

        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    dataIn = serialPort1.ReadLine();
                    textBox1.Text = dataIn;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Erreur de lecture du Port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {

           DialogResult Result = MessageBox.Show("etes vous sur de vouloir quitter ? ", "Attention !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            

            if(Result == DialogResult.Yes)
            {

                Application.Exit();
            }
            

        }
    }

}
