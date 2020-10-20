using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBasicExercise3
{
    public partial class FormBasicExercise3 : Form
    {
        public FormBasicExercise3()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usuarioTextBox.Text == "usuario" && passwordTextBox.Text == "contraseña")
            {
                MessageBox.Show("Login correcto. Bienvenido " + usuarioTextBox.Text);
            }
            else
            {
                MessageBox.Show("Login o contraseña incorrecta.");
                usuarioTextBox.Text = "";
                passwordTextBox.Text = "";

            }
        }
    }
}
