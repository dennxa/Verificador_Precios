
namespace Verificador_Precios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.logoTienda = new System.Windows.Forms.PictureBox();
            this.bienvenida = new System.Windows.Forms.Label();
            this.escaner = new System.Windows.Forms.PictureBox();
            this.nombreProducto = new System.Windows.Forms.Label();
            this.productoImg = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.precioProducto = new System.Windows.Forms.Label();
            this.cantidadProducto = new System.Windows.Forms.Label();
            this.flechitas = new System.Windows.Forms.PictureBox();
            this.fondoImg = new System.Windows.Forms.PictureBox();
            this.danger = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escaner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flechitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // logoTienda
            // 
            this.logoTienda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoTienda.BackgroundImage")));
            this.logoTienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoTienda.Location = new System.Drawing.Point(395, 14);
            this.logoTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoTienda.Name = "logoTienda";
            this.logoTienda.Size = new System.Drawing.Size(299, 299);
            this.logoTienda.TabIndex = 0;
            this.logoTienda.TabStop = false;
            // 
            // bienvenida
            // 
            this.bienvenida.AutoSize = true;
            this.bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienvenida.Location = new System.Drawing.Point(-2, 285);
            this.bienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bienvenida.Name = "bienvenida";
            this.bienvenida.Size = new System.Drawing.Size(1222, 52);
            this.bienvenida.TabIndex = 1;
            this.bienvenida.Text = "Bienvenido! Pase por favor por el sensor el codigo a escanear";
            this.bienvenida.Click += new System.EventHandler(this.label1_Click);
            // 
            // escaner
            // 
            this.escaner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("escaner.BackgroundImage")));
            this.escaner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.escaner.Image = ((System.Drawing.Image)(resources.GetObject("escaner.Image")));
            this.escaner.Location = new System.Drawing.Point(432, 365);
            this.escaner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.escaner.Name = "escaner";
            this.escaner.Size = new System.Drawing.Size(401, 272);
            this.escaner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.escaner.TabIndex = 2;
            this.escaner.TabStop = false;
            // 
            // nombreProducto
            // 
            this.nombreProducto.AutoSize = true;
            this.nombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombreProducto.Location = new System.Drawing.Point(279, 478);
            this.nombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Size = new System.Drawing.Size(605, 82);
            this.nombreProducto.TabIndex = 3;
            this.nombreProducto.Text = "Nombre producto";
            this.nombreProducto.Visible = false;
            // 
            // productoImg
            // 
            this.productoImg.Location = new System.Drawing.Point(373, 148);
            this.productoImg.Name = "productoImg";
            this.productoImg.Size = new System.Drawing.Size(340, 308);
            this.productoImg.TabIndex = 4;
            this.productoImg.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // precioProducto
            // 
            this.precioProducto.AutoSize = true;
            this.precioProducto.Font = new System.Drawing.Font("BIZ UDPGothic", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioProducto.Location = new System.Drawing.Point(88, 535);
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.Size = new System.Drawing.Size(283, 72);
            this.precioProducto.TabIndex = 5;
            this.precioProducto.Text = "Precio";
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.AutoSize = true;
            this.cantidadProducto.Font = new System.Drawing.Font("BIZ UDPGothic", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadProducto.Location = new System.Drawing.Point(334, 617);
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.Size = new System.Drawing.Size(379, 72);
            this.cantidadProducto.TabIndex = 6;
            this.cantidadProducto.Text = "cantidad";
            // 
            // flechitas
            // 
            this.flechitas.BackColor = System.Drawing.Color.Transparent;
            this.flechitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flechitas.BackgroundImage")));
            this.flechitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flechitas.Location = new System.Drawing.Point(878, 148);
            this.flechitas.Name = "flechitas";
            this.flechitas.Size = new System.Drawing.Size(272, 117);
            this.flechitas.TabIndex = 7;
            this.flechitas.TabStop = false;
            // 
            // fondoImg
            // 
            this.fondoImg.BackColor = System.Drawing.Color.Transparent;
            this.fondoImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fondoImg.BackgroundImage")));
            this.fondoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fondoImg.Location = new System.Drawing.Point(184, 109);
            this.fondoImg.Name = "fondoImg";
            this.fondoImg.Size = new System.Drawing.Size(720, 380);
            this.fondoImg.TabIndex = 8;
            this.fondoImg.TabStop = false;
            // 
            // danger
            // 
            this.danger.BackColor = System.Drawing.Color.Transparent;
            this.danger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("danger.BackgroundImage")));
            this.danger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.danger.Location = new System.Drawing.Point(840, 397);
            this.danger.Name = "danger";
            this.danger.Size = new System.Drawing.Size(280, 240);
            this.danger.TabIndex = 9;
            this.danger.TabStop = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(511, 201);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(1182, 82);
            this.back.TabIndex = 10;
            this.back.Text = "Regresando a la ventana de inicio...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1743, 82);
            this.label1.TabIndex = 11;
            this.label1.Text = "Lo sentimos :( parece que hay un error en el producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 82);
            this.label2.TabIndex = 12;
            this.label2.Text = "solicitado.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1821, 82);
            this.label3.TabIndex = 13;
            this.label3.Text = "Intentelo nuevamente y en caso de seguir acuda al area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(717, 82);
            this.label4.TabIndex = 14;
            this.label4.Text = "de Servicio al cliente.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.danger);
            this.Controls.Add(this.productoImg);
            this.Controls.Add(this.fondoImg);
            this.Controls.Add(this.flechitas);
            this.Controls.Add(this.cantidadProducto);
            this.Controls.Add(this.precioProducto);
            this.Controls.Add(this.nombreProducto);
            this.Controls.Add(this.escaner);
            this.Controls.Add(this.bienvenida);
            this.Controls.Add(this.logoTienda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escaner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flechitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox logoTienda;
        private System.Windows.Forms.Label bienvenida;
        private System.Windows.Forms.PictureBox escaner;
        private System.Windows.Forms.Label nombreProducto;
        private System.Windows.Forms.PictureBox productoImg;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label cantidadProducto;
        private System.Windows.Forms.Label precioProducto;
        private System.Windows.Forms.PictureBox flechitas;
        private System.Windows.Forms.PictureBox fondoImg;
        private System.Windows.Forms.PictureBox danger;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

