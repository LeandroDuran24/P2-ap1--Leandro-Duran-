namespace ParcialTech.Registros
{
    partial class EmpleadosForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBoxId = new System.Windows.Forms.MaskedTextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.maskedTextBoxSueldo = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AgregarRetencion = new System.Windows.Forms.Button();
            this.comboBoxRetencion = new System.Windows.Forms.ComboBox();
            this.dataGridViewRetencion = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarEmail = new System.Windows.Forms.Button();
            this.comboBoxEmail = new System.Windows.Forms.ComboBox();
            this.dataGridViewEmail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetencion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmpleadoId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sueldo";
            // 
            // maskedTextBoxId
            // 
            this.maskedTextBoxId.Location = new System.Drawing.Point(226, 10);
            this.maskedTextBoxId.Mask = "99999";
            this.maskedTextBoxId.Name = "maskedTextBoxId";
            this.maskedTextBoxId.Size = new System.Drawing.Size(131, 20);
            this.maskedTextBoxId.TabIndex = 6;
            this.maskedTextBoxId.ValidatingType = typeof(int);
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(226, 39);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(212, 20);
            this.textBoxNombres.TabIndex = 1;
            // 
            // maskedTextBoxSueldo
            // 
            this.maskedTextBoxSueldo.Location = new System.Drawing.Point(226, 91);
            this.maskedTextBoxSueldo.Mask = "99999";
            this.maskedTextBoxSueldo.Name = "maskedTextBoxSueldo";
            this.maskedTextBoxSueldo.Size = new System.Drawing.Size(212, 20);
            this.maskedTextBoxSueldo.TabIndex = 3;
            this.maskedTextBoxSueldo.ValidatingType = typeof(int);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(363, 406);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(282, 406);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 5;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(201, 406);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 8;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(363, 10);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 7;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AgregarRetencion);
            this.groupBox1.Controls.Add(this.comboBoxRetencion);
            this.groupBox1.Controls.Add(this.dataGridViewRetencion);
            this.groupBox1.Location = new System.Drawing.Point(17, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 172);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retencion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Retencion";
            // 
            // AgregarRetencion
            // 
            this.AgregarRetencion.Location = new System.Drawing.Point(219, 30);
            this.AgregarRetencion.Name = "AgregarRetencion";
            this.AgregarRetencion.Size = new System.Drawing.Size(75, 23);
            this.AgregarRetencion.TabIndex = 18;
            this.AgregarRetencion.Text = "Agregar";
            this.AgregarRetencion.UseVisualStyleBackColor = true;
            this.AgregarRetencion.Click += new System.EventHandler(this.AgregarRetencion_Click);
            // 
            // comboBoxRetencion
            // 
            this.comboBoxRetencion.FormattingEnabled = true;
            this.comboBoxRetencion.Location = new System.Drawing.Point(92, 30);
            this.comboBoxRetencion.Name = "comboBoxRetencion";
            this.comboBoxRetencion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRetencion.TabIndex = 4;
            // 
            // dataGridViewRetencion
            // 
            this.dataGridViewRetencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRetencion.Location = new System.Drawing.Point(6, 66);
            this.dataGridViewRetencion.Name = "dataGridViewRetencion";
            this.dataGridViewRetencion.Size = new System.Drawing.Size(334, 100);
            this.dataGridViewRetencion.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.AgregarEmail);
            this.groupBox2.Controls.Add(this.comboBoxEmail);
            this.groupBox2.Controls.Add(this.dataGridViewEmail);
            this.groupBox2.Location = new System.Drawing.Point(445, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 172);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TiposEmail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "TiposEmail";
            // 
            // AgregarEmail
            // 
            this.AgregarEmail.Location = new System.Drawing.Point(219, 30);
            this.AgregarEmail.Name = "AgregarEmail";
            this.AgregarEmail.Size = new System.Drawing.Size(75, 23);
            this.AgregarEmail.TabIndex = 11;
            this.AgregarEmail.Text = "Agregar";
            this.AgregarEmail.UseVisualStyleBackColor = true;
            this.AgregarEmail.Click += new System.EventHandler(this.AgregarEmail_Click);
            // 
            // comboBoxEmail
            // 
            this.comboBoxEmail.FormattingEnabled = true;
            this.comboBoxEmail.Location = new System.Drawing.Point(92, 30);
            this.comboBoxEmail.Name = "comboBoxEmail";
            this.comboBoxEmail.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmail.TabIndex = 10;
            // 
            // dataGridViewEmail
            // 
            this.dataGridViewEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmail.Location = new System.Drawing.Point(6, 66);
            this.dataGridViewEmail.Name = "dataGridViewEmail";
            this.dataGridViewEmail.Size = new System.Drawing.Size(288, 100);
            this.dataGridViewEmail.TabIndex = 0;
            // 
            // EmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 480);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.maskedTextBoxSueldo);
            this.Controls.Add(this.textBoxNombres);
            this.Controls.Add(this.maskedTextBoxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmpleadosForm";
            this.Text = "EmpleadosForm";
            this.Load += new System.EventHandler(this.EmpleadosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRetencion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxId;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSueldo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarEmail;
        private System.Windows.Forms.ComboBox comboBoxEmail;
        private System.Windows.Forms.DataGridView dataGridViewEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AgregarRetencion;
        private System.Windows.Forms.ComboBox comboBoxRetencion;
        private System.Windows.Forms.DataGridView dataGridViewRetencion;
    }
}