using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculosueldo
{
    public partial class Form1_calculo_sueldo : Form
    {
        public Form1_calculo_sueldo()
        {
            InitializeComponent();

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double horas_trabajadas;//variable que guardara las horas trabajadas
            double pagos;//variable que guardara el pago por hora
            double sueldo;//variebale que guardar el sueldo (pago*horas trabajadas)
            horas_trabajadas= double.Parse(txt_hrt.Text);//se obtiene las horas trabajadas
            pagos = double.Parse(txt_phr.Text);//se obtiene el valor de pagos por hora
            sueldo = (horas_trabajadas * pagos);//calculo del sueldo
            txt_sueldo.Text = sueldo.ToString();//se muestra el valor calculado

        }
        
    }
}
