﻿namespace DoAn
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Status: Online"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menutab = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnguihinh = new MaterialSkin.Controls.MaterialButton();
            this.txtchat = new System.Windows.Forms.TextBox();
            this.tabuser = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.khungchat = new System.Windows.Forms.RichTextBox();
            this.btngui = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menutab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menutab
            // 
            this.menutab.Controls.Add(this.tabPage1);
            this.menutab.Controls.Add(this.tabPage2);
            this.menutab.Controls.Add(this.tabPage3);
            this.menutab.Depth = 0;
            this.menutab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menutab.ImageList = this.imageList1;
            this.menutab.ItemSize = new System.Drawing.Size(120, 35);
            this.menutab.Location = new System.Drawing.Point(3, 64);
            this.menutab.MouseState = MaterialSkin.MouseState.HOVER;
            this.menutab.Multiline = true;
            this.menutab.Name = "menutab";
            this.menutab.SelectedIndex = 0;
            this.menutab.Size = new System.Drawing.Size(901, 513);
            this.menutab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.menutab.TabIndex = 2;
            this.menutab.Selected += new System.Windows.Forms.TabControlEventHandler(this.menutab_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnguihinh);
            this.tabPage1.Controls.Add(this.txtchat);
            this.tabPage1.Controls.Add(this.tabuser);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btngui);
            this.tabPage1.ImageKey = "message.jpg";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Message";
            // 
            // btnguihinh
            // 
            this.btnguihinh.AutoSize = false;
            this.btnguihinh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnguihinh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnguihinh.Depth = 0;
            this.btnguihinh.HighEmphasis = true;
            this.btnguihinh.Icon = null;
            this.btnguihinh.Location = new System.Drawing.Point(284, 413);
            this.btnguihinh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnguihinh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnguihinh.Name = "btnguihinh";
            this.btnguihinh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnguihinh.Size = new System.Drawing.Size(127, 41);
            this.btnguihinh.TabIndex = 5;
            this.btnguihinh.Text = "Gửi hình";
            this.btnguihinh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnguihinh.UseAccentColor = false;
            this.btnguihinh.UseVisualStyleBackColor = true;
            this.btnguihinh.Click += new System.EventHandler(this.btnguihinh_Click);
            // 
            // txtchat
            // 
            this.txtchat.Location = new System.Drawing.Point(281, 356);
            this.txtchat.Multiline = true;
            this.txtchat.Name = "txtchat";
            this.txtchat.Size = new System.Drawing.Size(364, 39);
            this.txtchat.TabIndex = 4;
            // 
            // tabuser
            // 
            this.tabuser.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.tabuser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.tabuser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabuser.HideSelection = true;
            this.tabuser.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.tabuser.Location = new System.Drawing.Point(72, 18);
            this.tabuser.MultiSelect = false;
            this.tabuser.Name = "tabuser";
            this.tabuser.Size = new System.Drawing.Size(203, 328);
            this.tabuser.SmallImageList = this.imageList2;
            this.tabuser.TabIndex = 3;
            this.tabuser.UseCompatibleStateImageBehavior = false;
            this.tabuser.View = System.Windows.Forms.View.List;
            this.tabuser.SelectedIndexChanged += new System.EventHandler(this.tabuser_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 200;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "usericon.png");
            this.imageList2.Images.SetKeyName(1, "online.png");
            this.imageList2.Images.SetKeyName(2, "offline.jpg");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.khungchat);
            this.panel1.Location = new System.Drawing.Point(281, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 328);
            this.panel1.TabIndex = 2;
            // 
            // khungchat
            // 
            this.khungchat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.khungchat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.khungchat.Location = new System.Drawing.Point(0, 0);
            this.khungchat.Name = "khungchat";
            this.khungchat.ReadOnly = true;
            this.khungchat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.khungchat.Size = new System.Drawing.Size(468, 326);
            this.khungchat.TabIndex = 0;
            this.khungchat.Text = "";
            // 
            // btngui
            // 
            this.btngui.AutoSize = false;
            this.btngui.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btngui.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btngui.Depth = 0;
            this.btngui.HighEmphasis = true;
            this.btngui.Icon = null;
            this.btngui.Location = new System.Drawing.Point(652, 354);
            this.btngui.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btngui.MouseState = MaterialSkin.MouseState.HOVER;
            this.btngui.Name = "btngui";
            this.btngui.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btngui.Size = new System.Drawing.Size(99, 41);
            this.btngui.TabIndex = 1;
            this.btngui.Text = "Gửi";
            this.btngui.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btngui.UseAccentColor = false;
            this.btngui.UseVisualStyleBackColor = true;
            this.btngui.Click += new System.EventHandler(this.btngui_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.ImageKey = "group.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(893, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Group";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.ImageKey = "logout.jpg";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(893, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logout";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "message.jpg");
            this.imageList1.Images.SetKeyName(1, "group.png");
            this.imageList1.Images.SetKeyName(2, "logout.jpg");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 580);
            this.Controls.Add(this.menutab);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.menutab;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menutab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl menutab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton btngui;
        private Panel panel1;
        private RichTextBox khungchat;
        private ListView tabuser;
        private ColumnHeader columnHeader1;
        private ImageList imageList2;
        private TextBox txtchat;
        private MaterialSkin.Controls.MaterialButton btnguihinh;
    }
}