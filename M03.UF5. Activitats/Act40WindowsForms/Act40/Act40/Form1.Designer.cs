namespace Act40
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblAlumno = new Label();
            txtboxAlumno = new TextBox();
            buttCalc = new Button();
            buttClear = new Button();
            lblnota1 = new Label();
            GboxNotas = new GroupBox();
            txtBoxNota4 = new TextBox();
            txtBoxNota3 = new TextBox();
            txtBoxNota2 = new TextBox();
            lblnota4 = new Label();
            txtBoxNota1 = new TextBox();
            lblnota3 = new Label();
            lblnota2 = new Label();
            buttLeave = new Button();
            lblPromedioNotas = new Label();
            lblNotaBaja = new Label();
            lblCondicion = new Label();
            txtBoxPromedioNotas = new TextBox();
            txtBoxNotaBaja = new TextBox();
            txtBoxCondicion = new TextBox();
            NotasProvider = new ErrorProvider(components);
            AlumnoProvider = new ErrorProvider(components);
            GboxNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotasProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlumnoProvider).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(121, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(319, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CONTROL DE PROMEDIO DE NOTAS";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(16, 100);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(58, 15);
            lblAlumno.TabIndex = 1;
            lblAlumno.Text = "ALUMNO";
            // 
            // txtboxAlumno
            // 
            txtboxAlumno.Location = new Point(16, 118);
            txtboxAlumno.Name = "txtboxAlumno";
            txtboxAlumno.Size = new Size(232, 23);
            txtboxAlumno.TabIndex = 1;
            txtboxAlumno.Validating += txtboxAlumno_Validating;
            // 
            // buttCalc
            // 
            buttCalc.Location = new Point(15, 150);
            buttCalc.Name = "buttCalc";
            buttCalc.Size = new Size(100, 39);
            buttCalc.TabIndex = 6;
            buttCalc.Text = "CALCULAR";
            buttCalc.UseVisualStyleBackColor = true;
            buttCalc.Click += buttCalc_Click;
            buttCalc.Validating += GboxNotas_Validating;
            // 
            // buttClear
            // 
            buttClear.Location = new Point(121, 150);
            buttClear.Name = "buttClear";
            buttClear.Size = new Size(100, 39);
            buttClear.TabIndex = 7;
            buttClear.Text = "LIMPIAR";
            buttClear.UseVisualStyleBackColor = true;
            buttClear.Click += buttClear_Click;
            // 
            // lblnota1
            // 
            lblnota1.AutoSize = true;
            lblnota1.Location = new Point(6, 30);
            lblnota1.Name = "lblnota1";
            lblnota1.Size = new Size(43, 15);
            lblnota1.TabIndex = 6;
            lblnota1.Text = "NOTA1";
            // 
            // GboxNotas
            // 
            GboxNotas.Controls.Add(txtBoxNota4);
            GboxNotas.Controls.Add(txtBoxNota3);
            GboxNotas.Controls.Add(txtBoxNota2);
            GboxNotas.Controls.Add(lblnota4);
            GboxNotas.Controls.Add(txtBoxNota1);
            GboxNotas.Controls.Add(lblnota3);
            GboxNotas.Controls.Add(lblnota2);
            GboxNotas.Controls.Add(lblnota1);
            GboxNotas.Location = new Point(277, 100);
            GboxNotas.Name = "GboxNotas";
            GboxNotas.Size = new Size(250, 89);
            GboxNotas.TabIndex = 7;
            GboxNotas.TabStop = false;
            GboxNotas.Text = "Registro de notas";
            GboxNotas.Validating += GboxNotas_Validating;
            // 
            // txtBoxNota4
            // 
            txtBoxNota4.Location = new Point(187, 54);
            txtBoxNota4.Name = "txtBoxNota4";
            txtBoxNota4.Size = new Size(54, 23);
            txtBoxNota4.TabIndex = 5;
            // 
            // txtBoxNota3
            // 
            txtBoxNota3.Location = new Point(127, 54);
            txtBoxNota3.Name = "txtBoxNota3";
            txtBoxNota3.Size = new Size(54, 23);
            txtBoxNota3.TabIndex = 4;
            // 
            // txtBoxNota2
            // 
            txtBoxNota2.Location = new Point(67, 54);
            txtBoxNota2.Name = "txtBoxNota2";
            txtBoxNota2.Size = new Size(54, 23);
            txtBoxNota2.TabIndex = 3;
            // 
            // lblnota4
            // 
            lblnota4.AutoSize = true;
            lblnota4.Location = new Point(187, 30);
            lblnota4.Name = "lblnota4";
            lblnota4.Size = new Size(43, 15);
            lblnota4.TabIndex = 9;
            lblnota4.Text = "NOTA4";
            // 
            // txtBoxNota1
            // 
            txtBoxNota1.Location = new Point(7, 54);
            txtBoxNota1.Name = "txtBoxNota1";
            txtBoxNota1.Size = new Size(54, 23);
            txtBoxNota1.TabIndex = 2;
            // 
            // lblnota3
            // 
            lblnota3.AutoSize = true;
            lblnota3.Location = new Point(127, 30);
            lblnota3.Name = "lblnota3";
            lblnota3.Size = new Size(43, 15);
            lblnota3.TabIndex = 8;
            lblnota3.Text = "NOTA3";
            // 
            // lblnota2
            // 
            lblnota2.AutoSize = true;
            lblnota2.Location = new Point(67, 30);
            lblnota2.Name = "lblnota2";
            lblnota2.Size = new Size(43, 15);
            lblnota2.TabIndex = 7;
            lblnota2.Text = "NOTA2";
            // 
            // buttLeave
            // 
            buttLeave.Location = new Point(433, 274);
            buttLeave.Name = "buttLeave";
            buttLeave.Size = new Size(100, 39);
            buttLeave.TabIndex = 8;
            buttLeave.Text = "SALIR";
            buttLeave.UseVisualStyleBackColor = true;
            buttLeave.Click += buttLeave_Click;
            // 
            // lblPromedioNotas
            // 
            lblPromedioNotas.AutoSize = true;
            lblPromedioNotas.Location = new Point(26, 219);
            lblPromedioNotas.Name = "lblPromedioNotas";
            lblPromedioNotas.Size = new Size(123, 15);
            lblPromedioNotas.TabIndex = 9;
            lblPromedioNotas.Text = "PROMEDIO DE NOTAS";
            // 
            // lblNotaBaja
            // 
            lblNotaBaja.AutoSize = true;
            lblNotaBaja.Location = new Point(53, 252);
            lblNotaBaja.Name = "lblNotaBaja";
            lblNotaBaja.Size = new Size(96, 15);
            lblNotaBaja.TabIndex = 10;
            lblNotaBaja.Text = "NOTA MAS BAJA";
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(76, 286);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(73, 15);
            lblCondicion.TabIndex = 11;
            lblCondicion.Text = "CONDICION";
            // 
            // txtBoxPromedioNotas
            // 
            txtBoxPromedioNotas.Location = new Point(182, 216);
            txtBoxPromedioNotas.Name = "txtBoxPromedioNotas";
            txtBoxPromedioNotas.ReadOnly = true;
            txtBoxPromedioNotas.Size = new Size(50, 23);
            txtBoxPromedioNotas.TabIndex = 12;
            txtBoxPromedioNotas.Text = "00.00";
            // 
            // txtBoxNotaBaja
            // 
            txtBoxNotaBaja.Location = new Point(182, 249);
            txtBoxNotaBaja.Name = "txtBoxNotaBaja";
            txtBoxNotaBaja.ReadOnly = true;
            txtBoxNotaBaja.Size = new Size(50, 23);
            txtBoxNotaBaja.TabIndex = 13;
            txtBoxNotaBaja.Text = "00.00";
            // 
            // txtBoxCondicion
            // 
            txtBoxCondicion.Location = new Point(182, 283);
            txtBoxCondicion.Name = "txtBoxCondicion";
            txtBoxCondicion.ReadOnly = true;
            txtBoxCondicion.Size = new Size(79, 23);
            txtBoxCondicion.TabIndex = 14;
            txtBoxCondicion.Text = "No definido";
            txtBoxCondicion.TextAlign = HorizontalAlignment.Center;
            // 
            // NotasProvider
            // 
            NotasProvider.ContainerControl = this;
            // 
            // AlumnoProvider
            // 
            AlumnoProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(545, 323);
            Controls.Add(txtBoxCondicion);
            Controls.Add(txtBoxNotaBaja);
            Controls.Add(txtBoxPromedioNotas);
            Controls.Add(lblCondicion);
            Controls.Add(lblNotaBaja);
            Controls.Add(lblPromedioNotas);
            Controls.Add(buttLeave);
            Controls.Add(buttClear);
            Controls.Add(buttCalc);
            Controls.Add(txtboxAlumno);
            Controls.Add(lblAlumno);
            Controls.Add(lblTitle);
            Controls.Add(GboxNotas);
            Name = "Form1";
            Text = "Control de promedio de notas";
            GboxNotas.ResumeLayout(false);
            GboxNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotasProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlumnoProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAlumno;
        private TextBox txtboxAlumno;
        private Button buttCalc;
        private Button buttClear;
        private Label lblnota1;
        private GroupBox GboxNotas;
        private Label lblnota2;
        private Label lblnota4;
        private Label lblnota3;
        private Button buttLeave;
        private TextBox txtBoxNota4;
        private TextBox txtBoxNota3;
        private TextBox txtBoxNota2;
        private TextBox txtBoxNota1;
        private Label lblPromedioNotas;
        private Label lblNotaBaja;
        private Label lblCondicion;
        private TextBox txtBoxPromedioNotas;
        private TextBox txtBoxNotaBaja;
        private TextBox txtBoxCondicion;
        private ErrorProvider NotasProvider;
        private ErrorProvider AlumnoProvider;
    }
}
