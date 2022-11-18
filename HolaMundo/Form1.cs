using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Al menos una letra mayúscula
        // Al menos una letra minúscula
        // Al menos un símbolo
        // Al menos un número
        // Al menos 6 caracteres

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtPwd.Text, "^(?=.*\\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\\w\\d\\s:])([^\\s]){6,}$"))
            {                
                if(txtPwdVal.Text == txtPwd.Text )
                {
                    MessageBox.Show("La contraseña ha sido validada");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no son iguales");
                }
            }
            else {
                MessageBox.Show("La contraseña no contiene el formato válido");
            }
        }
       
    }
}

