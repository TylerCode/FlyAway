namespace FormGameJam
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
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.tutText = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.rock03 = new System.Windows.Forms.PictureBox();
            this.rock05 = new System.Windows.Forms.PictureBox();
            this.rock04 = new System.Windows.Forms.PictureBox();
            this.rock02 = new System.Windows.Forms.PictureBox();
            this.rock01 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rock03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // tick
            // 
            this.tick.Interval = 30;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.start.Location = new System.Drawing.Point(273, 197);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 34);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(473, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(145, 25);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score: XXXXX";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.healthLabel.Location = new System.Drawing.Point(12, 9);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(121, 25);
            this.healthLabel.TabIndex = 2;
            this.healthLabel.Text = "Health: XXX";
            // 
            // tutText
            // 
            this.tutText.AutoSize = true;
            this.tutText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tutText.Location = new System.Drawing.Point(169, 164);
            this.tutText.Name = "tutText";
            this.tutText.Size = new System.Drawing.Size(314, 25);
            this.tutText.TabIndex = 3;
            this.tutText.Text = "Avoid the rocks as long as you can";
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.highScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.highScore.Location = new System.Drawing.Point(486, 34);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(132, 25);
            this.highScore.TabIndex = 11;
            this.highScore.Text = "Best: XXXXX";
            // 
            // rock03
            // 
            this.rock03.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rock03.Image = global::FormGameJam.Properties.Resources.Rock03_64;
            this.rock03.Location = new System.Drawing.Point(76, 68);
            this.rock03.Name = "rock03";
            this.rock03.Size = new System.Drawing.Size(64, 64);
            this.rock03.TabIndex = 9;
            this.rock03.TabStop = false;
            // 
            // rock05
            // 
            this.rock05.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rock05.Image = global::FormGameJam.Properties.Resources.Rock05_128;
            this.rock05.Location = new System.Drawing.Point(12, 164);
            this.rock05.Name = "rock05";
            this.rock05.Size = new System.Drawing.Size(128, 128);
            this.rock05.TabIndex = 8;
            this.rock05.TabStop = false;
            // 
            // rock04
            // 
            this.rock04.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rock04.Image = global::FormGameJam.Properties.Resources.Rock04_64;
            this.rock04.Location = new System.Drawing.Point(548, 130);
            this.rock04.Name = "rock04";
            this.rock04.Size = new System.Drawing.Size(64, 64);
            this.rock04.TabIndex = 7;
            this.rock04.TabStop = false;
            // 
            // rock02
            // 
            this.rock02.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rock02.Image = global::FormGameJam.Properties.Resources.Rock02;
            this.rock02.Location = new System.Drawing.Point(557, 341);
            this.rock02.Name = "rock02";
            this.rock02.Size = new System.Drawing.Size(32, 32);
            this.rock02.TabIndex = 6;
            this.rock02.TabStop = false;
            // 
            // rock01
            // 
            this.rock01.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rock01.Image = global::FormGameJam.Properties.Resources.Rock01;
            this.rock01.Location = new System.Drawing.Point(557, 249);
            this.rock01.Name = "rock01";
            this.rock01.Size = new System.Drawing.Size(32, 32);
            this.rock01.TabIndex = 5;
            this.rock01.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::FormGameJam.Properties.Resources.Ship;
            this.player.Location = new System.Drawing.Point(288, 370);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(48, 48);
            this.player.TabIndex = 10;
            this.player.TabStop = false;
            // 
            // background
            // 
            this.background.Image = global::FormGameJam.Properties.Resources.BackGround2;
            this.background.InitialImage = global::FormGameJam.Properties.Resources.BackGround2;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(640, 480);
            this.background.TabIndex = 4;
            this.background.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.tutText);
            this.Controls.Add(this.rock03);
            this.Controls.Add(this.rock05);
            this.Controls.Add(this.rock04);
            this.Controls.Add(this.rock02);
            this.Controls.Add(this.rock01);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.player);
            this.Controls.Add(this.background);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FlyAway";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rock03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label tutText;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox rock01;
        private System.Windows.Forms.PictureBox rock02;
        private System.Windows.Forms.PictureBox rock04;
        private System.Windows.Forms.PictureBox rock05;
        private System.Windows.Forms.PictureBox rock03;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label highScore;
    }
}

