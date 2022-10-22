
namespace Game_2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MoveLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveRightTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveUpTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveDownTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.Control = new System.Windows.Forms.Label();
            this.GameOver = new System.Windows.Forms.Label();
            this.Retry = new System.Windows.Forms.Label();
            this.VisibleTrueTimer = new System.Windows.Forms.Timer(this.components);
            this.MainMenu = new System.Windows.Forms.Label();
            this.Sure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MoveLeftTimer
            // 
            this.MoveLeftTimer.Tick += new System.EventHandler(this.MoveLeftTimer_Tick);
            // 
            // MoveRightTimer
            // 
            this.MoveRightTimer.Tick += new System.EventHandler(this.MoveRightTimer_Tick);
            // 
            // MoveUpTimer
            // 
            this.MoveUpTimer.Tick += new System.EventHandler(this.MoveUpTimer_Tick);
            // 
            // MoveDownTimer
            // 
            this.MoveDownTimer.Tick += new System.EventHandler(this.MoveDownTimer_Tick);
            // 
            // EnemyMoveTimer
            // 
            this.EnemyMoveTimer.Tick += new System.EventHandler(this.EnemyMove_Tick);
            // 
            // Control
            // 
            this.Control.AutoSize = true;
            this.Control.BackColor = System.Drawing.Color.Transparent;
            this.Control.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Control.ForeColor = System.Drawing.Color.Crimson;
            this.Control.Location = new System.Drawing.Point(12, 9);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(441, 52);
            this.Control.TabIndex = 0;
            this.Control.Text = "WASD - Управление.\r\nПри перемещении, враги и стены будут видны\r\n";
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameOver.ForeColor = System.Drawing.Color.DarkRed;
            this.GameOver.Image = global::Game_2._0.Properties.Resources.GameOver;
            this.GameOver.Location = new System.Drawing.Point(310, 227);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(386, 79);
            this.GameOver.TabIndex = 1;
            this.GameOver.Text = "Game Over";
            this.GameOver.Visible = false;
            // 
            // Retry
            // 
            this.Retry.AutoSize = true;
            this.Retry.BackColor = System.Drawing.Color.Transparent;
            this.Retry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Retry.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Retry.ForeColor = System.Drawing.Color.Crimson;
            this.Retry.Location = new System.Drawing.Point(465, 310);
            this.Retry.Name = "Retry";
            this.Retry.Size = new System.Drawing.Size(91, 30);
            this.Retry.TabIndex = 2;
            this.Retry.Text = "Retry";
            this.Retry.Visible = false;
            this.Retry.Click += new System.EventHandler(this.Retry_Click);
            // 
            // VisibleTrueTimer
            // 
            this.VisibleTrueTimer.Interval = 250;
            this.VisibleTrueTimer.Tick += new System.EventHandler(this.VisibleTrueTimer_Tick);
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = true;
            this.MainMenu.BackColor = System.Drawing.Color.Transparent;
            this.MainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenu.Font = new System.Drawing.Font("Showcard Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenu.ForeColor = System.Drawing.Color.Crimson;
            this.MainMenu.Location = new System.Drawing.Point(1069, 634);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(183, 38);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Sure
            // 
            this.Sure.AutoSize = true;
            this.Sure.BackColor = System.Drawing.Color.Transparent;
            this.Sure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sure.Font = new System.Drawing.Font("Showcard Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sure.ForeColor = System.Drawing.Color.Crimson;
            this.Sure.Location = new System.Drawing.Point(1106, 596);
            this.Sure.Name = "Sure";
            this.Sure.Size = new System.Drawing.Size(109, 38);
            this.Sure.TabIndex = 4;
            this.Sure.Text = "Sure?";
            this.Sure.Visible = false;
            this.Sure.Click += new System.EventHandler(this.Sure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Sure);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Retry);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.Control);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Blind";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer MoveLeftTimer;
        private System.Windows.Forms.Timer MoveRightTimer;
        private System.Windows.Forms.Timer MoveUpTimer;
        private System.Windows.Forms.Timer MoveDownTimer;
        private System.Windows.Forms.Timer EnemyMoveTimer;
        private System.Windows.Forms.Label Control;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.Label Retry;
        private System.Windows.Forms.Timer VisibleTrueTimer;
        private System.Windows.Forms.Label MainMenu;
        private System.Windows.Forms.Label Sure;
    }
}

