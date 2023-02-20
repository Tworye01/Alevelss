using RocketShip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace rocket
{


    public partial class Form1 : Form
    {
        Random rnd;

        // stars 
        PictureBox[] starsback;

        //background/player speed
        int backgroundspeed;
        int playerSpeed;

        //speed of enemies
        PictureBox[] enemey;

        int enemySpeed;

        //hearts

        int health;

        //commets
        PictureBox[] commets;

        //missiles
        PictureBox[] EnemyMissle;

        int EnemyMissleSpeed;
        PictureBox[] missles;
        int missleSpeed;

        // score
        int score;
        // levels of play
        int levels;
        // difficulty
        int diff;


        bool pause;
        bool gameover;
      
       

        static String paths = Path.GetFullPath(Environment.CurrentDirectory);
        static String dataBName = "data9.mdf";
        string connectString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=" + paths + @"\" + dataBName + "; Integrated Security=True;";
        //transparency of sprites
        public Form1()

        {
            
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();

        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

            //setting variables
            UpdateScores();
            health = 3;
            pause = false;
            gameover = false;
            score = 0;
            levels = 1;
            diff = 9;
            backgroundspeed = 30;
            playerSpeed = 4;
            Name = "natan";
            enemySpeed = 4;
            missleSpeed = 20;
            EnemyMissleSpeed = 4;
            missles = new PictureBox[1];
            rnd = new Random();
          
            //images 
            Image enemy_1 = Image.FromFile(@"asserts\\enemyblue.png");
            Image enemy_2 = Image.FromFile(@"asserts\\enemygreen.png");
            Image enemy_3 = Image.FromFile(@"asserts\\enemyred.png");
            Image enemy_4 = Image.FromFile(@"asserts\\alienboss.png");
            Image hearts = Image.FromFile(@"asserts\\heart.png");
            Image missle = Image.FromFile(@"asserts\\missle.png");
            Image commet1 = Image.FromFile(@"asserts\\Commet2.png");
            Image commet2 = Image.FromFile(@"asserts\\Commet3.png");
            //commets spawning
            commets = new PictureBox[2];
            for (int i = 0; i < commets.Length; i++)
            {
                commets[i] = new PictureBox();
                commets[i].Size = new Size(30, 30);
                commets[i].Visible = false;
                commets[i].SizeMode = PictureBoxSizeMode.Zoom;
                commets[i].BorderStyle = BorderStyle.None;

                int y = rnd.Next(-400, -240);
                int x = rnd.Next(50, 650);
                this.Controls.Add(commets[i]);
                commets[i].Location = new Point(x, y);
            }
            commets[0].Image = commet1;
            commets[1].Image = commet2;


            //main enemies
            enemey = new PictureBox[8];
            for (int i = 0; i < enemey.Length; i++)
            {
                int x = rnd.Next(50, 650);
                int y = rnd.Next(-100, -20);
                enemey[i] = new PictureBox();
                enemey[i].Size = new Size(50, 50);
                enemey[i].Visible = false;
                enemey[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemey[i].BorderStyle = BorderStyle.None;

                this.Controls.Add(enemey[i]);
                if (enemey[i].Bounds.IntersectsWith(enemey[i].Bounds))
                {
                    enemey[i].Visible = false;
                }

                enemey[i].Location = new Point(x, y);






            }

            enemey[0].Image = enemy_1;
            enemey[1].Image = enemy_2;
            enemey[2].Image = enemy_3;
            enemey[3].Image = enemy_3;
            enemey[4].Image = enemy_1;
            enemey[5].Image = enemy_3;
            enemey[6].Image = enemy_2;
            enemey[7].Image = enemy_4;



            //player missiles
            for (int i = 0; i < missles.Length; i++)
            {
                missles[i] = new PictureBox();
                missles[i].Size = new Size(20, 20);
                missles[i].Image = missle;
                missles[i].SizeMode = PictureBoxSizeMode.Zoom;
                missles[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(missles[i]);


            }
            starsback = new PictureBox[30];
            rnd = new Random();


            //stars background
            // with reference to https://www.youtube.com/watch?v=cU8ZBJTZA6E&list=PL-K0viiuJ2ReKWkb2-zWT2Fb3QXALsed3&index=2&ab_channel=Madsycode
            for (int i = 0; i < starsback.Length; i++)
            {

                starsback[i] = new PictureBox();
                starsback[i].BorderStyle = BorderStyle.None;
                starsback[i].Location = new Point(rnd.Next(20, 700), rnd.Next(-10, 700));

                if (i % 2 == 1)
                {
                    starsback[i].Size = new Size(2, 2);
                    starsback[i].BackColor = Color.White;


                }
                else
                {
                    starsback[i].Size = new Size(3, 3);
                    starsback[i].BackColor = Color.DarkGray;
                    starsback[i].Size = new Size(3, 2);
                    starsback[i].BackColor = Color.Yellow;
                    starsback[i].Size = new Size(2, 2);
                    starsback[i].BackColor = Color.LightBlue;
                }


                this.Controls.Add(starsback[i]);

            }

            //enemy missiles
            EnemyMissle = new PictureBox[8];

            for (int i = 0; i < EnemyMissle.Length; i++)
            {
                EnemyMissle[i] = new PictureBox();
                EnemyMissle[i].Size = new Size(3, 20);
                EnemyMissle[i].Visible = false;
                EnemyMissle[i].BackColor = Color.HotPink;
                int x = rnd.Next(0, 8);
                EnemyMissle[i].Location = new Point(enemey[x].Location.X, enemey[x].Location.Y - 20);
                this.Controls.Add(EnemyMissle[i]);



            }


        }


        //timer for the background
        private void MoveTimer_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < starsback.Length / 2; i++)
            {
                starsback[i].Top += backgroundspeed;


                if (starsback[i].Top >= this.Height)
                {
                    starsback[i].Top = -starsback[i].Height;

                }
            }
            for (int i = starsback.Length / 2; i < starsback.Length; i++)
            {
                starsback[i].Top += backgroundspeed - 2;


                if (starsback[i].Top >= this.Height)
                {
                    starsback[i].Top = -starsback[i].Height;


                }


            }


        }





        //timer for the player missiles
        private void MoveMissileTimer_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < missles.Length; i++)
            {
                if (missles[i].Top > 0)
                {
                    missles[i].Visible = true;
                    missles[i].Top -= missleSpeed;
                    Collions();
                    Collions3();
                }
                else
                {

                    missles[i].Visible = false;
                    missles[i].Location = new Point(Player.Location.X + 7, Player.Location.Y - i * 30);

                }






            }


        }

        //movement to the left
        private void Left_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }

        }

        //movement to the right
        private void Right_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 680)
            {
                Player.Left += playerSpeed;
            }

        }

        //movement to the bottom
        private void Down_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 500)
            {
                Player.Top += playerSpeed;
            }

        }

        //movement to the top
        private void Up_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }

        }

        //keypresses relating to movement
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   //if paused key inputs cant be used
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    RightT.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    LeftT.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    DownT.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    UpT.Start();
                }
            }


        }

        //stopping movement timers
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            LeftT.Stop();
            RightT.Stop();
            UpT.Stop();
            DownT.Stop();
            // if space is pressed, the game is paused

            if (e.KeyCode == Keys.Space)
            {
                if (!gameover)
                {
                    if (pause)
                    {
                        //when in paused and space bar is pressed the game continues
                        StartTime();
                        label4.Visible = false;
                        pause = false;
                    }
                    else
                    {
                        label4.Location = new Point(this.Width / 2 - 120, 150);
                        label4.Text = "PAUSED";
                        label4.Visible = true;
                        StopTime();
                        pause = true;
                    }
                }
            }
        }

        //Main enemy timers
        private void Etimer1_Tick(object sender, EventArgs e)
        {
            Enemymovement(enemey, enemySpeed);

        }

        private void Etimer2_Tick(object sender, EventArgs e)
        {

            Enemymovement2(commets, enemySpeed);
        }


        //enemy movement
        private void Enemymovement(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    int x = rnd.Next(50, 650);
                    int y = rnd.Next(-100, -20);
                    enemey[i].Location = new Point(x, y);
                }
            }
        }

        private void Enemymovement2(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    int x = rnd.Next(50, 650);
                    int y = rnd.Next(-100, -20);
                    commets[i].Location = new Point(x, y);
                }
            }
        }



        // collisions with player and enemy
        private void Collions()
        {
            int y = rnd.Next(-100, -20);
            int x = rnd.Next(50, 650);
            for (int i = 0; i < enemey.Length; i++)

            {




                if (missles[0].Bounds.IntersectsWith(enemey[i].Bounds))
                {


                    score += 1;
                    Score2();

                    enemey[i].Location = new Point(x, y);

                }
                if (Player.Bounds.IntersectsWith(enemey[i].Bounds))
                {

                    enemey[i].Location = new Point(x, y);
                    health--;
                    Health2();



                }

            }


        }


        // collisions with player and commets
        private void Collions3()
        {
            int y = rnd.Next(-400, -240);
            int x = rnd.Next(200, 500);
            for (int i = 0; i < commets.Length; i++)
            {
                if (missles[0].Bounds.IntersectsWith(commets[i].Bounds))
                {
                    score += 2;
                    Score2();





                    commets[i].Location = new Point(x, y);
                }
                if (Player.Bounds.IntersectsWith(commets[i].Bounds))
                {


                    commets[i].Location = new Point(x, y);
                    health--;
                    Health2();

                }

            }


        }


        // Ends game
        //highscores

        private void Gameend(String str)
        {
            
            label4.Text = str;
            label4.Location = new Point(200, 100);
            label4.Visible = true;
            PlayB.Visible = true;
            ExitB.Visible = true;
            HighS.Visible = true;
            CurrentScores();
            UpdateScores();


            StopTime();
       

        }
        // Stops the timers
        private void StopTime()
        {
            MoveMissleTimer.Stop();
            MoveTimer.Stop();
            Etimer.Stop();
            Etimer2.Stop();
            EMoveMissleTimer.Stop();

        }
        // Starts the timers
        private void StartTime()
        {
            MoveMissleTimer.Start();
            MoveTimer.Start();
            Etimer.Start();
            Etimer2.Start();
            EMoveMissleTimer.Start();

        }

        // timer for enemny missile 
        private void EMoveMissleTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < EnemyMissle.Length; i++)
            {
                if (EnemyMissle[i].Top < this.Height)
                {
                    EnemyMissle[i].Visible = true;
                    EnemyMissle[i].Top += EnemyMissleSpeed;
                    CollisionsEnemyMis();
                }
                else
                {
                    EnemyMissle[i].Visible = false;
                    int x = rnd.Next(0, 8);
                    EnemyMissle[i].Location = new Point(enemey[x].Location.X + 20, enemey[x].Location.Y + 30);

                }
            }


        }

        private void Score2()
        {
            score1.Text = (score < 10) ? "0" + score.ToString() : score.ToString();
            if (score % 30 == 0)
            {
                levels += 1;
                levels1.Text = (levels < 10) ? "0" + levels.ToString() : score.ToString();

                if (enemySpeed <= 10 && EnemyMissleSpeed <= 10 && diff >= 0)
                {
                    diff--;
                    enemySpeed++;
                    EnemyMissleSpeed++;

                }
                if (levels == 2)
                {
                    BackgroundImage = Image.FromFile(@"asserts\\blue_space.png");
                }

                if (levels == 3)
                {
                    BackgroundImage = Image.FromFile(@"asserts\\mars.png");

                }
            }

        }


        // collisions with player and enemny missile 
        private void CollisionsEnemyMis()
        {
            for (int i = 0; i < EnemyMissle.Length; i++)
            {
                if (EnemyMissle[i].Bounds.IntersectsWith(Player.Bounds))
                {

                    int x = rnd.Next(0, 8);
                    EnemyMissle[i].Location = new Point(enemey[x].Location.X + 20, enemey[x].Location.Y + 30);
                    health = health - 1;
                    Health2();



                }



            }


        }

        //health system in the game
        private void Health2()
        {
            if (health == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }

            if (health == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }

            if (health == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }


            if (health <= 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                Gameend("GAME OVER");
            }

        }




        // exit buttoin
        private void button1_Click(object sender, EventArgs e)
        {
            //exits out 

            Environment.Exit(1);
        }
        // play button
        private void PlayB_Click(object sender, EventArgs e)
        {

            //resets the game
            health = 3;
            

            this.Controls.Clear();
            InitializeComponent();

            Form1_Load_1(e, e);
      






        }

        // highscore button
        private void HighS_Click(object sender, EventArgs e)
        {
           
            PlayB.Visible = false;
            ExitB.Visible = true;
            HighS.Visible = false;
          
            dataGridView1.Visible = true;
          

        }


        private void UpdateScores()
        {   //using sql to select the data from the database
            string query = "SELECT Date,Name,Score FROM tablesss";
            using SqlConnection con = new SqlConnection(connectString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //the order of the code is descending
            dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Descending);

        }

        
        private void CurrentScores()
        {   //this inserts the new scores into the table
            string query = "INSERT INTO tablesss(Date,Name,Score) VALUES(@Date,@Name,@Score);";

            using SqlConnection con = new SqlConnection(connectString);
            using SqlCommand cmd = new SqlCommand(query, con);
            //this assaigns which paramters are assaigned to a variable 
            cmd.Parameters.Add("@Score", SqlDbType.Int).Value = score1.Text;
            cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;



            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }




        }

        private void name1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}