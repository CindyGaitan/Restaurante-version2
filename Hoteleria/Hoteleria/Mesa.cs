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
    public partial class Mesa : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        string id_mesa;

        public Mesa()
        {
            InitializeComponent();
            mostrar_mesa();
        }

        public void mostrar_mesa()
        {
            try
            {
                da = new OdbcDataAdapter("select idMesa as No, noMesa as Mesa, capacidad as Capacidad from mesa", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_mesa.DataSource = dt;
                dgv_mesa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                com = new OdbcCommand("insert into mesa (noMesa, capacidad) values (" + Convert.ToInt32(txt_noMesa.Text) + "," + Convert.ToInt32(txt_capacidad.Text) + ")", con.conexion());
                com.ExecuteNonQuery();
                txt_noMesa.Text = "";
                txt_capacidad.Text = "";
                mostrar_mesa();
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
                com = new OdbcCommand("update mesa set noMesa=" + Convert.ToInt32(txt_noMesa.Text) + ", capacidad=" + Convert.ToInt32(txt_capacidad.Text) + " where idMesa="+ Convert.ToInt32(this.id_mesa) +" ", con.conexion());
                com.ExecuteNonQuery();
                txt_noMesa.Text = "";
                txt_capacidad.Text = "";
                mostrar_mesa();
                MessageBox.Show("Datos actualizados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO actualizados, verifique la información. "+ex.ToString());
            }         
        }

        private void dgv_mesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_mesa.Rows[e.RowIndex];
                this.id_mesa = dgv.Cells[0].Value.ToString();
                txt_noMesa.Text = dgv.Cells[1].Value.ToString();
                txt_capacidad.Text = dgv.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                com = new OdbcCommand("delete from mesa where idMesa=" + Convert.ToInt32(this.id_mesa) + " ", con.conexion());
                com.ExecuteNonQuery();
                txt_noMesa.Text = "";
                txt_capacidad.Text = "";
                mostrar_mesa();
                MessageBox.Show("Datos eliminados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados, verifique la información. " + ex.ToString());
            }         
        }
    }
}
