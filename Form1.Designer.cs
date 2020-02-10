namespace Mario
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
            this.container = new System.Windows.Forms.Panel();
            this.gravityTimer = new System.Windows.Forms.Timer(this.components);
            this.mario = new System.Windows.Forms.PictureBox();
            this.background2 = new System.Windows.Forms.PictureBox();
            this.background1 = new System.Windows.Forms.PictureBox();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.mario);
            this.container.Controls.Add(this.background2);
            this.container.Controls.Add(this.background1);
            this.container.Location = new System.Drawing.Point(-5, -4);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1095, 606);
            this.container.TabIndex = 0;
            // 
            // gravityTimer
            // 
            this.gravityTimer.Tick += new System.EventHandler(this.gravityTimer_Tick);
            // 
            // mario
            // 
            this.mario.BackColor = System.Drawing.Color.White;
            this.mario.Image = global::Mario.Properties.Resources.mario;
            this.mario.Location = new System.Drawing.Point(378, 522);
            this.mario.Name = "mario";
            this.mario.Size = new System.Drawing.Size(30, 47);
            this.mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mario.TabIndex = 3;
            this.mario.TabStop = false;
            // 
            // background2
            // 
            this.background2.BackgroundImage = global::Mario.Properties.Resources.background;
            this.background2.Location = new System.Drawing.Point(1044, -49);
            this.background2.Name = "background2";
            this.background2.Size = new System.Drawing.Size(1153, 653);
            this.background2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background2.TabIndex = 2;
            this.background2.TabStop = false;
            // 
            // background1
            // 
            this.background1.BackgroundImage = global::Mario.Properties.Resources.background;
            this.background1.Location = new System.Drawing.Point(-58, -49);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(1153, 653);
            this.background1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background1.TabIndex = 1;
            this.background1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1088, 678);
            this.Controls.Add(this.container);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.move);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stop);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.PictureBox background2;
        private System.Windows.Forms.PictureBox background1;
        private System.Windows.Forms.Timer gravityTimer;
        private System.Windows.Forms.PictureBox mario;
    }
}

