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
    public partial class Platillo : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        string id_platillo;

        public Platillo()
        {
            InitializeComponent();
            mostrar_platillo();
            llenar_receta();
            cmb_receta.Text = "SELCCIONE OPCION";
        }

        public void mostrar_platillo()
        {
            try
            {
                da = new OdbcDataAdapter("select P.idPlatillo as No, P.nombrePlatillo as Platillo, P.costoPlatillo as Costo, P.descripcionPlatillo as Descripcion, R.Nombre as Receta from Platillo P inner join receta R on P.receta_idReceta = R.idReceta", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_platillo.DataSource = dt;
                dgv_platillo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        public void llenar_receta()
        {
            try
            {
                com = new OdbcCommand("select Nombre from Receta", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_receta.Items.Add(dr["Nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void dgv_platillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_platillo.Rows[e.RowIndex];
                this.id_platillo = dgv.Cells[0].Value.ToString();
                txt_nombrePlatillo.Text = dgv.Cells[1].Value.ToString();
                txt_costoPlatillo.Text = dgv.Cells[2].Value.ToString();
                txt_descripcionPlatillo.Text = dgv.Cells[3].Value.ToString();
                cmb_receta.Text = dgv.Cells[4].Value.ToString();
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
                string id_receta; int id = 0;
                com = new OdbcCommand("select idReceta from Receta where Nombre ='" +cmb_receta.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_receta = dr["idReceta"].ToString();
                    id = Convert.ToInt32(id_receta);
                }
                dr.Close();

                com = new OdbcCommand("insert into Platillo (nombrePlatillo, descripcionPlatillo, costoPlatillo, receta_idReceta) values ('"+txt_nombrePlatillo.Text+"', '"+txt_descripcionPlatillo.Text+"',"+Convert.ToDecimal(txt_costoPlatillo.Text)+", "+id+")", con.conexion());
                com.ExecuteNonQuery();
                mostrar_platillo();
                txt_nombrePlatillo.Text = "";
                txt_descripcionPlatillo.Text = "";
                txt_costoPlatillo.Text = "";
                cmb_receta.Text = "SELCCIONE OPCION";
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
                com = new OdbcCommand("update Platillo set nombrePlatillo='"+txt_nombrePlatillo.Text+"', descripcionPlatillo='"+txt_descripcionPlatillo.Text+"', costoPlatillo="+Convert.ToDecimal(txt_costoPlatillo.Text)+" where idPlatillo=" + Convert.ToInt32(this.id_platillo) + " ", con.conexion());
                com.ExecuteNonQuery();
                mostrar_platillo();
                txt_nombrePlatillo.Text = "";
                txt_descripcionPlatillo.Text = "";
                txt_costoPlatillo.Text = "";
                cmb_receta.Text = "SELCCIONE OPCION";
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
                com = new OdbcCommand("delete from Platillo where idPlatillo=" + Convert.ToInt32(this.id_platillo) + " ", con.conexion());
                com.ExecuteNonQuery();
                mostrar_platillo();
                txt_nombrePlatillo.Text = "";
                txt_descripcionPlatillo.Text = "";
                txt_costoPlatillo.Text = "";
                cmb_receta.Text = "SELCCIONE OPCION";
                MessageBox.Show("Datos eliminados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados, verifique la información. " + ex.ToString());
            }
        }
    }
}
