using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Form1 : Form
    {
        int[,] board;
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Timer aTimer2;
        private int counter = 60;
        Bitmap RED = new Bitmap("C:\\Users\\USER\\Desktop\\TETRIS COLORS\\RED BRICK.png");
        Bitmap bmpBoard = new Bitmap(250, 500);
        private void startgame()
        {
            board = new int[20, 10];
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i, j] = 0;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int temp = 1000;
            label1.Text = "EASY";
            x = 0;
            y = 0;
            aTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(aTimer_Tick);
            //aTimer.Interval = 0;
            aTimer.Interval = temp;
            aTimer.Start();
            label3.Text = counter.ToString();
            
            
        }
        private void aTimer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                aTimer.Stop();
            label3.Text = counter.ToString() + " " + aTimer.Interval.ToString();

            if (y<19)
                y++;

            label5.Text = y.ToString();
            Graphics.FromImage(bmpBoard).DrawImage(RED, x * 25, y * 25,(x+1)*25,(y+1)*25);
            boardGamePanel1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "MEDIUM";
            if (counter != 0)
            {
                int temp = 800;
                aTimer.Stop();
                counter = 60;
                aTimer2 = new System.Windows.Forms.Timer();
                aTimer2.Tick += new EventHandler(aTimer_Tick);
                //aTimer.Interval = 0;
                aTimer2.Interval = temp;
                aTimer2.Start();
                label3.Text = counter.ToString() + " " + aTimer2.Interval.ToString();
            }
        }

        private void veBoard(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(RED, x * 25, y * 25,25,25);
            
            //e.Graphics.DrawImage(bmpBoard, 0, 0);
            //MessageBox.Show("dau cat moi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.TabStop = false;
            button2.TabStop = false;
            button3.TabStop = false;
            button4.TabStop = false;
            button5.TabStop = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "VERY HARD";
            if (counter != 0)
            {
                aTimer.Stop();
                counter = 60;
                aTimer = new System.Windows.Forms.Timer();
                aTimer.Tick += new EventHandler(aTimer_Tick);
                aTimer.Interval = 400;
                aTimer.Start();
                label3.Text = counter.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "HARD";
            if (counter != 0)
            {
                aTimer.Stop();
                counter = 60;
                aTimer = new System.Windows.Forms.Timer();
                aTimer.Tick += new EventHandler(aTimer_Tick);
                aTimer.Interval = 600;
                aTimer.Start();
                label3.Text = counter.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "INSANE";
            if (counter != 0)
            {
                aTimer.Stop();
                counter = 60;
                aTimer = new System.Windows.Forms.Timer();
                aTimer.Tick += new EventHandler(aTimer_Tick);
                aTimer.Interval = 200;
                aTimer.Start();
                label3.Text = counter.ToString();
            }
        }

        private void boardGamePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            label5.Text = e.X.ToString() + " " + e.Y.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                MessageBox.Show("dau cat moi");
            if (e.KeyCode == Keys.Down)
                MessageBox.Show("dau cat moi");
            if (e.KeyCode == Keys.Right)
                MessageBox.Show("dau cat moi");
            if (e.KeyCode == Keys.Left)
                MessageBox.Show("dau cat moi");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "EASY";
            x = 0;
            y = 0;
            aTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(aTimer_Tick);
            aTimer.Interval = 1000;
            aTimer.Start();
            label3.Text = counter.ToString();

        }

        private void imgpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
