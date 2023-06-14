
namespace project_2
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            this.back = new System.Windows.Forms.Button();
            this.peasant75 = new System.Windows.Forms.PictureBox();
            this.duke75 = new System.Windows.Forms.PictureBox();
            this.commoner75 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.peasant75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duke75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoner75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.back.Location = new System.Drawing.Point(297, 223);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 26);
            this.back.TabIndex = 0;
            this.back.Text = "◄ Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // peasant75
            // 
            this.peasant75.BackColor = System.Drawing.Color.Transparent;
            this.peasant75.Image = ((System.Drawing.Image)(resources.GetObject("peasant75.Image")));
            this.peasant75.Location = new System.Drawing.Point(6, -1);
            this.peasant75.Name = "peasant75";
            this.peasant75.Size = new System.Drawing.Size(75, 75);
            this.peasant75.TabIndex = 15;
            this.peasant75.TabStop = false;
            // 
            // duke75
            // 
            this.duke75.BackColor = System.Drawing.Color.Transparent;
            this.duke75.Image = ((System.Drawing.Image)(resources.GetObject("duke75.Image")));
            this.duke75.Location = new System.Drawing.Point(154, -1);
            this.duke75.Name = "duke75";
            this.duke75.Size = new System.Drawing.Size(75, 75);
            this.duke75.TabIndex = 14;
            this.duke75.TabStop = false;
            // 
            // commoner75
            // 
            this.commoner75.BackColor = System.Drawing.Color.Transparent;
            this.commoner75.Image = ((System.Drawing.Image)(resources.GetObject("commoner75.Image")));
            this.commoner75.Location = new System.Drawing.Point(80, -1);
            this.commoner75.Name = "commoner75";
            this.commoner75.Size = new System.Drawing.Size(75, 75);
            this.commoner75.TabIndex = 13;
            this.commoner75.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(228, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(303, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "peasant       commoner          duke               count               baron     " +
    " ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCyan;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(5, 96);
            this.textBox1.MaxLength = 162767;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 153);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightCyan;
            this.textBox2.Location = new System.Drawing.Point(223, 96);
            this.textBox2.MaxLength = 162767;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 101);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Baron: -2 points; +4 sec Count: -1 points; +3 sec Duke: 0 points; +2 sec Commoner" +
    ": +1 point; 0 sec Peasant: +3 points; -1 sec";
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.peasant75);
            this.Controls.Add(this.duke75);
            this.Controls.Add(this.commoner75);
            this.Controls.Add(this.back);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grand Duck Hunt - Help";
            ((System.ComponentModel.ISupportInitialize)(this.peasant75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duke75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commoner75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.PictureBox peasant75;
        private System.Windows.Forms.PictureBox duke75;
        private System.Windows.Forms.PictureBox commoner75;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}