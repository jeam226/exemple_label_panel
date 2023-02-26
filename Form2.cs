using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_label_panel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Show();

            } if (radioButton2.Checked)
            {
                label1.Hide();

            } if (radioButton3.Checked)
            {
                label1.Show();
            }
        }
    }
}
