using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmInicio
{
    public partial class frmShow : Form
    {
        public frmShow(List<string> res)
        {
            InitializeComponent();
            foreach (string i in res)
            {
                textBox1.Text += i + Environment.NewLine;
            }
        }

        private void frmShow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
    }
}
