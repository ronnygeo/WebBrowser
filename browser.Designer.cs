using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;

namespace Web_Browser__HW_RGM_2012_
{
    partial class WebXplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebXplorer));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fullscreenb = new System.Windows.Forms.Button();
            this.refreshb = new System.Windows.Forms.Button();
            this.homeb = new System.Windows.Forms.Button();
            this.ph1 = new System.Windows.Forms.Label();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.gob = new System.Windows.Forms.Button();
            this.printb = new System.Windows.Forms.Button();
            this.addfavb = new System.Windows.Forms.Button();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.Progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.server = new System.Windows.Forms.ToolStripStatusLabel();
            this.filemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAllButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unhideButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historymenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.favoritesManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs = new System.Windows.Forms.TabControl();
            this.renderb = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.Controls.Add(this.fullscreenb);
            this.flowLayoutPanel1.Controls.Add(this.refreshb);
            this.flowLayoutPanel1.Controls.Add(this.homeb);
            this.flowLayoutPanel1.Controls.Add(this.ph1);
            this.flowLayoutPanel1.Controls.Add(this.addresstb);
            this.flowLayoutPanel1.Controls.Add(this.gob);
            this.flowLayoutPanel1.Controls.Add(this.printb);
            this.flowLayoutPanel1.Controls.Add(this.addfavb);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(811, 72);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // fullscreenb
            // 
            this.fullscreenb.FlatAppearance.BorderSize = 0;
            this.fullscreenb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullscreenb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.view_fullscreen__1_;
            this.fullscreenb.Location = new System.Drawing.Point(10, 3);
            this.fullscreenb.Name = "fullscreenb";
            this.fullscreenb.Size = new System.Drawing.Size(75, 65);
            this.fullscreenb.TabIndex = 13;
            this.fullscreenb.UseVisualStyleBackColor = true;
            this.fullscreenb.Click += new System.EventHandler(this.fullscreenb_Click);
            // 
            // refreshb
            // 
            this.refreshb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refreshb.FlatAppearance.BorderSize = 0;
            this.refreshb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.refresh_1;
            this.refreshb.Location = new System.Drawing.Point(91, 10);
            this.refreshb.Name = "refreshb";
            this.refreshb.Size = new System.Drawing.Size(40, 51);
            this.refreshb.TabIndex = 10;
            this.refreshb.UseVisualStyleBackColor = true;
            this.refreshb.Click += new System.EventHandler(this.refreshb_Click);
            // 
            // homeb
            // 
            this.homeb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeb.FlatAppearance.BorderSize = 0;
            this.homeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.home_1;
            this.homeb.Location = new System.Drawing.Point(137, 10);
            this.homeb.Name = "homeb";
            this.homeb.Size = new System.Drawing.Size(50, 51);
            this.homeb.TabIndex = 11;
            this.homeb.UseVisualStyleBackColor = true;
            this.homeb.Click += new System.EventHandler(this.homeb_Click);
            // 
            // ph1
            // 
            this.ph1.AutoSize = true;
            this.ph1.Location = new System.Drawing.Point(193, 0);
            this.ph1.Name = "ph1";
            this.ph1.Size = new System.Drawing.Size(0, 13);
            this.ph1.TabIndex = 12;
            // 
            // addresstb
            // 
            this.addresstb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addresstb.Location = new System.Drawing.Point(199, 25);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(395, 20);
            this.addresstb.TabIndex = 5;
            this.addresstb.Text = "http://";
            this.addresstb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addresstb_KeyUp);
            // 
            // gob
            // 
            this.gob.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gob.FlatAppearance.BorderSize = 0;
            this.gob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gob.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.web_find;
            this.gob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gob.Location = new System.Drawing.Point(600, 10);
            this.gob.Name = "gob";
            this.gob.Size = new System.Drawing.Size(60, 51);
            this.gob.TabIndex = 6;
            this.gob.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.gob.UseVisualStyleBackColor = true;
            this.gob.Click += new System.EventHandler(this.gob_Click);
            // 
            // printb
            // 
            this.printb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.printb.FlatAppearance.BorderSize = 0;
            this.printb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.printer_11;
            this.printb.Location = new System.Drawing.Point(666, 5);
            this.printb.Name = "printb";
            this.printb.Size = new System.Drawing.Size(57, 61);
            this.printb.TabIndex = 7;
            this.printb.UseVisualStyleBackColor = true;
            this.printb.Click += new System.EventHandler(this.printb_Click);
            // 
            // addfavb
            // 
            this.addfavb.FlatAppearance.BorderSize = 0;
            this.addfavb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addfavb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.favorites;
            this.addfavb.Location = new System.Drawing.Point(729, 3);
            this.addfavb.Name = "addfavb";
            this.addfavb.Size = new System.Drawing.Size(77, 63);
            this.addfavb.TabIndex = 8;
            this.addfavb.UseVisualStyleBackColor = true;
            this.addfavb.Click += new System.EventHandler(this.addfavb_Click);
            // 
            // statusbar
            // 
            this.statusbar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progressbar,
            this.status,
            this.server});
            this.statusbar.Location = new System.Drawing.Point(0, 621);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(838, 22);
            this.statusbar.TabIndex = 9;
            this.statusbar.Text = "statusStrip1";
            // 
            // Progressbar
            // 
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(100, 16);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(27, 17);
            this.status.Text = "Stat";
            // 
            // server
            // 
            this.server.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(39, 17);
            this.server.Text = "Server";
            // 
            // filemenu
            // 
            this.filemenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.filemenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeTabToolStripMenuItem,
            this.printToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.filemenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.filemenu.Name = "filemenu";
            this.filemenu.Size = new System.Drawing.Size(38, 20);
            this.filemenu.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem,
            this.tabToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.newToolStripMenuItem.Text = "New..";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.windowToolStripMenuItem.Text = "Window";
            this.windowToolStripMenuItem.Click += new System.EventHandler(this.windowToolStripMenuItem_Click);
            // 
            // tabToolStripMenuItem
            // 
            this.tabToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
            this.tabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tabToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tabToolStripMenuItem.Text = "Tab";
            this.tabToolStripMenuItem.Click += new System.EventHandler(this.tabToolStripMenuItem_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewmenu
            // 
            this.viewmenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.viewmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.hideAllButtonsToolStripMenuItem,
            this.unhideButtonsToolStripMenuItem});
            this.viewmenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewmenu.Name = "viewmenu";
            this.viewmenu.Size = new System.Drawing.Size(47, 20);
            this.viewmenu.Text = "View";
            this.viewmenu.MouseHover += new System.EventHandler(this.viewmenu_MouseHover);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // hideAllButtonsToolStripMenuItem
            // 
            this.hideAllButtonsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.hideAllButtonsToolStripMenuItem.Name = "hideAllButtonsToolStripMenuItem";
            this.hideAllButtonsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hideAllButtonsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.hideAllButtonsToolStripMenuItem.Text = "Hide All Buttons";
            this.hideAllButtonsToolStripMenuItem.Click += new System.EventHandler(this.hideAllButtonsToolStripMenuItem_Click);
            // 
            // unhideButtonsToolStripMenuItem
            // 
            this.unhideButtonsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.unhideButtonsToolStripMenuItem.Name = "unhideButtonsToolStripMenuItem";
            this.unhideButtonsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.unhideButtonsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.unhideButtonsToolStripMenuItem.Text = "Unhide Buttons";
            this.unhideButtonsToolStripMenuItem.Click += new System.EventHandler(this.unhideButtonsToolStripMenuItem_Click);
            // 
            // toolsmenu
            // 
            this.toolsmenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.toolsmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsHomeToolStripMenuItem,
            this.favoritesToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolsmenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolsmenu.Name = "toolsmenu";
            this.toolsmenu.Size = new System.Drawing.Size(48, 20);
            this.toolsmenu.Text = "Tools";
            // 
            // setAsHomeToolStripMenuItem
            // 
            this.setAsHomeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.setAsHomeToolStripMenuItem.Name = "setAsHomeToolStripMenuItem";
            this.setAsHomeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.setAsHomeToolStripMenuItem.Text = "Set as home";
            this.setAsHomeToolStripMenuItem.Click += new System.EventHandler(this.setAsHomeToolStripMenuItem_Click);
            // 
            // favoritesToolStripMenuItem
            // 
            this.favoritesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.favoritesToolStripMenuItem.Name = "favoritesToolStripMenuItem";
            this.favoritesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.favoritesToolStripMenuItem.Text = "Favorites Manager";
            this.favoritesToolStripMenuItem.Click += new System.EventHandler(this.favoritesToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.historyToolStripMenuItem.Text = "Clear History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // mainmenu
            // 
            this.mainmenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mainmenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filemenu,
            this.editToolStripMenuItem,
            this.viewmenu,
            this.historymenu,
            this.favoritesmenu,
            this.toolsmenu});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.Size = new System.Drawing.Size(838, 24);
            this.mainmenu.TabIndex = 10;
            this.mainmenu.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // historymenu
            // 
            this.historymenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistoryToolStripMenuItem});
            this.historymenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historymenu.Name = "historymenu";
            this.historymenu.Size = new System.Drawing.Size(59, 20);
            this.historymenu.Text = "History";
            this.historymenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.historymenu_DropDownItemClicked);
            this.historymenu.Click += new System.EventHandler(this.historymenu_Click);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.clearHistoryToolStripMenuItem.Text = "Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // favoritesmenu
            // 
            this.favoritesmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favoritesManagerToolStripMenuItem});
            this.favoritesmenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.favoritesmenu.Name = "favoritesmenu";
            this.favoritesmenu.Size = new System.Drawing.Size(70, 20);
            this.favoritesmenu.Text = "Favorites";
            this.favoritesmenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.favoritesmenu_DropDownItemClicked);
            // 
            // favoritesManagerToolStripMenuItem
            // 
            this.favoritesManagerToolStripMenuItem.Name = "favoritesManagerToolStripMenuItem";
            this.favoritesManagerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.favoritesManagerToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.favoritesManagerToolStripMenuItem.Text = "Favorites Manager";
            this.favoritesManagerToolStripMenuItem.Click += new System.EventHandler(this.favoritesManagerToolStripMenuItem_Click);
            // 
            // tabs
            // 
            this.tabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(15, 100);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(811, 514);
            this.tabs.TabIndex = 12;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // renderb
            // 
            this.renderb.Image = global::Web_Browser__HW_RGM_2012_.Properties.Resources.html;
            this.renderb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.renderb.Location = new System.Drawing.Point(718, 620);
            this.renderb.Name = "renderb";
            this.renderb.Size = new System.Drawing.Size(108, 23);
            this.renderb.TabIndex = 13;
            this.renderb.Text = "Render HTML";
            this.renderb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.renderb.UseVisualStyleBackColor = true;
            this.renderb.Click += new System.EventHandler(this.renderb_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // WebXplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(838, 643);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.renderb);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.mainmenu);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WebXplorer";
            this.Text = "Meteora - The Simplest Browser!";
            this.Load += new System.EventHandler(this.WebXplorer_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.Button gob;
        private System.Windows.Forms.Button printb;
        private System.Windows.Forms.Button addfavb;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripStatusLabel server;
        private System.Windows.Forms.ToolStripMenuItem filemenu;
        private System.Windows.Forms.ToolStripMenuItem viewmenu;
        private System.Windows.Forms.ToolStripMenuItem toolsmenu;
        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.Button refreshb;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideAllButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button homeb;
        private System.Windows.Forms.ToolStripMenuItem setAsHomeToolStripMenuItem;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historymenu;
        private System.Windows.Forms.ToolStripMenuItem favoritesmenu;
        private System.Windows.Forms.Button renderb;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoritesManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unhideButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.Label ph1;
        private System.Windows.Forms.Button fullscreenb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripProgressBar Progressbar;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        
    }
}

