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
    public partial class Direcciones : UserControl
    {
        private User u;
        public Direcciones(User u)
        {
            this.u = u;
            InitializeComponent();
        }

        private void Direcciones_Load(object sender, EventArgs e)
        {
            var dt = DBConnection.ExecuteQuery($"SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser={u.idUsuario}");
            dataGridView1.DataSource = dt;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (tb_direccion.Text.Equals(""))
            {
                MessageBox.Show("No has ingresado la direccion");
            }
            else
            {
                try
                {
                    DBConnection.ExecutenonQuery("INSERT INTO ADDRESS(idUser, address) " +
                        $"VALUES({u.idUsuario}, '{tb_direccion.Text}')");

                    MessageBox.Show("Se ha ingresado la direccion correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (tb_agnombre.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    DBConnection.ExecutenonQuery($"DELETE FROM ADDRESS WHERE idAddress ='{tb_agnombre.Text}'");
                    MessageBox.Show("Has eliminado la direccion");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR");
                }
            }
        }
    }

}
