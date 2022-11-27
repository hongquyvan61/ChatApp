namespace DoAn
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
            this.txtusername = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtpassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.logochat = new System.Windows.Forms.PictureBox();
            this.btndangnhap = new MaterialSkin.Controls.MaterialButton();
            this.btn_dangki = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.logochat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.AnimateReadOnly = false;
            this.txtusername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtusername.Depth = 0;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtusername.HideSelection = true;
            this.txtusername.Hint = "Nhập username...";
            this.txtusername.LeadingIcon = null;
            this.txtusername.Location = new System.Drawing.Point(165, 291);
            this.txtusername.MaxLength = 32767;
            this.txtusername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PrefixSuffixText = null;
            this.txtusername.ReadOnly = false;
            this.txtusername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.ShortcutsEnabled = true;
            this.txtusername.Size = new System.Drawing.Size(233, 48);
            this.txtusername.TabIndex = 1;
            this.txtusername.TabStop = false;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusername.TrailingIcon = null;
            this.txtusername.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(69, 304);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Username:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(69, 376);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Password:";
            // 
            // txtpassword
            // 
            this.txtpassword.AnimateReadOnly = false;
            this.txtpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtpassword.Depth = 0;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtpassword.HideSelection = true;
            this.txtpassword.Hint = "Nhập password...";
            this.txtpassword.LeadingIcon = null;
            this.txtpassword.Location = new System.Drawing.Point(165, 363);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PrefixSuffixText = null;
            this.txtpassword.ReadOnly = false;
            this.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(233, 48);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.TabStop = false;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpassword.TrailingIcon = null;
            this.txtpassword.UseSystemPasswordChar = false;
            // 
            // logochat
            // 
            this.logochat.Image = ((System.Drawing.Image)(resources.GetObject("logochat.Image")));
            this.logochat.Location = new System.Drawing.Point(141, 93);
            this.logochat.Name = "logochat";
            this.logochat.Size = new System.Drawing.Size(206, 168);
            this.logochat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logochat.TabIndex = 5;
            this.logochat.TabStop = false;
            // 
            // btndangnhap
            // 
            this.btndangnhap.AutoSize = false;
            this.btndangnhap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndangnhap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btndangnhap.Depth = 0;
            this.btndangnhap.HighEmphasis = true;
            this.btndangnhap.Icon = null;
            this.btndangnhap.Location = new System.Drawing.Point(260, 444);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btndangnhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btndangnhap.Size = new System.Drawing.Size(138, 45);
            this.btndangnhap.TabIndex = 6;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btndangnhap.UseAccentColor = false;
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btn_dangki
            // 
            this.btn_dangki.AutoSize = false;
            this.btn_dangki.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_dangki.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_dangki.Depth = 0;
            this.btn_dangki.HighEmphasis = true;
            this.btn_dangki.Icon = null;
            this.btn_dangki.Location = new System.Drawing.Point(69, 444);
            this.btn_dangki.Margin = new System.Windows.Forms.Padding(5);
            this.btn_dangki.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_dangki.Name = "btn_dangki";
            this.btn_dangki.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_dangki.Size = new System.Drawing.Size(135, 45);
            this.btn_dangki.TabIndex = 7;
            this.btn_dangki.Text = "Đăng kí";
            this.btn_dangki.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_dangki.UseAccentColor = false;
            this.btn_dangki.UseVisualStyleBackColor = true;
            this.btn_dangki.Click += new System.EventHandler(this.btn_dangki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 555);
            this.Controls.Add(this.btn_dangki);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.logochat);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtusername);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.logochat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtusername;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox22;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 txtpassword;
        private PictureBox logochat;
        private MaterialSkin.Controls.MaterialButton btndangnhap;
        private MaterialSkin.Controls.MaterialButton btn_dangki;
    }
}