namespace Leadersoftware
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
            this.button1 = new System.Windows.Forms.Button();
            this.leadersoftware1 = new inputP.Leadersoftware();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // leadersoftware1
            // 
            this.leadersoftware1.AutoScroll = true;
            this.leadersoftware1.AutoScrollMargin = new System.Drawing.Size(10, 5000);
            this.leadersoftware1.AutoScrollMinSize = new System.Drawing.Size(15, 5000);
            this.leadersoftware1.AutoSize = true;
            this.leadersoftware1.BackColor = System.Drawing.Color.LightSlateGray;
            this.leadersoftware1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leadersoftware1.Location = new System.Drawing.Point(580, -3452);
            this.leadersoftware1.Name = "leadersoftware1";
            this.leadersoftware1.Size = new System.Drawing.Size(1343, 3810);
            this.leadersoftware1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leadersoftware1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private inputP.Leadersoftware leadersoftware1;
    }
}