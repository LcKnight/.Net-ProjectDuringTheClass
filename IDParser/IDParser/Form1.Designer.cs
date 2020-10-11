namespace IDParser
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Searchbutton = new System.Windows.Forms.Button();
            this.KeytextBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrlcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BaiduradioButton = new System.Windows.Forms.RadioButton();
            this.BingradioButton = new System.Windows.Forms.RadioButton();
            this.GoogleradioButton = new System.Windows.Forms.RadioButton();
            this.SogouradioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(216, 71);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 23);
            this.Searchbutton.TabIndex = 0;
            this.Searchbutton.Text = "搜索";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // KeytextBox
            // 
            this.KeytextBox.Location = new System.Drawing.Point(41, 71);
            this.KeytextBox.Name = "KeytextBox";
            this.KeytextBox.Size = new System.Drawing.Size(100, 25);
            this.KeytextBox.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDcolumnHeader,
            this.UrlcolumnHeader});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(432, 132);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(356, 306);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IDcolumnHeader
            // 
            this.IDcolumnHeader.Text = "身份证号";
            this.IDcolumnHeader.Width = 102;
            // 
            // UrlcolumnHeader
            // 
            this.UrlcolumnHeader.Text = "URL";
            this.UrlcolumnHeader.Width = 249;
            // 
            // BaiduradioButton
            // 
            this.BaiduradioButton.AutoSize = true;
            this.BaiduradioButton.Location = new System.Drawing.Point(41, 200);
            this.BaiduradioButton.Name = "BaiduradioButton";
            this.BaiduradioButton.Size = new System.Drawing.Size(58, 19);
            this.BaiduradioButton.TabIndex = 3;
            this.BaiduradioButton.TabStop = true;
            this.BaiduradioButton.Text = "百度";
            this.BaiduradioButton.UseVisualStyleBackColor = true;
            // 
            // BingradioButton
            // 
            this.BingradioButton.AutoSize = true;
            this.BingradioButton.Location = new System.Drawing.Point(183, 200);
            this.BingradioButton.Name = "BingradioButton";
            this.BingradioButton.Size = new System.Drawing.Size(60, 19);
            this.BingradioButton.TabIndex = 4;
            this.BingradioButton.TabStop = true;
            this.BingradioButton.Text = "Bing";
            this.BingradioButton.UseVisualStyleBackColor = true;
            // 
            // GoogleradioButton
            // 
            this.GoogleradioButton.AutoSize = true;
            this.GoogleradioButton.Location = new System.Drawing.Point(41, 263);
            this.GoogleradioButton.Name = "GoogleradioButton";
            this.GoogleradioButton.Size = new System.Drawing.Size(76, 19);
            this.GoogleradioButton.TabIndex = 5;
            this.GoogleradioButton.TabStop = true;
            this.GoogleradioButton.Text = "Google";
            this.GoogleradioButton.UseVisualStyleBackColor = true;
            // 
            // SogouradioButton
            // 
            this.SogouradioButton.AutoSize = true;
            this.SogouradioButton.Location = new System.Drawing.Point(183, 262);
            this.SogouradioButton.Name = "SogouradioButton";
            this.SogouradioButton.Size = new System.Drawing.Size(68, 19);
            this.SogouradioButton.TabIndex = 6;
            this.SogouradioButton.TabStop = true;
            this.SogouradioButton.Text = "Sogou";
            this.SogouradioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SogouradioButton);
            this.Controls.Add(this.GoogleradioButton);
            this.Controls.Add(this.BingradioButton);
            this.Controls.Add(this.BaiduradioButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.KeytextBox);
            this.Controls.Add(this.Searchbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.TextBox KeytextBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IDcolumnHeader;
        private System.Windows.Forms.ColumnHeader UrlcolumnHeader;
        private System.Windows.Forms.RadioButton BaiduradioButton;
        private System.Windows.Forms.RadioButton BingradioButton;
        private System.Windows.Forms.RadioButton GoogleradioButton;
        private System.Windows.Forms.RadioButton SogouradioButton;
    }
}

