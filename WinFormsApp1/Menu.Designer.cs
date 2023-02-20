
namespace rocket
{
    partial class Menu
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
            this.PlayB = new System.Windows.Forms.Button();
            this.ExitB = new System.Windows.Forms.Button();
            this.HighS = new System.Windows.Forms.Button();
            this.TITLE = new System.Windows.Forms.Label();
            this.controls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayB
            // 
            this.PlayB.BackColor = System.Drawing.Color.Yellow;
            this.PlayB.Font = new System.Drawing.Font("Minecrafter", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayB.ForeColor = System.Drawing.Color.DeepPink;
            this.PlayB.Location = new System.Drawing.Point(247, 225);
            this.PlayB.Name = "PlayB";
            this.PlayB.Size = new System.Drawing.Size(188, 73);
            this.PlayB.TabIndex = 3;
            this.PlayB.Text = "PLAY";
            this.PlayB.UseVisualStyleBackColor = false;
            this.PlayB.Click += new System.EventHandler(this.PlayB_Click);
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.Color.Yellow;
            this.ExitB.Font = new System.Drawing.Font("Minecrafter", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitB.ForeColor = System.Drawing.Color.DeepPink;
            this.ExitB.Location = new System.Drawing.Point(89, 345);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(188, 73);
            this.ExitB.TabIndex = 4;
            this.ExitB.Text = "EXIT";
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // HighS
            // 
            this.HighS.BackColor = System.Drawing.Color.Yellow;
            this.HighS.Font = new System.Drawing.Font("Minecrafter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HighS.ForeColor = System.Drawing.Color.DeepPink;
            this.HighS.Location = new System.Drawing.Point(400, 345);
            this.HighS.Name = "HighS";
            this.HighS.Size = new System.Drawing.Size(188, 73);
            this.HighS.TabIndex = 5;
            this.HighS.Text = "HIGHSCORES";
            this.HighS.UseVisualStyleBackColor = false;
            this.HighS.Click += new System.EventHandler(this.HighS_Click);
            // 
            // TITLE
            // 
            this.TITLE.AutoSize = true;
            this.TITLE.BackColor = System.Drawing.Color.Yellow;
            this.TITLE.Font = new System.Drawing.Font("Minecrafter", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TITLE.ForeColor = System.Drawing.Color.DarkViolet;
            this.TITLE.Location = new System.Drawing.Point(76, 114);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(551, 42);
            this.TITLE.TabIndex = 6;
            this.TITLE.Text = "ROCKETS VS ALIENS";
            // 
            // controls
            // 
            this.controls.BackColor = System.Drawing.Color.Yellow;
            this.controls.Font = new System.Drawing.Font("Minecrafter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controls.ForeColor = System.Drawing.Color.DeepPink;
            this.controls.Location = new System.Drawing.Point(266, 454);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(159, 44);
            this.controls.TabIndex = 15;
            this.controls.Text = "CONTROLS";
            this.controls.UseVisualStyleBackColor = false;
            this.controls.Click += new System.EventHandler(this.controls_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::RocketShip.Properties.Resources.gfgfgfg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.HighS);
            this.Controls.Add(this.ExitB);
            this.Controls.Add(this.PlayB);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayB;
        private System.Windows.Forms.Button ExitB;
        private System.Windows.Forms.Button HighS;
        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Button controls;
    }
}