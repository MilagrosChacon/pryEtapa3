namespace pryEtapa3
{
    partial class frmVehiculo
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
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.btnAvion = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnBarco = new System.Windows.Forms.Button();
            this.pctVehiculo = new System.Windows.Forms.PictureBox();
            this.lblNombreVehiculo = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::pryEtapa3.Properties.Resources.logo;
            this.pctLogo.Location = new System.Drawing.Point(220, -11);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(120, 120);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(50, 100);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(476, 21);
            this.lblInstruccion.TabIndex = 1;
            this.lblInstruccion.Text = "Por favor, selecciona la opción Crear Vehiculo para comenzar.";
            // 
            // btnAvion
            // 
            this.btnAvion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAvion.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvion.Location = new System.Drawing.Point(220, 139);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(120, 29);
            this.btnAvion.TabIndex = 2;
            this.btnAvion.Text = "Avión";
            this.btnAvion.UseVisualStyleBackColor = true;
            // 
            // btnAuto
            // 
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(94, 139);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(120, 29);
            this.btnAuto.TabIndex = 3;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            // 
            // btnBarco
            // 
            this.btnBarco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBarco.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarco.Location = new System.Drawing.Point(346, 139);
            this.btnBarco.Name = "btnBarco";
            this.btnBarco.Size = new System.Drawing.Size(120, 29);
            this.btnBarco.TabIndex = 4;
            this.btnBarco.Text = "Barco";
            this.btnBarco.UseVisualStyleBackColor = true;
            // 
            // pctVehiculo
            // 
            this.pctVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.pctVehiculo.Location = new System.Drawing.Point(128, 186);
            this.pctVehiculo.Name = "pctVehiculo";
            this.pctVehiculo.Size = new System.Drawing.Size(300, 300);
            this.pctVehiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVehiculo.TabIndex = 5;
            this.pctVehiculo.TabStop = false;
            // 
            // lblNombreVehiculo
            // 
            this.lblNombreVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreVehiculo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVehiculo.Location = new System.Drawing.Point(217, 479);
            this.lblNombreVehiculo.Name = "lblNombreVehiculo";
            this.lblNombreVehiculo.Size = new System.Drawing.Size(123, 23);
            this.lblNombreVehiculo.TabIndex = 6;
            this.lblNombreVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(217, 502);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(123, 23);
            this.lblTipoVehiculo.TabIndex = 7;
            this.lblTipoVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEtapa3.Properties.Resources.frmInicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.lblTipoVehiculo);
            this.Controls.Add(this.lblNombreVehiculo);
            this.Controls.Add(this.pctVehiculo);
            this.Controls.Add(this.btnBarco);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.pctLogo);
            this.MaximizeBox = false;
            this.Name = "frmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear vehículo";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Button btnAvion;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnBarco;
        private System.Windows.Forms.PictureBox pctVehiculo;
        private System.Windows.Forms.Label lblNombreVehiculo;
        private System.Windows.Forms.Label lblTipoVehiculo;
    }
}

