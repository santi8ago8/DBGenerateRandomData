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
    public partial class atributo : UserControl, IAttributte
    {
        public atributo()
        {
            InitializeComponent();
        }

        public atributo(string name)
            : this()
        {
            this.label1.Text = name;
        }

        public atributo(string name, bool isKey)
            : this(name)
        {
            this.checkBox1.Checked = isKey;
        }

        public bool sinCOM
        {
            get { return checkBox2.Checked; }
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string i in textBox1.Lines)
            {
                if (!string.IsNullOrEmpty(i) && !string.IsNullOrWhiteSpace(i))
                    listBox1.Items.Add(i);
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object[] aux = new object[listBox1.SelectedItems.Count];
            listBox1.SelectedItems.CopyTo(aux, 0);
            foreach (object i in aux)
            {
                listBox1.Items.Remove(i);
            }
        }

        public int Count
        {
            get { return listBox1.Items.Count; }
        }

        public string this[int i]
        {
            get { return listBox1.Items[i].ToString(); }

        }

        public void remove(int pos)
        {
            // string res=listBox1.Items[pos].ToString();
            listBox1.Items.RemoveAt(pos);
            //  return res;
        }

        Random rnd = new Random();
        public object generate()
        {
            int count = listBox1.Items.Count - 1;
            if (count == -1)
                count = 0;
            int ind = rnd.Next(0, count);

            if (checkBox1.Checked)
            {
                object aux = listBox1.Items[ind];
                remove(ind);
                return aux;
            }
            else
            {
                object aux = listBox1.Items[ind];
                return aux;
            }
        }

        public string attPos
        {
            get { return label2.Text; }
            set { this.label2.Text = "@att" + value; }
        }
    }
}
    

