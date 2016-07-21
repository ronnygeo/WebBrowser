namespace Web_Browser__HW_RGM_2012_
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.homelb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.homeptb = new System.Windows.Forms.TextBox();
            this.sethb = new System.Windows.Forms.Button();
            this.clrhistoryb = new System.Windows.Forms.Button();
            this.Closeb = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // homelb
            // 
            this.homelb.AutoSize = true;
            this.homelb.Location = new System.Drawing.Point(10, 19);
            this.homelb.Name = "homelb";
            this.homelb.Size = new System.Drawing.Size(59, 13);
            this.homelb.TabIndex = 0;
            this.homelb.Text = "Homepage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.homeptb);
            this.groupBox1.Controls.Add(this.sethb);
            this.groupBox1.Controls.Add(this.homelb);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home";
            // 
            // homeptb
            // 
            this.homeptb.Location = new System.Drawing.Point(75, 15);
            this.homeptb.Name = "homeptb";
            this.homeptb.Size = new System.Drawing.Size(216, 20);
            this.homeptb.TabIndex = 2;
            // 
            // sethb
            // 
            this.sethb.FlatAppearance.BorderSize = 0;
            this.sethb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sethb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sethb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.home_3;
            this.sethb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sethb.Location = new System.Drawing.Point(224, 42);
            this.sethb.Name = "sethb";
            this.sethb.Size = new System.Drawing.Size(67, 34);
            this.sethb.TabIndex = 1;
            this.sethb.Text = "Set";
            this.sethb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sethb.UseVisualStyleBackColor = true;
            this.sethb.Click += new System.EventHandler(this.sethb_Click);
            // 
            // clrhistoryb
            // 
            this.clrhistoryb.FlatAppearance.BorderSize = 0;
            this.clrhistoryb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clrhistoryb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrhistoryb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.history_clear_1;
            this.clrhistoryb.Location = new System.Drawing.Point(24, 94);
            this.clrhistoryb.Name = "clrhistoryb";
            this.clrhistoryb.Size = new System.Drawing.Size(69, 67);
            this.clrhistoryb.TabIndex = 4;
            this.clrhistoryb.Text = "Clear History";
            this.clrhistoryb.UseVisualStyleBackColor = true;
            this.clrhistoryb.Click += new System.EventHandler(this.clrhistoryb_Click);
            // 
            // Closeb
            // 
            this.Closeb.FlatAppearance.BorderSize = 0;
            this.Closeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closeb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.button_cancel1;
            this.Closeb.Location = new System.Drawing.Point(257, 115);
            this.Closeb.Name = "Closeb";
            this.Closeb.Size = new System.Drawing.Size(45, 46);
            this.Closeb.TabIndex = 1;
            this.Closeb.UseVisualStyleBackColor = true;
            this.Closeb.Click += new System.EventHandler(this.Closeb_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 171);
            this.Controls.Add(this.clrhistoryb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Closeb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.Text = "settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label homelb;
        private System.Windows.Forms.Button Closeb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox homeptb;
        private System.Windows.Forms.Button sethb;
        private System.Windows.Forms.Button clrhistoryb;
    }
}