namespace MemoryGame
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
            this.pb13 = new System.Windows.Forms.PictureBox();
            this.pb23 = new System.Windows.Forms.PictureBox();
            this.pb03 = new System.Windows.Forms.PictureBox();
            this.pb12 = new System.Windows.Forms.PictureBox();
            this.pb22 = new System.Windows.Forms.PictureBox();
            this.pb02 = new System.Windows.Forms.PictureBox();
            this.pb11 = new System.Windows.Forms.PictureBox();
            this.pb21 = new System.Windows.Forms.PictureBox();
            this.pb01 = new System.Windows.Forms.PictureBox();
            this.pb10 = new System.Windows.Forms.PictureBox();
            this.pb20 = new System.Windows.Forms.PictureBox();
            this.pb00 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbScore = new System.Windows.Forms.ProgressBar();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.cmbSpeed = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrials = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb00)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // pb13
            // 
            this.pb13.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb13.Location = new System.Drawing.Point(331, 207);
            this.pb13.Name = "pb13";
            this.pb13.Size = new System.Drawing.Size(70, 69);
            this.pb13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb13.TabIndex = 13;
            this.pb13.TabStop = false;
            this.pb13.Tag = "Girl";
            this.pb13.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb23
            // 
            this.pb23.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb23.Location = new System.Drawing.Point(331, 304);
            this.pb23.Name = "pb23";
            this.pb23.Size = new System.Drawing.Size(70, 69);
            this.pb23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb23.TabIndex = 12;
            this.pb23.TabStop = false;
            this.pb23.Tag = "Basketball";
            this.pb23.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb03
            // 
            this.pb03.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb03.Location = new System.Drawing.Point(331, 107);
            this.pb03.Name = "pb03";
            this.pb03.Size = new System.Drawing.Size(70, 69);
            this.pb03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb03.TabIndex = 11;
            this.pb03.TabStop = false;
            this.pb03.Tag = "Book";
            this.pb03.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb12
            // 
            this.pb12.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb12.Location = new System.Drawing.Point(232, 207);
            this.pb12.Name = "pb12";
            this.pb12.Size = new System.Drawing.Size(70, 69);
            this.pb12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb12.TabIndex = 10;
            this.pb12.TabStop = false;
            this.pb12.Tag = "Boy";
            this.pb12.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb22
            // 
            this.pb22.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb22.Location = new System.Drawing.Point(232, 304);
            this.pb22.Name = "pb22";
            this.pb22.Size = new System.Drawing.Size(70, 69);
            this.pb22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb22.TabIndex = 9;
            this.pb22.TabStop = false;
            this.pb22.Tag = "Guitar";
            this.pb22.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb02
            // 
            this.pb02.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb02.Location = new System.Drawing.Point(232, 107);
            this.pb02.Name = "pb02";
            this.pb02.Size = new System.Drawing.Size(70, 69);
            this.pb02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb02.TabIndex = 8;
            this.pb02.TabStop = false;
            this.pb02.Tag = "Pen";
            this.pb02.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb11
            // 
            this.pb11.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb11.Location = new System.Drawing.Point(132, 207);
            this.pb11.Name = "pb11";
            this.pb11.Size = new System.Drawing.Size(70, 69);
            this.pb11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb11.TabIndex = 7;
            this.pb11.TabStop = false;
            this.pb11.Tag = "Book";
            this.pb11.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb21
            // 
            this.pb21.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb21.Location = new System.Drawing.Point(132, 304);
            this.pb21.Name = "pb21";
            this.pb21.Size = new System.Drawing.Size(70, 69);
            this.pb21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb21.TabIndex = 6;
            this.pb21.TabStop = false;
            this.pb21.Tag = "Basketball";
            this.pb21.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb01
            // 
            this.pb01.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb01.Location = new System.Drawing.Point(132, 107);
            this.pb01.Name = "pb01";
            this.pb01.Size = new System.Drawing.Size(70, 69);
            this.pb01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb01.TabIndex = 5;
            this.pb01.TabStop = false;
            this.pb01.Tag = "Guitar";
            this.pb01.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb10
            // 
            this.pb10.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb10.Location = new System.Drawing.Point(32, 207);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(70, 69);
            this.pb10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb10.TabIndex = 4;
            this.pb10.TabStop = false;
            this.pb10.Tag = "Pen";
            this.pb10.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb20
            // 
            this.pb20.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb20.Location = new System.Drawing.Point(32, 304);
            this.pb20.Name = "pb20";
            this.pb20.Size = new System.Drawing.Size(70, 69);
            this.pb20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb20.TabIndex = 2;
            this.pb20.TabStop = false;
            this.pb20.Tag = "Boy";
            this.pb20.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // pb00
            // 
            this.pb00.Image = global::MemoryGame.Properties.Resources.imgMemoryGameCardBG;
            this.pb00.Location = new System.Drawing.Point(32, 107);
            this.pb00.Name = "pb00";
            this.pb00.Size = new System.Drawing.Size(70, 69);
            this.pb00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb00.TabIndex = 0;
            this.pb00.TabStop = false;
            this.pb00.Tag = "Girl";
            this.pb00.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Orbitron", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(191, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 34);
            this.label4.TabIndex = 18;
            this.label4.Text = "Memory Game";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblSeconds);
            this.groupBox1.Controls.Add(this.lblMinutes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pbScore);
            this.groupBox1.Controls.Add(this.nudTimer);
            this.groupBox1.Controls.Add(this.cmbSpeed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(418, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 318);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Details";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnReset.Location = new System.Drawing.Point(105, 262);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 30);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnStart.Location = new System.Drawing.Point(19, 262);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 30);
            this.btnStart.TabIndex = 32;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblScore.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScore.Location = new System.Drawing.Point(100, 186);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(48, 20);
            this.lblScore.TabIndex = 31;
            this.lblScore.Text = "0/ 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(14, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Score:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(123, 130);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 14);
            this.label9.TabIndex = 27;
            this.label9.Text = ":";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSeconds.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSeconds.Location = new System.Drawing.Point(132, 128);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(35, 20);
            this.lblSeconds.TabIndex = 26;
            this.lblSeconds.Text = "00";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblMinutes.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMinutes.Location = new System.Drawing.Point(88, 128);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(35, 20);
            this.lblMinutes.TabIndex = 25;
            this.lblMinutes.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(14, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Time: ";
            // 
            // pbScore
            // 
            this.pbScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScore.BackColor = System.Drawing.Color.DarkViolet;
            this.pbScore.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pbScore.Location = new System.Drawing.Point(18, 209);
            this.pbScore.Maximum = 6;
            this.pbScore.Name = "pbScore";
            this.pbScore.Size = new System.Drawing.Size(166, 19);
            this.pbScore.Step = 1;
            this.pbScore.TabIndex = 14;
            // 
            // nudTimer
            // 
            this.nudTimer.Location = new System.Drawing.Point(18, 66);
            this.nudTimer.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.Size = new System.Drawing.Size(55, 21);
            this.nudTimer.TabIndex = 23;
            this.nudTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimer.ValueChanged += new System.EventHandler(this.nudTimer_ValueChanged);
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.FormattingEnabled = true;
            this.cmbSpeed.Items.AddRange(new object[] {
            "1.0x",
            "1.25x",
            "1.5x",
            "1.75x",
            "2.0x"});
            this.cmbSpeed.Location = new System.Drawing.Point(105, 66);
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSpeed.Size = new System.Drawing.Size(62, 22);
            this.cmbSpeed.TabIndex = 22;
            this.cmbSpeed.Text = "1.0x";
            this.cmbSpeed.SelectedIndexChanged += new System.EventHandler(this.cmbSpeed_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(101, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(14, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Trials: ";
            // 
            // lblTrials
            // 
            this.lblTrials.AutoSize = true;
            this.lblTrials.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTrials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTrials.Location = new System.Drawing.Point(149, 404);
            this.lblTrials.Name = "lblTrials";
            this.lblTrials.Size = new System.Drawing.Size(26, 22);
            this.lblTrials.TabIndex = 21;
            this.lblTrials.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.lblTrials);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pb13);
            this.Controls.Add(this.pb23);
            this.Controls.Add(this.pb03);
            this.Controls.Add(this.pb12);
            this.Controls.Add(this.pb22);
            this.Controls.Add(this.pb02);
            this.Controls.Add(this.pb11);
            this.Controls.Add(this.pb21);
            this.Controls.Add(this.pb01);
            this.Controls.Add(this.pb10);
            this.Controls.Add(this.pb20);
            this.Controls.Add(this.pb00);
            this.Name = "Form1";
            this.Text = "Memory Game";
            ((System.ComponentModel.ISupportInitialize)(this.pb13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb00)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb00;
        private System.Windows.Forms.PictureBox pb20;
        private System.Windows.Forms.PictureBox pb10;
        private System.Windows.Forms.PictureBox pb11;
        private System.Windows.Forms.PictureBox pb21;
        private System.Windows.Forms.PictureBox pb01;
        private System.Windows.Forms.PictureBox pb12;
        private System.Windows.Forms.PictureBox pb22;
        private System.Windows.Forms.PictureBox pb02;
        private System.Windows.Forms.PictureBox pb13;
        private System.Windows.Forms.PictureBox pb23;
        private System.Windows.Forms.PictureBox pb03;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTimer;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrials;
    }
}

