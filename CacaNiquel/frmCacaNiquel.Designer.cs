namespace CacaNiquel
{
    partial class fmrCacaNiquel
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
            this.lblNiquel1 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblNiquel2 = new System.Windows.Forms.Label();
            this.lblNiquel3 = new System.Windows.Forms.Label();
            this.tmrNiquel = new System.Windows.Forms.Timer(this.components);
            this.listNiquel = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNiquel1
            // 
            this.lblNiquel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNiquel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNiquel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel1.Location = new System.Drawing.Point(57, 61);
            this.lblNiquel1.Name = "lblNiquel1";
            this.lblNiquel1.Size = new System.Drawing.Size(50, 50);
            this.lblNiquel1.TabIndex = 0;
            this.lblNiquel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(248, 65);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(95, 43);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "&Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblNiquel2
            // 
            this.lblNiquel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNiquel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNiquel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel2.Location = new System.Drawing.Point(114, 61);
            this.lblNiquel2.Name = "lblNiquel2";
            this.lblNiquel2.Size = new System.Drawing.Size(50, 50);
            this.lblNiquel2.TabIndex = 2;
            this.lblNiquel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNiquel3
            // 
            this.lblNiquel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNiquel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNiquel3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiquel3.Location = new System.Drawing.Point(170, 61);
            this.lblNiquel3.Name = "lblNiquel3";
            this.lblNiquel3.Size = new System.Drawing.Size(50, 50);
            this.lblNiquel3.TabIndex = 3;
            this.lblNiquel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrNiquel
            // 
            this.tmrNiquel.Tick += new System.EventHandler(this.tmrNiquel_Tick);
            // 
            // listNiquel
            // 
            this.listNiquel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNiquel.FormattingEnabled = true;
            this.listNiquel.ItemHeight = 19;
            this.listNiquel.Location = new System.Drawing.Point(57, 127);
            this.listNiquel.Name = "listNiquel";
            this.listNiquel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listNiquel.Size = new System.Drawing.Size(163, 137);
            this.listNiquel.TabIndex = 4;
            // 
            // fmrCacaNiquel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 301);
            this.Controls.Add(this.listNiquel);
            this.Controls.Add(this.lblNiquel3);
            this.Controls.Add(this.lblNiquel2);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblNiquel1);
            this.Name = "fmrCacaNiquel";
            this.Text = "Caça Níquel";
            this.Load += new System.EventHandler(this.fmrCacaNiquel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNiquel1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblNiquel2;
        private System.Windows.Forms.Label lblNiquel3;
        private System.Windows.Forms.Timer tmrNiquel;
        private System.Windows.Forms.ListBox listNiquel;
    }
}

