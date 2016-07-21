namespace Web_Browser__HW_RGM_2012_
{
    partial class editfav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editfav));
            this.okb = new System.Windows.Forms.Button();
            this.closeb = new System.Windows.Forms.Button();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okb
            // 
            this.okb.FlatAppearance.BorderSize = 0;
            this.okb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.check;
            this.okb.Location = new System.Drawing.Point(53, 40);
            this.okb.Name = "okb";
            this.okb.Size = new System.Drawing.Size(75, 47);
            this.okb.TabIndex = 0;
            this.okb.UseVisualStyleBackColor = true;
            this.okb.Click += new System.EventHandler(this.okb_Click);
            // 
            // closeb
            // 
            this.closeb.FlatAppearance.BorderSize = 0;
            this.closeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.close;
            this.closeb.Location = new System.Drawing.Point(131, 43);
            this.closeb.Name = "closeb";
            this.closeb.Size = new System.Drawing.Size(75, 41);
            this.closeb.TabIndex = 1;
            this.closeb.UseVisualStyleBackColor = true;
            this.closeb.Click += new System.EventHandler(this.closeb_Click);
            // 
            // addresstb
            // 
            this.addresstb.Location = new System.Drawing.Point(12, 12);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(230, 20);
            this.addresstb.TabIndex = 2;
            // 
            // editfav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 97);
            this.Controls.Add(this.addresstb);
            this.Controls.Add(this.closeb);
            this.Controls.Add(this.okb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editfav";
            this.Text = "Edit Favorite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okb;
        private System.Windows.Forms.Button closeb;
        private System.Windows.Forms.TextBox addresstb;
    }
}