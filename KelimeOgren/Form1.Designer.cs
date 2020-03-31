namespace KelimeOgren
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngilizce = new System.Windows.Forms.TextBox();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe:";
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Location = new System.Drawing.Point(82, 15);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.Size = new System.Drawing.Size(149, 26);
            this.txtIngilizce.TabIndex = 2;
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(82, 45);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(149, 26);
            this.txtTurkce.TabIndex = 0;
            this.txtTurkce.TextChanged += new System.EventHandler(this.txtTurkce_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(289, 15);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(27, 18);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "90";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(298, 45);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(18, 18);
            this.lblKelime.TabIndex = 7;
            this.lblKelime.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kelime:";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(183, 77);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(52, 18);
            this.lblCevap.TabIndex = 8;
            this.lblCevap.Text = "Cevap";
            this.lblCevap.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "PAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 26);
            this.button2.TabIndex = 10;
            this.button2.Text = "GÖSTER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 132);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.txtIngilizce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "İngilize Kelime Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIngilizce;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

