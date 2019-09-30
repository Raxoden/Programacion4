using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formas;


namespace Figuras
{
    public partial class frmFiguras : Form
    {
        public frmFiguras()
        {
            InitializeComponent();
        }

        private void FrmFiguras_Load(object sender, EventArgs e)
        {
            cbFiguras.SelectedIndex = 0;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int opcion = cbFiguras.SelectedIndex;
            switch (opcion)
            {
                case 0:
                    if (txtLado1.Text != String.Empty)
                    {
                        Formas.Cuadrado cuadrado = new Formas.Cuadrado(Convert.ToDouble(txtLado1.Text));
                        resArea.Text = Convert.ToString(cuadrado.calcularArea());
                        resPerimetro.Text = Convert.ToString(cuadrado.calcularPerimetro());
                    }
                    else
                    {
                        MessageBox.Show("Debe digitar el valor solicitado.");
                    }
                    break;
                case 1:
                    if (txtLado1.Text != String.Empty && txtLado2.Text != String.Empty)
                    {
                        Formas.Rectangulo rectangulo = new Formas.Rectangulo(Convert.ToDouble(txtLado1.Text), Convert.ToDouble(txtLado2.Text));
                        resArea.Text = Convert.ToString(rectangulo.calcularArea());
                        resPerimetro.Text = Convert.ToString(rectangulo.calcularPerimetro());
                    }
                    else
                    {
                        MessageBox.Show("Debe digitar el valor solicitado.");
                    }
                    break;
                case 2:
                    if (txtLado1.Text != String.Empty && txtLado2.Text != String.Empty && txtLado3.Text != String.Empty && txtLado4.Text != String.Empty)
                    {
                        Formas.Triangulo triangulo = new Formas.Triangulo(Convert.ToDouble(txtLado1.Text), Convert.ToDouble(txtLado2.Text), Convert.ToDouble(txtLado3.Text), Convert.ToDouble(txtLado4.Text));
                        resArea.Text = Convert.ToString(triangulo.calcularArea());
                        resPerimetro.Text = Convert.ToString(triangulo.calcularPerimetro());
                    }
                    else
                    {
                        MessageBox.Show("Debe digitar el valor solicitado.");
                    }
                    break;
                case 3:
                    if (txtLado1.Text != String.Empty)
                    {
                        Formas.Circulo circulo = new Formas.Circulo(Convert.ToDouble(txtLado1.Text));
                        resArea.Text = Convert.ToString(circulo.calcularArea());
                        resPerimetro.Text = Convert.ToString(circulo.calcularPerimetro());
                    }
                    else
                    {
                        MessageBox.Show("Debe digitar el valor solicitado.");
                    }
                    break;
                default:
                    break;
            }
        }

        /*
         * Funcion para ocultar/mostrar campos segun se necesite. 
         */
        public void visibilidadCampos(Boolean vis,Boolean vis2)
        {
            lblLado3.Visible = vis;
            lblLado4.Visible = vis;
            txtLado3.Visible = vis;
            txtLado4.Visible = vis;
            lblLado2.Visible = vis2;
            txtLado2.Visible = vis2;
        }

        private void CbFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcion = cbFiguras.SelectedIndex;
            switch (opcion)
            {
                case 0:
                    visibilidadCampos(false, false);
                    lblLado1.Text = "Lado:";
                    break;
                case 1:
                    visibilidadCampos(false, true);
                    lblLado1.Text = "Largo:";
                    lblLado2.Text = "Ancho:";
                    break;
                case 2:
                    visibilidadCampos(false, false);
                    lblLado1.Text = "Radio:";
                    break;
                case 3:
                    visibilidadCampos(true, true);
                    lblLado1.Text = "Base(Lado 1):";
                    lblLado2.Text = "Altura:";
                    lblLado3.Text = "Lado 2:";
                    lblLado4.Text = "Lado 3:";
                    break;
                default:
                    break;
            }
        }
    }
}
