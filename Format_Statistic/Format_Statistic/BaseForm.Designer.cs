namespace Format_Statistic
{
    partial class BaseForm
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
            this.SourceCodeopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FileOpenbutton = new System.Windows.Forms.Button();
            this.WordslistView = new System.Windows.Forms.ListView();
            this.WordNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WordCountcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Formatbutton = new System.Windows.Forms.Button();
            this.FormatedPathLabel = new System.Windows.Forms.Label();
            this.OriginLineCountlabel = new System.Windows.Forms.Label();
            this.WordCountlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OriginPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceCodeopenFileDialog
            // 
            this.SourceCodeopenFileDialog.FileName = "openFileDialog1";
            // 
            // FileOpenbutton
            // 
            this.FileOpenbutton.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileOpenbutton.Location = new System.Drawing.Point(576, 97);
            this.FileOpenbutton.Name = "FileOpenbutton";
            this.FileOpenbutton.Size = new System.Drawing.Size(175, 41);
            this.FileOpenbutton.TabIndex = 1;
            this.FileOpenbutton.Text = "选择文件";
            this.FileOpenbutton.UseVisualStyleBackColor = true;
            this.FileOpenbutton.Click += new System.EventHandler(this.FileOpenbutton_Click);
            // 
            // WordslistView
            // 
            this.WordslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WordNamecolumnHeader,
            this.WordCountcolumnHeader});
            this.WordslistView.FullRowSelect = true;
            this.WordslistView.GridLines = true;
            this.WordslistView.HideSelection = false;
            this.WordslistView.Location = new System.Drawing.Point(417, 256);
            this.WordslistView.Name = "WordslistView";
            this.WordslistView.Size = new System.Drawing.Size(347, 170);
            this.WordslistView.TabIndex = 2;
            this.WordslistView.UseCompatibleStateImageBehavior = false;
            this.WordslistView.View = System.Windows.Forms.View.Details;
            // 
            // WordNamecolumnHeader
            // 
            this.WordNamecolumnHeader.Text = "单词名";
            this.WordNamecolumnHeader.Width = 180;
            // 
            // WordCountcolumnHeader
            // 
            this.WordCountcolumnHeader.Text = "出现次数";
            this.WordCountcolumnHeader.Width = 285;
            // 
            // Formatbutton
            // 
            this.Formatbutton.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold);
            this.Formatbutton.Location = new System.Drawing.Point(576, 176);
            this.Formatbutton.Name = "Formatbutton";
            this.Formatbutton.Size = new System.Drawing.Size(175, 54);
            this.Formatbutton.TabIndex = 3;
            this.Formatbutton.Text = "格式化";
            this.Formatbutton.UseVisualStyleBackColor = true;
            this.Formatbutton.Click += new System.EventHandler(this.Formatbutton_Click);
            // 
            // FormatedPathLabel
            // 
            this.FormatedPathLabel.AutoSize = true;
            this.FormatedPathLabel.Location = new System.Drawing.Point(38, 177);
            this.FormatedPathLabel.Name = "FormatedPathLabel";
            this.FormatedPathLabel.Size = new System.Drawing.Size(0, 15);
            this.FormatedPathLabel.TabIndex = 4;
            // 
            // OriginLineCountlabel
            // 
            this.OriginLineCountlabel.AutoSize = true;
            this.OriginLineCountlabel.Location = new System.Drawing.Point(79, 294);
            this.OriginLineCountlabel.Name = "OriginLineCountlabel";
            this.OriginLineCountlabel.Size = new System.Drawing.Size(0, 15);
            this.OriginLineCountlabel.TabIndex = 5;
            // 
            // WordCountlabel
            // 
            this.WordCountlabel.AutoSize = true;
            this.WordCountlabel.Location = new System.Drawing.Point(227, 293);
            this.WordCountlabel.Name = "WordCountlabel";
            this.WordCountlabel.Size = new System.Drawing.Size(0, 15);
            this.WordCountlabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "原始行数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "单词数";
            // 
            // OriginPathLabel
            // 
            this.OriginPathLabel.AutoSize = true;
            this.OriginPathLabel.Location = new System.Drawing.Point(41, 105);
            this.OriginPathLabel.Name = "OriginPathLabel";
            this.OriginPathLabel.Size = new System.Drawing.Size(0, 15);
            this.OriginPathLabel.TabIndex = 9;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.OriginPathLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WordCountlabel);
            this.Controls.Add(this.OriginLineCountlabel);
            this.Controls.Add(this.FormatedPathLabel);
            this.Controls.Add(this.Formatbutton);
            this.Controls.Add(this.WordslistView);
            this.Controls.Add(this.FileOpenbutton);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog SourceCodeopenFileDialog;
        private System.Windows.Forms.Button FileOpenbutton;
        private System.Windows.Forms.ListView WordslistView;
        private System.Windows.Forms.ColumnHeader WordNamecolumnHeader;
        private System.Windows.Forms.ColumnHeader WordCountcolumnHeader;
        private System.Windows.Forms.Button Formatbutton;
        private System.Windows.Forms.Label FormatedPathLabel;
        private System.Windows.Forms.Label OriginLineCountlabel;
        private System.Windows.Forms.Label WordCountlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label OriginPathLabel;
    }
}

