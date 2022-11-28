namespace DoAn
{
    partial class TaoNhom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoNhom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtsearchuser = new System.Windows.Forms.TextBox();
            this.btntimuser = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ketquasearch = new System.Windows.Forms.DataGridView();
            this.btntaonhom = new MaterialSkin.Controls.MaterialButton();
            this.txttennhom = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dsthanhvien = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturnToMain = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ketquasearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsthanhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(20, 133);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(103, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Nhập tên user:";
            // 
            // txtsearchuser
            // 
            this.txtsearchuser.Location = new System.Drawing.Point(129, 127);
            this.txtsearchuser.Multiline = true;
            this.txtsearchuser.Name = "txtsearchuser";
            this.txtsearchuser.Size = new System.Drawing.Size(304, 34);
            this.txtsearchuser.TabIndex = 3;
            // 
            // btntimuser
            // 
            this.btntimuser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btntimuser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btntimuser.Depth = 0;
            this.btntimuser.HighEmphasis = true;
            this.btntimuser.Icon = null;
            this.btntimuser.Location = new System.Drawing.Point(347, 168);
            this.btntimuser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btntimuser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btntimuser.Name = "btntimuser";
            this.btntimuser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btntimuser.Size = new System.Drawing.Size(86, 36);
            this.btntimuser.TabIndex = 4;
            this.btntimuser.Text = "Tìm kiếm";
            this.btntimuser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btntimuser.UseAccentColor = false;
            this.btntimuser.UseVisualStyleBackColor = true;
            this.btntimuser.Click += new System.EventHandler(this.btntimuser_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "usericon.png");
            // 
            // ketquasearch
            // 
            this.ketquasearch.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ketquasearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ketquasearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ketquasearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ketquasearch.Location = new System.Drawing.Point(129, 216);
            this.ketquasearch.Name = "ketquasearch";
            this.ketquasearch.RowHeadersWidth = 51;
            this.ketquasearch.RowTemplate.Height = 29;
            this.ketquasearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ketquasearch.Size = new System.Drawing.Size(304, 268);
            this.ketquasearch.TabIndex = 5;
            this.ketquasearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ketquasearch_CellContentClick);
            // 
            // btntaonhom
            // 
            this.btntaonhom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btntaonhom.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btntaonhom.Depth = 0;
            this.btntaonhom.HighEmphasis = true;
            this.btntaonhom.Icon = null;
            this.btntaonhom.Location = new System.Drawing.Point(631, 168);
            this.btntaonhom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btntaonhom.MouseState = MaterialSkin.MouseState.HOVER;
            this.btntaonhom.Name = "btntaonhom";
            this.btntaonhom.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btntaonhom.Size = new System.Drawing.Size(98, 36);
            this.btntaonhom.TabIndex = 6;
            this.btntaonhom.Text = "Tạo nhóm";
            this.btntaonhom.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btntaonhom.UseAccentColor = false;
            this.btntaonhom.UseVisualStyleBackColor = true;
            this.btntaonhom.Click += new System.EventHandler(this.btntaonhom_Click);
            // 
            // txttennhom
            // 
            this.txttennhom.Location = new System.Drawing.Point(530, 127);
            this.txttennhom.Multiline = true;
            this.txttennhom.Name = "txttennhom";
            this.txttennhom.Size = new System.Drawing.Size(199, 34);
            this.txttennhom.TabIndex = 8;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(447, 133);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Tên nhóm:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(447, 179);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(159, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Danh sách thành viên:";
            // 
            // dsthanhvien
            // 
            this.dsthanhvien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dsthanhvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dsthanhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dsthanhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsthanhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName});
            this.dsthanhvien.Location = new System.Drawing.Point(447, 216);
            this.dsthanhvien.Name = "dsthanhvien";
            this.dsthanhvien.RowHeadersWidth = 51;
            this.dsthanhvien.RowTemplate.Height = 29;
            this.dsthanhvien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dsthanhvien.Size = new System.Drawing.Size(282, 268);
            this.dsthanhvien.TabIndex = 11;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.AutoSize = false;
            this.btnReturnToMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReturnToMain.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReturnToMain.Depth = 0;
            this.btnReturnToMain.HighEmphasis = true;
            this.btnReturnToMain.Icon = null;
            this.btnReturnToMain.Location = new System.Drawing.Point(20, 79);
            this.btnReturnToMain.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReturnToMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnReturnToMain.Size = new System.Drawing.Size(208, 35);
            this.btnReturnToMain.TabIndex = 12;
            this.btnReturnToMain.Text = "< Quay về giao diện chính";
            this.btnReturnToMain.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReturnToMain.UseAccentColor = false;
            this.btnReturnToMain.UseVisualStyleBackColor = true;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(129, 179);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(124, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Kết quả tìm kiếm:";
            // 
            // TaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 510);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.btnReturnToMain);
            this.Controls.Add(this.dsthanhvien);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txttennhom);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btntaonhom);
            this.Controls.Add(this.ketquasearch);
            this.Controls.Add(this.btntimuser);
            this.Controls.Add(this.txtsearchuser);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label1);
            this.Name = "TaoNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoNhom";
            ((System.ComponentModel.ISupportInitialize)(this.ketquasearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsthanhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private TextBox txtsearchuser;
        private MaterialSkin.Controls.MaterialButton btntimuser;
        private ImageList imageList1;
        private DataGridView ketquasearch;
        private MaterialSkin.Controls.MaterialButton btntaonhom;
        private TextBox txttennhom;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private DataGridView dsthanhvien;
        private DataGridViewTextBoxColumn UserName;
        private MaterialSkin.Controls.MaterialButton btnReturnToMain;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}