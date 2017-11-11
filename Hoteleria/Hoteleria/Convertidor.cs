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
    public partial class frm_Convertidor : Form
    {
        string de, a;
        public frm_Convertidor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Convertidor_Load(object sender, EventArgs e)
        {

        }

        private void btn_Convertir_Click(object sender, EventArgs e)
        {

            double kiloAlibra = 2.20462, kilogAgramo = 1000, kilogAonza = 35.274, kiloAton = 0.001,
            libraAgramo = 453.592, libraAonza = 16, libraAkilo = 0.453592, libraAton = 0.000453592,
            gramoAlibra = 0.00220462, gramoAonza = 0.035274, gramoAkilog = 0.001, gramoAton = 0.000001,
            onzaAlibra = 0.0625, onzaAgramos = 28.3495, onzaAkilog = 0.0283495, onzaAton = 0.0000283495,
            tonAlibra = 2204.62, tonAkilog = 1000, tonAgramo = 1000000, tonAonza = 35273.96185,
            litroAml = 1000, litroAgalon = 0.264172, mlAlitro = 0.001, mlAgalon = 0.000264172,
            galonAlitro = 3.78541, galonAml = 3785.41;
            try {
                de = cmb_De.SelectedItem.ToString();
                a = cmb_A.SelectedItem.ToString();

                //MASA
                if (de == "Kilogramos" && a == "Libras")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * kiloAlibra);
                    lb_medida.Text = "lb";
                }
                else if (de == "Kilogramos" && a == "Gramos")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * kilogAgramo);
                    lb_medida.Text = "g";
                }
                else if (de == "Kilogramos" && a == "Onzas")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * kilogAonza);
                    lb_medida.Text = "oz";
                }
                else if (de == "Kilogramos" && a == "Toneladas")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * kiloAton);
                    lb_medida.Text = "t";
                }
                else if (de == "Libras" && a == "Kilogramos")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * libraAkilo);
                    lb_medida.Text = "kg";
                }
                else if (de == "Libras" && a == "Gramos")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * libraAgramo);
                    lb_medida.Text = "g";
                }
                else if (de == "Libras" && a == "Onzas")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * libraAonza);
                    lb_medida.Text = "oz";
                }
                else if (de == "Libras" && a == "Toneladas")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * libraAton);
                    lb_medida.Text = "t";
                }
                else if (de == "Gramos" && a == "Kilogramos")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * gramoAkilog);
                    lb_medida.Text = "kg";
                }
                else if (de == "Gramos" && a == "Libras")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * gramoAlibra);
                    lb_medida.Text = "lb";
                }
                else if (de == "Gramos" && a == "Onzas")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * gramoAonza);
                    lb_medida.Text = "oz";
                }
                else if (de == "Gramos" && a == "Toneladas")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * gramoAton);
                    lb_medida.Text = "t";
                }
                else if (de == "Onzas" && a == "Kilogramos")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * onzaAkilog);
                    lb_medida.Text = "kg";
                }
                else if (de == "Onzas" && a == "Libras")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * onzaAlibra);
                    lb_medida.Text = "lb";
                }
                else if (de == "Onzas" && a == "Gramos")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * onzaAgramos);
                    lb_medida.Text = "g";
                }
                else if (de == "Onzas" && a == "Toneladas")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * onzaAton);
                    lb_medida.Text = "t";
                }
                else if (de == "Toneladas" && a == "Libras")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * tonAlibra);
                    lb_medida.Text = "lb";
                }
                else if (de == "Toneladas" && a == "Kilogramos")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * tonAkilog);
                    lb_medida.Text = "kg";
                }
                else if (de == "Toneladas" && a == "Gramos")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * tonAgramo);
                    lb_medida.Text = "g";
                }
                else if (de == "Toneladas" && a == "Onzas")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * tonAonza);
                    lb_medida.Text = "oz";
                }
                //LIQUIDOS
                else if (de == "Litros" && a == "Mililitros")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * litroAml);
                    lb_medida.Text = "ml";
                }
                else if (de == "Litros" && a == "Galones")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * litroAgalon);
                    lb_medida.Text = "Galones";
                }
                else if (de == "Mililitros" && a == "Litros")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * mlAlitro);
                    lb_medida.Text = "L";
                }
                else if (de == "Mililitros" && a == "Galones")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * mlAgalon);
                    lb_medida.Text = "Galones";
                }
                else if (de == "Galones" && a == "Litros")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * galonAlitro);
                    lb_medida.Text = "L";
                }
                else if (de == "Galones" && a == "Mililitros")
                {
                    lb_resultado.Text = Convert.ToString(Convert.ToDouble(txt_Cantidad.Text) * galonAml);
                    lb_medida.Text = "ml";
                }
                else if (de == a)
                {
                    lb_resultado.Text = txt_Cantidad.Text;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }

        private void txt_Intercambiar_Click(object sender, EventArgs e)
        {
            string aux;
            try
            {
                aux = cmb_De.Text;
                cmb_De.Text = cmb_A.Text;
                cmb_A.Text = aux;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
