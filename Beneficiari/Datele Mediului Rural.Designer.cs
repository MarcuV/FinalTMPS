namespace Beneficiari
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localitatea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mediu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Serviciu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serviciu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Produs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nume,
            this.Prenume,
            this.Localitatea,
            this.Mediu,
            this.Email,
            this.Telefon,
            this.ID_Serviciu,
            this.Serviciu,
            this.ID_Produs,
            this.Produs,
            this.Pret});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1150, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // Prenume
            // 
            this.Prenume.HeaderText = "Prenume";
            this.Prenume.Name = "Prenume";
            // 
            // Localitatea
            // 
            this.Localitatea.HeaderText = "Localitatea";
            this.Localitatea.Name = "Localitatea";
            // 
            // Mediu
            // 
            this.Mediu.HeaderText = "Mediu";
            this.Mediu.Name = "Mediu";
            this.Mediu.Width = 75;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // ID_Serviciu
            // 
            this.ID_Serviciu.HeaderText = "ID_Serviciu";
            this.ID_Serviciu.Name = "ID_Serviciu";
            this.ID_Serviciu.Width = 75;
            // 
            // Serviciu
            // 
            this.Serviciu.HeaderText = "Serviciu";
            this.Serviciu.Name = "Serviciu";
            // 
            // ID_Produs
            // 
            this.ID_Produs.HeaderText = "ID_Produs";
            this.ID_Produs.Name = "ID_Produs";
            this.ID_Produs.Width = 75;
            // 
            // Produs
            // 
            this.Produs.HeaderText = "Produs";
            this.Produs.Name = "Produs";
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.Name = "Pret";
            this.Pret.Width = 75;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Mediul Rural";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localitatea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mediu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Serviciu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serviciu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Produs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
    }
}