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
    public partial class VerOrdenes : UserControl
    {
        public VerOrdenes()
        {
            InitializeComponent();
        }

        private void b_mostrar_Click(object sender, EventArgs e)
        {
            var dt = DBConnection.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.product_name, au.fullname, ad.address " +
                $" FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                $" WHERE ao.idProduct = pr.idProduct AND ao.idAddress = ad.idAddress AND ad.idUser = au.idUser");
            dataGridView1.DataSource = dt;
        }
    }
}
