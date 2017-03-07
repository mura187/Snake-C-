using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication7
{
    public partial class lbl : Form
    {
        private int direction = 0;
        public int score = 0;
        private Timer gameLoop = new Timer();
        private Random rand = new Random();
        private Graphics graphics;
        private Snake snake;
        private Food food;
        private int level = 1;

        public lbl()
        {
            InitializeComponent();
            snake = new Snake();
            food = new Food(rand);
            gameLoop.Interval = 85;
            gameLoop.Tick += Update;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelMenu_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (labelMenu.Visible)
            {
                labelMenu.Visible = false;
                gameLoop.Start();

            }
        }
        private void labelMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (labelMenu.Visible)
                    {
                        labelMenu.Visible = false;
                        gameLoop.Start();

                    }
                    break;
                case Keys.Space:
                    break;
                case Keys.Right:
                    if (direction != 2)
                        direction = 0;
                    break;
                case Keys.Down:
                    if (direction != 3)
                        direction = 1;
                    break;
                case Keys.Left:
                    if (direction != 0)
                        direction = 2;
                    break;
                case Keys.Up:
                    if (direction != 1)
                        direction = 3;
                    break;

            }
        }

        private void labelMenu_Paint(object sender, PaintEventArgs e)
        {
            graphics = this.CreateGraphics();
            snake.Draw(graphics);
            food.Draw(graphics);
        }
        private void Update(object sender, EventArgs e)
        {
            label2.Text = string.Format("Your Level is:{0}", level);
            label1.Text = string.Format("Score:{0}", score);
            this.Text = string.Format("Snake by Murat V2.0 Your Score is:{0}", score);
            snake.Move(direction);
            for (int i = 1; i < snake.Body.Length; i++)
                if (snake.Body[0].IntersectsWith(snake.Body[i]))
                    Restart();

            if (snake.Body[0].X < 0 || snake.Body[0].X > 1004)

                Restart();
            if (snake.Body[0].Y < 0 || snake.Body[0].Y > 610)

                Restart();
            if (snake.Body[0].IntersectsWith(food.Piece))
            {

                score += 75;
                level += 1;
                snake.Grow();
                if (snake.Body[0].X == food.Piece.X && snake.Body[0].Y == food.Piece.Y){
                    food.Generate(rand);
                }
                if (score > 224)
                {
                    gameLoop.Interval = 70;
                }
                if (score > 299)
                {
                    gameLoop.Interval = 74;
                }
                if (score > 375)
                {
                    gameLoop.Interval = 65;
                }
                if (score > 474)
                {
                    gameLoop.Interval = 56;
                }
                if (score > 549)
                {
                    gameLoop.Interval = 50;
                }
                if (score > 624)
                {
                    gameLoop.Interval = 45;
                }
            }
            this.Invalidate();

        }
        private void Restart()
        {
            gameLoop.Stop();
            graphics.Clear(SystemColors.Control);
            snake = new Snake();
            food = new Food(rand);
            direction = 0;
            score = 0;
            level = 1;
            labelMenu.Visible = true;
            gameLoop.Interval = 85;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Text = string.Format("Ваши очки:{0}", score);
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Text = string.Format("Your level is:{0}", level);
        }

    }
}

