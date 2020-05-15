using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrofa
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        
        /*
         * Choisir la section 
         */
        private void comboBox_section_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox_section.SelectedIndex)
            {
                case 0:
                    Hide();
                    //101. Module SYSTEM : Paramètres standards
                    Form2 f = new Form2();
                    f.Show();
                    break;
                case 1:
                    Hide();
                    //201. Module Capteur GPS 
                    Form7 f7 = new Form7();
                    f7.Show();
                    break;
                case 2:
                    Hide();
                    //202. Module capteur alerte mortalité (GPS & Accéléromètre)
                    Form3 f3 = new Form3();
                    f3.Show();
                    break;
                case 3:
                    Hide();
                    //203. Module capteur drop-off 
                    Form5 f5 = new Form5();
                    f5.Show();
                    break;
                case 4:
                    Hide();
                    //301. Module Transmission
                    Form6 f6 = new Form6();
                    f6.Show();
                    break;
                case 5:
                    Hide();
                    Form4 f4 = new Form4();
                    f4.Show();
                    break;
            }
        }
        /*
         * Choisir le port de la carte arduino
         */
        private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();

            comboBox_1.SelectedText = "    ";
            comboBox_1.Items.Clear();
            comboBox_1.Items.AddRange(ports);
        }
    }
}
