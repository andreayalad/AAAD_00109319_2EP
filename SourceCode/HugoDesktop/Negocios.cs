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
    public partial class Negocios : UserControl
    {
        public Negocios()
        {
            InitializeComponent();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (tb_agnombre.Text.Equals("") ||
               tb_aggdesc.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    DBConnection.ExecutenonQuery($"INSERT INTO BUSINEES(business_name, description) VALUES(" +
                                  $"'{tb_agnombre.Text}'," +
                                  $"'{tb_aggdesc.Text}')");
                                 
                    MessageBox.Show("Se ha ingresado un nuevo negocio:)");

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
                       DBConnection.ExecutenonQuery($"DELETE FROM BUSINEES WHERE business_name ='{tb_eliminar.Text}'");
                    MessageBox.Show("Se ha eliminado el negocio");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
    }
}
