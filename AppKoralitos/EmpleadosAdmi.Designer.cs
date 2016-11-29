namespace AppKoralitos
{
    partial class EmpleadosAdmi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleados Registrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id,
            this.Column_nombre,
            this.Column_tel,
            this.Column_mail,
            this.Column_Admin,
            this.Column_remove});
            this.dataGridView1.Location = new System.Drawing.Point(17, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 283);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cell_click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(17, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppKoralitos.Properties.Resources.koralitosImg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(544, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // Column_id
            // 
            this.Column_id.HeaderText = "Id";
            this.Column_id.Name = "Column_id";
            this.Column_id.ReadOnly = true;
            // 
            // Column_nombre
            // 
            this.Column_nombre.HeaderText = "Nombre";
            this.Column_nombre.Name = "Column_nombre";
            this.Column_nombre.ReadOnly = true;
            // 
            // Column_tel
            // 
            this.Column_tel.HeaderText = "Teléfono";
            this.Column_tel.Name = "Column_tel";
            this.Column_tel.ReadOnly = true;
            // 
            // Column_mail
            // 
            this.Column_mail.HeaderText = "Correo";
            this.Column_mail.Name = "Column_mail";
            this.Column_mail.ReadOnly = true;
            // 
            // Column_Admin
            // 
            this.Column_Admin.HeaderText = "Administrador";
            this.Column_Admin.Name = "Column_Admin";
            // 
            // Column_remove
            // 
            this.Column_remove.HeaderText = "Eliminar";
            this.Column_remove.Name = "Column_remove";
            // 
            // EmpleadosAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(743, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "EmpleadosAdmi";
            this.Text = "EmpleadosAdmi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_mail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Admin;
        private System.Windows.Forms.DataGridViewButtonColumn Column_remove;
    }
}