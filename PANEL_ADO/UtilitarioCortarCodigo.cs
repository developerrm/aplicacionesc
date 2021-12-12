using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PANEL_ADO
{
    public partial class UtilitarioCortarCodigo : Form
    {
        public UtilitarioCortarCodigo()
        {
            InitializeComponent();
        }

        private void bntGenerar_Click(object sender, EventArgs e)
        {
            var entrada = EntradaText.Text.Trim();
            var salida = "";
            var tmp  = "";
            char[] b = new char[entrada.Length];
            SalidaText.Clear();
            string path = @"C:\Users\ROGER-PC1\Downloads\MENU.txt";
            if (File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    using (StringReader sr = new StringReader(entrada.ToString()))
                    {
                        // Read 13 characters from the string into the array.
                        sr.Read(b, 0, entrada.Length);

                        for (int i = 0; i < b.Length; i++)
                        {
                            tmp = tmp + b[i].ToString();
                            if (tmp.ToUpper().Contains("CASE"))
                            {
                                salida = salida + "case" + "\t";
                                tmp = "";
                            }
                            if (("1,2,3,4,5,6,7,8,9,0").Contains(b[i]))
                            {
                                salida = salida + b[i].ToString();
                                tmp = "";
                            }
                            if (tmp.Contains("new"))
                            {
                                tmp = "";
                                for (int j = i + 1; j < b.Length; j++)
                                {
                                    tmp = tmp + b[j].ToString();
                                    if (tmp.Contains("."))
                                    {
                                        salida = salida + "\t" + tmp.ToString();
                                        i = j;
                                        break;
                                    }
                                }

                                for (int k = i; k < b.Length; k++)
                                {
                                    tmp = tmp + b[k].ToString();
                                    if (tmp.ToUpper().Contains("BREAK;"))
                                    {
                                        salida = salida + "\n";
                                        tmp = "";
                                        i = k;
                                        break;
                                    }

                                }
                            }
                        }

                    }
                    sw.WriteLine(salida);
                    
                }
            }
            
        }
    }
}
