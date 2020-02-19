namespace Leadersoftware
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.displaynum = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.thisgrid11 = new Leadersoftware.thisgrid1();
            this.inputP1 = new Leadersoftware.inputP();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.displaynum);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 687);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "College";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 53);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // displaynum
            // 
            this.displaynum.FlatAppearance.BorderSize = 0;
            this.displaynum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displaynum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaynum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.displaynum.Image = ((System.Drawing.Image)(resources.GetObject("displaynum.Image")));
            this.displaynum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displaynum.Location = new System.Drawing.Point(0, 295);
            this.displaynum.Name = "displaynum";
            this.displaynum.Size = new System.Drawing.Size(185, 60);
            this.displaynum.TabIndex = 3;
            this.displaynum.Text = "Charts";
            this.displaynum.UseVisualStyleBackColor = true;
            this.displaynum.Click += new System.EventHandler(this.displaynum_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Input";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(191, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 0);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // thisgrid11
            // 
            this.thisgrid11.AutoScroll = true;
            this.thisgrid11.AutoSize = true;
            this.thisgrid11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.thisgrid11.BackColor = System.Drawing.Color.White;
            this.thisgrid11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thisgrid11.Location = new System.Drawing.Point(191, 0);
            this.thisgrid11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thisgrid11.Name = "thisgrid11";
            this.thisgrid11.Size = new System.Drawing.Size(964, 687);
            this.thisgrid11.TabIndex = 3;
            this.thisgrid11.Load += new System.EventHandler(this.thisgrid11_Load_2);
            // 
            // inputP1
            // 
            this.inputP1.AutoScroll = true;
            this.inputP1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.inputP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputP1.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputP1.Location = new System.Drawing.Point(191, 0);
            this.inputP1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputP1.Name = "inputP1";
            this.inputP1.Size = new System.Drawing.Size(964, 687);
            this.inputP1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.thisgrid11);
            this.Controls.Add(this.inputP1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simmons";
            this.TransparencyKey = System.Drawing.Color.LightYellow;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button displaynum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private inputP inputP1;
        private thisgrid1 thisgrid11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}

