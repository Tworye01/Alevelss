
namespace rocket
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftT = new System.Windows.Forms.Timer(this.components);
            this.RightT = new System.Windows.Forms.Timer(this.components);
            this.UpT = new System.Windows.Forms.Timer(this.components);
            this.DownT = new System.Windows.Forms.Timer(this.components);
            this.MoveMissleTimer = new System.Windows.Forms.Timer(this.components);
            this.Etimer = new System.Windows.Forms.Timer(this.components);
            this.Etimer2 = new System.Windows.Forms.Timer(this.components);
            this.EMoveMissleTimer = new System.Windows.Forms.Timer(this.components);
            this.ExitB = new System.Windows.Forms.Button();
            this.PlayB = new System.Windows.Forms.Button();
            this.HighS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.levels1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::RocketShip.Properties.Resources.New_Piskel__4_;
            this.Player.Location = new System.Drawing.Point(329, 473);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(36, 59);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // MoveTimer
            // 
            this.MoveTimer.Enabled = true;
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick_1);
            // 
            // LeftT
            // 
            this.LeftT.Interval = 1;
            this.LeftT.Tick += new System.EventHandler(this.Left_Tick);
            // 
            // RightT
            // 
            this.RightT.Interval = 1;
            this.RightT.Tick += new System.EventHandler(this.Right_Tick);
            // 
            // UpT
            // 
            this.UpT.Interval = 1;
            this.UpT.Tick += new System.EventHandler(this.Up_Tick);
            // 
            // DownT
            // 
            this.DownT.Interval = 1;
            this.DownT.Tick += new System.EventHandler(this.Down_Tick);
            // 
            // MoveMissleTimer
            // 
            this.MoveMissleTimer.Enabled = true;
            this.MoveMissleTimer.Interval = 20;
            this.MoveMissleTimer.Tick += new System.EventHandler(this.MoveMissileTimer_Tick_1);
            // 
            // Etimer
            // 
            this.Etimer.Enabled = true;
            this.Etimer.Tick += new System.EventHandler(this.Etimer1_Tick);
            // 
            // Etimer2
            // 
            this.Etimer2.Enabled = true;
            this.Etimer2.Tick += new System.EventHandler(this.Etimer2_Tick);
            // 
            // EMoveMissleTimer
            // 
            this.EMoveMissleTimer.Enabled = true;
            this.EMoveMissleTimer.Interval = 20;
            this.EMoveMissleTimer.Tick += new System.EventHandler(this.EMoveMissleTimer_Tick);
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.Color.Yellow;
            this.ExitB.Font = new System.Drawing.Font("Minecrafter", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitB.ForeColor = System.Drawing.Color.DeepPink;
            this.ExitB.Location = new System.Drawing.Point(92, 334);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(188, 73);
            this.ExitB.TabIndex = 1;
            this.ExitB.Text = "EXIT";
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Visible = false;
            this.ExitB.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayB
            // 
            this.PlayB.BackColor = System.Drawing.Color.Yellow;
            this.PlayB.Font = new System.Drawing.Font("Minecrafter", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayB.ForeColor = System.Drawing.Color.DeepPink;
            this.PlayB.Location = new System.Drawing.Point(251, 224);
            this.PlayB.Name = "PlayB";
            this.PlayB.Size = new System.Drawing.Size(188, 73);
            this.PlayB.TabIndex = 2;
            this.PlayB.Text = "PLAY";
            this.PlayB.UseVisualStyleBackColor = false;
            this.PlayB.Visible = false;
            this.PlayB.Click += new System.EventHandler(this.PlayB_Click);
            // 
            // HighS
            // 
            this.HighS.BackColor = System.Drawing.Color.Yellow;
            this.HighS.Font = new System.Drawing.Font("Minecrafter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HighS.ForeColor = System.Drawing.Color.DeepPink;
            this.HighS.Location = new System.Drawing.Point(395, 334);
            this.HighS.Name = "HighS";
            this.HighS.Size = new System.Drawing.Size(188, 73);
            this.HighS.TabIndex = 3;
            this.HighS.Text = "HIGHSCORES";
            this.HighS.UseVisualStyleBackColor = false;
            this.HighS.Visible = false;
            this.HighS.Click += new System.EventHandler(this.HighS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Minecrafter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score1.ForeColor = System.Drawing.Color.Yellow;
            this.score1.Location = new System.Drawing.Point(52, 9);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(21, 11);
            this.score1.TabIndex = 6;
            this.score1.Text = "00";
            // 
            // levels1
            // 
            this.levels1.AutoSize = true;
            this.levels1.BackColor = System.Drawing.Color.Transparent;
            this.levels1.Font = new System.Drawing.Font("Minecrafter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.levels1.ForeColor = System.Drawing.Color.Yellow;
            this.levels1.Location = new System.Drawing.Point(54, 33);
            this.levels1.Name = "levels1";
            this.levels1.Size = new System.Drawing.Size(18, 11);
            this.levels1.TabIndex = 7;
            this.levels1.Text = "01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Minecrafter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 11);
            this.label2.TabIndex = 8;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Minecrafter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(0, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 11);
            this.label3.TabIndex = 9;
            this.label3.Text = "Level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Minecrafter", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(69, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(551, 42);
            this.label4.TabIndex = 10;
            this.label4.Text = "ROCKETS VS ALIENS";
            this.label4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RocketShip.Properties.Resources.heart;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(637, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::RocketShip.Properties.Resources.heart;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(602, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::RocketShip.Properties.Resources.heart;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(566, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Yellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.Color.Yellow;
            this.dataGridView1.Location = new System.Drawing.Point(95, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(488, 308);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::RocketShip.Properties.Resources.gfgfgfg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.levels1);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HighS);
            this.Controls.Add(this.PlayB);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.Player);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.Timer LeftT;
        private System.Windows.Forms.Timer RightT;
        private System.Windows.Forms.Timer UpT;
        private System.Windows.Forms.Timer DownT;
        private System.Windows.Forms.Timer MoveMissleTimer;
        private System.Windows.Forms.Timer Etimer;
        private System.Windows.Forms.Timer Etimer2;
        private System.Windows.Forms.Timer EMoveMissleTimer;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Button PlayB;
        private System.Windows.Forms.Button HighS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label levels1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

