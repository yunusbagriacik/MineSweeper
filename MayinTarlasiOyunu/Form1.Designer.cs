namespace MayinTarlasiOyunu
{
    partial class Form1
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
            this.btn_YeniOyun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Sure = new System.Windows.Forms.Label();
            this.lbl_mayinSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_YeniOyun
            // 
            this.btn_YeniOyun.BackgroundImage = global::MayinTarlasiOyunu.Properties.Resources.logo;
            this.btn_YeniOyun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_YeniOyun.Location = new System.Drawing.Point(284, 12);
            this.btn_YeniOyun.Name = "btn_YeniOyun";
            this.btn_YeniOyun.Size = new System.Drawing.Size(75, 73);
            this.btn_YeniOyun.TabIndex = 0;
            this.btn_YeniOyun.UseVisualStyleBackColor = true;
            this.btn_YeniOyun.Click += new System.EventHandler(this.btn_YeniOyun_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Sure
            // 
            this.lbl_Sure.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sure.ForeColor = System.Drawing.Color.Red;
            this.lbl_Sure.Location = new System.Drawing.Point(534, 25);
            this.lbl_Sure.Name = "lbl_Sure";
            this.lbl_Sure.Size = new System.Drawing.Size(118, 60);
            this.lbl_Sure.TabIndex = 2;
            this.lbl_Sure.Text = "0";
            this.lbl_Sure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mayinSayisi
            // 
            this.lbl_mayinSayisi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_mayinSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mayinSayisi.ForeColor = System.Drawing.Color.Red;
            this.lbl_mayinSayisi.Location = new System.Drawing.Point(12, 25);
            this.lbl_mayinSayisi.Name = "lbl_mayinSayisi";
            this.lbl_mayinSayisi.Size = new System.Drawing.Size(118, 60);
            this.lbl_mayinSayisi.TabIndex = 3;
            this.lbl_mayinSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 639);
            this.Controls.Add(this.lbl_mayinSayisi);
            this.Controls.Add(this.lbl_Sure);
            this.Controls.Add(this.btn_YeniOyun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_YeniOyun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Sure;
        private System.Windows.Forms.Label lbl_mayinSayisi;
    }
}

