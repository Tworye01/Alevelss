
namespace RocketShip
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Minecrafter", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(5, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 294);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROLS:\r\n\r\nUp: UP Arrow Key\r\nDown: DOWN Arrow Key\r\nLEFT: LEFT Arrow Key\r\nRIGHT:" +
    " RIGHT Arrow Key\r\nSPACE:PAuse GAme";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Yellow;
            this.Exit.Font = new System.Drawing.Font("Minecrafter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.DeepPink;
            this.Exit.Location = new System.Drawing.Point(507, 489);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(171, 60);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RocketShip.Properties.Resources.gfgfgfg;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
    }
}