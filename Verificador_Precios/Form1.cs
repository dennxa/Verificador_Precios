using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verificador_Precios
{
    public partial class Form1 : Form
    {
        private int segundos = 0;

        private String codigo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logoTienda.Location = new Point(this.Width / 2 - logoTienda.Width / 2, 20);
            bienvenida.Location = new Point(this.Width / 2 - bienvenida.Width / 2, logoTienda.Height + 60);
            escaner.Location = new Point(this.Width/2 - escaner.Width/2, bienvenida.Height + 280);
            flechitas.Location = new Point(this.Width / 2 - flechitas.Width / 2, escaner.Height + 350);
            nombreProducto.Visible = false;
            productoImg.Visible = false;
            precioProducto.Visible = false;
            cantidadProducto.Visible = false;
            fondoImg.Visible = false;
            danger.Visible = false;
            back.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //MessageBox.Show("vamos a buscar el producto "+codigo);
                try
                {
                    MySqlConnection servidor;
                    servidor = new MySqlConnection("server = 127.0.0.1; user = root; database = verificador_precios; SSL Mode = None; ");
                    servidor.Open();
                    string query = "SELECT producto_nombre, producto_precio, producto_stock, producto_imagen FROM productos WHERE producto_codigo =" + codigo + ";";
                    //MessageBox.Show(query);
                    MySqlCommand consulta;
                    consulta = new MySqlCommand(query, servidor);
                    MySqlDataReader resultado = consulta.ExecuteReader();
                    if (resultado.HasRows)
                    {
                        resultado.Read();
                        //MessageBox.Show(resultado.GetString(1));
                        nombreProducto.Visible = true;
                        precioProducto.Visible = true;
                        cantidadProducto.Visible = true;
                        fondoImg.Visible = true;
                        productoImg.Visible = true;

                        escaner.Visible = false;
                        bienvenida.Visible = false;
                        flechitas.Visible = false;
                        danger.Visible = false;
                        back.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        label3.Visible = false;
                        label4.Visible = false;


                        logoTienda.Location = new Point(this.Width - 250, 20);
                        
                        nombreProducto.Location = new Point(30,logoTienda.Height/2);
                        nombreProducto.Text = resultado.GetString(0);
                        
                        fondoImg.Location = new Point(30, logoTienda.Height+100);
                        productoImg.ImageLocation = resultado.GetString(3);
                        productoImg.SizeMode = PictureBoxSizeMode.StretchImage;
                        productoImg.Location = new Point(fondoImg.Width/2-productoImg.Width/2+30,320 );

                        precioProducto.Location = new Point(this.Width/2-20, fondoImg.Height+precioProducto.Height);
                        precioProducto.Text = "Precio: $" + resultado.GetString(1) + " pesos";

                        cantidadProducto.Location = new Point(this.Width / 2 - 20, fondoImg.Height + fondoImg.Height-cantidadProducto.Height);
                        cantidadProducto.Text = "Disponibles: " + resultado.GetString(2);
                        

                        segundos = 0;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        //MessageBox.Show("Llame al supervisor, el producto no fue encontrado");

                        escaner.Visible = false;
                        bienvenida.Visible = false;
                        flechitas.Visible = false;
                        nombreProducto.Visible = false;
                        precioProducto.Visible = false;
                        cantidadProducto.Visible = false;
                        fondoImg.Visible = false;
                        productoImg.Visible = false;

                        logoTienda.Visible = true;
                        logoTienda.Location = new Point(this.Width / 2 - logoTienda.Width / 2, 20);

                        danger.Visible = true;
                        danger.Location = new Point(this.Width / 2 - danger.Width / 2, this.Height-danger.Height-back.Height-40);
                        
                        back.Visible = true;
                        back.Location = new Point(this.Width-back.Width, this.Height - 100);

                        label1.Visible = true;
                        label1.Location = new Point(this.Width/2 - label1.Width/2, logoTienda.Height+40);

                        label2.Visible = true;
                        label2.Location = new Point(this.Width / 2 - label2.Width / 2, logoTienda.Height + label1.Height+40);

                        label3.Visible = true;
                        label3.Location = new Point(this.Width / 2 - label3.Width / 2, logoTienda.Height + label1.Height + label2.Height+40);

                        label4.Visible = true;
                        label4.Location = new Point(this.Width / 2 - label4.Width / 2, logoTienda.Height + label3.Height + label2.Height +label3.Height+ 40);

                        segundos = 0;
                        timer1.Enabled = true;
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString(), "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
                codigo = "";
            }
            else
            {
                codigo += e.KeyChar;
            }
        }

		private void timer1_Tick(object sender, EventArgs e)
		{
            segundos++;

            if (segundos == 4)
            {
                logoTienda.Location = new Point(this.Width / 2 - logoTienda.Width / 2, 20);
                timer1.Enabled = false;
                escaner.Visible = true;
                productoImg.Visible = false;
                logoTienda.Visible = true;
                bienvenida.Visible = true;
                flechitas.Visible = true;
                precioProducto.Visible = false;
                cantidadProducto.Visible = false;
                fondoImg.Visible = false;
                nombreProducto.Text = "";
                
                back.Visible = false;
                danger.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}