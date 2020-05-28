using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoDesktop
{
    public partial class Form1 : Form
    {
        private User u;
        public Form1()
        {
            InitializeComponent();
        }

        private void b_ingresar_Click(object sender, EventArgs e)
        {
            if (tb_nombre.Text.Equals(""))
            {
                MessageBox.Show("NO PUEDES DEJAR ESPACIOS VACIOS");
            }
            else
            {
                try
                {
                    var dt = DBConnection.ExecuteQuery("SELECT * FROM APPUSER" +
                        $" WHERE username = '{tb_nombre.Text}' AND userpassword = '{tb_password.Text}'");

                    if (dt.Rows.Count > 0)
                    {

                        var dataUsuario = dt.Rows[0];

                        u = new User(dataUsuario[0].ToString(), dataUsuario[2].ToString(),
                            Convert.ToBoolean(dataUsuario[4].ToString()));

                        Hide();
                        if (u.admin)
                        {
                            Admin ventanaPrincipal = new Admin(u);
                            ventanaPrincipal.Show();
                        }
                        else
                        {
                            Normal ventanaPrincipal = new Normal(u);
                            ventanaPrincipal.Show();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Datos incorrectos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}
