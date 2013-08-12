using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace frmInicio
{
    class clsGuardar
    {
        public void guardar(string path, List<string> res)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("--DB Generate data random");
                sw.WriteLine("-->diseñado y programado por: Santiago Nahuel Córdoba santi8ago8@gmail.com");
                foreach (string i in res)
                {
                    sw.WriteLine(i);
                }
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
