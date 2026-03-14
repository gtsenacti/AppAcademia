namespace AcademiaComercio
{
    partial class frmMatricula
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnApagar = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            ttAtualizar = new ToolTip(components);
            ttApagar = new ToolTip(components);
            ttSalvar = new ToolTip(components);
            rbMatricula = new RadioButton();
            rbNomeColaborador = new RadioButton();
            txtBuscarColaborador = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.matricula2026;
            pictureBox1.Location = new Point(578, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbMatricula);
            groupBox1.Controls.Add(rbNomeColaborador);
            groupBox1.Controls.Add(txtBuscarColaborador);
            groupBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(5, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 135);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar matriculados";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 444);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(782, 183);
            dataGridView1.TabIndex = 2;
            // 
            // btnApagar
            // 
            btnApagar.BackColor = Color.MistyRose;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.ForeColor = Color.Black;
            btnApagar.Image = Properties.Resources.deletar;
            btnApagar.Location = new Point(698, 361);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(75, 61);
            btnApagar.TabIndex = 13;
            ttApagar.SetToolTip(btnApagar, "Apagar registro do colaborador");
            btnApagar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightBlue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.Black;
            btnEditar.Image = Properties.Resources.editar;
            btnEditar.Location = new Point(617, 361);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 61);
            btnEditar.TabIndex = 12;
            ttAtualizar.SetToolTip(btnEditar, "Atualizar registro do colaborador");
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleGreen;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Image = Properties.Resources.confirmar;
            btnSalvar.Location = new Point(492, 361);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(119, 61);
            btnSalvar.TabIndex = 11;
            ttSalvar.SetToolTip(btnSalvar, "Salvar registro do colaborador");
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // ttAtualizar
            // 
            ttAtualizar.ToolTipIcon = ToolTipIcon.Info;
            ttAtualizar.ToolTipTitle = "Atualizar cadastro";
            // 
            // ttApagar
            // 
            ttApagar.ToolTipIcon = ToolTipIcon.Info;
            ttApagar.ToolTipTitle = "Apagar colaborador";
            // 
            // ttSalvar
            // 
            ttSalvar.ToolTipIcon = ToolTipIcon.Info;
            ttSalvar.ToolTipTitle = "Salvar colaborador";
            // 
            // rbMatricula
            // 
            rbMatricula.AutoSize = true;
            rbMatricula.Font = new Font("Arial", 12F);
            rbMatricula.Location = new Point(309, 42);
            rbMatricula.Name = "rbMatricula";
            rbMatricula.Size = new Size(115, 22);
            rbMatricula.TabIndex = 5;
            rbMatricula.TabStop = true;
            rbMatricula.Text = "por matrícula";
            rbMatricula.UseVisualStyleBackColor = true;
            // 
            // rbNomeColaborador
            // 
            rbNomeColaborador.AutoSize = true;
            rbNomeColaborador.Font = new Font("Arial", 12F);
            rbNomeColaborador.Location = new Point(143, 42);
            rbNomeColaborador.Name = "rbNomeColaborador";
            rbNomeColaborador.Size = new Size(92, 22);
            rbNomeColaborador.TabIndex = 4;
            rbNomeColaborador.TabStop = true;
            rbNomeColaborador.Text = "por nome";
            rbNomeColaborador.UseVisualStyleBackColor = true;
            // 
            // txtBuscarColaborador
            // 
            txtBuscarColaborador.Font = new Font("Arial", 12F);
            txtBuscarColaborador.Location = new Point(7, 70);
            txtBuscarColaborador.Name = "txtBuscarColaborador";
            txtBuscarColaborador.Size = new Size(554, 26);
            txtBuscarColaborador.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(533, 26);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(533, 26);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(12, 316);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(533, 26);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(551, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(218, 26);
            textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(551, 250);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(218, 26);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(551, 316);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(218, 26);
            textBox6.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 159);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 20;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 226);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 21;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(9, 292);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 22;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(547, 159);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 23;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(547, 226);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 24;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(547, 292);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 25;
            label6.Text = "label6";
            // 
            // frmMatricula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(781, 626);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnApagar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMatricula";
            Text = "Aplicativo Academia - Matrículas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnApagar;
        private ToolTip ttApagar;
        private Button btnEditar;
        private ToolTip ttAtualizar;
        private Button btnSalvar;
        private ToolTip ttSalvar;
        private RadioButton rbMatricula;
        private RadioButton rbNomeColaborador;
        private TextBox txtBuscarColaborador;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}