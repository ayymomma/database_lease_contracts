namespace tema_bd
{
    partial class AdaugaBlocFizic
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
            this.denumire = new System.Windows.Forms.TextBox();
            this.suprafata = new System.Windows.Forms.TextBox();
            this.den = new System.Windows.Forms.Label();
            this.sup = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // denumire
            // 
            this.denumire.Location = new System.Drawing.Point(191, 185);
            this.denumire.Multiline = true;
            this.denumire.Name = "denumire";
            this.denumire.Size = new System.Drawing.Size(159, 30);
            this.denumire.TabIndex = 14;
            // 
            // suprafata
            // 
            this.suprafata.Location = new System.Drawing.Point(455, 185);
            this.suprafata.Multiline = true;
            this.suprafata.Name = "suprafata";
            this.suprafata.Size = new System.Drawing.Size(159, 30);
            this.suprafata.TabIndex = 15;
            // 
            // den
            // 
            this.den.AutoSize = true;
            this.den.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.den.Location = new System.Drawing.Point(233, 167);
            this.den.Name = "den";
            this.den.Size = new System.Drawing.Size(71, 15);
            this.den.TabIndex = 19;
            this.den.Text = "Denumire";
            // 
            // sup
            // 
            this.sup.AutoSize = true;
            this.sup.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup.Location = new System.Drawing.Point(497, 167);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(72, 15);
            this.sup.TabIndex = 20;
            this.sup.Text = "Suprafata";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(300, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "Inserare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdaugaBlocFizic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sup);
            this.Controls.Add(this.den);
            this.Controls.Add(this.suprafata);
            this.Controls.Add(this.denumire);
            this.Name = "AdaugaBlocFizic";
            this.Text = "AdaugaBlocFizic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox denumire;
        private System.Windows.Forms.TextBox suprafata;
        private System.Windows.Forms.Label den;
        private System.Windows.Forms.Label sup;
        private System.Windows.Forms.Button button1;
    }
}