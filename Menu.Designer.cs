
namespace Game_2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Start = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Label();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.Volume = new System.Windows.Forms.Label();
            this.GameName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.Font = new System.Drawing.Font("Showcard Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start.ForeColor = System.Drawing.Color.Crimson;
            this.Start.Location = new System.Drawing.Point(527, 235);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(194, 67);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.Click += new System.EventHandler(this.start_Click);
            // 
            // Quit
            // 
            this.Quit.AutoSize = true;
            this.Quit.BackColor = System.Drawing.Color.Transparent;
            this.Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quit.Font = new System.Drawing.Font("Showcard Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quit.ForeColor = System.Drawing.Color.Crimson;
            this.Quit.Location = new System.Drawing.Point(1160, 634);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(92, 38);
            this.Quit.TabIndex = 1;
            this.Quit.Text = "Quit";
            this.Quit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(498, 343);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(263, 45);
            this.volumeBar.TabIndex = 3;
            this.volumeBar.Value = 2;
            this.volumeBar.Visible = false;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.BackColor = System.Drawing.Color.Transparent;
            this.Volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Volume.Font = new System.Drawing.Font("Showcard Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Volume.ForeColor = System.Drawing.Color.Crimson;
            this.Volume.Location = new System.Drawing.Point(550, 302);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(139, 38);
            this.Volume.TabIndex = 4;
            this.Volume.Text = "Volume";
            this.Volume.Click += new System.EventHandler(this.Volume_Click);
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.BackColor = System.Drawing.Color.Transparent;
            this.GameName.Font = new System.Drawing.Font("Chiller", 150F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameName.ForeColor = System.Drawing.Color.Crimson;
            this.GameName.Location = new System.Drawing.Point(426, 9);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(403, 230);
            this.GameName.TabIndex = 5;
            this.GameName.Text = "Blind";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.GameName);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Start);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blind";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label Quit;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label GameName;
    }
}