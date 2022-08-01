namespace flappybird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boruUst = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.boruAlt = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pBoxGameOver = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGameOver)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // boruUst
            // 
            this.boruUst.BackColor = System.Drawing.Color.DarkGray;
            this.boruUst.Image = ((System.Drawing.Image)(resources.GetObject("boruUst.Image")));
            this.boruUst.Location = new System.Drawing.Point(452, 0);
            this.boruUst.Name = "boruUst";
            this.boruUst.Size = new System.Drawing.Size(106, 132);
            this.boruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst.TabIndex = 0;
            this.boruUst.TabStop = false;
            // 
            // Zemin
            // 
            this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
            this.Zemin.Location = new System.Drawing.Point(-1, 463);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(643, 79);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 1;
            this.Zemin.TabStop = false;
            // 
            // boruAlt
            // 
            this.boruAlt.BackColor = System.Drawing.Color.DarkGray;
            this.boruAlt.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt.Image")));
            this.boruAlt.Location = new System.Drawing.Point(389, 320);
            this.boruAlt.Name = "boruAlt";
            this.boruAlt.Size = new System.Drawing.Size(102, 146);
            this.boruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt.TabIndex = 2;
            this.boruAlt.TabStop = false;
            this.boruAlt.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.DarkGray;
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(12, 205);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(84, 62);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 3;
            this.flappyBird.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(-1, 486);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(113, 38);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pBoxGameOver
            // 
            this.pBoxGameOver.Image = ((System.Drawing.Image)(resources.GetObject("pBoxGameOver.Image")));
            this.pBoxGameOver.Location = new System.Drawing.Point(36, 37);
            this.pBoxGameOver.Name = "pBoxGameOver";
            this.pBoxGameOver.Size = new System.Drawing.Size(545, 263);
            this.pBoxGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxGameOver.TabIndex = 5;
            this.pBoxGameOver.TabStop = false;
            this.pBoxGameOver.Click += new System.EventHandler(this.pBoxGameOver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pBoxGameOver);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 445);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(637, 539);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.boruAlt);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.boruUst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGameOver)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox boruUst;
        private PictureBox Zemin;
        private PictureBox boruAlt;
        private PictureBox flappyBird;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox pBoxGameOver;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}