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
    public partial class frmAtributos : Form
    {
        public frmAtributos(List<string> lines)
        {
            InitializeComponent();
            this.lines = lines;
            foreach (string i in this.lines)
            {
                textBox1.Text += i + Environment.NewLine;
            }
            textBox1.Text += "---------- ->Separador SNC<- ----------";
        }
        List<string> lines;

        public List<string> Lines
        {
            get
            {
                UpdateText();
                return lines;
            }
        }

        private void UpdateText()
        {
            lines.Clear();
            foreach (string i in textBox1.Lines)
            {
                lines.Add(i);
            }
        }
    }
}
