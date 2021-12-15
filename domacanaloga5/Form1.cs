using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domacanaloga5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int st1, st2, st3, sum;

            if (String.IsNullOrEmpty(textBox1.Text)) { MessageBox.Show("Polje 1 ne sme biti prazno!"); return; }
            if (String.IsNullOrEmpty(textBox2.Text)) { MessageBox.Show("Polje 2 ne sme biti prazno!"); return; }
            if (String.IsNullOrEmpty(textBox3.Text)) { MessageBox.Show("Polje 3 ne sme biti prazno!"); return; }

            int parsedValue;
            if (!int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("V polje 1 vnesi samo stevilko!");
                return;
            }
            if (!int.TryParse(textBox2.Text, out parsedValue))
            {
                MessageBox.Show("V polje 2 vnesi samo stevilko!");
                return;
            }
            if (!int.TryParse(textBox3.Text, out parsedValue))
            {
                MessageBox.Show("V polje 3 vnesi samo stevilko!");
                return;
            }

            st1 = Convert.ToInt32(textBox1.Text);
            st2 = Convert.ToInt32(textBox2.Text);
            st3 = Convert.ToInt32(textBox3.Text);

            sum = st1 + st2 + st3;
            label2.Text = Convert.ToString(sum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
