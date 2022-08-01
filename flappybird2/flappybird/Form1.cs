namespace flappybird
{
    public partial class Form1 : Form
    {
        int defaultBoruHizi = 8;
        int defaultGravity = 10;
        int boruHizi = 8;
        int gravity = 10;
        int score = 0;
        Point defaultPos;
        public int Score 
        {
            get => score;
            set
            {
                score = value;
                if (score % 5 == 0)
                    boruHizi += 2;
            }
        }
        public Form1()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            boruAlt.Left -= boruHizi;
            boruUst.Left -= boruHizi;
            scoreText.Text = "Score: " + score;
            if (boruAlt.Left < -150)
            {
                boruAlt.Left = 800;
                ++Score;
            }
            if (boruUst.Left < -180)
            {
                boruUst.Left = 950;
                ++Score;
            }
            if(flappyBird.Bounds.IntersectsWith(boruAlt.Bounds) || flappyBird.Bounds.IntersectsWith(boruUst.Bounds) || flappyBird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                endGame();
            }
            if (flappyBird.Top <= 25)
            {
                endGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            defaultPos = flappyBird.Location;
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {                                                      

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == ' ')
            {
                gravity = -10;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text = "Game Over!";
            groupBox1.Visible = true;
            pictureBox1.Enabled = true;    
        }

       

        private void RestartGame()
        {
            flappyBird.Location = defaultPos;
            score = 0;
            gravity = defaultGravity;
            boruHizi = defaultBoruHizi;
            gameTimer.Start();
            groupBox1.Visible = false;
            this.Select();
        }

        private void pBoxGameOver_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RestartGame();
            pictureBox1.Enabled = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}