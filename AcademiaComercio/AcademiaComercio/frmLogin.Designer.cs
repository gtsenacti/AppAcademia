namespace AcademiaComercio
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblTitulo = new Label();
            lblUusuário = new Label();
            lblSenha = new Label();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            btnSair = new Button();
            button1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(220, 116);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(246, 23);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(220, 173);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(246, 23);
            txtSenha.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Black;
            lblTitulo.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(241, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(199, 48);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Aplicativo \r\n               Academia";
            // 
            // lblUusuário
            // 
            lblUusuário.AutoSize = true;
            lblUusuário.BackColor = Color.Black;
            lblUusuário.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUusuário.ForeColor = Color.White;
            lblUusuário.Location = new Point(219, 96);
            lblUusuário.Name = "lblUusuário";
            lblUusuário.Size = new Size(75, 19);
            lblUusuário.TabIndex = 4;
            lblUusuário.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Black;
            lblSenha.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(223, 153);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(64, 19);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoAcademia;
            pictureBox1.Location = new Point(28, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.MediumSeaGreen;
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatAppearance.BorderColor = Color.DarkGreen;
            btnEntrar.FlatAppearance.BorderSize = 2;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntrar.Location = new Point(304, 237);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(162, 49);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextAlign = ContentAlignment.MiddleRight;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.LightCoral;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderColor = Color.Red;
            btnSair.FlatAppearance.BorderSize = 2;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.ActiveCaptionText;
            btnSair.Location = new Point(28, 237);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(102, 49);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.TextAlign = ContentAlignment.MiddleRight;
            btnSair.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.MediumBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(136, 237);
            button1.Name = "button1";
            button1.Size = new Size(162, 49);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Location = new Point(0, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 81);
            panel1.TabIndex = 10;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(489, 304);
            Controls.Add(button1);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Controls.Add(lblSenha);
            Controls.Add(lblUusuário);
            Controls.Add(lblTitulo);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "Aplicativo Academia - Tela Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblTitulo;
        private Label lblUusuário;
        private Label lblSenha;
        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Button btnSair;
        private Button button1;
        private Panel panel1;
    }
}
