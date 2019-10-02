namespace mswanson2b1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.txtUSDCanada = new System.Windows.Forms.TextBox();
            this.txtUSDGermany = new System.Windows.Forms.TextBox();
            this.txtUSDChina = new System.Windows.Forms.TextBox();
            this.txtUSDKorea = new System.Windows.Forms.TextBox();
            this.txtRateCanada = new System.Windows.Forms.TextBox();
            this.txtRateGermany = new System.Windows.Forms.TextBox();
            this.txtRateChina = new System.Windows.Forms.TextBox();
            this.txtRateKorea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmountCanada = new System.Windows.Forms.TextBox();
            this.txtAmountGermany = new System.Windows.Forms.TextBox();
            this.txtAmountChina = new System.Windows.Forms.TextBox();
            this.txtAmountKorea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(406, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 23);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(236, 259);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 23);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(746, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "$ US:";
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(770, 233);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.ReadOnly = true;
            this.txtTotalUSD.Size = new System.Drawing.Size(164, 20);
            this.txtTotalUSD.TabIndex = 45;
            this.txtTotalUSD.TabStop = false;
            this.txtTotalUSD.Text = "0.00";
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUSDCanada
            // 
            this.txtUSDCanada.Location = new System.Drawing.Point(576, 233);
            this.txtUSDCanada.Name = "txtUSDCanada";
            this.txtUSDCanada.ReadOnly = true;
            this.txtUSDCanada.Size = new System.Drawing.Size(164, 20);
            this.txtUSDCanada.TabIndex = 43;
            this.txtUSDCanada.TabStop = false;
            this.txtUSDCanada.Text = "0.00";
            this.txtUSDCanada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDCanada.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUSDGermany
            // 
            this.txtUSDGermany.Location = new System.Drawing.Point(406, 233);
            this.txtUSDGermany.Name = "txtUSDGermany";
            this.txtUSDGermany.ReadOnly = true;
            this.txtUSDGermany.Size = new System.Drawing.Size(164, 20);
            this.txtUSDGermany.TabIndex = 42;
            this.txtUSDGermany.TabStop = false;
            this.txtUSDGermany.Text = "0.00";
            this.txtUSDGermany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDGermany.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUSDChina
            // 
            this.txtUSDChina.Location = new System.Drawing.Point(236, 233);
            this.txtUSDChina.Name = "txtUSDChina";
            this.txtUSDChina.ReadOnly = true;
            this.txtUSDChina.Size = new System.Drawing.Size(164, 20);
            this.txtUSDChina.TabIndex = 41;
            this.txtUSDChina.TabStop = false;
            this.txtUSDChina.Text = "0.00";
            this.txtUSDChina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDChina.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUSDKorea
            // 
            this.txtUSDKorea.Location = new System.Drawing.Point(66, 233);
            this.txtUSDKorea.Name = "txtUSDKorea";
            this.txtUSDKorea.ReadOnly = true;
            this.txtUSDKorea.Size = new System.Drawing.Size(164, 20);
            this.txtUSDKorea.TabIndex = 40;
            this.txtUSDKorea.TabStop = false;
            this.txtUSDKorea.Text = "0.00";
            this.txtUSDKorea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUSDKorea.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateCanada
            // 
            this.txtRateCanada.Location = new System.Drawing.Point(576, 207);
            this.txtRateCanada.Name = "txtRateCanada";
            this.txtRateCanada.Size = new System.Drawing.Size(164, 20);
            this.txtRateCanada.TabIndex = 39;
            this.txtRateCanada.Text = "0.759905";
            this.txtRateCanada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateCanada.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateGermany
            // 
            this.txtRateGermany.Location = new System.Drawing.Point(406, 207);
            this.txtRateGermany.Name = "txtRateGermany";
            this.txtRateGermany.Size = new System.Drawing.Size(164, 20);
            this.txtRateGermany.TabIndex = 37;
            this.txtRateGermany.Text = "1.10504";
            this.txtRateGermany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateGermany.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateChina
            // 
            this.txtRateChina.Location = new System.Drawing.Point(236, 207);
            this.txtRateChina.Name = "txtRateChina";
            this.txtRateChina.Size = new System.Drawing.Size(164, 20);
            this.txtRateChina.TabIndex = 36;
            this.txtRateChina.Text = "0.140409";
            this.txtRateChina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateChina.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtRateKorea
            // 
            this.txtRateKorea.Location = new System.Drawing.Point(66, 207);
            this.txtRateKorea.Name = "txtRateKorea";
            this.txtRateKorea.Size = new System.Drawing.Size(164, 20);
            this.txtRateKorea.TabIndex = 34;
            this.txtRateKorea.Text = "0.000838265";
            this.txtRateKorea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateKorea.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Rate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Amount:";
            // 
            // txtAmountCanada
            // 
            this.txtAmountCanada.Location = new System.Drawing.Point(576, 181);
            this.txtAmountCanada.Name = "txtAmountCanada";
            this.txtAmountCanada.Size = new System.Drawing.Size(164, 20);
            this.txtAmountCanada.TabIndex = 30;
            this.txtAmountCanada.Text = "0.00";
            this.txtAmountCanada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountCanada.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountGermany
            // 
            this.txtAmountGermany.Location = new System.Drawing.Point(406, 181);
            this.txtAmountGermany.Name = "txtAmountGermany";
            this.txtAmountGermany.Size = new System.Drawing.Size(164, 20);
            this.txtAmountGermany.TabIndex = 29;
            this.txtAmountGermany.Text = "0.00";
            this.txtAmountGermany.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountGermany.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountChina
            // 
            this.txtAmountChina.Location = new System.Drawing.Point(236, 181);
            this.txtAmountChina.Name = "txtAmountChina";
            this.txtAmountChina.Size = new System.Drawing.Size(164, 20);
            this.txtAmountChina.TabIndex = 26;
            this.txtAmountChina.Text = "0.00";
            this.txtAmountChina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountChina.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountKorea
            // 
            this.txtAmountKorea.Location = new System.Drawing.Point(66, 181);
            this.txtAmountKorea.Name = "txtAmountKorea";
            this.txtAmountKorea.Size = new System.Drawing.Size(164, 20);
            this.txtAmountKorea.TabIndex = 25;
            this.txtAmountKorea.Text = "0.00";
            this.txtAmountKorea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountKorea.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(817, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "United States";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(770, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(164, 163);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Canada";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(576, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 163);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Germany";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(406, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(164, 163);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "China";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(236, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Korea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Korea";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 352);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalUSD);
            this.Controls.Add(this.txtUSDCanada);
            this.Controls.Add(this.txtUSDGermany);
            this.Controls.Add(this.txtUSDChina);
            this.Controls.Add(this.txtUSDKorea);
            this.Controls.Add(this.txtRateCanada);
            this.Controls.Add(this.txtRateGermany);
            this.Controls.Add(this.txtRateChina);
            this.Controls.Add(this.txtRateKorea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmountCanada);
            this.Controls.Add(this.txtAmountGermany);
            this.Controls.Add(this.txtAmountChina);
            this.Controls.Add(this.txtAmountKorea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.TextBox txtUSDCanada;
        private System.Windows.Forms.TextBox txtUSDGermany;
        private System.Windows.Forms.TextBox txtUSDChina;
        private System.Windows.Forms.TextBox txtUSDKorea;
        private System.Windows.Forms.TextBox txtRateCanada;
        private System.Windows.Forms.TextBox txtRateGermany;
        private System.Windows.Forms.TextBox txtRateChina;
        private System.Windows.Forms.TextBox txtRateKorea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmountCanada;
        private System.Windows.Forms.TextBox txtAmountGermany;
        private System.Windows.Forms.TextBox txtAmountChina;
        private System.Windows.Forms.TextBox txtAmountKorea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

