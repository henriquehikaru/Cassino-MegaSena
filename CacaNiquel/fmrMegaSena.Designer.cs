namespace CacaNiquel
{
    partial class fmrMegaSena
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
            this.lblCardAtual = new System.Windows.Forms.Label();
            this.btnSortearNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtDeCard = new System.Windows.Forms.TextBox();
            this.lstCartoes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCardAtual
            // 
            this.lblCardAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCardAtual.Location = new System.Drawing.Point(37, 116);
            this.lblCardAtual.Name = "lblCardAtual";
            this.lblCardAtual.Size = new System.Drawing.Size(437, 71);
            this.lblCardAtual.TabIndex = 0;
            this.lblCardAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSortearNum
            // 
            this.btnSortearNum.Location = new System.Drawing.Point(213, 504);
            this.btnSortearNum.Name = "btnSortearNum";
            this.btnSortearNum.Size = new System.Drawing.Size(75, 61);
            this.btnSortearNum.TabIndex = 1;
            this.btnSortearNum.Text = "&Sortear Números";
            this.btnSortearNum.UseVisualStyleBackColor = true;
            this.btnSortearNum.Click += new System.EventHandler(this.btnSortearNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qtde de Cartões: ";
            // 
            // txtQtDeCard
            // 
            this.txtQtDeCard.Location = new System.Drawing.Point(131, 54);
            this.txtQtDeCard.Name = "txtQtDeCard";
            this.txtQtDeCard.Size = new System.Drawing.Size(100, 20);
            this.txtQtDeCard.TabIndex = 3;
            // 
            // lstCartoes
            // 
            this.lstCartoes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCartoes.FormattingEnabled = true;
            this.lstCartoes.ItemHeight = 19;
            this.lstCartoes.Location = new System.Drawing.Point(37, 223);
            this.lstCartoes.Name = "lstCartoes";
            this.lstCartoes.Size = new System.Drawing.Size(437, 251);
            this.lstCartoes.TabIndex = 4;
            // 
            // fmrMegaSena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 616);
            this.Controls.Add(this.lstCartoes);
            this.Controls.Add(this.txtQtDeCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSortearNum);
            this.Controls.Add(this.lblCardAtual);
            this.Name = "fmrMegaSena";
            this.Text = "fmrMegaSena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardAtual;
        private System.Windows.Forms.Button btnSortearNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtDeCard;
        private System.Windows.Forms.ListBox lstCartoes;
    }
}