namespace AppKoralitos
{
    partial class FacturaPLlevar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaPLlevar));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_sub_total = new System.Windows.Forms.Label();
            this.label_total_desc = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.richTextBox_dir = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button_tipo_pago = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_iv = new System.Windows.Forms.TextBox();
            this.textBox_is = new System.Windows.Forms.TextBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.textBox_mesero = new System.Windows.Forms.TextBox();
            this.textBox_transporte = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ultimosP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(175, 165);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(682, 419);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 165);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(156, 419);
            this.flowLayoutPanel2.TabIndex = 5;
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
            this.dataGridView1.Location = new System.Drawing.Point(863, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 311);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.row_added);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.row_removed);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(863, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sub Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(863, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total (sin Descuento):";
            // 
            // label_sub_total
            // 
            this.label_sub_total.AutoSize = true;
            this.label_sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sub_total.Location = new System.Drawing.Point(1092, 479);
            this.label_sub_total.Name = "label_sub_total";
            this.label_sub_total.Size = new System.Drawing.Size(24, 26);
            this.label_sub_total.TabIndex = 9;
            this.label_sub_total.Text = "0";
            // 
            // label_total_desc
            // 
            this.label_total_desc.AutoSize = true;
            this.label_total_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_desc.Location = new System.Drawing.Point(1092, 512);
            this.label_total_desc.Name = "label_total_desc";
            this.label_total_desc.Size = new System.Drawing.Size(24, 26);
            this.label_total_desc.TabIndex = 10;
            this.label_total_desc.Text = "0";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 55);
            this.maskedTextBox1.Mask = "####-####";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(131, 32);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.Enter += new System.EventHandler(this.maskedText_enter);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(175, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 32);
            this.button4.TabIndex = 14;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(171, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Opciones";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Familias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nombre:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_name.Location = new System.Drawing.Point(109, 12);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(147, 24);
            this.label_name.TabIndex = 19;
            this.label_name.Text = "Sin especificar";
            // 
            // richTextBox_dir
            // 
            this.richTextBox_dir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_dir.Location = new System.Drawing.Point(431, 12);
            this.richTextBox_dir.Name = "richTextBox_dir";
            this.richTextBox_dir.ReadOnly = true;
            this.richTextBox_dir.Size = new System.Drawing.Size(426, 102);
            this.richTextBox_dir.TabIndex = 20;
            this.richTextBox_dir.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(320, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Dirección:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(863, 589);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 67);
            this.button3.TabIndex = 22;
            this.button3.Text = "Cancelar Orden";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_tipo_pago
            // 
            this.button_tipo_pago.BackColor = System.Drawing.Color.Green;
            this.button_tipo_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tipo_pago.Location = new System.Drawing.Point(12, 599);
            this.button_tipo_pago.Name = "button_tipo_pago";
            this.button_tipo_pago.Size = new System.Drawing.Size(156, 50);
            this.button_tipo_pago.TabIndex = 51;
            this.button_tipo_pago.Text = "Contado";
            this.button_tipo_pago.UseVisualStyleBackColor = false;
            this.button_tipo_pago.Click += new System.EventHandler(this.button_tipo_pago_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(863, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 52;
            this.label3.Text = "Total:";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(1092, 547);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(24, 26);
            this.label_total.TabIndex = 53;
            this.label_total.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(864, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "IV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(864, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 24);
            this.label10.TabIndex = 55;
            this.label10.Text = "IS:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(864, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 24);
            this.label11.TabIndex = 56;
            this.label11.Text = "Descuento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(1093, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 24);
            this.label12.TabIndex = 57;
            this.label12.Text = "ID Mesero:";
            // 
            // textBox_iv
            // 
            this.textBox_iv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_iv.Location = new System.Drawing.Point(986, 13);
            this.textBox_iv.Name = "textBox_iv";
            this.textBox_iv.Size = new System.Drawing.Size(100, 26);
            this.textBox_iv.TabIndex = 58;
            this.textBox_iv.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            this.textBox_iv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // textBox_is
            // 
            this.textBox_is.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_is.Location = new System.Drawing.Point(986, 45);
            this.textBox_is.Name = "textBox_is";
            this.textBox_is.Size = new System.Drawing.Size(100, 26);
            this.textBox_is.TabIndex = 59;
            this.textBox_is.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            this.textBox_is.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // textBox_desc
            // 
            this.textBox_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_desc.Location = new System.Drawing.Point(986, 78);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(100, 26);
            this.textBox_desc.TabIndex = 60;
            this.textBox_desc.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            this.textBox_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // textBox_mesero
            // 
            this.textBox_mesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mesero.Location = new System.Drawing.Point(1215, 15);
            this.textBox_mesero.Name = "textBox_mesero";
            this.textBox_mesero.Size = new System.Drawing.Size(77, 26);
            this.textBox_mesero.TabIndex = 61;
            this.textBox_mesero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // textBox_transporte
            // 
            this.textBox_transporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_transporte.Location = new System.Drawing.Point(986, 110);
            this.textBox_transporte.Name = "textBox_transporte";
            this.textBox_transporte.Size = new System.Drawing.Size(100, 26);
            this.textBox_transporte.TabIndex = 62;
            this.textBox_transporte.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
            this.textBox_transporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(864, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 24);
            this.label13.TabIndex = 63;
            this.label13.Text = "Transporte:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(175, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 50);
            this.button1.TabIndex = 64;
            this.button1.Text = "Imprimir Orden";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_ultimosP
            // 
            this.button_ultimosP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_ultimosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ultimosP.Location = new System.Drawing.Point(431, 589);
            this.button_ultimosP.Name = "button_ultimosP";
            this.button_ultimosP.Size = new System.Drawing.Size(197, 67);
            this.button_ultimosP.TabIndex = 65;
            this.button_ultimosP.Text = "Ultimos Pedidos";
            this.button_ultimosP.UseVisualStyleBackColor = false;
            this.button_ultimosP.Click += new System.EventHandler(this.button_ultimosP_Click);
            // 
            // FacturaPLlevar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1297, 661);
            this.Controls.Add(this.button_ultimosP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_transporte);
            this.Controls.Add(this.textBox_mesero);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.textBox_is);
            this.Controls.Add(this.textBox_iv);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_tipo_pago);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox_dir);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label_total_desc);
            this.Controls.Add(this.label_sub_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FacturaPLlevar";
            this.Text = "FacturaPLlevar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected void init_food()
        {
            families_btns = new System.Collections.Generic.Dictionary<long, System.Windows.Forms.Button>();
            platillos_btns = new System.Collections.Generic.Dictionary<long, System.Windows.Forms.Button>();

            foreach(var f in mcontrol.get_menu())
            {
                System.Windows.Forms.Button fbtn = new System.Windows.Forms.Button();
                foreach(var p in f.Value.platillos)
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

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Collections.Generic.Dictionary<long, System.Windows.Forms.Button> families_btns;
        private System.Collections.Generic.Dictionary<long, System.Windows.Forms.Button> platillos_btns;

        private AppKoralitos.Controller.MainController mcontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_sub_total;
        private System.Windows.Forms.Label label_total_desc;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.RichTextBox richTextBox_dir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_tipo_pago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_iv;
        private System.Windows.Forms.TextBox textBox_is;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.TextBox textBox_mesero;
        private System.Windows.Forms.TextBox textBox_transporte;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.Button button_ultimosP;
    }
}