namespace Server
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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.btnstart = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(71, 171);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(51, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Status:";
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(72, 203);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtstatus.Size = new System.Drawing.Size(406, 206);
            this.txtstatus.TabIndex = 5;
            // 
            // btnstart
            // 
            this.btnstart.AutoSize = false;
            this.btnstart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnstart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnstart.Depth = 0;
            this.btnstart.HighEmphasis = true;
            this.btnstart.Icon = null;
            this.btnstart.Location = new System.Drawing.Point(509, 206);
            this.btnstart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnstart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnstart.Name = "btnstart";
            this.btnstart.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnstart.Size = new System.Drawing.Size(104, 45);
            this.btnstart.TabIndex = 6;
            this.btnstart.Text = "Start";
            this.btnstart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnstart.UseAccentColor = false;
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.materialLabel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private TextBox txtstatus;
        private MaterialSkin.Controls.MaterialButton btnstart;
    }
}