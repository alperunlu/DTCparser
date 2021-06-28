using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace DTCparser
{
    public partial class DTCparser : Form
    {
        public DTCparser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hexstring = textBox1.Text.ToString();
            hexstring = hexstring.PadLeft(6, '0');
            textBox1.Text = hexstring;
            string binarystring = String.Join(String.Empty, hexstring.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
            textBox4.Text = binarystring;

            string FMIs = binarystring.Substring(19, 5);
            string SPNs = binarystring.Substring(17, 3) + binarystring.Substring(8, 8) + binarystring.Substring(0, 8);
            textBox2.Text = SPNs;
            textBox3.Text = FMIs;

 
           string FMIhex = Convert.ToInt32(FMIs, 2).ToString("X");
           string SPNhex = Convert.ToInt32(SPNs, 2).ToString("X");
           textBox5.Text = SPNhex;
           textBox6.Text = FMIhex;

           int SPNd = int.Parse(SPNhex, System.Globalization.NumberStyles.HexNumber);
           int FMId = int.Parse(FMIhex, System.Globalization.NumberStyles.HexNumber);
           textBox7.Text = SPNd.ToString();
           textBox8.Text = FMId.ToString();


        }
    }
}
