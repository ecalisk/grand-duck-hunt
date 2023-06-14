
namespace project_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.helpB = new System.Windows.Forms.Button();
            this.ductrix = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authors = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gruelingRadioB = new System.Windows.Forms.RadioButton();
            this.doomRadioB = new System.Windows.Forms.RadioButton();
            this.harshRadioB = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.playername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ductrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // playB
            // 
            this.playB.BackColor = System.Drawing.Color.LightCyan;
            this.playB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playB.Location = new System.Drawing.Point(230, 63);
            this.playB.Name = "playB";
            this.playB.Size = new System.Drawing.Size(75, 26);
            this.playB.TabIndex = 1;
            this.playB.Text = "PLAY";
            this.playB.UseVisualStyleBackColor = false;
            this.playB.Click += new System.EventHandler(this.playClick);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.LightCyan;
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitB.Location = new System.Drawing.Point(230, 128);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(75, 26);
            this.exitB.TabIndex = 2;
            this.exitB.Text = "EXIT";
            this.exitB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitClick);
            // 
            // helpB
            // 
            this.helpB.BackColor = System.Drawing.Color.LightCyan;
            this.helpB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.helpB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpB.Location = new System.Drawing.Point(230, 95);
            this.helpB.Name = "helpB";
            this.helpB.Size = new System.Drawing.Size(75, 26);
            this.helpB.TabIndex = 3;
            this.helpB.Text = "HELP";
            this.helpB.UseVisualStyleBackColor = false;
            this.helpB.Click += new System.EventHandler(this.helpClick);
            // 
            // ductrix
            // 
            this.ductrix.BackColor = System.Drawing.Color.Transparent;
            this.ductrix.Image = ((System.Drawing.Image)(resources.GetObject("ductrix.Image")));
            this.ductrix.Location = new System.Drawing.Point(52, 27);
            this.ductrix.Name = "ductrix";
            this.ductrix.Size = new System.Drawing.Size(150, 170);
            this.ductrix.TabIndex = 4;
            this.ductrix.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(72, 11);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(126, 19);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 6;
            // 
            // authors
            // 
            this.authors.AutoSize = true;
            this.authors.BackColor = System.Drawing.Color.Transparent;
            this.authors.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.authors.Location = new System.Drawing.Point(22, 240);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(346, 21);
            this.authors.TabIndex = 7;
            this.authors.Text = "DEVELOPED BY: NOBLE RUBBER DUCKIES";
            this.authors.Click += new System.EventHandler(this.authors_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.gruelingRadioB);
            this.groupBox1.Controls.Add(this.doomRadioB);
            this.groupBox1.Controls.Add(this.harshRadioB);
            this.groupBox1.Location = new System.Drawing.Point(137, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 45);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty:";
            // 
            // gruelingRadioB
            // 
            this.gruelingRadioB.AutoSize = true;
            this.gruelingRadioB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gruelingRadioB.Location = new System.Drawing.Point(83, 17);
            this.gruelingRadioB.Name = "gruelingRadioB";
            this.gruelingRadioB.Size = new System.Drawing.Size(70, 21);
            this.gruelingRadioB.TabIndex = 15;
            this.gruelingRadioB.TabStop = true;
            this.gruelingRadioB.Text = "grueling";
            this.gruelingRadioB.UseVisualStyleBackColor = true;
            // 
            // doomRadioB
            // 
            this.doomRadioB.AutoSize = true;
            this.doomRadioB.BackColor = System.Drawing.Color.Transparent;
            this.doomRadioB.Checked = true;
            this.doomRadioB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doomRadioB.Location = new System.Drawing.Point(159, 17);
            this.doomRadioB.Name = "doomRadioB";
            this.doomRadioB.Size = new System.Drawing.Size(57, 21);
            this.doomRadioB.TabIndex = 14;
            this.doomRadioB.TabStop = true;
            this.doomRadioB.Text = "doom";
            this.doomRadioB.UseVisualStyleBackColor = false;
            // 
            // harshRadioB
            // 
            this.harshRadioB.AutoSize = true;
            this.harshRadioB.BackColor = System.Drawing.Color.Transparent;
            this.harshRadioB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.harshRadioB.Location = new System.Drawing.Point(22, 16);
            this.harshRadioB.Name = "harshRadioB";
            this.harshRadioB.Size = new System.Drawing.Size(55, 21);
            this.harshRadioB.TabIndex = 13;
            this.harshRadioB.TabStop = true;
            this.harshRadioB.Text = "harsh";
            this.harshRadioB.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Location = new System.Drawing.Point(212, 202);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 21);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "gggggggggggggggggggggggg";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.playername);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(24, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 45);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Username";
            // 
            // playername
            // 
            this.playername.BackColor = System.Drawing.Color.LightCyan;
            this.playername.Location = new System.Drawing.Point(10, 16);
            this.playername.Name = "playername";
            this.playername.Size = new System.Drawing.Size(80, 24);
            this.playername.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.authors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.ductrix);
            this.Controls.Add(this.helpB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.playB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grand Duck Hunt Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.ductrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button helpB;
        private System.Windows.Forms.PictureBox ductrix;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label authors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton doomRadioB;
        private System.Windows.Forms.RadioButton harshRadioB;
        private System.Windows.Forms.RadioButton gruelingRadioB;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox playername;
    }
}

