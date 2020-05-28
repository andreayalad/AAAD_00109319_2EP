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
    public partial class Productos : UserControl
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (tb_agnombre.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    int idBusiness = Convert.ToInt32(
                            DBConnection.ExecuteQuery("SELECT * FROM BUSINEES WHERE " +
                        $"business_name = '{tb_aggcont.Text}'").Rows[0][0].ToString()
                        );

                    DBConnection.ExecutenonQuery($"INSERT INTO PRODUCT(idBusiness, product_name) VALUES(" +
                                  $"{idBusiness}," +
                                  $"'{tb_agnombre.Text}')");

                    MessageBox.Show("Se ha ingresado producto");

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
                    DBConnection.ExecutenonQuery($"DELETE FROM PRODUCT WHERE product_name ='{tb_eliminar.Text}'");
                    MessageBox.Show("Se ha eliminado el producto");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR, no se ha podido eliminar el producto");
                }
            }
        }
    }
}
