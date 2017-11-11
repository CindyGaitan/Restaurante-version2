using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Hoteleria
{
    public partial class Receta : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        string id_receta;

        public Receta()
        {
            InitializeComponent();
            mostrar_receta();
        }

        public void mostrar_receta()
        {
            try
            {
                da = new OdbcDataAdapter("select idReceta as No, Nombre, tiempoPreparacion as Tiempo, numeroPersonas as Personas, Procedimiento from Receta", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_receta.DataSource = dt;
                dgv_receta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void dgv_receta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_receta.Rows[e.RowIndex];
                this.id_receta = dgv.Cells[0].Value.ToString();
                txt_nombreReceta.Text = dgv.Cells[1].Value.ToString();
                txt_tiempoReceta.Text = dgv.Cells[2].Value.ToString();
                txt_NoPersonas.Text = dgv.Cells[3].Value.ToString();
                txt_procedimientoReceta.Text = dgv.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                com = new OdbcCommand("insert into Receta (Nombre, Procedimiento, tiempoPreparacion, numeroPersonas) values ('"+ txt_nombreReceta.Text +"', '"+ txt_procedimientoReceta.Text +"', '"+ txt_tiempoReceta.Text +"',"+ Convert.ToInt32(txt_NoPersonas.Text) +")", con.conexion());
                com.ExecuteNonQuery();
                txt_nombreReceta.Text = "";
                txt_tiempoReceta.Text = "";
                txt_procedimientoReceta.Text = "";
                txt_NoPersonas.Text = "";
                mostrar_receta();
                MessageBox.Show("Datos ingresados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información. ");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            try
            {
                com = new OdbcCommand("update Receta set Nombre='"+ txt_nombreReceta.Text +"', Procedimiento='"+ txt_procedimientoReceta.Text +"', tiempoPreparacion='"+ txt_tiempoReceta.Text +"', numeroPersonas="+ Convert.ToInt32(txt_NoPersonas.Text) +" where idReceta=" + Convert.ToInt32(this.id_receta) + " ", con.conexion());
                com.ExecuteNonQuery();
                txt_nombreReceta.Text = "";
                txt_tiempoReceta.Text = "";
                txt_procedimientoReceta.Text = "";
                txt_NoPersonas.Text = "";
                mostrar_receta();
                MessageBox.Show("Datos actualizados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO actualizados, verifique la información. " + ex.ToString());
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                com = new OdbcCommand("delete from Receta where idReceta=" + Convert.ToInt32(this.id_receta) + " ", con.conexion());
                com.ExecuteNonQuery();
                txt_nombreReceta.Text = "";
                txt_tiempoReceta.Text = "";
                txt_procedimientoReceta.Text = "";
                txt_NoPersonas.Text = "";
                mostrar_receta();
                MessageBox.Show("Datos eliminados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados, verifique la información. " + ex.ToString());
            }          
        }
    }
}
