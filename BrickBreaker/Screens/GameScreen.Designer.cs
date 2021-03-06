﻿namespace BrickBreaker
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.scoreLabel.Location = new System.Drawing.Point(647, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(390, 51);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "SCORE:";
            // 
            // lifeLabel
            // 
            this.lifeLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.lifeLabel.Location = new System.Drawing.Point(3, 0);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(453, 51);
            this.lifeLabel.TabIndex = 1;
            this.lifeLabel.Text = "LIVES:";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lifeLabel);
            this.Controls.Add(this.scoreLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1037, 606);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label lifeLabel;
    }
}
