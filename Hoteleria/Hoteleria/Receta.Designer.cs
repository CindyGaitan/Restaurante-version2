namespace Hoteleria
{
    partial class Receta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receta));
            this.Pnl_botones = new System.Windows.Forms.Panel();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.Lbl_borrar = new System.Windows.Forms.Label();
            this.Lbl_editar = new System.Windows.Forms.Label();
            this.Lbl_guardar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.dgv_receta = new System.Windows.Forms.DataGridView();
            this.pnl_Receta = new System.Windows.Forms.Panel();
            this.txt_procedimientoReceta = new System.Windows.Forms.TextBox();
            this.txt_NoPersonas = new System.Windows.Forms.TextBox();
            this.txt_tiempoReceta = new System.Windows.Forms.TextBox();
            this.txt_nombreReceta = new System.Windows.Forms.TextBox();
            this.lbl_NoPersonas = new System.Windows.Forms.Label();
            this.lbl_TiempoReceta = new System.Windows.Forms.Label();
            this.lbl_procedimiento = new System.Windows.Forms.Label();
            this.lbl_nombreReceta = new System.Windows.Forms.Label();
            this.Pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receta)).BeginInit();
            this.pnl_Receta.SuspendLayout();
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
            this.Pnl_botones.Location = new System.Drawing.Point(341, 12);
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
            // dgv_receta
            // 
            this.dgv_receta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_receta.Location = new System.Drawing.Point(513, 177);
            this.dgv_receta.Name = "dgv_receta";
            this.dgv_receta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_receta.Size = new System.Drawing.Size(400, 231);
            this.dgv_receta.TabIndex = 13;
            this.dgv_receta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_receta_CellContentClick);
            // 
            // pnl_Receta
            // 
            this.pnl_Receta.Controls.Add(this.txt_procedimientoReceta);
            this.pnl_Receta.Controls.Add(this.txt_NoPersonas);
            this.pnl_Receta.Controls.Add(this.txt_tiempoReceta);
            this.pnl_Receta.Controls.Add(this.txt_nombreReceta);
            this.pnl_Receta.Controls.Add(this.lbl_NoPersonas);
            this.pnl_Receta.Controls.Add(this.lbl_TiempoReceta);
            this.pnl_Receta.Controls.Add(this.lbl_procedimiento);
            this.pnl_Receta.Controls.Add(this.lbl_nombreReceta);
            this.pnl_Receta.Location = new System.Drawing.Point(34, 177);
            this.pnl_Receta.Name = "pnl_Receta";
            this.pnl_Receta.Size = new System.Drawing.Size(458, 231);
            this.pnl_Receta.TabIndex = 14;
            // 
            // txt_procedimientoReceta
            // 
            this.txt_procedimientoReceta.Location = new System.Drawing.Point(172, 105);
            this.txt_procedimientoReceta.Multiline = true;
            this.txt_procedimientoReceta.Name = "txt_procedimientoReceta";
            this.txt_procedimientoReceta.Size = new System.Drawing.Size(260, 110);
            this.txt_procedimientoReceta.TabIndex = 20;
            // 
            // txt_NoPersonas
            // 
            this.txt_NoPersonas.Location = new System.Drawing.Point(172, 79);
            this.txt_NoPersonas.Name = "txt_NoPersonas";
            this.txt_NoPersonas.Size = new System.Drawing.Size(190, 20);
            this.txt_NoPersonas.TabIndex = 19;
            // 
            // txt_tiempoReceta
            // 
            this.txt_tiempoReceta.Location = new System.Drawing.Point(172, 53);
            this.txt_tiempoReceta.Name = "txt_tiempoReceta";
            this.txt_tiempoReceta.Size = new System.Drawing.Size(190, 20);
            this.txt_tiempoReceta.TabIndex = 18;
            // 
            // txt_nombreReceta
            // 
            this.txt_nombreReceta.Location = new System.Drawing.Point(172, 27);
            this.txt_nombreReceta.Name = "txt_nombreReceta";
            this.txt_nombreReceta.Size = new System.Drawing.Size(190, 20);
            this.txt_nombreReceta.TabIndex = 17;
            // 
            // lbl_NoPersonas
            // 
            this.lbl_NoPersonas.AutoSize = true;
            this.lbl_NoPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoPersonas.Location = new System.Drawing.Point(13, 79);
            this.lbl_NoPersonas.Name = "lbl_NoPersonas";
            this.lbl_NoPersonas.Size = new System.Drawing.Size(109, 16);
            this.lbl_NoPersonas.TabIndex = 16;
            this.lbl_NoPersonas.Text = "No. de Personas";
            // 
            // lbl_TiempoReceta
            // 
            this.lbl_TiempoReceta.AutoSize = true;
            this.lbl_TiempoReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TiempoReceta.Location = new System.Drawing.Point(13, 53);
            this.lbl_TiempoReceta.Name = "lbl_TiempoReceta";
            this.lbl_TiempoReceta.Size = new System.Drawing.Size(151, 16);
            this.lbl_TiempoReceta.TabIndex = 15;
            this.lbl_TiempoReceta.Text = "Tiempo de Preparación";
            // 
            // lbl_procedimiento
            // 
            this.lbl_procedimiento.AutoSize = true;
            this.lbl_procedimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_procedimiento.Location = new System.Drawing.Point(13, 105);
            this.lbl_procedimiento.Name = "lbl_procedimiento";
            this.lbl_procedimiento.Size = new System.Drawing.Size(95, 16);
            this.lbl_procedimiento.TabIndex = 14;
            this.lbl_procedimiento.Text = "Procedimiento";
            // 
            // lbl_nombreReceta
            // 
            this.lbl_nombreReceta.AutoSize = true;
            this.lbl_nombreReceta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombreReceta.Location = new System.Drawing.Point(13, 27);
            this.lbl_nombreReceta.Name = "lbl_nombreReceta";
            this.lbl_nombreReceta.Size = new System.Drawing.Size(57, 16);
            this.lbl_nombreReceta.TabIndex = 13;
            this.lbl_nombreReceta.Text = "Nombre";
            // 
            // Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(947, 436);
            this.Controls.Add(this.pnl_Receta);
            this.Controls.Add(this.dgv_receta);
            this.Controls.Add(this.Pnl_botones);
            this.Name = "Receta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receta";
            this.Pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receta)).EndInit();
            this.pnl_Receta.ResumeLayout(false);
            this.pnl_Receta.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_receta;
        private System.Windows.Forms.Panel pnl_Receta;
        private System.Windows.Forms.TextBox txt_procedimientoReceta;
        private System.Windows.Forms.TextBox txt_NoPersonas;
        private System.Windows.Forms.TextBox txt_tiempoReceta;
        private System.Windows.Forms.TextBox txt_nombreReceta;
        private System.Windows.Forms.Label lbl_NoPersonas;
        private System.Windows.Forms.Label lbl_TiempoReceta;
        private System.Windows.Forms.Label lbl_procedimiento;
        private System.Windows.Forms.Label lbl_nombreReceta;
    }
}