namespace AdamAsmacaOyunu
{
    partial class Start
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.cb_Sayi = new System.Windows.Forms.ComboBox();
            this.cb_Rastgele = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ilk10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Start.Location = new System.Drawing.Point(282, 164);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(209, 72);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // cb_Sayi
            // 
            this.cb_Sayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_Sayi.FormattingEnabled = true;
            this.cb_Sayi.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cb_Sayi.Location = new System.Drawing.Point(325, 260);
            this.cb_Sayi.Name = "cb_Sayi";
            this.cb_Sayi.Size = new System.Drawing.Size(121, 33);
            this.cb_Sayi.TabIndex = 1;
            // 
            // cb_Rastgele
            // 
            this.cb_Rastgele.AutoSize = true;
            this.cb_Rastgele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_Rastgele.Location = new System.Drawing.Point(308, 308);
            this.cb_Rastgele.Name = "cb_Rastgele";
            this.cb_Rastgele.Size = new System.Drawing.Size(164, 29);
            this.cb_Rastgele.TabIndex = 2;
            this.cb_Rastgele.Text = "Rastgele Sayı";
            this.cb_Rastgele.UseVisualStyleBackColor = true;
            this.cb_Rastgele.Click += new System.EventHandler(this.cb_Rastgele_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(282, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kelime Ekle/Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(594, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Skor Tablosu";
            // 
            // ilk10
            // 
            this.ilk10.AutoSize = true;
            this.ilk10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilk10.Location = new System.Drawing.Point(594, 67);
            this.ilk10.Name = "ilk10";
            this.ilk10.Size = new System.Drawing.Size(0, 20);
            this.ilk10.TabIndex = 5;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ilk10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Rastgele);
            this.Controls.Add(this.cb_Sayi);
            this.Controls.Add(this.btn_Start);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.ComboBox cb_Sayi;
        private System.Windows.Forms.CheckBox cb_Rastgele;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label ilk10;
    }
}