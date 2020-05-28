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
    public partial class Ordenes : UserControl
    {
        private User u;
        public Ordenes(User u)
        {
            this.u = u;
            InitializeComponent();
        }


        private void Ordenes_Load(object sender, EventArgs e)
        {
            var dt = DBConnection.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.product_name, au.fullname, ad.address " +
                $" FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                $" WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = '{u.idUsuario}'");
            dataGridView1.DataSource = dt;
        }

        
  

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            if (tb_producto.Text.Equals("")||tb_direccion.Text.Equals(""))
            {
                MessageBox.Show("No has ingresado datos completos");
            }
            else
            {
                try
                {

                    DateTime fecha = DateTime.Now;

                    int idProducto = Convert.ToInt32(
                            DBConnection.ExecuteQuery("SELECT * FROM PRODUCT WHERE " +
                        $"product_name = '{tb_producto.Text}'").Rows[0][0].ToString());

                    DBConnection.ExecutenonQuery("INSERT INTO APPORDER(idProduct, idAddress, createDate) " +
                        $" VALUES({idProducto},{tb_direccion.Text}, '{fecha.ToString("mm/dd/yyyy")}')");

                    MessageBox.Show("Tu pedido se ha realizado correctamente");

                    var dt = DBConnection.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.product_name, au.fullname, ad.address " +
                    $" FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                    $" WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = '{u.idUsuario}'");
                    dataGridView1.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (tb_orden.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    DBConnection.ExecutenonQuery($"DELETE FROM APPORDER WHERE idOrder ='{tb_orden.Text}'");
                    MessageBox.Show("Has eliminado la orden");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR");
                }
            }
        }
    }
}
  

