namespace programacion_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelusuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxusuario = new System.Windows.Forms.TextBox();
            this.textBoxcontra = new System.Windows.Forms.TextBox();
            this.buttoningresar = new System.Windows.Forms.Button();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelusuario
            // 
            this.labelusuario.Location = new System.Drawing.Point(92, 96);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(75, 23);
            this.labelusuario.TabIndex = 0;
            this.labelusuario.Text = "usuario";
            this.labelusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(92, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "contreseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxusuario
            // 
            this.textBoxusuario.Location = new System.Drawing.Point(225, 96);
            this.textBoxusuario.Name = "textBoxusuario";
            this.textBoxusuario.Size = new System.Drawing.Size(260, 20);
            this.textBoxusuario.TabIndex = 2;
            // 
            // textBoxcontra
            // 
            this.textBoxcontra.Location = new System.Drawing.Point(225, 143);
            this.textBoxcontra.Name = "textBoxcontra";
            this.textBoxcontra.PasswordChar = '-';
            this.textBoxcontra.Size = new System.Drawing.Size(260, 20);
            this.textBoxcontra.TabIndex = 3;
            // 
            // buttoningresar
            // 
            this.buttoningresar.Location = new System.Drawing.Point(310, 207);
            this.buttoningresar.Name = "buttoningresar";
            this.buttoningresar.Size = new System.Drawing.Size(93, 46);
            this.buttoningresar.TabIndex = 4;
            this.buttoningresar.Text = "ingresar";
            this.buttoningresar.UseVisualStyleBackColor = true;
            this.buttoningresar.Click += new System.EventHandler(this.buttoningresar_Click);
            // 
            // labeltitulo
            // 
            this.labeltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.Location = new System.Drawing.Point(249, 9);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(209, 35);
            this.labeltitulo.TabIndex = 5;
            this.labeltitulo.Text = "ingrese sus datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeltitulo);
            this.Controls.Add(this.buttoningresar);
            this.Controls.Add(this.textBoxcontra);
            this.Controls.Add(this.textBoxusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelusuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxusuario;
        private System.Windows.Forms.TextBox textBoxcontra;
        private System.Windows.Forms.Button buttoningresar;
        private System.Windows.Forms.Label labeltitulo;
    }
}

