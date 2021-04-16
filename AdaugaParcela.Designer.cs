namespace tema_bd
{
    partial class AdaugaParcela
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
            this.button1 = new System.Windows.Forms.Button();
            this.supr = new System.Windows.Forms.TextBox();
            this.arab = new System.Windows.Forms.TextBox();
            this.blocF = new System.Windows.Forms.ComboBox();
            this.bLOCFIZICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new tema_bd.DataSet1();
            this.suprafata = new System.Windows.Forms.Label();
            this.arabil = new System.Windows.Forms.Label();
            this.blocFizic = new System.Windows.Forms.Label();
            this.bLOC_FIZICTableAdapter = new tema_bd.DataSet1TableAdapters.BLOC_FIZICTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bLOCFIZICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Inserare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // supr
            // 
            this.supr.Location = new System.Drawing.Point(67, 201);
            this.supr.Multiline = true;
            this.supr.Name = "supr";
            this.supr.Size = new System.Drawing.Size(159, 30);
            this.supr.TabIndex = 13;
            // 
            // arab
            // 
            this.arab.Location = new System.Drawing.Point(325, 201);
            this.arab.Multiline = true;
            this.arab.Name = "arab";
            this.arab.Size = new System.Drawing.Size(163, 30);
            this.arab.TabIndex = 14;
            // 
            // blocF
            // 
            this.blocF.DataSource = this.bLOCFIZICBindingSource;
            this.blocF.DisplayMember = "DENUMIRE";
            this.blocF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blocF.FormattingEnabled = true;
            this.blocF.Location = new System.Drawing.Point(600, 201);
            this.blocF.Name = "blocF";
            this.blocF.Size = new System.Drawing.Size(133, 21);
            this.blocF.TabIndex = 16;
            this.blocF.ValueMember = "BLOC_FIZIC_ID";
            // 
            // bLOCFIZICBindingSource
            // 
            this.bLOCFIZICBindingSource.DataMember = "BLOC_FIZIC";
            this.bLOCFIZICBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suprafata
            // 
            this.suprafata.AutoSize = true;
            this.suprafata.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suprafata.Location = new System.Drawing.Point(116, 183);
            this.suprafata.Name = "suprafata";
            this.suprafata.Size = new System.Drawing.Size(72, 15);
            this.suprafata.TabIndex = 18;
            this.suprafata.Text = "Suprafata";
            // 
            // arabil
            // 
            this.arabil.AutoSize = true;
            this.arabil.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arabil.Location = new System.Drawing.Point(383, 183);
            this.arabil.Name = "arabil";
            this.arabil.Size = new System.Drawing.Size(46, 15);
            this.arabil.TabIndex = 19;
            this.arabil.Text = "Arabil";
            // 
            // blocFizic
            // 
            this.blocFizic.AutoSize = true;
            this.blocFizic.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocFizic.Location = new System.Drawing.Point(621, 183);
            this.blocFizic.Name = "blocFizic";
            this.blocFizic.Size = new System.Drawing.Size(90, 15);
            this.blocFizic.TabIndex = 20;
            this.blocFizic.Text = "Bloc Fizic ID";
            // 
            // bLOC_FIZICTableAdapter
            // 
            this.bLOC_FIZICTableAdapter.ClearBeforeFill = true;
            // 
            // AdaugaParcela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blocFizic);
            this.Controls.Add(this.arabil);
            this.Controls.Add(this.suprafata);
            this.Controls.Add(this.blocF);
            this.Controls.Add(this.arab);
            this.Controls.Add(this.supr);
            this.Controls.Add(this.button1);
            this.Name = "AdaugaParcela";
            this.Text = "AdaugaParcela";
            this.Load += new System.EventHandler(this.AdaugaParcela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bLOCFIZICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox supr;
        private System.Windows.Forms.TextBox arab;
        private System.Windows.Forms.ComboBox blocF;
        private System.Windows.Forms.Label suprafata;
        private System.Windows.Forms.Label arabil;
        private System.Windows.Forms.Label blocFizic;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bLOCFIZICBindingSource;
        private DataSet1TableAdapters.BLOC_FIZICTableAdapter bLOC_FIZICTableAdapter;
    }
}