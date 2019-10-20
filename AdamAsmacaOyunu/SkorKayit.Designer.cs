namespace AdamAsmacaOyunu
{
    partial class SkorKayit
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
            this.adiniz = new System.Windows.Forms.TextBox();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.gonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adiniz
            // 
            this.adiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adiniz.Location = new System.Drawing.Point(115, 35);
            this.adiniz.Multiline = true;
            this.adiniz.Name = "adiniz";
            this.adiniz.Size = new System.Drawing.Size(165, 29);
            this.adiniz.TabIndex = 0;
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Ad.Location = new System.Drawing.Point(18, 35);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(84, 25);
            this.lbl_Ad.TabIndex = 1;
            this.lbl_Ad.Text = "Adınız:";
            // 
            // gonder
            // 
            this.gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.gonder.Location = new System.Drawing.Point(286, 28);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(118, 39);
            this.gonder.TabIndex = 2;
            this.gonder.Text = "Gönder";
            this.gonder.UseVisualStyleBackColor = true;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // SkorKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 105);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.adiniz);
            this.Name = "SkorKayit";
            this.Text = "SkorKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adiniz;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Button gonder;
    }
}