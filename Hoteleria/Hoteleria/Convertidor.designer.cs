namespace Hoteleria
{
    partial class frm_Convertidor
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
            this.lb_De = new System.Windows.Forms.Label();
            this.lb_A = new System.Windows.Forms.Label();
            this.btn_Convertir = new System.Windows.Forms.Button();
            this.cmb_De = new System.Windows.Forms.ComboBox();
            this.cmb_A = new System.Windows.Forms.ComboBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.lb_medida = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lb_Cantidad = new System.Windows.Forms.Label();
            this.txt_Intercambiar = new System.Windows.Forms.Button();
            this.gb_resultado = new System.Windows.Forms.GroupBox();
            this.gb_resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_De
            // 
            this.lb_De.AutoSize = true;
            this.lb_De.Location = new System.Drawing.Point(359, 44);
            this.lb_De.Name = "lb_De";
            this.lb_De.Size = new System.Drawing.Size(34, 20);
            this.lb_De.TabIndex = 2;
            this.lb_De.Text = "De:";
            this.lb_De.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_A
            // 
            this.lb_A.AutoSize = true;
            this.lb_A.Location = new System.Drawing.Point(359, 105);
            this.lb_A.Name = "lb_A";
            this.lb_A.Size = new System.Drawing.Size(24, 20);
            this.lb_A.TabIndex = 3;
            this.lb_A.Text = "A:";
            // 
            // btn_Convertir
            // 
            this.btn_Convertir.Location = new System.Drawing.Point(489, 175);
            this.btn_Convertir.Name = "btn_Convertir";
            this.btn_Convertir.Size = new System.Drawing.Size(111, 51);
            this.btn_Convertir.TabIndex = 4;
            this.btn_Convertir.Text = "Convertir";
            this.btn_Convertir.UseVisualStyleBackColor = true;
            this.btn_Convertir.Click += new System.EventHandler(this.btn_Convertir_Click);
            // 
            // cmb_De
            // 
            this.cmb_De.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_De.FormattingEnabled = true;
            this.cmb_De.Items.AddRange(new object[] {
            "--MASA",
            "Gramos",
            "Kilogramos",
            "Libras",
            "Onzas",
            "Toneladas",
            "--LIQUIDOS",
            "Mililitros",
            "Litros",
            "Galones"});
            this.cmb_De.Location = new System.Drawing.Point(441, 44);
            this.cmb_De.Name = "cmb_De";
            this.cmb_De.Size = new System.Drawing.Size(145, 28);
            this.cmb_De.TabIndex = 5;
            // 
            // cmb_A
            // 
            this.cmb_A.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_A.FormattingEnabled = true;
            this.cmb_A.Items.AddRange(new object[] {
            "--MASA",
            "Gramos",
            "Kilogramos",
            "Libras",
            "Onzas",
            "Toneladas",
            "--LIQUIDOS",
            "Mililitros",
            "Litros",
            "Galones"});
            this.cmb_A.Location = new System.Drawing.Point(441, 105);
            this.cmb_A.Name = "cmb_A";
            this.cmb_A.Size = new System.Drawing.Size(145, 28);
            this.cmb_A.TabIndex = 6;
            // 
            // lb_resultado
            // 
            this.lb_resultado.Location = new System.Drawing.Point(6, 45);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(113, 30);
            this.lb_resultado.TabIndex = 7;
            // 
            // lb_medida
            // 
            this.lb_medida.Location = new System.Drawing.Point(139, 45);
            this.lb_medida.Name = "lb_medida";
            this.lb_medida.Size = new System.Drawing.Size(59, 30);
            this.lb_medida.TabIndex = 9;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(148, 79);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(140, 26);
            this.txt_Cantidad.TabIndex = 10;
            // 
            // lb_Cantidad
            // 
            this.lb_Cantidad.AutoSize = true;
            this.lb_Cantidad.Location = new System.Drawing.Point(55, 79);
            this.lb_Cantidad.Name = "lb_Cantidad";
            this.lb_Cantidad.Size = new System.Drawing.Size(77, 20);
            this.lb_Cantidad.TabIndex = 11;
            this.lb_Cantidad.Text = "Cantidad:";
            // 
            // txt_Intercambiar
            // 
            this.txt_Intercambiar.Location = new System.Drawing.Point(328, 175);
            this.txt_Intercambiar.Name = "txt_Intercambiar";
            this.txt_Intercambiar.Size = new System.Drawing.Size(116, 51);
            this.txt_Intercambiar.TabIndex = 12;
            this.txt_Intercambiar.Text = "Intercambiar";
            this.txt_Intercambiar.UseVisualStyleBackColor = true;
            this.txt_Intercambiar.Click += new System.EventHandler(this.txt_Intercambiar_Click);
            // 
            // gb_resultado
            // 
            this.gb_resultado.Controls.Add(this.lb_resultado);
            this.gb_resultado.Controls.Add(this.lb_medida);
            this.gb_resultado.Location = new System.Drawing.Point(682, 44);
            this.gb_resultado.Name = "gb_resultado";
            this.gb_resultado.Size = new System.Drawing.Size(204, 94);
            this.gb_resultado.TabIndex = 13;
            this.gb_resultado.TabStop = false;
            this.gb_resultado.Text = "RESULTADO";
            // 
            // frm_Convertidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 253);
            this.Controls.Add(this.gb_resultado);
            this.Controls.Add(this.txt_Intercambiar);
            this.Controls.Add(this.lb_Cantidad);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.cmb_A);
            this.Controls.Add(this.cmb_De);
            this.Controls.Add(this.btn_Convertir);
            this.Controls.Add(this.lb_A);
            this.Controls.Add(this.lb_De);
            this.Name = "frm_Convertidor";
            this.Text = "Convertidor de Medidas";
            this.Load += new System.EventHandler(this.frm_Convertidor_Load);
            this.gb_resultado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_De;
        private System.Windows.Forms.Label lb_A;
        private System.Windows.Forms.Button btn_Convertir;
        private System.Windows.Forms.ComboBox cmb_De;
        private System.Windows.Forms.ComboBox cmb_A;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.Label lb_medida;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label lb_Cantidad;
        private System.Windows.Forms.Button txt_Intercambiar;
        private System.Windows.Forms.GroupBox gb_resultado;
    }
}

