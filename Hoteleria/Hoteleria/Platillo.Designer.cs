namespace Hoteleria
{
    partial class Platillo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Platillo));
            this.Pnl_botones = new System.Windows.Forms.Panel();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.Lbl_borrar = new System.Windows.Forms.Label();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_platillo = new System.Windows.Forms.DataGridView();
            this.pnl_platillo = new System.Windows.Forms.Panel();
            this.cmb_receta = new System.Windows.Forms.ComboBox();
            this.txt_descripcionPlatillo = new System.Windows.Forms.TextBox();
            this.txt_costoPlatillo = new System.Windows.Forms.TextBox();
            this.txt_nombrePlatillo = new System.Windows.Forms.TextBox();
            this.lbl_receta = new System.Windows.Forms.Label();
            this.lbl_costoPlatillo = new System.Windows.Forms.Label();
            this.lbl_descripcionPlatillo = new System.Windows.Forms.Label();
            this.lbl_nombrePlatillo = new System.Windows.Forms.Label();
            this.Pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_platillo)).BeginInit();
            this.pnl_platillo.SuspendLayout();
            this.SuspendLayout();
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
            this.Pnl_botones.Location = new System.Drawing.Point(344, 12);
            this.Pnl_botones.Name = "Pnl_botones";
            this.Pnl_botones.Size = new System.Drawing.Size(283, 106);
            this.Pnl_botones.TabIndex = 12;
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
            // dgv_platillo
            // 
            this.dgv_platillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_platillo.Location = new System.Drawing.Point(417, 163);
            this.dgv_platillo.Name = "dgv_platillo";
            this.dgv_platillo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_platillo.Size = new System.Drawing.Size(430, 237);
            this.dgv_platillo.TabIndex = 13;
            this.dgv_platillo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_platillo_CellContentClick);
            // 
            // pnl_platillo
            // 
            this.pnl_platillo.Controls.Add(this.cmb_receta);
            this.pnl_platillo.Controls.Add(this.txt_descripcionPlatillo);
            this.pnl_platillo.Controls.Add(this.txt_costoPlatillo);
            this.pnl_platillo.Controls.Add(this.txt_nombrePlatillo);
            this.pnl_platillo.Controls.Add(this.lbl_receta);
            this.pnl_platillo.Controls.Add(this.lbl_costoPlatillo);
            this.pnl_platillo.Controls.Add(this.lbl_descripcionPlatillo);
            this.pnl_platillo.Controls.Add(this.lbl_nombrePlatillo);
            this.pnl_platillo.Location = new System.Drawing.Point(12, 163);
            this.pnl_platillo.Name = "pnl_platillo";
            this.pnl_platillo.Size = new System.Drawing.Size(399, 237);
            this.pnl_platillo.TabIndex = 14;
            // 
            // cmb_receta
            // 
            this.cmb_receta.FormattingEnabled = true;
            this.cmb_receta.Location = new System.Drawing.Point(108, 189);
            this.cmb_receta.Name = "cmb_receta";
            this.cmb_receta.Size = new System.Drawing.Size(167, 21);
            this.cmb_receta.TabIndex = 19;
            // 
            // txt_descripcionPlatillo
            // 
            this.txt_descripcionPlatillo.Location = new System.Drawing.Point(108, 83);
            this.txt_descripcionPlatillo.Multiline = true;
            this.txt_descripcionPlatillo.Name = "txt_descripcionPlatillo";
            this.txt_descripcionPlatillo.Size = new System.Drawing.Size(266, 101);
            this.txt_descripcionPlatillo.TabIndex = 18;
            // 
            // txt_costoPlatillo
            // 
            this.txt_costoPlatillo.Location = new System.Drawing.Point(108, 57);
            this.txt_costoPlatillo.Name = "txt_costoPlatillo";
            this.txt_costoPlatillo.Size = new System.Drawing.Size(167, 20);
            this.txt_costoPlatillo.TabIndex = 17;
            // 
            // txt_nombrePlatillo
            // 
            this.txt_nombrePlatillo.Location = new System.Drawing.Point(108, 31);
            this.txt_nombrePlatillo.Name = "txt_nombrePlatillo";
            this.txt_nombrePlatillo.Size = new System.Drawing.Size(167, 20);
            this.txt_nombrePlatillo.TabIndex = 16;
            // 
            // lbl_receta
            // 
            this.lbl_receta.AutoSize = true;
            this.lbl_receta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receta.Location = new System.Drawing.Point(16, 189);
            this.lbl_receta.Name = "lbl_receta";
            this.lbl_receta.Size = new System.Drawing.Size(52, 16);
            this.lbl_receta.TabIndex = 15;
            this.lbl_receta.Text = "Receta";
            // 
            // lbl_costoPlatillo
            // 
            this.lbl_costoPlatillo.AutoSize = true;
            this.lbl_costoPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_costoPlatillo.Location = new System.Drawing.Point(16, 57);
            this.lbl_costoPlatillo.Name = "lbl_costoPlatillo";
            this.lbl_costoPlatillo.Size = new System.Drawing.Size(43, 16);
            this.lbl_costoPlatillo.TabIndex = 15;
            this.lbl_costoPlatillo.Text = "Costo";
            // 
            // lbl_descripcionPlatillo
            // 
            this.lbl_descripcionPlatillo.AutoSize = true;
            this.lbl_descripcionPlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcionPlatillo.Location = new System.Drawing.Point(16, 83);
            this.lbl_descripcionPlatillo.Name = "lbl_descripcionPlatillo";
            this.lbl_descripcionPlatillo.Size = new System.Drawing.Size(80, 16);
            this.lbl_descripcionPlatillo.TabIndex = 14;
            this.lbl_descripcionPlatillo.Text = "Descripcion";
            // 
            // lbl_nombrePlatillo
            // 
            this.lbl_nombrePlatillo.AutoSize = true;
            this.lbl_nombrePlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombrePlatillo.Location = new System.Drawing.Point(16, 31);
            this.lbl_nombrePlatillo.Name = "lbl_nombrePlatillo";
            this.lbl_nombrePlatillo.Size = new System.Drawing.Size(57, 16);
            this.lbl_nombrePlatillo.TabIndex = 13;
            this.lbl_nombrePlatillo.Text = "Nombre";
            // 
            // Platillo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(878, 424);
            this.Controls.Add(this.pnl_platillo);
            this.Controls.Add(this.dgv_platillo);
            this.Controls.Add(this.Pnl_botones);
            this.Name = "Platillo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Platillo";
            this.Pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_platillo)).EndInit();
            this.pnl_platillo.ResumeLayout(false);
            this.pnl_platillo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_botones;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label Lbl_borrar;
        private System.Windows.Forms.Label Lbl_editar;
        private System.Windows.Forms.Label Lbl_guardar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.DataGridView dgv_platillo;
        private System.Windows.Forms.Panel pnl_platillo;
        private System.Windows.Forms.ComboBox cmb_receta;
        private System.Windows.Forms.TextBox txt_descripcionPlatillo;
        private System.Windows.Forms.TextBox txt_costoPlatillo;
        private System.Windows.Forms.TextBox txt_nombrePlatillo;
        private System.Windows.Forms.Label lbl_receta;
        private System.Windows.Forms.Label lbl_costoPlatillo;
        private System.Windows.Forms.Label lbl_descripcionPlatillo;
        private System.Windows.Forms.Label lbl_nombrePlatillo;
    }
}