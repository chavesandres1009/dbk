namespace AppKoralitos
{
    partial class ConsultWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_empleados = new System.Windows.Forms.DataGridView();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_plates = new System.Windows.Forms.DataGridView();
            this.Column_plate_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_plate_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_plate_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_consult = new System.Windows.Forms.Button();
            this.label_ingresos = new System.Windows.Forms.Label();
            this.label_express = new System.Windows.Forms.Label();
            this.label_llevar = new System.Windows.Forms.Label();
            this.label_local = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_empleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_plates)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppKoralitos.Properties.Resources.koralitosImg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 144);
            this.panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(481, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(481, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(329, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(329, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.68493F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.31507F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label_ingresos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_express, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_llevar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_local, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_total, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 438);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(3, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 48);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ventas (En local):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingresos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(3, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ventas (Express):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 48);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ventas (Para llevar):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(3, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ventas total:";
            // 
            // dataGridView_empleados
            // 
            this.dataGridView_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id,
            this.Column_name,
            this.Column_cant,
            this.Column_ganancia});
            this.dataGridView_empleados.Location = new System.Drawing.Point(333, 150);
            this.dataGridView_empleados.Name = "dataGridView_empleados";
            this.dataGridView_empleados.Size = new System.Drawing.Size(425, 188);
            this.dataGridView_empleados.TabIndex = 6;
            // 
            // Column_id
            // 
            this.Column_id.HeaderText = "Id";
            this.Column_id.Name = "Column_id";
            this.Column_id.ReadOnly = true;
            this.Column_id.Visible = false;
            // 
            // Column_name
            // 
            this.Column_name.HeaderText = "Nombre";
            this.Column_name.Name = "Column_name";
            this.Column_name.ReadOnly = true;
            // 
            // Column_cant
            // 
            this.Column_cant.HeaderText = "Cantidad";
            this.Column_cant.Name = "Column_cant";
            this.Column_cant.ReadOnly = true;
            // 
            // Column_ganancia
            // 
            this.Column_ganancia.HeaderText = "Total";
            this.Column_ganancia.Name = "Column_ganancia";
            this.Column_ganancia.ReadOnly = true;
            // 
            // dataGridView_plates
            // 
            this.dataGridView_plates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_plates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_plate_id,
            this.Column_plate_name,
            this.Column_plate_price,
            this.Column_cantidad});
            this.dataGridView_plates.Location = new System.Drawing.Point(333, 383);
            this.dataGridView_plates.Name = "dataGridView_plates";
            this.dataGridView_plates.Size = new System.Drawing.Size(425, 188);
            this.dataGridView_plates.TabIndex = 7;
            this.dataGridView_plates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column_plate_id
            // 
            this.Column_plate_id.HeaderText = "Id";
            this.Column_plate_id.Name = "Column_plate_id";
            this.Column_plate_id.ReadOnly = true;
            this.Column_plate_id.Visible = false;
            // 
            // Column_plate_name
            // 
            this.Column_plate_name.HeaderText = "Nombre";
            this.Column_plate_name.Name = "Column_plate_name";
            this.Column_plate_name.ReadOnly = true;
            // 
            // Column_plate_price
            // 
            this.Column_plate_price.HeaderText = "Precio";
            this.Column_plate_price.Name = "Column_plate_price";
            this.Column_plate_price.ReadOnly = true;
            // 
            // Column_cantidad
            // 
            this.Column_cantidad.HeaderText = "Cantidad";
            this.Column_cantidad.Name = "Column_cantidad";
            this.Column_cantidad.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(329, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Empleados:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(329, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 24);
            this.label11.TabIndex = 9;
            this.label11.Text = "Platillos:";
            // 
            // button_consult
            // 
            this.button_consult.BackColor = System.Drawing.Color.Black;
            this.button_consult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_consult.ForeColor = System.Drawing.Color.White;
            this.button_consult.Location = new System.Drawing.Point(687, 14);
            this.button_consult.Name = "button_consult";
            this.button_consult.Size = new System.Drawing.Size(125, 82);
            this.button_consult.TabIndex = 10;
            this.button_consult.Text = "Consultar";
            this.button_consult.UseVisualStyleBackColor = false;
            this.button_consult.Click += new System.EventHandler(this.button_consult_Click);
            // 
            // label_ingresos
            // 
            this.label_ingresos.AutoSize = true;
            this.label_ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ingresos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ingresos.Location = new System.Drawing.Point(150, 0);
            this.label_ingresos.Name = "label_ingresos";
            this.label_ingresos.Size = new System.Drawing.Size(21, 24);
            this.label_ingresos.TabIndex = 13;
            this.label_ingresos.Text = "0";
            // 
            // label_express
            // 
            this.label_express.AutoSize = true;
            this.label_express.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_express.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_express.Location = new System.Drawing.Point(150, 44);
            this.label_express.Name = "label_express";
            this.label_express.Size = new System.Drawing.Size(21, 24);
            this.label_express.TabIndex = 14;
            this.label_express.Text = "0";
            // 
            // label_llevar
            // 
            this.label_llevar.AutoSize = true;
            this.label_llevar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_llevar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_llevar.Location = new System.Drawing.Point(150, 110);
            this.label_llevar.Name = "label_llevar";
            this.label_llevar.Size = new System.Drawing.Size(21, 24);
            this.label_llevar.TabIndex = 15;
            this.label_llevar.Text = "0";
            // 
            // label_local
            // 
            this.label_local.AutoSize = true;
            this.label_local.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_local.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_local.Location = new System.Drawing.Point(150, 173);
            this.label_local.Name = "label_local";
            this.label_local.Size = new System.Drawing.Size(21, 24);
            this.label_local.TabIndex = 16;
            this.label_local.Text = "0";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_total.Location = new System.Drawing.Point(150, 243);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(21, 24);
            this.label_total.TabIndex = 17;
            this.label_total.Text = "0";
            // 
            // ConsultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(813, 604);
            this.Controls.Add(this.button_consult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView_plates);
            this.Controls.Add(this.dataGridView_empleados);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Name = "ConsultWindow";
            this.Text = "ConsultWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_empleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_plates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ganancia;
        private System.Windows.Forms.DataGridView dataGridView_plates;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_plate_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_plate_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_plate_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cantidad;
        private System.Windows.Forms.Button button_consult;
        private System.Windows.Forms.Label label_ingresos;
        private System.Windows.Forms.Label label_express;
        private System.Windows.Forms.Label label_llevar;
        private System.Windows.Forms.Label label_local;
        private System.Windows.Forms.Label label_total;
    }
}