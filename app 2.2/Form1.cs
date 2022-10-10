using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSentence.Text = Properties.Settings.Default.sentence.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
    }
    public class Logic
        {
        
        }
    
    }
}
