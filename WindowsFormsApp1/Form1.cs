using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Bonjour {0} {1} vous avez {2:0.00} ans",txtPrenom.Text,txtNom.Text, tool.CalcAge(dtNaissance.Value)));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( sender.ToString());
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form2 f = new Form2())
            {
                f.ShowDialog();
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form3 f = new Form3())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    lblTel.Text = f.Controls["textBox1"].Text + " " + f.Controls["textBox2"].Text + " " 
                        + f.Controls["textBox3"].Text + " " + f.Controls["textBox4"].Text + " " + f.Controls["textBox5"].Text;
                }
            }
        }

        private void cmdColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ActiveForm.BackColor = colorDialog1.Color;
            }
        }
    }
}

public abstract class tool
{
    public static double CalcAge(DateTime DateNaiss)
    {
        return ((DateTime.Now - DateNaiss).Days / 365.242189);
    }
}