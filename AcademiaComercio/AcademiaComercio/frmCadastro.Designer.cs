namespace AcademiaComercio
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvCadastrarColaborador = new DataGridView();
            gbCadastroColaborador = new GroupBox();
            btnApagar = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            txtSenha = new TextBox();
            label3 = new Label();
            txtMatricula = new TextBox();
            label2 = new Label();
            txtNomeColaborador = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbMatricula = new RadioButton();
            rbNomeColaborador = new RadioButton();
            txtBuscarColaborador = new TextBox();
            ttSalvar = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvCadastrarColaborador).BeginInit();
            gbCadastroColaborador.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCadastrarColaborador
            // 
            dgvCadastrarColaborador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCadastrarColaborador.Location = new Point(311, 21);
            dgvCadastrarColaborador.Name = "dgvCadastrarColaborador";
            dgvCadastrarColaborador.Size = new Size(383, 442);
            dgvCadastrarColaborador.TabIndex = 0;
            // 
            // gbCadastroColaborador
            // 
            gbCadastroColaborador.Controls.Add(btnApagar);
            gbCadastroColaborador.Controls.Add(btnEditar);
            gbCadastroColaborador.Controls.Add(btnSalvar);
            gbCadastroColaborador.Controls.Add(txtSenha);
            gbCadastroColaborador.Controls.Add(label3);
            gbCadastroColaborador.Controls.Add(txtMatricula);
            gbCadastroColaborador.Controls.Add(label2);
            gbCadastroColaborador.Controls.Add(txtNomeColaborador);
            gbCadastroColaborador.Controls.Add(label1);
            gbCadastroColaborador.ForeColor = Color.White;
            gbCadastroColaborador.Location = new Point(12, 12);
            gbCadastroColaborador.Name = "gbCadastroColaborador";
            gbCadastroColaborador.Size = new Size(293, 326);
            gbCadastroColaborador.TabIndex = 1;
            gbCadastroColaborador.TabStop = false;
            gbCadastroColaborador.Text = "Colaborador";
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.MistyRose;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.ForeColor = Color.Black;
            btnApagar.Image = Properties.Resources.deletar;
            btnApagar.Location = new Point(212, 251);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 61);
            btnApagar.TabIndex = 10;
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightBlue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Black;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.Location = new Point(131, 251);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 61);
            btnEditar.TabIndex = 9;
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleGreen;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Image = Properties.Resources.confirmar;
            btnSalvar.Location = new Point(6, 251);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(119, 61);
            btnSalvar.TabIndex = 8;
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(6, 198);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(281, 26);
            txtSenha.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 177);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 6;
            label3.Text = "Senha:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(6, 130);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(281, 26);
            txtMatricula.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 109);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 4;
            label2.Text = "Matrícula:";
            // 
            // txtNomeColaborador
            // 
            txtNomeColaborador.Location = new Point(6, 64);
            txtNomeColaborador.Name = "txtNomeColaborador";
            txtNomeColaborador.Size = new Size(281, 26);
            txtNomeColaborador.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(164, 18);
            label1.TabIndex = 2;
            label1.Text = "Nome do colaborador:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMatricula);
            groupBox1.Controls.Add(rbNomeColaborador);
            groupBox1.Controls.Add(txtBuscarColaborador);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 344);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 119);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar colaborador";
            // 
            // rbMatricula
            // 
            rbMatricula.AutoSize = true;
            rbMatricula.Location = new Point(172, 38);
            rbMatricula.Name = "rbMatricula";
            rbMatricula.Size = new Size(115, 22);
            rbMatricula.TabIndex = 2;
            rbMatricula.TabStop = true;
            rbMatricula.Text = "por matrícula";
            rbMatricula.UseVisualStyleBackColor = true;
            // 
            // rbNomeColaborador
            // 
            rbNomeColaborador.AutoSize = true;
            rbNomeColaborador.Location = new Point(6, 38);
            rbNomeColaborador.Name = "rbNomeColaborador";
            rbNomeColaborador.Size = new Size(92, 22);
            rbNomeColaborador.TabIndex = 1;
            rbNomeColaborador.TabStop = true;
            rbNomeColaborador.Text = "por nome";
            rbNomeColaborador.UseVisualStyleBackColor = true;
            // 
            // txtBuscarColaborador
            // 
            txtBuscarColaborador.Location = new Point(6, 66);
            txtBuscarColaborador.Name = "txtBuscarColaborador";
            txtBuscarColaborador.Size = new Size(281, 26);
            txtBuscarColaborador.TabIndex = 0;
            // 
            // ttSalvar
            // 
            ttSalvar.IsBalloon = true;
            ttSalvar.ToolTipIcon = ToolTipIcon.Info;
            ttSalvar.ToolTipTitle = "Salvar cadastro";
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(706, 516);
            Controls.Add(groupBox1);
            Controls.Add(gbCadastroColaborador);
            Controls.Add(dgvCadastrarColaborador);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmCadastro";
            Text = "Aplicativo Academia- Cadastro de Colaborador";
            Load += frmCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCadastrarColaborador).EndInit();
            gbCadastroColaborador.ResumeLayout(false);
            gbCadastroColaborador.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCadastrarColaborador;
        private GroupBox gbCadastroColaborador;
        private Label label1;
        private Button btnApagar;
        private Button btnEditar;
        private Button btnSalvar;
        private TextBox txtSenha;
        private Label label3;
        private TextBox txtMatricula;
        private Label label2;
        private TextBox txtNomeColaborador;
        private GroupBox groupBox1;
        private RadioButton rbMatricula;
        private RadioButton rbNomeColaborador;
        private TextBox txtBuscarColaborador;
        private ToolTip ttSalvar;
    }
}