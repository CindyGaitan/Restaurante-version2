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
    public partial class Agregar_platillos : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        Conversion conversion = new Conversion();
        string id_platillo;

        public Agregar_platillos()
        {
            InitializeComponent();
            llenado_platillo();
            cmb_Platillos.Text = "SELECCIONE OPCION";
            txt_noPedido.Enabled = false;
            txt_fechaPedido.Enabled = false;
            txt_mesaPedido.Enabled = false;
            txt_clientePedido.Enabled = false;
        }

        public void mostrarPlatillos()
        {
            try
            {
                da = new OdbcDataAdapter("select pl.idPlatillo as 'No Platillo',pl.nombrePlatillo as Platillo, r.nombre as Receta, dpp.cantidadPlatillo as Cantidad,(pl.costoPlatillo*dpp.cantidadPlatillo) as Costo from platillo pl inner join receta r on pl.receta_idReceta = r.idReceta inner join detallepedidoplatillo dpp on dpp.platillo_idPlatillo = pl.idPlatillo inner join pedidoRestaurante p on p.idPedidoRestaurante = dpp.pedidoRestaurante_idPedido where p.idPedidoRestaurante = " + Convert.ToInt32(txt_noPedido.Text)+" ", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_agregarPlatillo.DataSource = dt;
                dgv_agregarPlatillo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR"+ex);
            }
        }

        public void llenado_platillo()
        {
            try
            {
                com = new OdbcCommand("select nombrePlatillo from Platillo", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_Platillos.Items.Add(dr["nombrePlatillo"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //TOMA DE CANTIDAD Y TIPO DE MEDIDA DE INGREDIENTES
                string TipoMedidaBodega=null, TipoMedidaDetalle=null; string cantidadBodega=null, cantidadDetalle=null, iproducto=null;
                double cbodega = 0, cdetalle = 0, var=0;
                int varCambio=0;
                com = new OdbcCommand("select p.idPlatillo, p.nombrePlatillo, r.idReceta, r.nombre as Receta,  dri.productos_idProducto, tp.nombre as 'Tipo Producto', pr.idProducto, pr.descripcion as Producto, de.cantidad as CantidadBodega, tm.nombre as 'Tipo Medida Bodega', (dri.PesoOcantidad *"+ txt_cantPlatillos.Text +") as 'PesoOcantidad Detalle', tmm.nombre as 'Tipo Medida Detalle' from platillo p inner join receta r on p.receta_idReceta = r.idReceta inner join detallerecetaingrediente dri on dri.receta_idReceta = r.idReceta inner join productos pr on pr.idProducto = dri.productos_idProducto inner join tipoproducto tp on tp.idTipoProducto = pr.tipoProducto_idTipoProducto inner join detallebodega de on de.productos_idProducto = pr.idProducto inner join tipomedida tm on tm.idTipoMedida = de.tipoMedida_idTipoMedida inner join tipomedida tmm on tmm.idTipoMedida = dri.tipoMedida_idTipoMedida where p.nombrePlatillo = '" + cmb_Platillos.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    TipoMedidaBodega = dr["Tipo Medida Bodega"].ToString();
                    TipoMedidaDetalle = dr["Tipo Medida Detalle"].ToString();
                    cantidadBodega = dr["CantidadBodega"].ToString();
                    cantidadDetalle = dr["PesoOcantidad Detalle"].ToString();
                    iproducto = dr["producto"].ToString();
                    MessageBox.Show("PRODUCTO:   "+iproducto+ " | Cantidad en bodega:  " + cantidadBodega + " | Tipo Medida Bodega: " + TipoMedidaBodega + " |Cantidad en Pedido:  " + cantidadDetalle + "| Tipo Medida en Pedido:  " + TipoMedidaDetalle);
                    //conversion
                    cbodega = Convert.ToDouble(cantidadBodega);
                    cdetalle = Convert.ToDouble(cantidadDetalle);
                    var = conversion.convertir(cbodega,TipoMedidaBodega,cdetalle,TipoMedidaDetalle);
                    if (var < cbodega)
                    {
                        MessageBox.Show("Ingrediente "+iproducto+" si Disponible " + " | Cantidad en bodega: " + cbodega +" "+TipoMedidaBodega + " | Cantidad convertida:  " + var+" "+TipoMedidaBodega);
                        varCambio =0;
                    }
                    else { MessageBox.Show("Ingrediente "+iproducto+" no Disponible" + " | Cantidad en bodega:" + cbodega + " " + TipoMedidaBodega + " |Cantidad convertida: " + var+" " + TipoMedidaBodega); varCambio = +1; }
                }
                dr.Close();

                if (varCambio != 0)
                {
                    MessageBox.Show("PEDIDO NO ACEPTADO NO ACEPTADO NO ACEPTADO");
                }
                else
                {
                    //PLATILLO 
                    string platillo; int id_platillo = 0;
                    com = new OdbcCommand("select idPlatillo from platillo where nombrePlatillo ='" + cmb_Platillos.Text + "' ", con.conexion());
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        platillo = dr["idPlatillo"].ToString();
                        id_platillo = Convert.ToInt32(platillo);
                    }
                    dr.Close();
                    //TOMA DE CANTIDAD Y TIPO DE MEDIDA DE INGREDIENTES
                    string producto, iproducto2; int idProducto=0; 
                    com = new OdbcCommand("select p.idPlatillo, p.nombrePlatillo, r.idReceta, r.nombre as Receta,  dri.productos_idProducto, tp.nombre as 'Tipo Producto', pr.idProducto, pr.descripcion as Producto, de.cantidad as CantidadBodega, tm.nombre as 'Tipo Medida Bodega', (dri.PesoOcantidad *" + txt_cantPlatillos.Text + ") as 'PesoOcantidad Detalle', tmm.nombre as 'Tipo Medida Detalle' from platillo p inner join receta r on p.receta_idReceta = r.idReceta inner join detallerecetaingrediente dri on dri.receta_idReceta = r.idReceta inner join productos pr on pr.idProducto = dri.productos_idProducto inner join tipoproducto tp on tp.idTipoProducto = pr.tipoProducto_idTipoProducto inner join detallebodega de on de.productos_idProducto = pr.idProducto inner join tipomedida tm on tm.idTipoMedida = de.tipoMedida_idTipoMedida inner join tipomedida tmm on tmm.idTipoMedida = dri.tipoMedida_idTipoMedida where p.nombrePlatillo = '" + cmb_Platillos.Text + "' ", con.conexion());
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        TipoMedidaBodega = dr["Tipo Medida Bodega"].ToString();
                        TipoMedidaDetalle = dr["Tipo Medida Detalle"].ToString();
                        cantidadBodega = dr["CantidadBodega"].ToString();
                        cantidadDetalle = dr["PesoOcantidad Detalle"].ToString();
                        producto = dr["idProducto"].ToString();
                        idProducto = Convert.ToInt32(producto);
                        iproducto2 = dr["producto"].ToString();
                        //conversion
                        cbodega = Convert.ToDouble(cantidadBodega);
                        cdetalle = Convert.ToDouble(cantidadDetalle);
                        var = conversion.convertir(cbodega, TipoMedidaBodega, cdetalle, TipoMedidaDetalle);
                        //REBAJA DE INVENTARIO EN DETALLE BODEGA
                        com = new OdbcCommand("update detallebodega set cantidad=" + (Convert.ToDouble(cantidadBodega) - var) + " where productos_idProducto="+idProducto+" ", con.conexion());
                        com.ExecuteNonQuery();
                        MessageBox.Show("Ingrediente: "+iproducto+" |Nueva Cantidad en Bodega: "+ (Convert.ToDouble(cantidadBodega) - var)+" "+TipoMedidaBodega);
                    }
                    dr.Close();
                   
                    //INGRESO PEDIDO
                    com = new OdbcCommand("insert into detallepedidoplatillo (cantidadPlatillo, pedidoRestaurante_idPedido, platillo_idPlatillo) values (" + Convert.ToInt32(txt_cantPlatillos.Text) + "," + Convert.ToInt32(txt_noPedido.Text) + ", " + id_platillo + " )", con.conexion());
                    com.ExecuteNonQuery();

                    cmb_Platillos.Text = "SELECCIONE OPCION";
                    txt_cantPlatillos.Text = "";
                    mostrarPlatillos();
                    MessageBox.Show("Datos ingresados. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información." + ex.ToString());
            }
        }

        private void dgv_agregarPlatillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_agregarPlatillo.Rows[e.RowIndex];
                this.id_platillo= dgv.Cells[1].Value.ToString();
                cmb_Platillos.Text = dgv.Cells[1].Value.ToString();
                txt_cantPlatillos.Text = dgv.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //TOMA DE CANTIDAD Y TIPO DE MEDIDA DE INGREDIENTES
                string TipoMedidaBodega = null, TipoMedidaDetalle = null; string cantidadBodega = null, cantidadDetalle = null, iproducto = null;
                double cbodega = 0, cdetalle = 0, var = 0;
                int varCambio = 0;
                com = new OdbcCommand("select p.idPlatillo, p.nombrePlatillo, r.idReceta, r.nombre as Receta,  dri.productos_idProducto, tp.nombre as 'Tipo Producto', pr.idProducto, pr.descripcion as Producto, de.cantidad as CantidadBodega, tm.nombre as 'Tipo Medida Bodega', (dri.PesoOcantidad *" + txt_cantPlatillos.Text + ") as 'PesoOcantidad Detalle', tmm.nombre as 'Tipo Medida Detalle' from platillo p inner join receta r on p.receta_idReceta = r.idReceta inner join detallerecetaingrediente dri on dri.receta_idReceta = r.idReceta inner join productos pr on pr.idProducto = dri.productos_idProducto inner join tipoproducto tp on tp.idTipoProducto = pr.tipoProducto_idTipoProducto inner join detallebodega de on de.productos_idProducto = pr.idProducto inner join tipomedida tm on tm.idTipoMedida = de.tipoMedida_idTipoMedida inner join tipomedida tmm on tmm.idTipoMedida = dri.tipoMedida_idTipoMedida where p.nombrePlatillo = '" + cmb_Platillos.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    TipoMedidaBodega = dr["Tipo Medida Bodega"].ToString();
                    TipoMedidaDetalle = dr["Tipo Medida Detalle"].ToString();
                    cantidadBodega = dr["CantidadBodega"].ToString();
                    cantidadDetalle = dr["PesoOcantidad Detalle"].ToString();
                    iproducto = dr["producto"].ToString();
                    MessageBox.Show("PRODUCTO:   " + iproducto + " Tipo Medida Bodega: " + TipoMedidaBodega + " Cantidad:  " + cantidadBodega + " Tipo Medida Detalle:  " + TipoMedidaDetalle + " Cantidad:  " + cantidadDetalle);
                    //conversion
                    cbodega = Convert.ToDouble(cantidadBodega);
                    cdetalle = Convert.ToDouble(cantidadDetalle);
                    var = conversion.convertir(cbodega, TipoMedidaBodega, cdetalle, TipoMedidaDetalle);
                    if (var < cbodega)
                    {
                        MessageBox.Show("Ingrediente " + iproducto + " Disponible " + " Cantidad en bodega: " + cbodega + " Cantidad convertida:  " + var);
                        varCambio = 0;
                    }
                    else { MessageBox.Show("Ingrediente" + iproducto + " no Disponible" + " Cantidad en bodega:" + cbodega + " Cantidad convertida: " + var); varCambio = +1; }
                }
                dr.Close();

                if (varCambio != 0)
                {
                    MessageBox.Show("Pedido NO ACEPTADO NO ACEPTADO NO ACEPTADO");
                }
                else
                {
                    //TOMA DE CANTIDAD Y TIPO DE MEDIDA DE INGREDIENTES
                    string producto; int idProducto = 0;
                    com = new OdbcCommand("select p.idPlatillo, p.nombrePlatillo, r.idReceta, r.nombre as Receta,  dri.productos_idProducto, tp.nombre as 'Tipo Producto', pr.idProducto, pr.descripcion as Producto, de.cantidad as CantidadBodega, tm.nombre as 'Tipo Medida Bodega', (dri.PesoOcantidad *" + txt_cantPlatillos.Text + ") as 'PesoOcantidad Detalle', tmm.nombre as 'Tipo Medida Detalle' from platillo p inner join receta r on p.receta_idReceta = r.idReceta inner join detallerecetaingrediente dri on dri.receta_idReceta = r.idReceta inner join productos pr on pr.idProducto = dri.productos_idProducto inner join tipoproducto tp on tp.idTipoProducto = pr.tipoProducto_idTipoProducto inner join detallebodega de on de.productos_idProducto = pr.idProducto inner join tipomedida tm on tm.idTipoMedida = de.tipoMedida_idTipoMedida inner join tipomedida tmm on tmm.idTipoMedida = dri.tipoMedida_idTipoMedida where p.nombrePlatillo = '" + cmb_Platillos.Text + "' ", con.conexion());
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        TipoMedidaBodega = dr["Tipo Medida Bodega"].ToString();
                        TipoMedidaDetalle = dr["Tipo Medida Detalle"].ToString();
                        cantidadBodega = dr["CantidadBodega"].ToString();
                        cantidadDetalle = dr["PesoOcantidad Detalle"].ToString();
                        producto = dr["idProducto"].ToString();
                        idProducto = Convert.ToInt32(producto);
                        //conversion
                        cbodega = Convert.ToDouble(cantidadBodega);
                        cdetalle = Convert.ToDouble(cantidadDetalle);
                        var = conversion.convertir(cbodega, TipoMedidaBodega, cdetalle, TipoMedidaDetalle);
                        //REBAJA DE INVENTARIO EN DETALLE BODEGA
                        com = new OdbcCommand("update detallebodega set cantidad=" + (Convert.ToDouble(cantidadBodega) - var) + " where productos_idProducto=" + idProducto + " ", con.conexion());
                        com.ExecuteNonQuery();
                    }
                    dr.Close();

                    //PLATILLO 
                    string platillo; int id_platillos = 0;
                    com = new OdbcCommand("select idPlatillo from platillo where nombrePlatillo ='" + cmb_Platillos.Text + "' ", con.conexion());
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        platillo = dr["idPlatillo"].ToString();
                        id_platillos = Convert.ToInt32(platillo);
                    }
                    dr.Close();

                    //PLATILLO2
                    string platillo2; int id_platillos2 = 0;
                    com = new OdbcCommand("select idPlatillo from platillo where nombrePlatillo ='" + this.id_platillo + "' ", con.conexion());
                    dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        platillo2 = dr["idPlatillo"].ToString();
                        id_platillos2 = Convert.ToInt32(platillo2);
                    }
                    dr.Close();

                    com = new OdbcCommand("update detallepedidoplatillo set platillo_idPlatillo=" + id_platillos + ", cantidadPlatillo=" + Convert.ToInt32(txt_cantPlatillos.Text) + " where pedidoRestaurante_idPedido=" + Convert.ToInt32(txt_noPedido.Text) + " and platillo_idPlatillo=" + id_platillos2 + " ", con.conexion());
                    com.ExecuteNonQuery();

                    cmb_Platillos.Text = "SELECCIONE OPCION";
                    txt_cantPlatillos.Text = "";
                    mostrarPlatillos();
                    MessageBox.Show("Datos actualizados. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO actualizados, verifique la información. " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //PLATILLO 
                string platillo; int id_platillos = 0;
                com = new OdbcCommand("select idPlatillo from platillo where nombrePlatillo ='" + this.id_platillo + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    platillo = dr["idPlatillo"].ToString();
                    id_platillos = Convert.ToInt32(platillo);
                }
                dr.Close();

                com = new OdbcCommand("delete from detallepedidoplatillo where pedidoRestaurante_idPedido=" + Convert.ToInt32(txt_noPedido.Text) + " and platillo_idPlatillo="+id_platillos+" ", con.conexion());
                com.ExecuteNonQuery();

                cmb_Platillos.Text = "SELECCIONE OPCION";
                txt_cantPlatillos.Text = "";
                mostrarPlatillos();
                MessageBox.Show("Datos eliminados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados, verifique la información. " + ex.ToString());
            }
        }

        private void Agregar_platillos_Load(object sender, EventArgs e)
        {
            mostrarPlatillos();
        }
    }
}
