namespace AppKoralitos
{
    partial class Factura_Mesa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura_Mesa));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_sub_total = new System.Windows.Forms.Label();
            this.label_total_desc = new System.Windows.Forms.Label();
            this.comboBox_name_cliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Mesas = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_iv = new System.Windows.Forms.TextBox();
            this.textBox_is = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_idMesero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_tipo_pago = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(174, 184);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(682, 388);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 184);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(156, 388);
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
            this.Column4,
            this.Column5});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(862, 184);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(460, 311);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_Click);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.row_added);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(857, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sub Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(857, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total (sin descuento):";
            // 
            // label_sub_total
            // 
            this.label_sub_total.AutoSize = true;
            this.label_sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sub_total.Location = new System.Drawing.Point(1082, 498);
            this.label_sub_total.Name = "label_sub_total";
            this.label_sub_total.Size = new System.Drawing.Size(24, 26);
            this.label_sub_total.TabIndex = 9;
            this.label_sub_total.Text = "0";
            // 
            // label_total_desc
            // 
            this.label_total_desc.AutoSize = true;
            this.label_total_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total_desc.Location = new System.Drawing.Point(1082, 534);
            this.label_total_desc.Name = "label_total_desc";
            this.label_total_desc.Size = new System.Drawing.Size(24, 26);
            this.label_total_desc.TabIndex = 10;
            this.label_total_desc.Text = "0";
            // 
            // comboBox_name_cliente
            // 
            this.comboBox_name_cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_name_cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox_name_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_name_cliente.FormattingEnabled = true;
            this.comboBox_name_cliente.Location = new System.Drawing.Point(99, 7);
            this.comboBox_name_cliente.Name = "comboBox_name_cliente";
            this.comboBox_name_cliente.Size = new System.Drawing.Size(156, 28);
            this.comboBox_name_cliente.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Familias";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(170, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Opciones";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mesa:";
            // 
            // flowLayoutPanel_Mesas
            // 
            this.flowLayoutPanel_Mesas.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_Mesas.Location = new System.Drawing.Point(84, 42);
            this.flowLayoutPanel_Mesas.Name = "flowLayoutPanel_Mesas";
            this.flowLayoutPanel_Mesas.Size = new System.Drawing.Size(1238, 100);
            this.flowLayoutPanel_Mesas.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(275, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "IV:";
            // 
            // textBox_iv
            // 
            this.textBox_iv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_iv.Location = new System.Drawing.Point(316, 10);
            this.textBox_iv.Name = "textBox_iv";
            this.textBox_iv.Size = new System.Drawing.Size(100, 26);
            this.textBox_iv.TabIndex = 19;
            // 
            // textBox_is
            // 
            this.textBox_is.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_is.Location = new System.Drawing.Point(482, 10);
            this.textBox_is.Name = "textBox_is";
            this.textBox_is.Size = new System.Drawing.Size(100, 26);
            this.textBox_is.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(442, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "IS:";
            // 
            // textBox_desc
            // 
            this.textBox_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_desc.Location = new System.Drawing.Point(723, 10);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(100, 26);
            this.textBox_desc.TabIndex = 23;
            this.textBox_desc.Text = "0";
            this.textBox_desc.TextChanged += new System.EventHandler(this.textBox_desc_TextChanged);
            this.textBox_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(601, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Descuento:";
            // 
            // textBox_idMesero
            // 
            this.textBox_idMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idMesero.Location = new System.Drawing.Point(1040, 10);
            this.textBox_idMesero.Name = "textBox_idMesero";
            this.textBox_idMesero.Size = new System.Drawing.Size(100, 26);
            this.textBox_idMesero.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(858, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 24);
            this.label3.TabIndex = 46;
            this.label3.Text = "Atendido por (ID):";
            // 
            // button_tipo_pago
            // 
            this.button_tipo_pago.BackColor = System.Drawing.Color.Green;
            this.button_tipo_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tipo_pago.Location = new System.Drawing.Point(12, 594);
            this.button_tipo_pago.Name = "button_tipo_pago";
            this.button_tipo_pago.Size = new System.Drawing.Size(156, 50);
            this.button_tipo_pago.TabIndex = 50;
            this.button_tipo_pago.Text = "Contado";
            this.button_tipo_pago.UseVisualStyleBackColor = false;
            this.button_tipo_pago.Click += new System.EventHandler(this.button_tipo_pago_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(174, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 50);
            this.button1.TabIndex = 49;
            this.button1.Text = "Imprimir Orden";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancelar.Location = new System.Drawing.Point(857, 615);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(177, 77);
            this.button_cancelar.TabIndex = 48;
            this.button_cancelar.Text = "Cancelar Orden";
            this.button_cancelar.UseVisualStyleBackColor = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_Cancelar);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(1082, 575);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(24, 26);
            this.label_total.TabIndex = 52;
            this.label_total.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(857, 575);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 26);
            this.label12.TabIndex = 51;
            this.label12.Text = "Total:";
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
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Sin IV";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Con IV";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Remove";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cobrar";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 47;
            // 
            // Factura_Mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 704);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button_tipo_pago);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.textBox_idMesero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_is);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_iv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flowLayoutPanel_Mesas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_name_cliente);
            this.Controls.Add(this.label_total_desc);
            this.Controls.Add(this.label_sub_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Factura_Mesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

        protected void init_mesas()
        {
            mesas_btns = new System.Collections.Generic.Dictionary<int, System.Windows.Forms.Button>();

            foreach (var m in mcontrol.get_mesas())
            {
                System.Windows.Forms.Button mbtn = new System.Windows.Forms.Button();

                //mbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
                //mbtn.Size = new System.Drawing.Size(120, 50);
                mbtn.Name = "btn_mesa_" + m.Key;
                mbtn.Text = m.Key.ToString();
                mbtn.BackColor = m.Value.estado == AppKoralitos.Model.Clases.Mesa.LIBRE ? System.Drawing.Color.Aqua : System.Drawing.Color.LightGreen;
                mesas_btns.Add(m.Key, mbtn);
            }

            foreach (var m in mesas_btns)
            {
                this.flowLayoutPanel_Mesas.Controls.Add(m.Value);
                m.Value.Click += new System.EventHandler(this.btn_mesas_click);
            }
        }

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Collections.Generic.Dictionary<long, System.Windows.Forms.Button> families_btns;
        private System.Collections.Generic.Dictionary<long, System.Windows.Forms.Button> platillos_btns;
        private System.Collections.Generic.Dictionary<int, System.Windows.Forms.Button> mesas_btns;
        private AppKoralitos.Controller.MainController mcontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_sub_total;
        private System.Windows.Forms.Label label_total_desc;
        private System.Windows.Forms.ComboBox comboBox_name_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Mesas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_iv;
        private System.Windows.Forms.TextBox textBox_is;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_idMesero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_tipo_pago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}