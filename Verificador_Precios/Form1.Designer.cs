﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoTienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escaner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoImg)).BeginInit();
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
            this.logoTienda.Size = new System.Drawing.Size(398, 231);
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
            this.nombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProducto.Location = new System.Drawing.Point(279, 478);
            this.nombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Size = new System.Drawing.Size(145, 52);
            this.nombreProducto.TabIndex = 3;
            this.nombreProducto.Text = "label2";
            this.nombreProducto.Visible = false;
            // 
            // productoImg
            // 
            this.productoImg.Location = new System.Drawing.Point(856, 378);
            this.productoImg.Name = "productoImg";
            this.productoImg.Size = new System.Drawing.Size(244, 223);
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
            this.precioProducto.Location = new System.Drawing.Point(284, 581);
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.Size = new System.Drawing.Size(51, 20);
            this.precioProducto.TabIndex = 5;
            this.precioProducto.Text = "label3";
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.AutoSize = true;
            this.cantidadProducto.Location = new System.Drawing.Point(334, 617);
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.Size = new System.Drawing.Size(51, 20);
            this.cantidadProducto.TabIndex = 6;
            this.cantidadProducto.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.cantidadProducto);
            this.Controls.Add(this.precioProducto);
            this.Controls.Add(this.productoImg);
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
    }
}
