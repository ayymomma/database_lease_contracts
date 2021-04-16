namespace tema_bd
{
    partial class AdaugaContract
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
            this.data = new System.Windows.Forms.TextBox();
            this.suma = new System.Windows.Forms.TextBox();
            this.durata = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.persoanaID = new System.Windows.Forms.Label();
            this.blocFizicID = new System.Windows.Forms.Label();
            this.dataSet1 = new tema_bd.DataSet1();
            this.blocFizic = new System.Windows.Forms.ComboBox();
            this.bLOCFIZICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLOC_FIZICTableAdapter = new tema_bd.DataSet1TableAdapters.BLOC_FIZICTableAdapter();
            this.persid = new System.Windows.Forms.ComboBox();
            this.pERSOANABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSOANATableAdapter = new tema_bd.DataSet1TableAdapters.PERSOANATableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLOCFIZICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSOANABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(139, 206);
            this.data.Multiline = true;
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(181, 30);
            this.data.TabIndex = 1;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(326, 206);
            this.suma.Multiline = true;
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(139, 30);
            this.suma.TabIndex = 2;
            // 
            // durata
            // 
            this.durata.Location = new System.Drawing.Point(471, 206);
            this.durata.Multiline = true;
            this.durata.Name = "durata";
            this.durata.Size = new System.Drawing.Size(177, 30);
            this.durata.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Contract";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Suma Contract";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(503, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Durata Contract";
            // 
            // persoanaID
            // 
            this.persoanaID.AutoSize = true;
            this.persoanaID.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persoanaID.Location = new System.Drawing.Point(26, 188);
            this.persoanaID.Name = "persoanaID";
            this.persoanaID.Size = new System.Drawing.Size(89, 15);
            this.persoanaID.TabIndex = 7;
            this.persoanaID.Text = "Persoana ID";
            // 
            // blocFizicID
            // 
            this.blocFizicID.AutoSize = true;
            this.blocFizicID.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blocFizicID.Location = new System.Drawing.Point(667, 188);
            this.blocFizicID.Name = "blocFizicID";
            this.blocFizicID.Size = new System.Drawing.Size(90, 15);
            this.blocFizicID.TabIndex = 8;
            this.blocFizicID.Text = "Bloc Fizic ID";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blocFizic
            // 
            this.blocFizic.DataSource = this.bLOCFIZICBindingSource;
            this.blocFizic.DisplayMember = "DENUMIRE";
            this.blocFizic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blocFizic.FormattingEnabled = true;
            this.blocFizic.Location = new System.Drawing.Point(654, 206);
            this.blocFizic.Name = "blocFizic";
            this.blocFizic.Size = new System.Drawing.Size(121, 21);
            this.blocFizic.TabIndex = 10;
            this.blocFizic.ValueMember = "BLOC_FIZIC_ID";
            // 
            // bLOCFIZICBindingSource
            // 
            this.bLOCFIZICBindingSource.DataMember = "BLOC_FIZIC";
            this.bLOCFIZICBindingSource.DataSource = this.dataSet1;
            // 
            // bLOC_FIZICTableAdapter
            // 
            this.bLOC_FIZICTableAdapter.ClearBeforeFill = true;
            // 
            // persid
            // 
            this.persid.DataSource = this.pERSOANABindingSource;
            this.persid.DisplayMember = "NUME";
            this.persid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.persid.FormattingEnabled = true;
            this.persid.Location = new System.Drawing.Point(12, 206);
            this.persid.Name = "persid";
            this.persid.Size = new System.Drawing.Size(121, 21);
            this.persid.TabIndex = 11;
            this.persid.ValueMember = "PERSOANA_ID";
            // 
            // pERSOANABindingSource
            // 
            this.pERSOANABindingSource.DataMember = "PERSOANA";
            this.pERSOANABindingSource.DataSource = this.dataSet1;
            // 
            // pERSOANATableAdapter
            // 
            this.pERSOANATableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Inserare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdaugaContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.persid);
            this.Controls.Add(this.blocFizic);
            this.Controls.Add(this.blocFizicID);
            this.Controls.Add(this.persoanaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durata);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.data);
            this.Name = "AdaugaContract";
            this.Text = "AdaugaContract";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.Load += new System.EventHandler(this.AdaugaContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLOCFIZICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSOANABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox suma;
        private System.Windows.Forms.TextBox durata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label persoanaID;
        private System.Windows.Forms.Label blocFizicID;
        private DataSet1 dataSet1;
        private System.Windows.Forms.ComboBox blocFizic;
        private System.Windows.Forms.BindingSource bLOCFIZICBindingSource;
        private DataSet1TableAdapters.BLOC_FIZICTableAdapter bLOC_FIZICTableAdapter;
        private System.Windows.Forms.ComboBox persid;
        private System.Windows.Forms.BindingSource pERSOANABindingSource;
        private DataSet1TableAdapters.PERSOANATableAdapter pERSOANATableAdapter;
        private System.Windows.Forms.Button button1;
    }
}