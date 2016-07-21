namespace Web_Browser__HW_RGM_2012_
{
    partial class favorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(favorites));
            this.Addresstbox = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.editb = new System.Windows.Forms.Button();
            this.addnew = new System.Windows.Forms.Button();
            this.removeb = new System.Windows.Forms.Button();
            this.closeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addresstbox
            // 
            this.Addresstbox.Location = new System.Drawing.Point(13, 13);
            this.Addresstbox.Name = "Addresstbox";
            this.Addresstbox.Size = new System.Drawing.Size(263, 20);
            this.Addresstbox.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 48);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(308, 253);
            this.treeView1.TabIndex = 5;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // editb
            // 
            this.editb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.pencil;
            this.editb.Location = new System.Drawing.Point(130, 304);
            this.editb.Name = "editb";
            this.editb.Size = new System.Drawing.Size(65, 58);
            this.editb.TabIndex = 6;
            this.editb.UseVisualStyleBackColor = true;
            this.editb.Click += new System.EventHandler(this.editb_Click);
            // 
            // addnew
            // 
            this.addnew.FlatAppearance.BorderSize = 0;
            this.addnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnew.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.bookmark_new;
            this.addnew.Location = new System.Drawing.Point(282, 5);
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(35, 37);
            this.addnew.TabIndex = 3;
            this.addnew.UseVisualStyleBackColor = true;
            this.addnew.Click += new System.EventHandler(this.addnew_Click);
            // 
            // removeb
            // 
            this.removeb.FlatAppearance.BorderSize = 0;
            this.removeb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.dialog_cancel_copy;
            this.removeb.Location = new System.Drawing.Point(13, 304);
            this.removeb.Name = "removeb";
            this.removeb.Size = new System.Drawing.Size(75, 58);
            this.removeb.TabIndex = 2;
            this.removeb.UseVisualStyleBackColor = true;
            this.removeb.Click += new System.EventHandler(this.removeb_Click);
            // 
            // closeb
            // 
            this.closeb.FlatAppearance.BorderSize = 0;
            this.closeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.document_save;
            this.closeb.Location = new System.Drawing.Point(264, 306);
            this.closeb.Name = "closeb";
            this.closeb.Size = new System.Drawing.Size(53, 51);
            this.closeb.TabIndex = 0;
            this.closeb.UseVisualStyleBackColor = true;
            this.closeb.Click += new System.EventHandler(this.closeb_Click);
            // 
            // favorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 370);
            this.Controls.Add(this.editb);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Addresstbox);
            this.Controls.Add(this.addnew);
            this.Controls.Add(this.removeb);
            this.Controls.Add(this.closeb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "favorites";
            this.Text = "Favorites Manager";
            this.Load += new System.EventHandler(this.favorites_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeb;
        private System.Windows.Forms.Button removeb;
        private System.Windows.Forms.Button addnew;
        private System.Windows.Forms.TextBox Addresstbox;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button editb;
    }
}