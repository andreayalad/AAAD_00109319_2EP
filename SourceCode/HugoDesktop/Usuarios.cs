using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugoDesktop
{
    public partial class Usuarios : UserControl
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (tb_agnombrec.Text.Equals("") ||
               tb_aggnombre.Text.Equals("") ||
               tb_aggadmin.Text.Equals("") ||
               tb_agnombrec.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    DBConnection.ExecutenonQuery($"INSERT INTO APPUSER(fullname, username, userpassword, userType) VALUES(" +
                                  $"'{tb_agnombrec.Text}'," +
                                  $"'{tb_aggnombre.Text}'," +
                                  $"'{tb_aggcon.Text}'," +
                                  $"'{tb_aggadmin.Text}')");
                    MessageBox.Show("Se ha ingresado usuario");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {

            if (tb_eliminar.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    DBConnection.ExecutenonQuery($"DELETE FROM APPUSER WHERE username ='{tb_eliminar.Text}'");
                    MessageBox.Show("Se ha eliminado el usuario");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void b_mostrar_Click(object sender, EventArgs e)
        {
            var dt = DBConnection.ExecuteQuery($"SELECT * FROM APPUSER");

            dataGridView1.DataSource = dt;

            MessageBox.Show("Datos obtenidos exitosamente");
        }
    }
}
