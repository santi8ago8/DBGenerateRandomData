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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            cbTipo.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != string.Empty)
            {
                if (cbTipo.SelectedIndex==1)
                {
                    atributo att = new atributo(tbNombre.Text, checkbKey.Checked);
                  //att.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
                    att.Show();
                    flowLayoutPanel1.Controls.Add(att);
                }
                if (cbTipo.SelectedIndex == 0)
                {
                    numericAtributte att = new numericAtributte(tbNombre.Text, checkbKey.Checked);
                    att.Show();
                    flowLayoutPanel1.Controls.Add(att);

                }
                tbNombre.Text = string.Empty;
                checkbKey.Checked = false;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != string.Empty)
            {
                int pos = -1;
                for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
                {
                    if (flowLayoutPanel1.Controls[i].Text == tbNombre.Text)
                        pos = i;
                }
                if (pos != -1)
                    flowLayoutPanel1.Controls.RemoveAt(pos);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int max=cantMax();
            reset();
            if (nudCant.Value > max)
            {
                MessageBox.Show("No se puede generar la cantidad pedida, se generan " + max + " valores random");
                nudCant.Value = max;
            }
            if (tbTableName.Text != string.Empty)
            {

                List<string> res=generar();
                new frmShow(res).ShowDialog();
            }
        }

        private void reset()
        {
            foreach (Control i in flowLayoutPanel1.Controls)
            {
                if (i is numericAtributte)
                    (i as numericAtributte).resetStack();
            }
        }

        private List<string> generar()
        {
            List<string> res = new List<string>();
            string[] lines;
            do
            {
                lines = mostrarfrmAtributos();
            }
            while (!isCorrectLines(lines));
            for (int j = 0; j < nudCant.Value; j++)
            {
                res.AddRange(generarLinea(lines));

            }
            return res;
        }

        private string[] generarLinea(string[] lines)
        {
            //throw new NotImplementedException();
            List<string> lineas=new List<string>();
            foreach (string line in lines)
            {
                if (line.Contains("@att"))
                {
                    lineas.Add(reemplazar(line));
                }
                else
                {
                    lineas.Add(line);
                }
            }

            return lineas.ToArray();

        }

        private string reemplazar(string line)
        {
            for (int i=0;i<line.Length;i++)
            {
                if (line.IndexOf("@att", i) != -1)
                {
                    int pos = getNumerAttribute(line, i);
                    line = line.Replace("@att" + pos.ToString(),
                        (flowLayoutPanel1.Controls[pos] as IAttributte).generate().ToString());
                }
            }
            return line;
        }

        private int getNumerAttribute(string line, int index)
        {
            if (index == -1)
            {
                return -1;
            }
            int ind = line.IndexOf("@att", index);
            ind += 4;
            string aux = string.Empty;
            do
            {
                aux += line[ind].ToString();
                ind++;
            }
            while (line[ind] != '\''
                && line[ind] != ','
                && line[ind] != ')'
                && line[ind] != ' '
                && line[ind] != '-'
                && line[ind] != '_'
                && line[ind] != '.');
            return Convert.ToInt32(aux);
        }

        private bool isCorrectLines(string[] lines)
        {
            bool res=true;;
            foreach (string i in lines)
            {
                if (i != string.Empty)
                {
                    int pos = 0;
                    if (i.Contains("@att"))
                    {
                        do
                        {
                            int numero=getNumerAttribute(i, i.IndexOf("@att", pos));
                            pos=i.IndexOf("@att", pos);
                            pos += 1;
                            if (numero >= flowLayoutPanel1.Controls.Count)
                                res = false;
                        }
                        while (i.IndexOf("@att", pos) != -1);
                    }
                }
            }
            return res;
        }

        private string[] mostrarfrmAtributos()
        {
            List<string> lines = new List<string>();
            lines.Add("INSERT INTO " + tbTableName.Text);
            string aux = "VALUES (";
            foreach (Control i in flowLayoutPanel1.Controls)
            {
                if (i is numericAtributte)
                    aux += (i as IAttributte).attPos;
                else if (i is atributo)
                {
                    if ((i as atributo).sinCOM)
                        aux += (i as atributo).attPos;
                    else
                        aux += "'" + (i as atributo).attPos + "'";
                }

                if (flowLayoutPanel1.Controls.IndexOf(i) != flowLayoutPanel1.Controls.Count-1)
                    aux += ",";
            }
            aux += ")";
            lines.Add(aux);
            frmAtributos att = new frmAtributos(lines);
            att.ShowDialog();
            return att.Lines.ToArray<string>();
        }

        private int cantMax()
        {
            int max = int.MaxValue;
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                if (flowLayoutPanel1.Controls[i] is atributo)
                {
                    if ((flowLayoutPanel1.Controls[i] as atributo).Count < max &&
                        (flowLayoutPanel1.Controls[i] as atributo).Key)
                        max = (flowLayoutPanel1.Controls[i] as atributo).Count;
                }
                else if (flowLayoutPanel1.Controls[i] is numericAtributte)
                {
                    if ((flowLayoutPanel1.Controls[i] as numericAtributte).Count < max &&
                          (flowLayoutPanel1.Controls[i] as numericAtributte).Key)
                        max = (flowLayoutPanel1.Controls[i] as numericAtributte).Count;
                }
            }
            return max;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int max = cantMax();
            reset();
            if (nudCant.Value > max)
            {
                MessageBox.Show("No se puede generar la cantidad pedida, se generan " + max + " valores random");
                nudCant.Value = max;
            }
            if (tbTableName.Text != string.Empty)
            {
                List<string> res = generar();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    new clsGuardar().guardar(saveFileDialog1.FileName, res);
                    MessageBox.Show("Guardado en: " + saveFileDialog1.FileName, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void flowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                (flowLayoutPanel1.Controls[i] as IAttributte).attPos = i.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
