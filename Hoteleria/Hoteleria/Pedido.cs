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
    public partial class Pedido : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        public string id_pedido;

        public Pedido()
        {
            InitializeComponent();
            mostrar_pedido();
            llendao_mesa();
            llenado_cliente();
            cmb_cliente.Text = "SELECCIONE OPCION";
            cmb_mesa.Text = "SELECCIONE OPCION";
            txt_noPedido.Enabled = false;
        }

        public void mostrar_pedido()
        {
            try
            {
                da = new OdbcDataAdapter("select P.idPedidoRestaurante as No, P.fechaPedido as Fecha, M.noMesa as Mesa, concat(C.nombreCliente,' ',C.apellidoCliente) as Cliente, c.nitCliente as Nit from pedidoRestaurante p inner join Cliente C on P.cliente_idCliente = C.idCliente inner join mesa m on p.mesa_idMesa=m.idMesa", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_pedido.DataSource = dt;
                dgv_pedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.ToString());
            }
        }

        public void llendao_mesa()
        {
            try
            {
                com = new OdbcCommand("select noMesa from Mesa", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_mesa.Items.Add(dr["noMesa"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        public void llenado_cliente()
        {
            try
            {
                com = new OdbcCommand("select concat(nombreCliente,' ',apellidoCliente) from Cliente;", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_cliente.Items.Add(dr["concat(nombreCliente,' ',apellidoCliente)"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.ToString());
            }
        }

        private void dgv_pedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_pedido.Rows[e.RowIndex];
                this.id_pedido = dgv.Cells[0].Value.ToString();
                txt_noPedido.Text = dgv.Cells[0].Value.ToString();
                dtp_fecha.Text = dgv.Cells[1].Value.ToString();
                cmb_mesa.Text = dgv.Cells[2].Value.ToString();
                cmb_cliente.Text = dgv.Cells[3].Value.ToString();

                com = new OdbcCommand("select p.idPedidoRestaurante, sum((pl.costoPlatillo*dpp.cantidadPlatillo+pro.precio* dpb.cantidadBebida)/2) as Costo from platillo pl inner join receta r on pl.receta_idReceta = r.idReceta inner join detallepedidoplatillo dpp on dpp.platillo_idPlatillo = pl.idPlatillo inner join pedidoRestaurante p on p.idPedidoRestaurante = dpp.pedidoRestaurante_idPedido inner join detallepedidobebida dpb on dpb.pedidoRestaurante_idPedido = p.idPedidoRestaurante inner join productos pro on pro.idProducto = dpb.productos_idProducto where p.idPedidoRestaurante=" + Convert.ToUInt32(txt_noPedido.Text)+" ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    label1.Text ="Q. "+(dr["costo"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {   //MESA
                string mesa; int id_mesa = 0;
                com = new OdbcCommand("select noMesa from Mesa where noMesa ='" + cmb_mesa.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    mesa = dr["noMesa"].ToString();
                    id_mesa = Convert.ToInt32(mesa);
                }
                dr.Close();
                
                //Cliente
                string cliente; int id_cliente = 0;
                com = new OdbcCommand("select idCliente from cliente where concat(nombreCliente,' ',apellidoCliente) ='" + cmb_cliente.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cliente = dr["idCliente"].ToString();
                    id_cliente = Convert.ToInt32(cliente);
                }
                dr.Close();

                //INGRESO PEDIDO
                com = new OdbcCommand("insert into PedidoRestaurante (fechaPedido, mesa_idMesa, cliente_idCliente) values ('" + dtp_fecha.Value.ToString("yyyy/M/d") + "'," + id_mesa + "," + id_cliente + ")", con.conexion());
                com.ExecuteNonQuery();

                mostrar_pedido();
                cmb_cliente.Text = "SELECCIONE OPCION";
                cmb_mesa.Text = "SELECCIONE OPCION";
                txt_noPedido.Text = "";
                MessageBox.Show("Datos ingresados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información." + ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Agregar_platillos ag = new Agregar_platillos();
            //mostrarDatosPedido_Platillo();

            string cliente = null;
            string fecha = null;
            string mesa = null;
            com = new OdbcCommand("select concat(c.nombreCliente,' ', c.apellidoCliente), p.fechaPedido, p.mesa_idMesa from cliente c inner join pedidoRestaurante p on p.cliente_idCliente=c.idCliente where idPedidoRestaurante=" + Convert.ToInt32(this.id_pedido) + " ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cliente = dr["concat(c.nombreCliente,' ', c.apellidoCliente)"].ToString();
            }
            dr.Close();

            com = new OdbcCommand("select fechaPedido from pedidoRestaurante where idPedidoRestaurante=" + Convert.ToInt32(this.id_pedido) + " ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                fecha = dr["fechaPedido"].ToString();
            }
            dr.Close();

            com = new OdbcCommand("select mesa_idMesa from pedidoRestaurante where idPedidoRestaurante=" + Convert.ToInt32(this.id_pedido) + " ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                mesa = dr["mesa_idMesa"].ToString();
            }
            dr.Close();

            ag.txt_noPedido.Text = txt_noPedido.Text;
            ag.txt_clientePedido.Text = cliente;
            ag.txt_fechaPedido.Text = fecha;
            ag.txt_mesaPedido.Text = mesa;

            ag.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agregar_bebidas agb = new Agregar_bebidas();
            string cliente = null;
            string fecha = null;
            string mesa = null;
            com = new OdbcCommand("select concat(c.nombreCliente,' ', c.apellidoCliente), p.fechaPedido, p.mesa_idMesa from cliente c inner join pedidoRestaurante p on p.cliente_idCliente=c.idCliente where idPedidoRestaurante=" + Convert.ToInt32(this.id_pedido) + " ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                cliente = dr["concat(c.nombreCliente,' ', c.apellidoCliente)"].ToString();
            }
            dr.Close();

            com = new OdbcCommand("select fechaPedido from pedidoRestaurante where idPedidoRestaurante=" + Convert.ToInt32(this.id_pedido) + " ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                fecha = dr["fechaPedido"].ToString();
            }
            dr.Close();

            com = new OdbcCommand("select mesa_idMesa from pedidoRestaurante where idPedidoRestaurante=" + Convert.ToInt32(this.id_pedido) + " ", con.conexion());
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                mesa = dr["mesa_idMesa"].ToString();
            }
            dr.Close();

            agb.txt_noPedido.Text = txt_noPedido.Text;
            agb.txt_clientePedido.Text = cliente;
            agb.txt_fechaPedido.Text = fecha;
            agb.txt_mesaPedido.Text = mesa;
            agb.Show();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                //Cliente
                string cliente; int id_cliente = 0;
                com = new OdbcCommand("select idCliente from cliente where concat(nombreCliente,' ',apellidoCliente) ='" + cmb_cliente.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cliente = dr["idCliente"].ToString();
                    id_cliente = Convert.ToInt32(cliente);
                }
                dr.Close();

                com = new OdbcCommand("update pedidoRestaurante set fechaPedido='" + dtp_fecha.Value.ToString("d/M/yyyy") + "', mesa_idMesa=" + Convert.ToInt32(cmb_mesa.Text) + ", cliente_idCliente=" + id_cliente + " where idPedidoRestaurante=" + Convert.ToInt32(this.id_pedido)+" ", con.conexion());
                com.ExecuteNonQuery();

                mostrar_pedido();
                cmb_cliente.Text = "SELECCIONE OPCION";
                cmb_mesa.Text = "SELECCIONE OPCION";
                txt_noPedido.Text = "";
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
                com = new OdbcCommand("delete from pedidoRestaurante where idPedidoRestaurante=" + Convert.ToInt32(this.id_pedido) + " ", con.conexion());
                com.ExecuteNonQuery();
                mostrar_pedido();
                cmb_cliente.Text = "SELECCIONE OPCION";
                cmb_mesa.Text = "SELECCIONE OPCION";
                txt_noPedido.Text = "";
                MessageBox.Show("Datos eliminados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados, verifique la información. " + ex.ToString());
            }
        }

      
        public void mostrarDatosPedido_Bebida()
        {
           
        }
    }
}
