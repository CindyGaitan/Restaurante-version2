using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoteleria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
         
        }

        private void platillosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Platillo pl = new Platillo();
            pl.Show();
        }

        private void bebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesa me = new Mesa();
            me.Show();
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Receta rec = new Receta();
            rec.Show();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido pe = new Pedido();
            pe.Show();
        }

        private void asignaciónDeIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionReceta asig = new AsignacionReceta();
            asig.Show();
        }

        private void convertidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Convertidor conv = new frm_Convertidor();
            conv.Show();
        }
    }
}
