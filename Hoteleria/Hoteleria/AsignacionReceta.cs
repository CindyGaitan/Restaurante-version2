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
    public partial class AsignacionReceta : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        string ingrediente, receta, pesoCantidad;
        Conversion conv = new Conversion();

        public AsignacionReceta()
        {
            InitializeComponent();
            mostrar_Asignacion();
            llenar_ingrediente();
            llenar_receta();
            llenar_tipoMedida();
            cmb_receta.Text = "SELECCIONE OPCION";
            cmb_ingrediente.Text = "SELECCIONE OPCION";
            cmb_tipoMedida.Text = "SELECCIONE";
        }

        public void mostrar_Asignacion()
        {
            try
            {
                da = new OdbcDataAdapter("select r.nombre as Receta, p.descripcion as Ingrediente, d.pesoOcantidad as Cantidad, tpm.nombre as Medida from detallerecetaingrediente d inner join receta r on r.idReceta = d.receta_idReceta inner join productos p on p.idProducto = d.productos_idProducto inner join tipomedida tpm on tpm.idTipoMedida = d.tipoMedida_idTipoMedida", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_asignacion.DataSource = dt;
                dgv_asignacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR").ToString();
            }
        }

        public void llenar_tipoMedida()
        {
            try
            {
                com = new OdbcCommand("select nombre from tipomedida", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_tipoMedida.Items.Add(dr["Nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        //public void llenar_unidad()
        //{
        //    try
        //    {
        //        com = new OdbcCommand("select tm.nombre from tipomedida tm inner join detallebodega db on db.tipoMedida_idTipoMedida = tm.idTipoMedida inner join productos p on p.idProducto = db.productos_idProducto inner join tipoproducto tp on tp.idTipoProducto = p.tipoProducto_idTipoProducto where p.descripcion = '" + cmb_ingrediente.Text + "' ", con.conexion());
        //        dr = com.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            lbl_Medida.Text=(dr["nombre"].ToString());
        //        }
        //        dr.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error");
        //    }
        //}

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
                MessageBox.Show("Error").ToString();
            }
        }

        public void llenar_ingrediente()
        {
            try
            {
                com = new OdbcCommand("select p.descripcion from productos p inner join detallebodega d on p.idProducto = d.productos_idProducto inner join tipomedida t on d.tipoMedida_idTipoMedida = t.idTipoMedida inner join tipoproducto tp on tp.idTipoProducto = p.tipoProducto_idTipoProducto where tp.nombre = 'Ingrediente' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_ingrediente.Items.Add(dr["descripcion"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error").ToString();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_ingrediente; int id_ing = 0;
                com = new OdbcCommand("select idProducto from productos where descripcion ='" + cmb_ingrediente.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_ingrediente = dr["idProducto"].ToString();
                    id_ing = Convert.ToInt32(id_ingrediente);
                }
                dr.Close();

                string id_receta; int id_rec = 0;
                com = new OdbcCommand("select idReceta from Receta where Nombre ='" + cmb_receta.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_receta = dr["idReceta"].ToString();
                    id_rec = Convert.ToInt32(id_receta);
                }
                dr.Close();

                string ingrediente; int id_ingr = 0;
                com = new OdbcCommand("select idIngrediente from ingrediente where nombre ='" + cmb_ingrediente.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ingrediente = dr["idIngediente"].ToString();
                    id_ingr = Convert.ToInt32(ingrediente);
                }
                dr.Close();

                string tipo; int id_tipo = 0;
                com = new OdbcCommand("select idTipoMedida from tipoMedida where nombre ='" + cmb_tipoMedida.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    tipo = dr["idTipoMedida"].ToString();
                    id_tipo = Convert.ToInt32(tipo);
                }
                dr.Close();

                com = new OdbcCommand("insert into detalleRecetaIngrediente (productos_idProducto, receta_idReceta, pesoOcantidad, tipoMedida_idTipoMedida) values ("+id_ing+","+id_rec+",'"+txt_cantidad.Text+"',"+id_tipo+")", con.conexion());
                com.ExecuteNonQuery();

                string medida;                                      //
                double cantidad, cant;                              //
                cantidad = Convert.ToDouble(txt_cantidad.Text);     //
                medida = cmb_tipoMedida.Text;    //
                txt_cantidad.Text = "";                         
                cmb_ingrediente.Text = "SELECCIONE OPCION";
                cmb_receta.Text = "SELECCIONE OPCION";
                cmb_tipoMedida.Text = "SELECCIONE OPCION";
                mostrar_Asignacion();

                MessageBox.Show("Datos ingresados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información." + ex.ToString());
            }
        }

        private void cmb_ingrediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //llenar_unidad();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_ingrediente; int id_ing = 0;
                com = new OdbcCommand("select idProducto from productos where descripcion ='" + this.ingrediente + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_ingrediente = dr["idProducto"].ToString();
                    id_ing = Convert.ToInt32(id_ingrediente);
                }
                dr.Close();

                string id_receta; int id_rec = 0;
                com = new OdbcCommand("select idReceta from Receta where Nombre ='" + this.receta + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_receta = dr["idReceta"].ToString();
                    id_rec = Convert.ToInt32(id_receta);
                }
                dr.Close();

                com = new OdbcCommand("delete from detalleRecetaIngrediente where productos_idProducto=" +id_ing+ " and receta_idReceta="+id_rec+" ", con.conexion());
                com.ExecuteNonQuery();
                txt_cantidad.Text = "";
                cmb_ingrediente.Text = "SELECCIONE OPCION";
                cmb_receta.Text = "SELECCIONE OPCION";
                mostrar_Asignacion();
                MessageBox.Show("Datos eliminados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados, verifique la información. " + ex.ToString());
            }
        }

        private void cmb_receta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_asignacion.Rows[e.RowIndex];
                cmb_receta.Text = dgv.Cells[0].Value.ToString();
                receta = dgv.Cells[0].Value.ToString();
                cmb_ingrediente.Text = dgv.Cells[1].Value.ToString();
                ingrediente = dgv.Cells[1].Value.ToString();
                txt_cantidad.Text = dgv.Cells[2].Value.ToString();
                pesoCantidad = dgv.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_ingrediente; int id_ing = 0;
                com = new OdbcCommand("select idProducto from productos where descripcion ='" + cmb_ingrediente.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_ingrediente = dr["idProducto"].ToString();
                    id_ing = Convert.ToInt32(id_ingrediente);
                }
                dr.Close();

                string id_ingrediente2; int id_ing2 = 0;
                com = new OdbcCommand("select idProducto from productos where descripcion ='" + this.ingrediente + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_ingrediente2 = dr["idProducto"].ToString();
                    id_ing2 = Convert.ToInt32(id_ingrediente2);
                }
                dr.Close();

                string id_receta; int id_rec = 0;
                com = new OdbcCommand("select idReceta from Receta where Nombre ='" + cmb_receta.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_receta = dr["idReceta"].ToString();
                    id_rec = Convert.ToInt32(id_receta);
                }
                dr.Close();

                string id_receta2; int id_rec2 = 0;
                com = new OdbcCommand("select idReceta from Receta where Nombre ='" + this.receta + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_receta2 = dr["idReceta"].ToString();
                    id_rec2 = Convert.ToInt32(id_receta2);
                }
                dr.Close();

                com = new OdbcCommand("update detalleRecetaIngrediente set productos_idProducto=" + id_ing + ", receta_idReceta="+id_rec+", pesoOcantidad='"+txt_cantidad.Text+"' where productos_idProducto="+id_ing2+" and receta_idReceta="+id_rec2+" ", con.conexion());
                com.ExecuteNonQuery();
                txt_cantidad.Text = "";
                cmb_ingrediente.Text = "SELECCIONE OPCION";
                cmb_receta.Text = "SELECCIONE OPCION";
                mostrar_Asignacion();
                MessageBox.Show("Datos actualizados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO actualizados, verifique la información. " + ex.ToString());
            }
        }
    }
}
