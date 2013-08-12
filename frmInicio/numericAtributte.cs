using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmInicio
{
    public partial class numericAtributte : UserControl,IAttributte
    {
        public numericAtributte()
        {
            InitializeComponent();
        }
        public numericAtributte(string name)
            :this()
        {
            Text = name;
        }
        public numericAtributte(string name, bool key)
        :this(name)
        {
            Key = key;
        }

        public bool Key
        {
            get { return checkBox1.Checked; }
            set { this.checkBox1.Checked = value; }
        }

        public override string Text
        {
            get { return label1.Text; }
            set { this.label1.Text = value; }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value>numericUpDown2.Value)
                numericUpDown2.Value=numericUpDown1.Value+1;
            if (numericUpDown2.Value < numericUpDown1.Value)
                numericUpDown1.Value = numericUpDown2.Value > 0 ? numericUpDown2.Value : 0;
            desde = (int)numericUpDown1.Value;
        }

        public int Count
        {
            get { return (int)(numericUpDown2.Value - numericUpDown1.Value); }
        }

        int desde=0;
        Random rnd = new Random();
        Stack<int> usados = new Stack<int>();
        public object generate()
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                    return desde++;
                else
                {
                    int ind;
                    do
                    {
                        ind = rnd.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                    }
                    while (usados.Contains(ind));
                    usados.Push(ind);
                    return ind;
                }
            }
            else
            {
                int ind = rnd.Next((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                return ind;
            }        
        }



        public string attPos
        {
            get { return label4.Text; }
            set { this.label4.Text = "@att" + value; }
        }

        internal void resetStack()
        {
            usados.Clear();
        }
    }
}
