
namespace RocketShip
{
    partial class Form2
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
            this.ExitB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitB
            // 
            this.ExitB.BackColor = System.Drawing.Color.Yellow;
            this.ExitB.Font = new System.Drawing.Font("Minecrafter", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitB.ForeColor = System.Drawing.Color.DeepPink;
            this.ExitB.Location = new System.Drawing.Point(508, 482);
            this.ExitB.Name = "ExitB";
            this.ExitB.Size = new System.Drawing.Size(154, 54);
            this.ExitB.TabIndex = 5;
            this.ExitB.Text = "EXIT";
            this.ExitB.UseVisualStyleBackColor = false;
            this.ExitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RocketShip.Properties.Resources.gfgfgfg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.ExitB);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitB;
    }
}