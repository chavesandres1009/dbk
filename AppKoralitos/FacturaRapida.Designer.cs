namespace AppKoralitos
{
    partial class FacturaRapida
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
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_is = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_iv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_name_cliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_subtotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.total_desc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_idMesero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_tipo_pago = new System.Windows.Forms.Button();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_desc
            // 
            this.textBox_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_desc.Location = new System.Drawing.Point(723, 7);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(100, 26);
            this.textBox_desc.TabIndex = 31;
            this.textBox_desc.Text = "0";
            this.textBox_desc.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            this.textBox_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(601, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "Descuento:";
            // 
            // textBox_is
            // 
            this.textBox_is.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_is.Location = new System.Drawing.Point(482, 7);
            this.textBox_is.Name = "textBox_is";
            this.textBox_is.Size = new System.Drawing.Size(100, 26);
            this.textBox_is.TabIndex = 29;
            this.textBox_is.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            this.textBox_is.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(442, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "IS:";
            // 
            // textBox_iv
            // 
            this.textBox_iv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_iv.Location = new System.Drawing.Point(316, 7);
            this.textBox_iv.Name = "textBox_iv";
            this.textBox_iv.Size = new System.Drawing.Size(100, 26);
            this.textBox_iv.TabIndex = 27;
            this.textBox_iv.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            this.textBox_iv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(275, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "IV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cliente:";
            // 
            // comboBox_name_cliente
            // 
            this.comboBox_name_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_name_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_name_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_name_cliente.FormattingEnabled = true;
            this.comboBox_name_cliente.Location = new System.Drawing.Point(99, 4);
            this.comboBox_name_cliente.Name = "comboBox_name_cliente";
            this.comboBox_name_cliente.Size = new System.Drawing.Size(156, 28);
            this.comboBox_name_cliente.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(166, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Opciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Familias";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(1087, 452);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(24, 26);
            this.label_total.TabIndex = 39;
            this.label_total.Text = "0";
            // 
            // label_subtotal
            // 
            this.label_subtotal.AutoSize = true;
            this.label_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subtotal.Location = new System.Drawing.Point(1087, 414);
            this.label_subtotal.Name = "label_subtotal";
            this.label_subtotal.Size = new System.Drawing.Size(24, 26);
            this.label_subtotal.TabIndex = 38;
            this.label_subtotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(858, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "Total (sin Descuento):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(858, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "Sub Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(858, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(421, 311);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.row_added);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 100);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(156, 388);
            this.flowLayoutPanel2.TabIndex = 34;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(858, 540);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 77);
            this.button3.TabIndex = 33;
            this.button3.Text = "Cancelar Orden";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(170, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(682, 388);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(858, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "Total:";
            // 
            // total_desc
            // 
            this.total_desc.AutoSize = true;
            this.total_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_desc.Location = new System.Drawing.Point(1087, 494);
            this.total_desc.Name = "total_desc";
            this.total_desc.Size = new System.Drawing.Size(24, 26);
            this.total_desc.TabIndex = 43;
            this.total_desc.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(859, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Atendido por (ID):";
            // 
            // textBox_idMesero
            // 
            this.textBox_idMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idMesero.Location = new System.Drawing.Point(1041, 8);
            this.textBox_idMesero.Name = "textBox_idMesero";
            this.textBox_idMesero.Size = new System.Drawing.Size(100, 26);
            this.textBox_idMesero.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 50);
            this.button1.TabIndex = 46;
            this.button1.Text = "Imprimir Orden";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_tipo_pago
            // 
            this.button_tipo_pago.BackColor = System.Drawing.Color.Green;
            this.button_tipo_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tipo_pago.Location = new System.Drawing.Point(8, 522);
            this.button_tipo_pago.Name = "button_tipo_pago";
            this.button_tipo_pago.Size = new System.Drawing.Size(156, 50);
            this.button_tipo_pago.TabIndex = 47;
            this.button_tipo_pago.Text = "Contado";
            this.button_tipo_pago.UseVisualStyleBackColor = false;
            this.button_tipo_pago.Click += new System.EventHandler(this.click_tipo_pago);
            // 
            // Column_id
            // 
            this.Column_id.HeaderText = "Id";
            this.Column_id.Name = "Column_id";
            this.Column_id.ReadOnly = true;
            this.Column_id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Plato";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sin IV";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Con IV";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Remove";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // FacturaRapida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppKoralitos.Properties.Resources.koralitosImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 629);
            this.Controls.Add(this.button_tipo_pago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_idMesero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_subtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_is);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_iv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_name_cliente);
            this.Name = "FacturaRapida";
            this.Text = "FacturaRapida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected void init_food()
        {
            families_btns = new System.Collections.Generic.Dictionary<long, System.Windows.Forms.Button>();
            platillos_btns = new System.Collections.Generic.Dictionary<long, System.Windows.Forms.Button>();

            foreach (var f in mcontroller.get_menu())
            {
                System.Windows.Forms.Button fbtn = new System.Windows.Forms.Button();
                foreach (var p in f.Value.platillos)
                {
                    System.Windows.Forms.Button pbtn = new System.Windows.Forms.Button();
                    pbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
                    pbtn.Size = new System.Drawing.Size(120, 50);
                    pbtn.Name = "btn_platillo_" + p.Key;
                    pbtn.Text = p.Value.nombre;
                    pbtn.Visible = false;
                    platillos_btns.Add(p.Key, pbtn);
                }
                fbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
                fbtn.Size = new System.Drawing.Size(120, 50);
                fbtn.Name = "btn_familia_" + f.Key;
                fbtn.Text = f.Value.nombre;
                families_btns.Add(f.Key, fbtn);
            }
            foreach (var f in families_btns)
            {
                this.flowLayoutPanel2.Controls.Add(f.Value);
                f.Value.Click += new System.EventHandler(this.btn_family_Click);
            }
            foreach (var p in platillos_btns)
            {
                this.flowLayoutPanel1.Controls.Add(p.Value);
                p.Value.Click += new System.EventHandler(this.btn_food_Click);
            }
        }

        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_is;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_iv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_name_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_subtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private AppKoralitos.Controller.MainController mcontroller;

        private System.Collections.Generic.Dictionary<long, System.Windows.Forms.Button> families_btns;
        private System.Collections.Generic.Dictionary<long, System.Windows.Forms.Button> platillos_btns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total_desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_idMesero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_tipo_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}