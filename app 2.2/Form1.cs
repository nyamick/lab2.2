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
            string sentence;
            try
            {
                sentence = (this.txtSentence.Text);
            }
            catch (FormatException)
            {
                return;
            }
            Properties.Settings.Default.sentence = sentence;
            Properties.Settings.Default.Save();
            var average = Logic.Reverse(sentence);
            MessageBox.Show("Результат: " + average.ToString());
        }
    }
    public class Logic
    {
        public static string Reverse(string sentence)

        {
            string[] words = sentence.Split();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = new string(words[i].Reverse().ToArray());
            }
            return string.Join(" ", words);
        }
    }
}
