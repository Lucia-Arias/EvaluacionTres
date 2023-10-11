namespace AaAaAaA
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
            this.btInicio = new System.Windows.Forms.Button();
            this.lbLb = new System.Windows.Forms.Label();
            this.btCrear = new System.Windows.Forms.Button();
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.lbObligatorio2 = new System.Windows.Forms.Label();
            this.lbObligatorio1 = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.llb2 = new System.Windows.Forms.LinkLabel();
            this.llb1 = new System.Windows.Forms.LinkLabel();
            this.lbPreguntas = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbBienvenido = new System.Windows.Forms.Label();
            this.gbCrear = new System.Windows.Forms.GroupBox();
            this.gbInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btInicio
            // 
            this.btInicio.BackColor = System.Drawing.Color.Gray;
            this.btInicio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicio.ForeColor = System.Drawing.Color.Black;
            this.btInicio.Location = new System.Drawing.Point(542, 65);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(187, 38);
            this.btInicio.TabIndex = 0;
            this.btInicio.Text = "INICIAR SESIÓN";
            this.btInicio.UseVisualStyleBackColor = false;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click_1);
            // 
            // lbLb
            // 
            this.lbLb.AutoSize = true;
            this.lbLb.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLb.Location = new System.Drawing.Point(12, 33);
            this.lbLb.Name = "lbLb";
            this.lbLb.Size = new System.Drawing.Size(272, 72);
            this.lbLb.TabIndex = 1;
            this.lbLb.Text = "LucyBell";
            // 
            // btCrear
            // 
            this.btCrear.BackColor = System.Drawing.Color.Gray;
            this.btCrear.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrear.ForeColor = System.Drawing.Color.Black;
            this.btCrear.Location = new System.Drawing.Point(542, 141);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(187, 38);
            this.btCrear.TabIndex = 2;
            this.btCrear.Text = "CREAR CUENTA";
            this.btCrear.UseVisualStyleBackColor = false;
            // 
            // gbInicio
            // 
            this.gbInicio.BackColor = System.Drawing.Color.DarkGray;
            this.gbInicio.Controls.Add(this.lbObligatorio2);
            this.gbInicio.Controls.Add(this.lbObligatorio1);
            this.gbInicio.Controls.Add(this.btIniciar);
            this.gbInicio.Controls.Add(this.llb2);
            this.gbInicio.Controls.Add(this.llb1);
            this.gbInicio.Controls.Add(this.lbPreguntas);
            this.gbInicio.Controls.Add(this.tbContraseña);
            this.gbInicio.Controls.Add(this.lbContraseña);
            this.gbInicio.Controls.Add(this.tbCorreo);
            this.gbInicio.Controls.Add(this.lbCorreo);
            this.gbInicio.Location = new System.Drawing.Point(92, 141);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Size = new System.Drawing.Size(283, 297);
            this.gbInicio.TabIndex = 3;
            this.gbInicio.TabStop = false;
            this.gbInicio.Visible = false;
            // 
            // lbObligatorio2
            // 
            this.lbObligatorio2.AutoSize = true;
            this.lbObligatorio2.BackColor = System.Drawing.Color.Red;
            this.lbObligatorio2.ForeColor = System.Drawing.Color.Black;
            this.lbObligatorio2.Location = new System.Drawing.Point(6, 161);
            this.lbObligatorio2.Name = "lbObligatorio2";
            this.lbObligatorio2.Size = new System.Drawing.Size(98, 13);
            this.lbObligatorio2.TabIndex = 9;
            this.lbObligatorio2.Text = "* Campo obligatorio";
            this.lbObligatorio2.Visible = false;
            // 
            // lbObligatorio1
            // 
            this.lbObligatorio1.AutoEllipsis = true;
            this.lbObligatorio1.AutoSize = true;
            this.lbObligatorio1.BackColor = System.Drawing.Color.Red;
            this.lbObligatorio1.ForeColor = System.Drawing.Color.Black;
            this.lbObligatorio1.Location = new System.Drawing.Point(6, 74);
            this.lbObligatorio1.Name = "lbObligatorio1";
            this.lbObligatorio1.Size = new System.Drawing.Size(98, 13);
            this.lbObligatorio1.TabIndex = 8;
            this.lbObligatorio1.Text = "* Campo obligatorio";
            this.lbObligatorio1.Visible = false;
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.Color.Gray;
            this.btIniciar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciar.Location = new System.Drawing.Point(81, 243);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(126, 34);
            this.btIniciar.TabIndex = 7;
            this.btIniciar.Text = "INICIAR SESIÓN";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click_1);
            // 
            // llb2
            // 
            this.llb2.ActiveLinkColor = System.Drawing.Color.Red;
            this.llb2.AutoSize = true;
            this.llb2.DisabledLinkColor = System.Drawing.Color.Fuchsia;
            this.llb2.LinkColor = System.Drawing.Color.Blue;
            this.llb2.Location = new System.Drawing.Point(212, 227);
            this.llb2.Name = "llb2";
            this.llb2.Size = new System.Drawing.Size(33, 13);
            this.llb2.TabIndex = 6;
            this.llb2.TabStop = true;
            this.llb2.Text = "AQUÍ";
            // 
            // llb1
            // 
            this.llb1.ActiveLinkColor = System.Drawing.Color.Red;
            this.llb1.AutoSize = true;
            this.llb1.DisabledLinkColor = System.Drawing.Color.Fuchsia;
            this.llb1.LinkColor = System.Drawing.Color.Blue;
            this.llb1.Location = new System.Drawing.Point(230, 190);
            this.llb1.Name = "llb1";
            this.llb1.Size = new System.Drawing.Size(33, 13);
            this.llb1.TabIndex = 5;
            this.llb1.TabStop = true;
            this.llb1.Text = "AQUÍ";
            // 
            // lbPreguntas
            // 
            this.lbPreguntas.AutoSize = true;
            this.lbPreguntas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreguntas.Location = new System.Drawing.Point(40, 186);
            this.lbPreguntas.Name = "lbPreguntas";
            this.lbPreguntas.Size = new System.Drawing.Size(189, 54);
            this.lbPreguntas.TabIndex = 4;
            this.lbPreguntas.Text = "¿Olvidaste tu contraseña?\r\n\r\n¿No tienes una cuenta?";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.ForeColor = System.Drawing.Color.Gray;
            this.tbContraseña.Location = new System.Drawing.Point(6, 132);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(271, 26);
            this.tbContraseña.TabIndex = 3;
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContraseña.Location = new System.Drawing.Point(28, 102);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(136, 27);
            this.lbContraseña.TabIndex = 2;
            this.lbContraseña.Text = "Contraseña";
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.ForeColor = System.Drawing.Color.Gray;
            this.tbCorreo.Location = new System.Drawing.Point(6, 45);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(271, 26);
            this.tbCorreo.TabIndex = 1;
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.Location = new System.Drawing.Point(28, 15);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(210, 27);
            this.lbCorreo.TabIndex = 0;
            this.lbCorreo.Text = "Correo Electrónico";
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.AutoSize = true;
            this.lbBienvenido.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.Location = new System.Drawing.Point(213, 195);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(377, 75);
            this.lbBienvenido.TabIndex = 4;
            this.lbBienvenido.Text = "Bienvenido";
            this.lbBienvenido.Visible = false;
            // 
            // gbCrear
            // 
            this.gbCrear.BackColor = System.Drawing.Color.DarkGray;
            this.gbCrear.Location = new System.Drawing.Point(421, 12);
            this.gbCrear.Name = "gbCrear";
            this.gbCrear.Size = new System.Drawing.Size(308, 440);
            this.gbCrear.TabIndex = 5;
            this.gbCrear.TabStop = false;
            this.gbCrear.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbCrear);
            this.Controls.Add(this.gbInicio);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.lbLb);
            this.Controls.Add(this.btInicio);
            this.Controls.Add(this.lbBienvenido);
            this.Name = "Form1";
            this.Text = "LucyBell";
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Label lbLb;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbPreguntas;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.LinkLabel llb1;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.LinkLabel llb2;
        private System.Windows.Forms.Label lbBienvenido;
        private System.Windows.Forms.GroupBox gbCrear;
        private System.Windows.Forms.Label lbObligatorio1;
        private System.Windows.Forms.Label lbObligatorio2;
    }
}

