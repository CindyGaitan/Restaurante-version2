namespace Hoteleria
{
    partial class Agregar_bebidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_bebidas));
            this.txt_cantBebida = new System.Windows.Forms.TextBox();
            this.cmb_bebida = new System.Windows.Forms.ComboBox();
            this.lbl_cantidadBebida = new System.Windows.Forms.Label();
            this.lbl_bebida = new System.Windows.Forms.Label();
            this.Pnl_botones = new System.Windows.Forms.Panel();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.Lbl_borrar = new System.Windows.Forms.Label();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_agregarBebida = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mesaPedido = new System.Windows.Forms.TextBox();
            this.txt_fechaPedido = new System.Windows.Forms.TextBox();
            this.txt_clientePedido = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_noPedido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_botones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agregarBebida)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cantBebida
            // 
            this.txt_cantBebida.Location = new System.Drawing.Point(159, 79);
            this.txt_cantBebida.Name = "txt_cantBebida";
            this.txt_cantBebida.Size = new System.Drawing.Size(89, 20);
            this.txt_cantBebida.TabIndex = 29;
            // 
            // cmb_bebida
            // 
            this.cmb_bebida.FormattingEnabled = true;
            this.cmb_bebida.Location = new System.Drawing.Point(159, 52);
            this.cmb_bebida.Name = "cmb_bebida";
            this.cmb_bebida.Size = new System.Drawing.Size(172, 21);
            this.cmb_bebida.TabIndex = 28;
            // 
            // lbl_cantidadBebida
            // 
            this.lbl_cantidadBebida.AutoSize = true;
            this.lbl_cantidadBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadBebida.Location = new System.Drawing.Point(18, 79);
            this.lbl_cantidadBebida.Name = "lbl_cantidadBebida";
            this.lbl_cantidadBebida.Size = new System.Drawing.Size(135, 16);
            this.lbl_cantidadBebida.TabIndex = 27;
            this.lbl_cantidadBebida.Text = "Cantidad de Bebidas";
            // 
            // lbl_bebida
            // 
            this.lbl_bebida.AutoSize = true;
            this.lbl_bebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bebida.Location = new System.Drawing.Point(18, 52);
            this.lbl_bebida.Name = "lbl_bebida";
            this.lbl_bebida.Size = new System.Drawing.Size(52, 16);
            this.lbl_bebida.TabIndex = 26;
            this.lbl_bebida.Text = "Bebida";
            // 
            // Pnl_botones
            // 
            this.Pnl_botones.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Pnl_botones.Controls.Add(this.btn_borrar);
            this.Pnl_botones.Controls.Add(this.btn_editar);
            this.Pnl_botones.Controls.Add(this.Lbl_borrar);
            this.Pnl_botones.Controls.Add(this.Lbl_editar);
            this.Pnl_botones.Controls.Add(this.Lbl_guardar);
            this.Pnl_botones.Controls.Add(this.btn_guardar);
            this.Pnl_botones.Location = new System.Drawing.Point(290, 22);
            this.Pnl_botones.Name = "Pnl_botones";
            this.Pnl_botones.Size = new System.Drawing.Size(283, 106);
            this.Pnl_botones.TabIndex = 30;
            // 
            // btn_borrar
            // 
            this.btn_borrar.FlatAppearance.BorderSize = 0;
            this.btn_borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_borrar.Image")));
            this.btn_borrar.Location = new System.Drawing.Point(199, 7);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(65, 65);
            this.btn_borrar.TabIndex = 16;
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(111, 7);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(65, 65);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // Lbl_borrar
            // 
            this.Lbl_borrar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_borrar.Location = new System.Drawing.Point(199, 75);
            this.Lbl_borrar.Name = "Lbl_borrar";
            this.Lbl_borrar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_borrar.TabIndex = 10;
            this.Lbl_borrar.Text = "Borrar";
            this.Lbl_borrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_editar
            // 
            this.Lbl_editar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_editar.Location = new System.Drawing.Point(111, 75);
            this.Lbl_editar.Name = "Lbl_editar";
            this.Lbl_editar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_editar.TabIndex = 7;
            this.Lbl_editar.Text = "Editar";
            this.Lbl_editar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_guardar
            // 
            this.Lbl_guardar.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_guardar.Location = new System.Drawing.Point(21, 75);
            this.Lbl_guardar.Name = "Lbl_guardar";
            this.Lbl_guardar.Size = new System.Drawing.Size(65, 22);
            this.Lbl_guardar.TabIndex = 1;
            this.Lbl_guardar.Text = "Guardar";
            this.Lbl_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_guardar
            // 
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(21, 7);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(65, 65);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_cantBebida);
            this.panel1.Controls.Add(this.lbl_bebida);
            this.panel1.Controls.Add(this.lbl_cantidadBebida);
            this.panel1.Controls.Add(this.cmb_bebida);
            this.panel1.Location = new System.Drawing.Point(50, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 165);
            this.panel1.TabIndex = 31;
            // 
            // dgv_agregarBebida
            // 
            this.dgv_agregarBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agregarBebida.Location = new System.Drawing.Point(434, 240);
            this.dgv_agregarBebida.Name = "dgv_agregarBebida";
            this.dgv_agregarBebida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_agregarBebida.Size = new System.Drawing.Size(403, 165);
            this.dgv_agregarBebida.TabIndex = 32;
            this.dgv_agregarBebida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_agregarBebida_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_mesaPedido);
            this.groupBox1.Controls.Add(this.txt_fechaPedido);
            this.groupBox1.Controls.Add(this.txt_clientePedido);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_noPedido);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PEDIDO";
            // 
            // txt_mesaPedido
            // 
            this.txt_mesaPedido.Location = new System.Drawing.Point(437, 54);
            this.txt_mesaPedido.Name = "txt_mesaPedido";
            this.txt_mesaPedido.Size = new System.Drawing.Size(122, 20);
            this.txt_mesaPedido.TabIndex = 36;
            // 
            // txt_fechaPedido
            // 
            this.txt_fechaPedido.Location = new System.Drawing.Point(227, 55);
            this.txt_fechaPedido.Name = "txt_fechaPedido";
            this.txt_fechaPedido.Size = new System.Drawing.Size(122, 20);
            this.txt_fechaPedido.TabIndex = 35;
            // 
            // txt_clientePedido
            // 
            this.txt_clientePedido.Location = new System.Drawing.Point(437, 28);
            this.txt_clientePedido.Name = "txt_clientePedido";
            this.txt_clientePedido.Size = new System.Drawing.Size(122, 20);
            this.txt_clientePedido.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(382, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(389, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Mesa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Fecha";
            // 
            // txt_noPedido
            // 
            this.txt_noPedido.Location = new System.Drawing.Point(227, 29);
            this.txt_noPedido.Name = "txt_noPedido";
            this.txt_noPedido.Size = new System.Drawing.Size(122, 20);
            this.txt_noPedido.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "No. Pedido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "No. Pedido";
            // 
            // Agregar_bebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(875, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_agregarBebida);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pnl_botones);
            this.Name = "Agregar_bebidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar_bebidascs";
            this.Load += new System.EventHandler(this.Agregar_bebidas_Load);
            this.Pnl_botones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agregarBebida)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cantBebida;
        private System.Windows.Forms.ComboBox cmb_bebida;
        private System.Windows.Forms.Label lbl_cantidadBebida;
        private System.Windows.Forms.Label lbl_bebida;
        private System.Windows.Forms.Panel Pnl_botones;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label Lbl_borrar;
        private System.Windows.Forms.Label Lbl_editar;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_agregarBebida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_mesaPedido;
        public System.Windows.Forms.TextBox txt_fechaPedido;
        public System.Windows.Forms.TextBox txt_clientePedido;
        public System.Windows.Forms.TextBox txt_noPedido;
    }
}