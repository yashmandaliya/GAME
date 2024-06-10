using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {

        int gravity = 5;
        int pipeSpeed = 8;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreLabel.Text = "Score :" + score;

            if(pipeBottom.Left < -50)
            {
                pipeBottom.Left = 800;
                score++;
            }

            if(pipeTop.Left < -80)
            {
                pipeTop.Left = 950;
                score++;
            }

            if(flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
               flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
               flappyBird.Top <= -25)
            {
                EndGame();
            }

            if(score > 15)
            {
                pipeSpeed = 25;
            }
            if(score > 35)
            {
                pipeSpeed = 45;
            }
        }
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
            if(e.KeyCode == Keys.Escape)
            {
                gameTimer1.Stop();
            }
            if(e.KeyCode == Keys.F6)
            {
                gameTimer1.Start();
            }
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        public void EndGame()
        {
            gameTimer1.Stop();
            MessageBox.Show("Game Over");          
        }       
    }
}
