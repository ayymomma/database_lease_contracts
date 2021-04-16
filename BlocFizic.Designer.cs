namespace tema_bd
{
    partial class BlocFizic
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
            this.Adauga = new System.Windows.Forms.Button();
            this.Editeaza_Bloc = new System.Windows.Forms.Button();
            this.Sterge_Bloc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // Adauga
            // 
            this.Adauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adauga.Location = new System.Drawing.Point(335, 32);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(150, 35);
            this.Adauga.TabIndex = 1;
            this.Adauga.Text = "Adauga Bloc Fizic";
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // Editeaza_Bloc
            // 
            this.Editeaza_Bloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editeaza_Bloc.Location = new System.Drawing.Point(335, 73);
            this.Editeaza_Bloc.Name = "Editeaza_Bloc";
            this.Editeaza_Bloc.Size = new System.Drawing.Size(150, 35);
            this.Editeaza_Bloc.TabIndex = 3;
            this.Editeaza_Bloc.Text = "Editeaza Bloc Fizic";
            this.Editeaza_Bloc.UseVisualStyleBackColor = true;
            this.Editeaza_Bloc.Click += new System.EventHandler(this.Editeaza_Bloc_Click);
            // 
            // Sterge_Bloc
            // 
            this.Sterge_Bloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sterge_Bloc.Location = new System.Drawing.Point(335, 114);
            this.Sterge_Bloc.Name = "Sterge_Bloc";
            this.Sterge_Bloc.Size = new System.Drawing.Size(150, 35);
            this.Sterge_Bloc.TabIndex = 4;
            this.Sterge_Bloc.Text = "Sterge Bloc Fizic";
            this.Sterge_Bloc.UseVisualStyleBackColor = true;
            this.Sterge_Bloc.Click += new System.EventHandler(this.Sterge_Bloc_Click);
            // 
            // BlocFizic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sterge_Bloc);
            this.Controls.Add(this.Editeaza_Bloc);
            this.Controls.Add(this.Adauga);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BlocFizic";
            this.Text = "BlocFizic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.Load += new System.EventHandler(this.BlocFizic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.Button Editeaza_Bloc;
        private System.Windows.Forms.Button Sterge_Bloc;
    }
}