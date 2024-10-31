namespace UI
{
    partial class Form1
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
            dgvPartidos = new DataGridView();
            groupBox1 = new GroupBox();
            btnBorrador = new Button();
            dtpFechaPartido = new DateTimePicker();
            cmbDeporte = new ComboBox();
            txtEquipoLocal = new TextBox();
            txtEquipoVisitante = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            txtIdModificar = new TextBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            txtMarcadorVisitante = new TextBox();
            label7 = new Label();
            txtMarcadorLocal = new TextBox();
            label5 = new Label();
            btnModificar = new Button();
            groupBox3 = new GroupBox();
            txtIdEliminar = new TextBox();
            label6 = new Label();
            btnEliminar = new Button();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPartidos
            // 
            dgvPartidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Location = new Point(6, 22);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.Size = new Size(897, 395);
            dgvPartidos.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrador);
            groupBox1.Controls.Add(dtpFechaPartido);
            groupBox1.Controls.Add(cmbDeporte);
            groupBox1.Controls.Add(txtEquipoLocal);
            groupBox1.Controls.Add(txtEquipoVisitante);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 252);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Partido";
            // 
            // btnBorrador
            // 
            btnBorrador.Location = new Point(0, 209);
            btnBorrador.Name = "btnBorrador";
            btnBorrador.Size = new Size(113, 37);
            btnBorrador.TabIndex = 9;
            btnBorrador.Text = "Borrador";
            btnBorrador.UseVisualStyleBackColor = true;
            btnBorrador.Click += btnBorrador_Click;
            // 
            // dtpFechaPartido
            // 
            dtpFechaPartido.Location = new Point(11, 180);
            dtpFechaPartido.Name = "dtpFechaPartido";
            dtpFechaPartido.Size = new Size(200, 23);
            dtpFechaPartido.TabIndex = 8;
            // 
            // cmbDeporte
            // 
            cmbDeporte.FormattingEnabled = true;
            cmbDeporte.Location = new Point(11, 39);
            cmbDeporte.Name = "cmbDeporte";
            cmbDeporte.Size = new Size(150, 23);
            cmbDeporte.TabIndex = 7;
            // 
            // txtEquipoLocal
            // 
            txtEquipoLocal.Location = new Point(11, 83);
            txtEquipoLocal.Name = "txtEquipoLocal";
            txtEquipoLocal.Size = new Size(150, 23);
            txtEquipoLocal.TabIndex = 6;
            // 
            // txtEquipoVisitante
            // 
            txtEquipoVisitante.Location = new Point(11, 131);
            txtEquipoVisitante.Name = "txtEquipoVisitante";
            txtEquipoVisitante.Size = new Size(150, 23);
            txtEquipoVisitante.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 157);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha del partido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 113);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 3;
            label3.Text = "Equipo visitante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 65);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Equipo local";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Deporte";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(119, 209);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(113, 37);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Confirmar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // txtIdModificar
            // 
            txtIdModificar.Location = new Point(11, 45);
            txtIdModificar.Name = "txtIdModificar";
            txtIdModificar.Size = new Size(150, 23);
            txtIdModificar.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtMarcadorVisitante);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtMarcadorLocal);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtIdModificar);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Location = new Point(12, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(244, 213);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 123);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 12;
            label8.Text = "Marcado Visitante";
            // 
            // txtMarcadorVisitante
            // 
            txtMarcadorVisitante.Location = new Point(11, 141);
            txtMarcadorVisitante.Name = "txtMarcadorVisitante";
            txtMarcadorVisitante.Size = new Size(150, 23);
            txtMarcadorVisitante.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 79);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 10;
            label7.Text = "Marcador Local";
            // 
            // txtMarcadorLocal
            // 
            txtMarcadorLocal.Location = new Point(11, 97);
            txtMarcadorLocal.Name = "txtMarcadorLocal";
            txtMarcadorLocal.Size = new Size(150, 23);
            txtMarcadorLocal.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 27);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 8;
            label5.Text = "ID partido";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(112, 170);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(126, 37);
            btnModificar.TabIndex = 0;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtIdEliminar);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Location = new Point(12, 489);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(244, 151);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar";
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(11, 59);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(150, 23);
            txtIdEliminar.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 29);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 1;
            label6.Text = "ID partido";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(112, 108);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 37);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvPartidos);
            groupBox4.Location = new Point(262, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(909, 423);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Partidos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 652);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Partidos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPartidos;
        private GroupBox groupBox1;
        private TextBox txtIdModificar;
        private TextBox txtEquipoLocal;
        private TextBox txtEquipoVisitante;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregar;
        private GroupBox groupBox2;
        private Button btnModificar;
        private GroupBox groupBox3;
        private Button btnEliminar;
        private GroupBox groupBox4;
        private Label label5;
        private TextBox txtIdEliminar;
        private Label label6;
        private DateTimePicker dtpFechaPartido;
        private ComboBox cmbDeporte;
        private Label label8;
        private TextBox txtMarcadorVisitante;
        private Label label7;
        private TextBox txtMarcadorLocal;
        private Button btnBorrador;
    }
}
