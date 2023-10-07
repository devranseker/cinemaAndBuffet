namespace cinemaAndBuffet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textEgypt = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            textTea = new TextBox();
            textTicket = new TextBox();
            label2 = new Label();
            textWater = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            LblVault = new Label();
            button1 = new Button();
            LblTotal = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 49);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Egypt :";
            // 
            // textEgypt
            // 
            textEgypt.Location = new Point(84, 43);
            textEgypt.Name = "textEgypt";
            textEgypt.Size = new Size(91, 27);
            textEgypt.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 192);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textTea);
            groupBox1.Controls.Add(textTicket);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textWater);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textEgypt);
            groupBox1.Location = new Point(12, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 255);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktar ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 125);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 8;
            label5.Text = "Tea : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 160);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 6;
            label4.Text = "Ticket  :";
            // 
            // textTea
            // 
            textTea.Location = new Point(84, 125);
            textTea.Name = "textTea";
            textTea.Size = new Size(91, 27);
            textTea.TabIndex = 7;
            // 
            // textTicket
            // 
            textTicket.Location = new Point(84, 160);
            textTicket.Name = "textTicket";
            textTicket.Size = new Size(91, 27);
            textTicket.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 87);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Water :";
            // 
            // textWater
            // 
            textWater.Location = new Point(84, 80);
            textWater.Name = "textWater";
            textWater.Size = new Size(91, 27);
            textWater.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 46);
            label8.Name = "label8";
            label8.Size = new Size(115, 20);
            label8.TabIndex = 0;
            label8.Text = "Egypt : 10TL ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 87);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 2;
            label7.Text = "Water : 5TL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 160);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 6;
            label6.Text = "Ticket  : 30TL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 125);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 8;
            label3.Text = "Tea : 10TL ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(235, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 255);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fiyat Table ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Lime;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(LblVault);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(LblTotal);
            groupBox3.Location = new Point(428, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(197, 255);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa ";
            // 
            // button2
            // 
            button2.Location = new Point(16, 133);
            button2.Name = "button2";
            button2.Size = new Size(136, 40);
            button2.TabIndex = 12;
            button2.Text = "Reset ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LblVault
            // 
            LblVault.AutoSize = true;
            LblVault.Location = new Point(36, 202);
            LblVault.Name = "LblVault";
            LblVault.Size = new Size(116, 20);
            LblVault.TabIndex = 11;
            LblVault.Text = "Vault : 00 TL ";
            // 
            // button1
            // 
            button1.Location = new Point(16, 87);
            button1.Name = "button1";
            button1.Size = new Size(136, 40);
            button1.TabIndex = 10;
            button1.Text = "Calculate ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LblTotal
            // 
            LblTotal.AutoSize = true;
            LblTotal.Location = new Point(36, 62);
            LblTotal.Name = "LblTotal";
            LblTotal.Size = new Size(113, 20);
            LblTotal.TabIndex = 9;
            LblTotal.Text = "Total : 00 TL ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Pristina", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(61, 24);
            label10.Name = "label10";
            label10.Size = new Size(273, 35);
            label10.TabIndex = 5;
            label10.Text = "Sinema Büfe Satış Paneli ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(409, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 370);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Bradley Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textEgypt;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private TextBox textTea;
        private TextBox textTicket;
        private Label label2;
        private TextBox textWater;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private Label LblTotal;
        private Label label10;
        private PictureBox pictureBox1;
        private Label LblVault;
        private Button button2;
    }
}