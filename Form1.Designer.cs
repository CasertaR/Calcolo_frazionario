namespace Calcolo_frazionario
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPrimoNum = new System.Windows.Forms.TextBox();
            this.txtPrimoDen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSecNum = new System.Windows.Forms.TextBox();
            this.lstSegno = new System.Windows.Forms.ListBox();
            this.txtSecDen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRisNum = new System.Windows.Forms.TextBox();
            this.txtRisDen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.btnSemplifica = new System.Windows.Forms.Button();
            this.grpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrimoNum
            // 
            this.txtPrimoNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimoNum.Location = new System.Drawing.Point(9, 111);
            this.txtPrimoNum.Multiline = true;
            this.txtPrimoNum.Name = "txtPrimoNum";
            this.txtPrimoNum.Size = new System.Drawing.Size(89, 42);
            this.txtPrimoNum.TabIndex = 0;
            this.txtPrimoNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrimoDen
            // 
            this.txtPrimoDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimoDen.Location = new System.Drawing.Point(9, 39);
            this.txtPrimoDen.Multiline = true;
            this.txtPrimoDen.Name = "txtPrimoDen";
            this.txtPrimoDen.Size = new System.Drawing.Size(88, 42);
            this.txtPrimoDen.TabIndex = 1;
            this.txtPrimoDen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "____________";
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.label4);
            this.grpBox.Controls.Add(this.txtRisDen);
            this.grpBox.Controls.Add(this.txtRisNum);
            this.grpBox.Controls.Add(this.label3);
            this.grpBox.Controls.Add(this.txtSecDen);
            this.grpBox.Controls.Add(this.label2);
            this.grpBox.Controls.Add(this.txtSecNum);
            this.grpBox.Controls.Add(this.lstSegno);
            this.grpBox.Controls.Add(this.txtPrimoNum);
            this.grpBox.Controls.Add(this.txtPrimoDen);
            this.grpBox.Controls.Add(this.label1);
            this.grpBox.Location = new System.Drawing.Point(42, 42);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(463, 190);
            this.grpBox.TabIndex = 3;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "impstare l\'espressione e premere il pulsante \"Calcola\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "____________";
            // 
            // txtSecNum
            // 
            this.txtSecNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecNum.Location = new System.Drawing.Point(212, 39);
            this.txtSecNum.Multiline = true;
            this.txtSecNum.Name = "txtSecNum";
            this.txtSecNum.Size = new System.Drawing.Size(88, 42);
            this.txtSecNum.TabIndex = 4;
            this.txtSecNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstSegno
            // 
            this.lstSegno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSegno.BackColor = System.Drawing.Color.White;
            this.lstSegno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSegno.FormattingEnabled = true;
            this.lstSegno.ItemHeight = 18;
            this.lstSegno.Location = new System.Drawing.Point(147, 56);
            this.lstSegno.Name = "lstSegno";
            this.lstSegno.Size = new System.Drawing.Size(19, 76);
            this.lstSegno.TabIndex = 3;
            // 
            // txtSecDen
            // 
            this.txtSecDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecDen.Location = new System.Drawing.Point(209, 111);
            this.txtSecDen.Multiline = true;
            this.txtSecDen.Name = "txtSecDen";
            this.txtSecDen.Size = new System.Drawing.Size(91, 42);
            this.txtSecDen.TabIndex = 6;
            this.txtSecDen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "=";
            // 
            // txtRisNum
            // 
            this.txtRisNum.Enabled = false;
            this.txtRisNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRisNum.Location = new System.Drawing.Point(358, 39);
            this.txtRisNum.Multiline = true;
            this.txtRisNum.Name = "txtRisNum";
            this.txtRisNum.Size = new System.Drawing.Size(91, 42);
            this.txtRisNum.TabIndex = 8;
            this.txtRisNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRisDen
            // 
            this.txtRisDen.Enabled = false;
            this.txtRisDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRisDen.Location = new System.Drawing.Point(358, 111);
            this.txtRisDen.Multiline = true;
            this.txtRisDen.Name = "txtRisDen";
            this.txtRisDen.Size = new System.Drawing.Size(91, 42);
            this.txtRisDen.TabIndex = 9;
            this.txtRisDen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "____________";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(57, 264);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(439, 36);
            this.btnCalcola.TabIndex = 4;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // btnSemplifica
            // 
            this.btnSemplifica.Location = new System.Drawing.Point(57, 317);
            this.btnSemplifica.Name = "btnSemplifica";
            this.btnSemplifica.Size = new System.Drawing.Size(439, 36);
            this.btnSemplifica.TabIndex = 5;
            this.btnSemplifica.Text = "Semplifica";
            this.btnSemplifica.UseVisualStyleBackColor = true;
            this.btnSemplifica.Click += new System.EventHandler(this.btnSemplifica_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 413);
            this.Controls.Add(this.btnSemplifica);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.grpBox);
            this.Name = "frmMain";
            this.Text = "Calcolo Frazionario";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimoNum;
        private System.Windows.Forms.TextBox txtPrimoDen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecNum;
        private System.Windows.Forms.ListBox lstSegno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRisDen;
        private System.Windows.Forms.TextBox txtRisNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecDen;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Button btnSemplifica;
    }
}

