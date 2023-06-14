
namespace project_2
{
    partial class end
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(end));
            this.over = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.scoredPointsL = new System.Windows.Forms.Label();
            this.exitMenu = new System.Windows.Forms.Button();
            this.exitdesktop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeSpentL = new System.Windows.Forms.Label();
            this.difficultyL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Transparent;
            this.over.Font = new System.Drawing.Font("PMingLiU-ExtB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.over.Location = new System.Drawing.Point(99, 12);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(200, 37);
            this.over.TabIndex = 0;
            this.over.Text = "Game Over!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCORE:";
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // scoredPointsL
            // 
            this.scoredPointsL.AutoSize = true;
            this.scoredPointsL.BackColor = System.Drawing.Color.Transparent;
            this.scoredPointsL.Font = new System.Drawing.Font("PMingLiU-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.scoredPointsL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoredPointsL.Location = new System.Drawing.Point(176, 77);
            this.scoredPointsL.Name = "scoredPointsL";
            this.scoredPointsL.Size = new System.Drawing.Size(0, 29);
            this.scoredPointsL.TabIndex = 2;
            // 
            // exitMenu
            // 
            this.exitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitMenu.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitMenu.Location = new System.Drawing.Point(216, 203);
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(75, 46);
            this.exitMenu.TabIndex = 4;
            this.exitMenu.Text = "Exit to Menu";
            this.exitMenu.UseVisualStyleBackColor = true;
            this.exitMenu.Visible = false;
            // 
            // exitdesktop
            // 
            this.exitdesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitdesktop.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitdesktop.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitdesktop.Location = new System.Drawing.Point(297, 203);
            this.exitdesktop.Name = "exitdesktop";
            this.exitdesktop.Size = new System.Drawing.Size(75, 46);
            this.exitdesktop.TabIndex = 5;
            this.exitdesktop.Text = "Exit to Desktop";
            this.exitdesktop.UseVisualStyleBackColor = true;
            this.exitdesktop.Click += new System.EventHandler(this.exitdesktop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "TIME SPENT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("PMingLiU-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "DIFFICULTY:";
            // 
            // timeSpentL
            // 
            this.timeSpentL.AutoSize = true;
            this.timeSpentL.BackColor = System.Drawing.Color.Transparent;
            this.timeSpentL.Font = new System.Drawing.Font("PMingLiU-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.timeSpentL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeSpentL.Location = new System.Drawing.Point(176, 114);
            this.timeSpentL.Name = "timeSpentL";
            this.timeSpentL.Size = new System.Drawing.Size(0, 29);
            this.timeSpentL.TabIndex = 8;
            // 
            // difficultyL
            // 
            this.difficultyL.AutoSize = true;
            this.difficultyL.BackColor = System.Drawing.Color.Transparent;
            this.difficultyL.Font = new System.Drawing.Font("PMingLiU-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.difficultyL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.difficultyL.Location = new System.Drawing.Point(176, 155);
            this.difficultyL.Name = "difficultyL";
            this.difficultyL.Size = new System.Drawing.Size(0, 29);
            this.difficultyL.TabIndex = 9;
            // 
            // end
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.difficultyL);
            this.Controls.Add(this.timeSpentL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitdesktop);
            this.Controls.Add(this.exitMenu);
            this.Controls.Add(this.scoredPointsL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.over);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "end";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game over..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label over;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label scoredPointsL;
        private System.Windows.Forms.Button exitMenu;
        private System.Windows.Forms.Button exitdesktop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeSpentL;
        private System.Windows.Forms.Label difficultyL;
    }
}