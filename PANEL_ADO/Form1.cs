using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PANEL_ADO
{
    public partial class Form1 : Form
    {
        Class1 cn = new Class1();
        public Form1()
        {
            InitializeComponent();
           
        }
        

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            bool sw;
            Class1 cn = new Class1();
            string user = txt_user.Text;
            string pass = txt_pss.Text;
            sw = cn.validar(user, pass);
            if (sw is true)
            {
                MessageBox.Show("Conexion con datos ingresados exitosamente");

                cmb_empresas.Items.Add("hola");
            }
            else MessageBox.Show("Conexion sin exito");
        }
    }
  
 
 }
