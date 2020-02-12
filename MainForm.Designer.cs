namespace Mario
{
    partial class MainForm
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
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.gravityTimer = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLives = new System.Windows.Forms.Label();
            this.labelScoreNum = new System.Windows.Forms.Label();
            this.labelLivesNum = new System.Windows.Forms.Label();
            this.bulletTimer = new System.Windows.Forms.Timer(this.components);
            this.cannon = new System.Windows.Forms.PictureBox();
            this.cloud3 = new System.Windows.Forms.PictureBox();
            this.cloud2 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.mario = new System.Windows.Forms.PictureBox();
            this.cloud1 = new System.Windows.Forms.PictureBox();
            this.backgroundSky = new System.Windows.Forms.PictureBox();
            this.cloud4 = new System.Windows.Forms.PictureBox();
            this.cloud5 = new System.Windows.Forms.PictureBox();
            this.cloud6 = new System.Windows.Forms.PictureBox();
            this.cloud7 = new System.Windows.Forms.PictureBox();
            this.cloud8 = new System.Windows.Forms.PictureBox();
            this.question2 = new Mario.GameObjects.Question();
            this.question1 = new Mario.GameObjects.Question();
            this.questionWings1 = new Mario.GameObjects.QuestionWings();
            this.shell1 = new Mario.GameObjects.Shell();
            this.brick1 = new Mario.GameObjects.Brick();
            this.smallTunnel1 = new Mario.GameObjects.SmallTunnel();
            this.brick3 = new Mario.GameObjects.Brick();
            this.brick2 = new Mario.GameObjects.Brick();
            this.coin5 = new Mario.GameObjects.Coin();
            this.coin4 = new Mario.GameObjects.Coin();
            this.coin3 = new Mario.GameObjects.Coin();
            this.coin2 = new Mario.GameObjects.Coin();
            this.coin1 = new Mario.GameObjects.Coin();
            this.mushroomGreen1 = new Mario.GameObjects.MushroomGreen();
            this.mushroomRed1 = new Mario.GameObjects.MushroomRed();
            ((System.ComponentModel.ISupportInitialize)(this.cannon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundSky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.question2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.question1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionWings1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shell1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallTunnel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroomGreen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroomRed1)).BeginInit();
            this.SuspendLayout();
            // 
            // movementTimer
            // 
            this.movementTimer.Enabled = true;
            this.movementTimer.Tick += new System.EventHandler(this.movementTimer_Tick);
            // 
            // gravityTimer
            // 
            this.gravityTimer.Enabled = true;
            this.gravityTimer.Interval = 10;
            this.gravityTimer.Tick += new System.EventHandler(this.gravityTimer_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(33, 19);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(111, 35);
            this.labelScore.TabIndex = 15;
            this.labelScore.Text = "Score:";
            // 
            // labelLives
            // 
            this.labelLives.AutoSize = true;
            this.labelLives.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLives.Location = new System.Drawing.Point(209, 19);
            this.labelLives.Name = "labelLives";
            this.labelLives.Size = new System.Drawing.Size(100, 35);
            this.labelLives.TabIndex = 16;
            this.labelLives.Text = "Lives:";
            // 
            // labelScoreNum
            // 
            this.labelScoreNum.AutoSize = true;
            this.labelScoreNum.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreNum.Location = new System.Drawing.Point(150, 19);
            this.labelScoreNum.Name = "labelScoreNum";
            this.labelScoreNum.Size = new System.Drawing.Size(32, 35);
            this.labelScoreNum.TabIndex = 17;
            this.labelScoreNum.Text = "0";
            // 
            // labelLivesNum
            // 
            this.labelLivesNum.AutoSize = true;
            this.labelLivesNum.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLivesNum.Location = new System.Drawing.Point(329, 19);
            this.labelLivesNum.Name = "labelLivesNum";
            this.labelLivesNum.Size = new System.Drawing.Size(0, 35);
            this.labelLivesNum.TabIndex = 19;
            // 
            // bulletTimer
            // 
            this.bulletTimer.Enabled = true;
            this.bulletTimer.Interval = 5000;
            this.bulletTimer.Tick += new System.EventHandler(this.bulletTimer_Tick);
            // 
            // cannon
            // 
            this.cannon.Image = global::Mario.Properties.Resources.cannon;
            this.cannon.Location = new System.Drawing.Point(1106, 651);
            this.cannon.Name = "cannon";
            this.cannon.Size = new System.Drawing.Size(60, 70);
            this.cannon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cannon.TabIndex = 23;
            this.cannon.TabStop = false;
            // 
            // cloud3
            // 
            this.cloud3.BackColor = System.Drawing.Color.Transparent;
            this.cloud3.Image = global::Mario.Properties.Resources.cloud3;
            this.cloud3.Location = new System.Drawing.Point(1482, 74);
            this.cloud3.Name = "cloud3";
            this.cloud3.Size = new System.Drawing.Size(185, 120);
            this.cloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud3.TabIndex = 10;
            this.cloud3.TabStop = false;
            // 
            // cloud2
            // 
            this.cloud2.BackColor = System.Drawing.Color.Transparent;
            this.cloud2.Image = global::Mario.Properties.Resources.cloud2;
            this.cloud2.Location = new System.Drawing.Point(767, 272);
            this.cloud2.Name = "cloud2";
            this.cloud2.Size = new System.Drawing.Size(181, 114);
            this.cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud2.TabIndex = 9;
            this.cloud2.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackgroundImage = global::Mario.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(0, 719);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(10000, 123);
            this.ground.TabIndex = 7;
            this.ground.TabStop = false;
            // 
            // mario
            // 
            this.mario.BackColor = System.Drawing.Color.Transparent;
            this.mario.Image = global::Mario.Properties.Resources.mario;
            this.mario.Location = new System.Drawing.Point(621, 672);
            this.mario.Name = "mario";
            this.mario.Size = new System.Drawing.Size(30, 47);
            this.mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mario.TabIndex = 3;
            this.mario.TabStop = false;
            // 
            // cloud1
            // 
            this.cloud1.BackColor = System.Drawing.Color.Transparent;
            this.cloud1.Image = global::Mario.Properties.Resources.cloud1;
            this.cloud1.Location = new System.Drawing.Point(74, 141);
            this.cloud1.Name = "cloud1";
            this.cloud1.Size = new System.Drawing.Size(181, 114);
            this.cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud1.TabIndex = 8;
            this.cloud1.TabStop = false;
            // 
            // backgroundSky
            // 
            this.backgroundSky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.backgroundSky.Location = new System.Drawing.Point(0, 0);
            this.backgroundSky.Name = "backgroundSky";
            this.backgroundSky.Size = new System.Drawing.Size(10000, 843);
            this.backgroundSky.TabIndex = 6;
            this.backgroundSky.TabStop = false;
            // 
            // cloud4
            // 
            this.cloud4.BackColor = System.Drawing.Color.Transparent;
            this.cloud4.Image = global::Mario.Properties.Resources.cloud4;
            this.cloud4.Location = new System.Drawing.Point(1850, 232);
            this.cloud4.Name = "cloud4";
            this.cloud4.Size = new System.Drawing.Size(181, 114);
            this.cloud4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud4.TabIndex = 30;
            this.cloud4.TabStop = false;
            // 
            // cloud5
            // 
            this.cloud5.BackColor = System.Drawing.Color.Transparent;
            this.cloud5.Image = global::Mario.Properties.Resources.cloud5;
            this.cloud5.Location = new System.Drawing.Point(2230, 57);
            this.cloud5.Name = "cloud5";
            this.cloud5.Size = new System.Drawing.Size(181, 114);
            this.cloud5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud5.TabIndex = 31;
            this.cloud5.TabStop = false;
            // 
            // cloud6
            // 
            this.cloud6.BackColor = System.Drawing.Color.Transparent;
            this.cloud6.Image = global::Mario.Properties.Resources.cloud6;
            this.cloud6.Location = new System.Drawing.Point(3075, 239);
            this.cloud6.Name = "cloud6";
            this.cloud6.Size = new System.Drawing.Size(181, 114);
            this.cloud6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud6.TabIndex = 32;
            this.cloud6.TabStop = false;
            // 
            // cloud7
            // 
            this.cloud7.BackColor = System.Drawing.Color.Transparent;
            this.cloud7.Image = global::Mario.Properties.Resources.cloud7;
            this.cloud7.Location = new System.Drawing.Point(3769, 61);
            this.cloud7.Name = "cloud7";
            this.cloud7.Size = new System.Drawing.Size(181, 114);
            this.cloud7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud7.TabIndex = 33;
            this.cloud7.TabStop = false;
            // 
            // cloud8
            // 
            this.cloud8.BackColor = System.Drawing.Color.Transparent;
            this.cloud8.Image = global::Mario.Properties.Resources.cloud7;
            this.cloud8.Location = new System.Drawing.Point(4094, 273);
            this.cloud8.Name = "cloud8";
            this.cloud8.Size = new System.Drawing.Size(181, 114);
            this.cloud8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloud8.TabIndex = 34;
            this.cloud8.TabStop = false;
            // 
            // question2
            // 
            this.question2.IsPopped = false;
            this.question2.Location = new System.Drawing.Point(705, 609);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(25, 25);
            this.question2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.question2.TabIndex = 51;
            this.question2.TabStop = false;
            // 
            // question1
            // 
            this.question1.IsPopped = false;
            this.question1.Location = new System.Drawing.Point(651, 609);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(25, 25);
            this.question1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.question1.TabIndex = 50;
            this.question1.TabStop = false;
            // 
            // questionWings1
            // 
            this.questionWings1.IsPopped = false;
            this.questionWings1.Location = new System.Drawing.Point(1320, 600);
            this.questionWings1.Name = "questionWings1";
            this.questionWings1.Size = new System.Drawing.Size(65, 35);
            this.questionWings1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionWings1.TabIndex = 49;
            this.questionWings1.TabStop = false;
            // 
            // shell1
            // 
            this.shell1.Location = new System.Drawing.Point(1769, 695);
            this.shell1.Name = "shell1";
            this.shell1.Size = new System.Drawing.Size(30, 25);
            this.shell1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shell1.TabIndex = 48;
            this.shell1.TabStop = false;
            // 
            // brick1
            // 
            this.brick1.Location = new System.Drawing.Point(1654, 695);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(25, 25);
            this.brick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick1.TabIndex = 44;
            this.brick1.TabStop = false;
            // 
            // smallTunnel1
            // 
            this.smallTunnel1.Location = new System.Drawing.Point(1673, 651);
            this.smallTunnel1.Name = "smallTunnel1";
            this.smallTunnel1.Size = new System.Drawing.Size(60, 70);
            this.smallTunnel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.smallTunnel1.TabIndex = 47;
            this.smallTunnel1.TabStop = false;
            // 
            // brick3
            // 
            this.brick3.Location = new System.Drawing.Point(1966, 694);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(25, 25);
            this.brick3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick3.TabIndex = 46;
            this.brick3.TabStop = false;
            // 
            // brick2
            // 
            this.brick2.Location = new System.Drawing.Point(1630, 695);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(25, 25);
            this.brick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brick2.TabIndex = 45;
            this.brick2.TabStop = false;
            // 
            // coin5
            // 
            this.coin5.Location = new System.Drawing.Point(583, 635);
            this.coin5.Name = "coin5";
            this.coin5.Size = new System.Drawing.Size(25, 25);
            this.coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin5.TabIndex = 43;
            this.coin5.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.Location = new System.Drawing.Point(892, 590);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(25, 25);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin4.TabIndex = 42;
            this.coin4.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.Location = new System.Drawing.Point(860, 575);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(25, 25);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 41;
            this.coin3.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Location = new System.Drawing.Point(828, 561);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(25, 25);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 40;
            this.coin2.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Location = new System.Drawing.Point(796, 552);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(25, 25);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 39;
            this.coin1.TabStop = false;
            // 
            // mushroomGreen1
            // 
            this.mushroomGreen1.Location = new System.Drawing.Point(561, 695);
            this.mushroomGreen1.Name = "mushroomGreen1";
            this.mushroomGreen1.Size = new System.Drawing.Size(25, 25);
            this.mushroomGreen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mushroomGreen1.TabIndex = 38;
            this.mushroomGreen1.TabStop = false;
            // 
            // mushroomRed1
            // 
            this.mushroomRed1.Location = new System.Drawing.Point(497, 693);
            this.mushroomRed1.Name = "mushroomRed1";
            this.mushroomRed1.Size = new System.Drawing.Size(25, 25);
            this.mushroomRed1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mushroomRed1.TabIndex = 37;
            this.mushroomRed1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1367, 862);
            this.Controls.Add(this.question2);
            this.Controls.Add(this.question1);
            this.Controls.Add(this.questionWings1);
            this.Controls.Add(this.shell1);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.smallTunnel1);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.coin5);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.mushroomGreen1);
            this.Controls.Add(this.mushroomRed1);
            this.Controls.Add(this.cloud8);
            this.Controls.Add(this.cloud7);
            this.Controls.Add(this.cloud6);
            this.Controls.Add(this.cloud5);
            this.Controls.Add(this.cloud4);
            this.Controls.Add(this.cannon);
            this.Controls.Add(this.labelLivesNum);
            this.Controls.Add(this.labelScoreNum);
            this.Controls.Add(this.labelLives);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.cloud3);
            this.Controls.Add(this.cloud2);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.mario);
            this.Controls.Add(this.cloud1);
            this.Controls.Add(this.backgroundSky);
            this.MinimumSize = new System.Drawing.Size(1363, 892);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.move);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stop);
            ((System.ComponentModel.ISupportInitialize)(this.cannon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundSky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloud8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.question2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.question1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionWings1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shell1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallTunnel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroomGreen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroomRed1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Timer gravityTimer;
        private System.Windows.Forms.PictureBox cloud1;
        private System.Windows.Forms.PictureBox cloud2;
        private System.Windows.Forms.PictureBox cloud3;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLives;
        public System.Windows.Forms.Label labelScoreNum;
        public System.Windows.Forms.Label labelLivesNum;
        public System.Windows.Forms.PictureBox mario;
        public System.Windows.Forms.PictureBox ground;
        public System.Windows.Forms.PictureBox backgroundSky;
        private System.Windows.Forms.Timer bulletTimer;
        public System.Windows.Forms.PictureBox cannon;
        private System.Windows.Forms.PictureBox cloud4;
        private System.Windows.Forms.PictureBox cloud5;
        private System.Windows.Forms.PictureBox cloud6;
        private System.Windows.Forms.PictureBox cloud7;
        private System.Windows.Forms.PictureBox cloud8;
        private GameObjects.MushroomRed mushroomRed1;
        private GameObjects.MushroomGreen mushroomGreen1;
        private GameObjects.Coin coin1;
        private GameObjects.Coin coin2;
        private GameObjects.Coin coin3;
        private GameObjects.Coin coin4;
        private GameObjects.Coin coin5;
        private GameObjects.Brick brick1;
        private GameObjects.Brick brick2;
        private GameObjects.Brick brick3;
        private GameObjects.SmallTunnel smallTunnel1;
        private GameObjects.Shell shell1;
        private GameObjects.QuestionWings questionWings1;
        private GameObjects.Question question1;
        private GameObjects.Question question2;
    }
}

