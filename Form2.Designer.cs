
namespace project_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.exitDesktop = new System.Windows.Forms.Button();
            this.exitMenu = new System.Windows.Forms.Button();
            this.aesthetic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aesthetic2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.count50 = new System.Windows.Forms.PictureBox();
            this.commoner75 = new System.Windows.Forms.PictureBox();
            this.duke75 = new System.Windows.Forms.PictureBox();
            this.peasant75 = new System.Windows.Forms.PictureBox();
            this.baron50 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.greeting = new System.Windows.Forms.Label();
            this.greet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.count50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoner75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duke75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peasant75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baron50)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 650;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // exitDesktop
            // 
            this.exitDesktop.BackColor = System.Drawing.Color.PaleGreen;
            this.exitDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitDesktop.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitDesktop.Location = new System.Drawing.Point(0, 154);
            this.exitDesktop.Name = "exitDesktop";
            this.exitDesktop.Size = new System.Drawing.Size(80, 54);
            this.exitDesktop.TabIndex = 1;
            this.exitDesktop.Text = "Exit to desktop";
            this.exitDesktop.UseVisualStyleBackColor = false;
            this.exitDesktop.Click += new System.EventHandler(this.exitDesktop_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.BackColor = System.Drawing.Color.PaleGreen;
            this.exitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitMenu.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitMenu.Location = new System.Drawing.Point(0, 207);
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(80, 54);
            this.exitMenu.TabIndex = 2;
            this.exitMenu.Text = "Exit to menu";
            this.exitMenu.UseVisualStyleBackColor = false;
            this.exitMenu.Visible = false;
            // 
            // aesthetic
            // 
            this.aesthetic.BackColor = System.Drawing.Color.PaleGreen;
            this.aesthetic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aesthetic.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aesthetic.Location = new System.Drawing.Point(0, 53);
            this.aesthetic.Name = "aesthetic";
            this.aesthetic.Size = new System.Drawing.Size(80, 54);
            this.aesthetic.TabIndex = 3;
            this.aesthetic.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:";
            // 
            // aesthetic2
            // 
            this.aesthetic2.BackColor = System.Drawing.Color.PaleGreen;
            this.aesthetic2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aesthetic2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aesthetic2.Location = new System.Drawing.Point(0, 106);
            this.aesthetic2.Name = "aesthetic2";
            this.aesthetic2.Size = new System.Drawing.Size(80, 54);
            this.aesthetic2.TabIndex = 5;
            this.aesthetic2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "TIME:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.PaleGreen;
            this.score.Font = new System.Drawing.Font("Yu Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(16, 73);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(23, 25);
            this.score.TabIndex = 7;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.PaleGreen;
            this.time.Font = new System.Drawing.Font("Yu Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.time.Location = new System.Drawing.Point(16, 126);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 25);
            this.time.TabIndex = 8;
            this.time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // count50
            // 
            this.count50.BackColor = System.Drawing.Color.Transparent;
            this.count50.Image = ((System.Drawing.Image)(resources.GetObject("count50.Image")));
            this.count50.Location = new System.Drawing.Point(234, 122);
            this.count50.Name = "count50";
            this.count50.Size = new System.Drawing.Size(50, 50);
            this.count50.TabIndex = 9;
            this.count50.TabStop = false;
            this.count50.Visible = false;
            this.count50.Click += new System.EventHandler(this.hit);
            // 
            // commoner75
            // 
            this.commoner75.BackColor = System.Drawing.Color.Transparent;
            this.commoner75.Image = ((System.Drawing.Image)(resources.GetObject("commoner75.Image")));
            this.commoner75.Location = new System.Drawing.Point(120, 48);
            this.commoner75.Name = "commoner75";
            this.commoner75.Size = new System.Drawing.Size(75, 75);
            this.commoner75.TabIndex = 10;
            this.commoner75.TabStop = false;
            this.commoner75.Visible = false;
            this.commoner75.Click += new System.EventHandler(this.hit);
            // 
            // duke75
            // 
            this.duke75.BackColor = System.Drawing.Color.Transparent;
            this.duke75.Image = ((System.Drawing.Image)(resources.GetObject("duke75.Image")));
            this.duke75.Location = new System.Drawing.Point(265, 48);
            this.duke75.Name = "duke75";
            this.duke75.Size = new System.Drawing.Size(75, 75);
            this.duke75.TabIndex = 11;
            this.duke75.TabStop = false;
            this.duke75.Visible = false;
            this.duke75.Click += new System.EventHandler(this.hit);
            // 
            // peasant75
            // 
            this.peasant75.BackColor = System.Drawing.Color.Transparent;
            this.peasant75.Image = ((System.Drawing.Image)(resources.GetObject("peasant75.Image")));
            this.peasant75.Location = new System.Drawing.Point(195, 0);
            this.peasant75.Name = "peasant75";
            this.peasant75.Size = new System.Drawing.Size(75, 75);
            this.peasant75.TabIndex = 12;
            this.peasant75.TabStop = false;
            this.peasant75.Visible = false;
            this.peasant75.Click += new System.EventHandler(this.hit);
            // 
            // baron50
            // 
            this.baron50.BackColor = System.Drawing.Color.Transparent;
            this.baron50.Image = ((System.Drawing.Image)(resources.GetObject("baron50.Image")));
            this.baron50.Location = new System.Drawing.Point(157, 122);
            this.baron50.Name = "baron50";
            this.baron50.Size = new System.Drawing.Size(50, 50);
            this.baron50.TabIndex = 13;
            this.baron50.TabStop = false;
            this.baron50.Visible = false;
            this.baron50.Click += new System.EventHandler(this.hit);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 54);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.BackColor = System.Drawing.Color.PaleGreen;
            this.greeting.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.greeting.Location = new System.Drawing.Point(8, 5);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(37, 17);
            this.greeting.TabIndex = 15;
            this.greeting.Text = "Hello";
            // 
            // greet
            // 
            this.greet.AutoSize = true;
            this.greet.BackColor = System.Drawing.Color.PaleGreen;
            this.greet.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.greet.Location = new System.Drawing.Point(12, 22);
            this.greet.Name = "greet";
            this.greet.Size = new System.Drawing.Size(0, 17);
            this.greet.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.greet);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.baron50);
            this.Controls.Add(this.peasant75);
            this.Controls.Add(this.duke75);
            this.Controls.Add(this.commoner75);
            this.Controls.Add(this.count50);
            this.Controls.Add(this.time);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aesthetic2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aesthetic);
            this.Controls.Add(this.exitMenu);
            this.Controls.Add(this.exitDesktop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grand Duck Hunt";
            ((System.ComponentModel.ISupportInitialize)(this.count50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoner75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duke75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peasant75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baron50)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button exitDesktop;
        private System.Windows.Forms.Button exitMenu;
        private System.Windows.Forms.Button aesthetic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aesthetic2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox count50;
        private System.Windows.Forms.PictureBox commoner75;
        private System.Windows.Forms.PictureBox duke75;
        private System.Windows.Forms.PictureBox peasant75;
        private System.Windows.Forms.PictureBox baron50;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label greet;
    }
}