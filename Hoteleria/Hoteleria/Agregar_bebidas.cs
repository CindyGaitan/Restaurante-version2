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
    public partial class Agregar_bebidas : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        string id_bebida;

        public Agregar_bebidas()
        {
            InitializeComponent();
            cmb_bebida.Text = "SELECCIONE OPCION";
            txt_noPedido.Enabled = false;
            txt_mesaPedido.Enabled = false;
            txt_fechaPedido.Enabled = false;
            txt_clientePedido.Enabled = false;
            llenado_bebida();
        }

        public void mostrarBebidas()
        {
            try
            {
                da = new OdbcDataAdapter("select p.descripcion as Bebida,p.precio as Precio, dpb.cantidadBebida as Cantidad, (p.precio*dpb.cantidadBebida) as costo from productos p inner join detallepedidobebida dpb on dpb.productos_idProducto = p.idProducto inner join tipoproducto tp on tp.idTipoProducto = p.tipoProducto_idTipoProducto inner join pedidoRestaurante pe on pe.idPedidoRestaurante = dpb.pedidoRestaurante_idPedido where pe.idPedidoRestaurante = " + Convert.ToInt32(txt_noPedido.Text) + " ", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_agregarBebida.DataSource = dt;
                dgv_agregarBebida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        public void llenado_bebida()
        {
            try
            {
                com = new OdbcCommand("select p.descripcion from productos p inner join detallebodega d on p.idProducto = d.productos_idProducto inner join tipomedida t on d.tipoMedida_idTipoMedida = t.idTipoMedida inner join tipoproducto tp on tp.idTipoProducto = p.tipoProducto_idTipoProducto where tp.nombre = 'Bebida' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_bebida.Items.Add(dr["descripcion"].ToString());
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
            {  //BEBIDA 
                string bebida; int id_bebida = 0;
                com = new OdbcCommand("select idProducto from productos where descripcion ='" + cmb_bebida.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    bebida = dr["idProducto"].ToString();
                    id_bebida = Convert.ToInt32(bebida);
                }
                dr.Close();
                //CANTIDAD EN BODEGA
                string cant; double cantidadBodega = 0;
                com = new OdbcCommand("select cantidad from detallebodega where productos_idProducto ='"+id_bebida+"' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cant = dr["cantidad"].ToString();
                    cantidadBodega = Convert.ToDouble(cant);
                }
                dr.Close();
                if (cantidadBodega < Convert.ToDouble(txt_cantBebida.Text))
                {
                    MessageBox.Show("Bebida no disponible" + " |Cantidad en bodega: " + cantidadBodega + " " + "| Cantidad solicitada" + txt_cantBebida.Text);
                    MessageBox.Show("PEDIDO NO ACEPTADO NO ACEPTADO NO ACEPTADO");
                }
                else
                {
                    MessageBox.Show("Bebida si disponible" + " |Cantidad en bodega: " + cantidadBodega + " " + "| Cantidad solicitada" + txt_cantBebida.Text+" | Nueva cantidad en Bodega: "+(cantidadBodega-Convert.ToDouble(txt_cantBebida.Text)));
                    //INGRESO BEBIDA
                    com = new OdbcCommand("insert into detallepedidobebida (cantidadBebida, pedidoRestaurante_idPedido, productos_idProducto) values (" + Convert.ToInt32(txt_cantBebida.Text) + "," + Convert.ToInt32(txt_noPedido.Text) + ", " + id_bebida + " )", con.conexion());
                    com.ExecuteNonQuery();

                    //REBAJA DE INVENTARIO EN DETALLE BODEGA
                    com = new OdbcCommand("update detallebodega set cantidad=" + (cantidadBodega - Convert.ToDouble(txt_cantBebida.Text)) + " where productos_idProducto=" + id_bebida + " ", con.conexion());
                    com.ExecuteNonQuery();

                    cmb_bebida.Text = "SELECCIONE OPCION";
                    mostrarBebidas();
                    txt_cantBebida.Text = "";
                    MessageBox.Show("Datos ingresados. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información." + ex.ToString());
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                //BEBIDA 
                string bebida; int id_bebida = 0;
                com = new OdbcCommand("select idProducto from productos where descripcion ='" + cmb_bebida.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    bebida = dr["idProducto"].ToString();
                    id_bebida = Convert.ToInt32(bebida);
                }
                dr.Close();

                //BEBIDA2
                string bebida2; int id_bebidas2 = 0;
                com = new OdbcCommand("select idProducto from productos where descripcion ='" + this.id_bebida + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    bebida2 = dr["idProducto"].ToString();
                    id_bebidas2 = Convert.ToInt32(bebida2);
                }
                dr.Close();

                com = new OdbcCommand("update detallepedidobebida set productos_idProducto=" + id_bebida + ", cantidadBebida=" + Convert.ToInt32(txt_cantBebida.Text) + " where pedidoRestaurante_idPedido=" + Convert.ToInt32(txt_noPedido.Text)+" and productos_idProducto="+id_bebidas2+" ", con.conexion());
                com.ExecuteNonQuery();

                cmb_bebida.Text = "SELECCIONE OPCION";
                mostrarBebidas();
                txt_cantBebida.Text = "";
                MessageBox.Show("Datos actualizados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO actualizados, verifique la información. " + ex.ToString());
            }
        }

        private void dgv_agregarBebida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_agregarBebida.Rows[e.RowIndex];
                this.id_bebida= dgv.Cells[0].Value.ToString();
                cmb_bebida.Text = dgv.Cells[0].Value.ToString();
                txt_cantBebida.Text = dgv.Cells[2].Value.ToString();
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
                //BEBIDA 
                string bebida; int id_bebidas = 0;
                com = new OdbcCommand("select idProducto from productos where descripcion ='" + this.id_bebida + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    bebida = dr["idProducto"].ToString();
                    id_bebidas = Convert.ToInt32(bebida);
                }
                dr.Close();

                com = new OdbcCommand("delete from detallepedidobebida where pedidoRestaurante_idPedido=" + Convert.ToInt32(txt_noPedido.Text) + " and productos_idProducto=" + id_bebidas + " ", con.conexion());
                com.ExecuteNonQuery();

                cmb_bebida.Text = "SELECCIONE OPCION";
                mostrarBebidas();
                txt_cantBebida.Text = "";
                MessageBox.Show("Datos eliminados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados, verifique la información. " + ex.ToString());
            }
        }

        private void Agregar_bebidas_Load(object sender, EventArgs e)
        {
           mostrarBebidas();
        }
    }
}
