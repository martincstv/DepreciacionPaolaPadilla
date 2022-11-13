namespace Depreciacion_PaolaPadilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Informacion = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.dateTimePicker_FechaDepreciacion = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_FechaCompra = new System.Windows.Forms.DateTimePicker();
            this.textBox_MontoCompra = new System.Windows.Forms.TextBox();
            this.textBox_ValorResidual = new System.Windows.Forms.TextBox();
            this.radioButton_Vehiculo = new System.Windows.Forms.RadioButton();
            this.radioButton_Inmueble = new System.Windows.Forms.RadioButton();
            this.label_ValorResidual = new System.Windows.Forms.Label();
            this.label_FechaDepreciacion = new System.Windows.Forms.Label();
            this.label_FechaCompra = new System.Windows.Forms.Label();
            this.label_MontoCompra = new System.Windows.Forms.Label();
            this.label_TipoCompra = new System.Windows.Forms.Label();
            this.dataGridView_ActivosFijos = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ActivosFijos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button_Limpiar);
            this.groupBox1.Controls.Add(this.button_Informacion);
            this.groupBox1.Controls.Add(this.button_Salir);
            this.groupBox1.Controls.Add(this.button_Calcular);
            this.groupBox1.Controls.Add(this.dateTimePicker_FechaDepreciacion);
            this.groupBox1.Controls.Add(this.dateTimePicker_FechaCompra);
            this.groupBox1.Controls.Add(this.textBox_MontoCompra);
            this.groupBox1.Controls.Add(this.textBox_ValorResidual);
            this.groupBox1.Controls.Add(this.radioButton_Vehiculo);
            this.groupBox1.Controls.Add(this.radioButton_Inmueble);
            this.groupBox1.Controls.Add(this.label_ValorResidual);
            this.groupBox1.Controls.Add(this.label_FechaDepreciacion);
            this.groupBox1.Controls.Add(this.label_FechaCompra);
            this.groupBox1.Controls.Add(this.label_MontoCompra);
            this.groupBox1.Controls.Add(this.label_TipoCompra);
            this.groupBox1.Controls.Add(this.dataGridView_ActivosFijos);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(923, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEPRECIACION DE ACTIVOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.BackColor = System.Drawing.SystemColors.Window;
            this.button_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Limpiar.Location = new System.Drawing.Point(572, 272);
            this.button_Limpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(84, 28);
            this.button_Limpiar.TabIndex = 21;
            this.button_Limpiar.Text = "LIMPIAR";
            this.button_Limpiar.UseVisualStyleBackColor = false;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Informacion
            // 
            this.button_Informacion.BackColor = System.Drawing.SystemColors.Window;
            this.button_Informacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Informacion.Location = new System.Drawing.Point(664, 272);
            this.button_Informacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Informacion.Name = "button_Informacion";
            this.button_Informacion.Size = new System.Drawing.Size(148, 28);
            this.button_Informacion.TabIndex = 20;
            this.button_Informacion.Text = "MAS INFORMACION";
            this.button_Informacion.UseVisualStyleBackColor = false;
            this.button_Informacion.Click += new System.EventHandler(this.button_Informacion_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.SystemColors.Window;
            this.button_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Salir.Location = new System.Drawing.Point(820, 272);
            this.button_Salir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(84, 28);
            this.button_Salir.TabIndex = 19;
            this.button_Salir.Text = "SALIR";
            this.button_Salir.UseVisualStyleBackColor = false;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // button_Calcular
            // 
            this.button_Calcular.BackColor = System.Drawing.SystemColors.Window;
            this.button_Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Calcular.Location = new System.Drawing.Point(480, 272);
            this.button_Calcular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(84, 28);
            this.button_Calcular.TabIndex = 18;
            this.button_Calcular.Text = "CALCULAR";
            this.button_Calcular.UseVisualStyleBackColor = false;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // dateTimePicker_FechaDepreciacion
            // 
            this.dateTimePicker_FechaDepreciacion.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.dateTimePicker_FechaDepreciacion.Enabled = false;
            this.dateTimePicker_FechaDepreciacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_FechaDepreciacion.Location = new System.Drawing.Point(138, 119);
            this.dateTimePicker_FechaDepreciacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_FechaDepreciacion.Name = "dateTimePicker_FechaDepreciacion";
            this.dateTimePicker_FechaDepreciacion.Size = new System.Drawing.Size(149, 26);
            this.dateTimePicker_FechaDepreciacion.TabIndex = 11;
            // 
            // dateTimePicker_FechaCompra
            // 
            this.dateTimePicker_FechaCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker_FechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_FechaCompra.Location = new System.Drawing.Point(138, 91);
            this.dateTimePicker_FechaCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_FechaCompra.Name = "dateTimePicker_FechaCompra";
            this.dateTimePicker_FechaCompra.Size = new System.Drawing.Size(149, 26);
            this.dateTimePicker_FechaCompra.TabIndex = 10;
            // 
            // textBox_MontoCompra
            // 
            this.textBox_MontoCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_MontoCompra.Location = new System.Drawing.Point(138, 63);
            this.textBox_MontoCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_MontoCompra.Name = "textBox_MontoCompra";
            this.textBox_MontoCompra.Size = new System.Drawing.Size(112, 26);
            this.textBox_MontoCompra.TabIndex = 9;
            // 
            // textBox_ValorResidual
            // 
            this.textBox_ValorResidual.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.textBox_ValorResidual.Location = new System.Drawing.Point(138, 147);
            this.textBox_ValorResidual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_ValorResidual.Name = "textBox_ValorResidual";
            this.textBox_ValorResidual.ReadOnly = true;
            this.textBox_ValorResidual.Size = new System.Drawing.Size(112, 26);
            this.textBox_ValorResidual.TabIndex = 8;
            // 
            // radioButton_Vehiculo
            // 
            this.radioButton_Vehiculo.AutoSize = true;
            this.radioButton_Vehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_Vehiculo.Location = new System.Drawing.Point(223, 37);
            this.radioButton_Vehiculo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton_Vehiculo.Name = "radioButton_Vehiculo";
            this.radioButton_Vehiculo.Size = new System.Drawing.Size(92, 23);
            this.radioButton_Vehiculo.TabIndex = 7;
            this.radioButton_Vehiculo.Text = "Vehiculo";
            this.radioButton_Vehiculo.UseVisualStyleBackColor = true;
            // 
            // radioButton_Inmueble
            // 
            this.radioButton_Inmueble.AutoSize = true;
            this.radioButton_Inmueble.Checked = true;
            this.radioButton_Inmueble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_Inmueble.Location = new System.Drawing.Point(103, 35);
            this.radioButton_Inmueble.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton_Inmueble.Name = "radioButton_Inmueble";
            this.radioButton_Inmueble.Size = new System.Drawing.Size(96, 23);
            this.radioButton_Inmueble.TabIndex = 6;
            this.radioButton_Inmueble.TabStop = true;
            this.radioButton_Inmueble.Text = "Inmueble";
            this.radioButton_Inmueble.UseVisualStyleBackColor = true;
            // 
            // label_ValorResidual
            // 
            this.label_ValorResidual.AutoSize = true;
            this.label_ValorResidual.Location = new System.Drawing.Point(12, 150);
            this.label_ValorResidual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ValorResidual.Name = "label_ValorResidual";
            this.label_ValorResidual.Size = new System.Drawing.Size(113, 19);
            this.label_ValorResidual.TabIndex = 5;
            this.label_ValorResidual.Text = "Valor Residual";
            // 
            // label_FechaDepreciacion
            // 
            this.label_FechaDepreciacion.AutoSize = true;
            this.label_FechaDepreciacion.Location = new System.Drawing.Point(11, 123);
            this.label_FechaDepreciacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FechaDepreciacion.Name = "label_FechaDepreciacion";
            this.label_FechaDepreciacion.Size = new System.Drawing.Size(158, 19);
            this.label_FechaDepreciacion.TabIndex = 4;
            this.label_FechaDepreciacion.Text = "Fecha Depreciacion";
            // 
            // label_FechaCompra
            // 
            this.label_FechaCompra.AutoSize = true;
            this.label_FechaCompra.Location = new System.Drawing.Point(12, 96);
            this.label_FechaCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FechaCompra.Name = "label_FechaCompra";
            this.label_FechaCompra.Size = new System.Drawing.Size(118, 19);
            this.label_FechaCompra.TabIndex = 3;
            this.label_FechaCompra.Text = "Fecha Compra";
            // 
            // label_MontoCompra
            // 
            this.label_MontoCompra.AutoSize = true;
            this.label_MontoCompra.Location = new System.Drawing.Point(12, 69);
            this.label_MontoCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MontoCompra.Name = "label_MontoCompra";
            this.label_MontoCompra.Size = new System.Drawing.Size(116, 19);
            this.label_MontoCompra.TabIndex = 2;
            this.label_MontoCompra.Text = "Monto Compra";
            // 
            // label_TipoCompra
            // 
            this.label_TipoCompra.AutoSize = true;
            this.label_TipoCompra.Location = new System.Drawing.Point(12, 37);
            this.label_TipoCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TipoCompra.Name = "label_TipoCompra";
            this.label_TipoCompra.Size = new System.Drawing.Size(87, 19);
            this.label_TipoCompra.TabIndex = 1;
            this.label_TipoCompra.Text = "Tipo Activo";
            // 
            // dataGridView_ActivosFijos
            // 
            this.dataGridView_ActivosFijos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView_ActivosFijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ActivosFijos.Location = new System.Drawing.Point(321, 23);
            this.dataGridView_ActivosFijos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_ActivosFijos.Name = "dataGridView_ActivosFijos";
            this.dataGridView_ActivosFijos.RowHeadersWidth = 51;
            this.dataGridView_ActivosFijos.RowTemplate.Height = 25;
            this.dataGridView_ActivosFijos.Size = new System.Drawing.Size(582, 243);
            this.dataGridView_ActivosFijos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(953, 336);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA DE DEPRECIACION DE ACTIVOS FIJOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ActivosFijos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label_ValorResidual;
        private Label label_FechaDepreciacion;
        private Label label_FechaCompra;
        private Label label_MontoCompra;
        private Label label_TipoCompra;
        private DataGridView dataGridView_ActivosFijos;
        private DateTimePicker dateTimePicker_FechaDepreciacion;
        private DateTimePicker dateTimePicker_FechaCompra;
        private TextBox textBox_MontoCompra;
        private TextBox textBox_ValorResidual;
        private RadioButton radioButton_Vehiculo;
        private RadioButton radioButton_Inmueble;
        private Button button_Calcular;
        private Button button_Salir;
        private Button button_Informacion;
        private Button button_Limpiar;
        private PictureBox pictureBox1;
    }
}