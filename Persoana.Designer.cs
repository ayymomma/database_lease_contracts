namespace tema_bd
{
    partial class Persoana
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
            this.Adauga = new System.Windows.Forms.Button();
            this.Sterge_Persoana = new System.Windows.Forms.Button();
            this.Editeaza_Persoana = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pERSOANABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new tema_bd.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSOANATableAdapter = new tema_bd.DataSet1TableAdapters.PERSOANATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSOANABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Adauga
            // 
            this.Adauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adauga.Location = new System.Drawing.Point(332, 63);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(150, 35);
            this.Adauga.TabIndex = 0;
            this.Adauga.Text = "Adauga Persoana";
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // Sterge_Persoana
            // 
            this.Sterge_Persoana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sterge_Persoana.Location = new System.Drawing.Point(332, 145);
            this.Sterge_Persoana.Name = "Sterge_Persoana";
            this.Sterge_Persoana.Size = new System.Drawing.Size(150, 35);
            this.Sterge_Persoana.TabIndex = 1;
            this.Sterge_Persoana.Text = "Sterge Persoana";
            this.Sterge_Persoana.UseVisualStyleBackColor = true;
            this.Sterge_Persoana.Click += new System.EventHandler(this.Sterge_Persoana_Click);
            // 
            // Editeaza_Persoana
            // 
            this.Editeaza_Persoana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeaza_Persoana.Location = new System.Drawing.Point(332, 104);
            this.Editeaza_Persoana.Name = "Editeaza_Persoana";
            this.Editeaza_Persoana.Size = new System.Drawing.Size(150, 35);
            this.Editeaza_Persoana.TabIndex = 2;
            this.Editeaza_Persoana.Text = "Editeaza Persoana";
            this.Editeaza_Persoana.UseVisualStyleBackColor = true;
            this.Editeaza_Persoana.Click += new System.EventHandler(this.Editeaza_Persoana_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 252);
            this.dataGridView1.TabIndex = 3;
            // 
            // pERSOANABindingSource
            // 
            this.pERSOANABindingSource.DataMember = "PERSOANA";
            this.pERSOANABindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // pERSOANATableAdapter
            // 
            this.pERSOANATableAdapter.ClearBeforeFill = true;
            // 
            // Persoana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Editeaza_Persoana);
            this.Controls.Add(this.Sterge_Persoana);
            this.Controls.Add(this.Adauga);
            this.Name = "Persoana";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSOANABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.Button Sterge_Persoana;
        private System.Windows.Forms.Button Editeaza_Persoana;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pERSOANABindingSource;
        private DataSet1TableAdapters.PERSOANATableAdapter pERSOANATableAdapter;
    }
}