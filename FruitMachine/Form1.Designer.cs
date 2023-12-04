namespace FruitMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pb1Top = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pb1Bottom = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.boolcheck = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.balanceText = new System.Windows.Forms.Label();
            this.Spin = new System.Windows.Forms.Button();
            this.pb2Top = new System.Windows.Forms.PictureBox();
            this.pb3Top = new System.Windows.Forms.PictureBox();
            this.pb2Bottom = new System.Windows.Forms.PictureBox();
            this.pb3Bottom = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartButton.Location = new System.Drawing.Point(366, 558);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(150, 89);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Stop";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FruitMachine.Resource1.tile190;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(366, 199);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FruitMachine.Resource1.tile190;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(692, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::FruitMachine.Resource1.tile190;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.InitialImage = global::FruitMachine.Resource1.tile000;
            this.pictureBox3.Location = new System.Drawing.Point(1007, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pb1Top
            // 
            this.pb1Top.BackColor = System.Drawing.Color.Transparent;
            this.pb1Top.BackgroundImage = global::FruitMachine.Resource1.tile070;
            this.pb1Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1Top.Location = new System.Drawing.Point(366, 12);
            this.pb1Top.Name = "pb1Top";
            this.pb1Top.Size = new System.Drawing.Size(150, 150);
            this.pb1Top.TabIndex = 5;
            this.pb1Top.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(291, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // pb1Bottom
            // 
            this.pb1Bottom.BackColor = System.Drawing.Color.Transparent;
            this.pb1Bottom.BackgroundImage = global::FruitMachine.Resource1.tile009;
            this.pb1Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1Bottom.Location = new System.Drawing.Point(366, 388);
            this.pb1Bottom.Name = "pb1Bottom";
            this.pb1Bottom.Size = new System.Drawing.Size(150, 150);
            this.pb1Bottom.TabIndex = 12;
            this.pb1Bottom.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(692, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 89);
            this.button1.TabIndex = 13;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Test";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(1007, 558);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 89);
            this.button2.TabIndex = 15;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1004, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // boolcheck
            // 
            this.boolcheck.Enabled = true;
            this.boolcheck.Interval = 50;
            this.boolcheck.Tick += new System.EventHandler(this.boolcheck_Tick);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "";
            this.textBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox1.Location = new System.Drawing.Point(63, 468);
            this.textBox1.MinimumSize = new System.Drawing.Size(4, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 18;
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.BackColor = System.Drawing.Color.Transparent;
            this.goldLabel.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goldLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.goldLabel.Location = new System.Drawing.Point(41, 45);
            this.goldLabel.MinimumSize = new System.Drawing.Size(300, 150);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(300, 150);
            this.goldLabel.TabIndex = 19;
            this.goldLabel.Text = "1000";
            this.goldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // balanceText
            // 
            this.balanceText.AutoSize = true;
            this.balanceText.BackColor = System.Drawing.Color.Transparent;
            this.balanceText.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.balanceText.Location = new System.Drawing.Point(60, 88);
            this.balanceText.Name = "balanceText";
            this.balanceText.Size = new System.Drawing.Size(49, 13);
            this.balanceText.TabIndex = 20;
            this.balanceText.Text = "Balance:";
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.Color.Transparent;
            this.Spin.Location = new System.Drawing.Point(63, 504);
            this.Spin.MinimumSize = new System.Drawing.Size(200, 100);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(200, 100);
            this.Spin.TabIndex = 21;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = false;
            this.Spin.Click += new System.EventHandler(this.button3_Click);
            // 
            // pb2Top
            // 
            this.pb2Top.BackColor = System.Drawing.Color.Transparent;
            this.pb2Top.BackgroundImage = global::FruitMachine.Resource1.tile070;
            this.pb2Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2Top.Location = new System.Drawing.Point(692, 12);
            this.pb2Top.Name = "pb2Top";
            this.pb2Top.Size = new System.Drawing.Size(150, 150);
            this.pb2Top.TabIndex = 22;
            this.pb2Top.TabStop = false;
            // 
            // pb3Top
            // 
            this.pb3Top.BackColor = System.Drawing.Color.Transparent;
            this.pb3Top.BackgroundImage = global::FruitMachine.Resource1.tile070;
            this.pb3Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3Top.Location = new System.Drawing.Point(1007, 12);
            this.pb3Top.Name = "pb3Top";
            this.pb3Top.Size = new System.Drawing.Size(150, 150);
            this.pb3Top.TabIndex = 23;
            this.pb3Top.TabStop = false;
            // 
            // pb2Bottom
            // 
            this.pb2Bottom.BackColor = System.Drawing.Color.Transparent;
            this.pb2Bottom.BackgroundImage = global::FruitMachine.Resource1.tile009;
            this.pb2Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2Bottom.Location = new System.Drawing.Point(692, 388);
            this.pb2Bottom.Name = "pb2Bottom";
            this.pb2Bottom.Size = new System.Drawing.Size(150, 150);
            this.pb2Bottom.TabIndex = 24;
            this.pb2Bottom.TabStop = false;
            // 
            // pb3Bottom
            // 
            this.pb3Bottom.BackColor = System.Drawing.Color.Transparent;
            this.pb3Bottom.BackgroundImage = global::FruitMachine.Resource1.tile009;
            this.pb3Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3Bottom.Location = new System.Drawing.Point(1007, 388);
            this.pb3Bottom.Name = "pb3Bottom";
            this.pb3Bottom.Size = new System.Drawing.Size(150, 150);
            this.pb3Bottom.TabIndex = 25;
            this.pb3Bottom.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(963, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 715);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb3Bottom);
            this.Controls.Add(this.pb2Bottom);
            this.Controls.Add(this.pb3Top);
            this.Controls.Add(this.pb2Top);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.balanceText);
            this.Controls.Add(this.goldLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb1Bottom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pb1Top);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Not-A-Slot-Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3Bottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pb1Top;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pb1Bottom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer boolcheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.Label balanceText;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.PictureBox pb2Top;
        private System.Windows.Forms.PictureBox pb3Top;
        private System.Windows.Forms.PictureBox pb2Bottom;
        private System.Windows.Forms.PictureBox pb3Bottom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

