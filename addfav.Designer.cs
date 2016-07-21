namespace Web_Browser__HW_RGM_2012_
{
    partial class addfav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addfav));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nametb = new System.Windows.Forms.TextBox();
            this.urltb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.closeb = new System.Windows.Forms.Button();
            this.saveb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL";
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(91, 50);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(217, 20);
            this.nametb.TabIndex = 2;
            // 
            // urltb
            // 
            this.urltb.Location = new System.Drawing.Point(91, 78);
            this.urltb.Name = "urltb";
            this.urltb.Size = new System.Drawing.Size(217, 20);
            this.urltb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Give a name for this page and you can access this page whenever you want.";
            // 
            // closeb
            // 
            this.closeb.FlatAppearance.BorderSize = 0;
            this.closeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.close;
            this.closeb.Location = new System.Drawing.Point(184, 120);
            this.closeb.Name = "closeb";
            this.closeb.Size = new System.Drawing.Size(37, 39);
            this.closeb.TabIndex = 5;
            this.closeb.UseVisualStyleBackColor = true;
            this.closeb.Click += new System.EventHandler(this.closeb_Click);
            // 
            // saveb
            // 
            this.saveb.FlatAppearance.BorderSize = 0;
            this.saveb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.check;
            this.saveb.Location = new System.Drawing.Point(105, 114);
            this.saveb.Name = "saveb";
            this.saveb.Size = new System.Drawing.Size(54, 51);
            this.saveb.TabIndex = 4;
            this.saveb.UseVisualStyleBackColor = true;
            this.saveb.Click += new System.EventHandler(this.saveb_Click);
            // 
            // addfav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 177);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closeb);
            this.Controls.Add(this.saveb);
            this.Controls.Add(this.urltb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addfav";
            this.Text = "Add to Favorites";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.addfav_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox urltb;
        private System.Windows.Forms.Button saveb;
        private System.Windows.Forms.Button closeb;
        private System.Windows.Forms.Label label3;
    }
}