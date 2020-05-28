namespace HugoDesktop
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b_users = new System.Windows.Forms.Button();
            this.b_negocios = new System.Windows.Forms.Button();
            this.b_productos = new System.Windows.Forms.Button();
            this.b_ordenes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.b_users, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_negocios, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_productos, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_ordenes, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.01518F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.98482F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // b_users
            // 
            this.b_users.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_users.BackColor = System.Drawing.Color.Indigo;
            this.b_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_users.Font = new System.Drawing.Font("Coolvetica Rg", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_users.ForeColor = System.Drawing.Color.White;
            this.b_users.Location = new System.Drawing.Point(3, 3);
            this.b_users.Name = "b_users";
            this.b_users.Size = new System.Drawing.Size(212, 53);
            this.b_users.TabIndex = 0;
            this.b_users.Text = "USUARIOS";
            this.b_users.UseVisualStyleBackColor = false;
            this.b_users.Click += new System.EventHandler(this.b_users_Click);
            // 
            // b_negocios
            // 
            this.b_negocios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_negocios.BackColor = System.Drawing.Color.Indigo;
            this.b_negocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_negocios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_negocios.Font = new System.Drawing.Font("Coolvetica Rg", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_negocios.ForeColor = System.Drawing.Color.White;
            this.b_negocios.Location = new System.Drawing.Point(221, 3);
            this.b_negocios.Name = "b_negocios";
            this.b_negocios.Size = new System.Drawing.Size(212, 53);
            this.b_negocios.TabIndex = 4;
            this.b_negocios.Text = "NEGOCIOS";
            this.b_negocios.UseVisualStyleBackColor = false;
            this.b_negocios.Click += new System.EventHandler(this.b_negocios_Click);
            // 
            // b_productos
            // 
            this.b_productos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_productos.BackColor = System.Drawing.Color.Indigo;
            this.b_productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_productos.Font = new System.Drawing.Font("Coolvetica Rg", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_productos.ForeColor = System.Drawing.Color.White;
            this.b_productos.Location = new System.Drawing.Point(439, 3);
            this.b_productos.Name = "b_productos";
            this.b_productos.Size = new System.Drawing.Size(212, 53);
            this.b_productos.TabIndex = 5;
            this.b_productos.Text = "PRODUCTOS";
            this.b_productos.UseVisualStyleBackColor = false;
            this.b_productos.Click += new System.EventHandler(this.b_productos_Click);
            // 
            // b_ordenes
            // 
            this.b_ordenes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_ordenes.BackColor = System.Drawing.Color.Indigo;
            this.b_ordenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_ordenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ordenes.Font = new System.Drawing.Font("Coolvetica Rg", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ordenes.ForeColor = System.Drawing.Color.White;
            this.b_ordenes.Location = new System.Drawing.Point(657, 3);
            this.b_ordenes.Name = "b_ordenes";
            this.b_ordenes.Size = new System.Drawing.Size(215, 53);
            this.b_ordenes.TabIndex = 6;
            this.b_ordenes.Text = "ORDENES";
            this.b_ordenes.UseVisualStyleBackColor = false;
            this.b_ordenes.Click += new System.EventHandler(this.b_ordenes_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b_users;
        private System.Windows.Forms.Button b_negocios;
        private System.Windows.Forms.Button b_productos;
        private System.Windows.Forms.Button b_ordenes;
    }
}