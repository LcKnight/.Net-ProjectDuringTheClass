namespace StuManageSys
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
            this.StulistView = new System.Windows.Forms.ListView();
            this.StudentIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_ClassIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SexcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClasslistView = new System.Windows.Forms.ListView();
            this.Class_ClassIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Class_SchoolIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MajorcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GradecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumscolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SchoollistView = new System.Windows.Forms.ListView();
            this.SchoolIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SchoolNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deletebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StulistView
            // 
            this.StulistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentIdcolumnHeader,
            this.StudentNamecolumnHeader,
            this.Student_ClassIdcolumnHeader,
            this.AgecolumnHeader,
            this.SexcolumnHeader});
            this.StulistView.FullRowSelect = true;
            this.StulistView.GridLines = true;
            this.StulistView.HideSelection = false;
            this.StulistView.LabelEdit = true;
            this.StulistView.Location = new System.Drawing.Point(582, 244);
            this.StulistView.MultiSelect = false;
            this.StulistView.Name = "StulistView";
            this.StulistView.Size = new System.Drawing.Size(340, 209);
            this.StulistView.TabIndex = 0;
            this.StulistView.UseCompatibleStateImageBehavior = false;
            this.StulistView.View = System.Windows.Forms.View.Details;
            this.StulistView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.StulistView_AfterLabelEdit);
            this.StulistView.DoubleClick += new System.EventHandler(this.StulistView_DoubleClick);
            this.StulistView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StulistView_MouseDoubleClick);
            // 
            // StudentIdcolumnHeader
            // 
            this.StudentIdcolumnHeader.Text = "学号";
            // 
            // StudentNamecolumnHeader
            // 
            this.StudentNamecolumnHeader.Text = "姓名";
            this.StudentNamecolumnHeader.Width = 77;
            // 
            // Student_ClassIdcolumnHeader
            // 
            this.Student_ClassIdcolumnHeader.Text = "班级Id";
            // 
            // AgecolumnHeader
            // 
            this.AgecolumnHeader.Text = "年龄";
            this.AgecolumnHeader.Width = 75;
            // 
            // SexcolumnHeader
            // 
            this.SexcolumnHeader.Text = "性别";
            this.SexcolumnHeader.Width = 85;
            // 
            // ClasslistView
            // 
            this.ClasslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Class_ClassIdcolumnHeader,
            this.Class_SchoolIdcolumnHeader,
            this.MajorcolumnHeader,
            this.GradecolumnHeader,
            this.NumscolumnHeader});
            this.ClasslistView.FullRowSelect = true;
            this.ClasslistView.GridLines = true;
            this.ClasslistView.HideSelection = false;
            this.ClasslistView.LabelEdit = true;
            this.ClasslistView.Location = new System.Drawing.Point(63, 244);
            this.ClasslistView.MultiSelect = false;
            this.ClasslistView.Name = "ClasslistView";
            this.ClasslistView.Size = new System.Drawing.Size(383, 209);
            this.ClasslistView.TabIndex = 1;
            this.ClasslistView.UseCompatibleStateImageBehavior = false;
            this.ClasslistView.View = System.Windows.Forms.View.Details;
            this.ClasslistView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ClasslistView_AfterLabelEdit);
            // 
            // Class_ClassIdcolumnHeader
            // 
            this.Class_ClassIdcolumnHeader.Text = "班级编号";
            this.Class_ClassIdcolumnHeader.Width = 88;
            // 
            // Class_SchoolIdcolumnHeader
            // 
            this.Class_SchoolIdcolumnHeader.Text = "学校";
            this.Class_SchoolIdcolumnHeader.Width = 75;
            // 
            // MajorcolumnHeader
            // 
            this.MajorcolumnHeader.Text = "专业";
            // 
            // GradecolumnHeader
            // 
            this.GradecolumnHeader.Text = "年级";
            // 
            // NumscolumnHeader
            // 
            this.NumscolumnHeader.Text = "人数";
            // 
            // SchoollistView
            // 
            this.SchoollistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SchoolIdcolumnHeader,
            this.SchoolNamecolumnHeader});
            this.SchoollistView.FullRowSelect = true;
            this.SchoollistView.GridLines = true;
            this.SchoollistView.HideSelection = false;
            this.SchoollistView.LabelEdit = true;
            this.SchoollistView.Location = new System.Drawing.Point(63, 80);
            this.SchoollistView.MultiSelect = false;
            this.SchoollistView.Name = "SchoollistView";
            this.SchoollistView.Size = new System.Drawing.Size(241, 145);
            this.SchoollistView.TabIndex = 2;
            this.SchoollistView.UseCompatibleStateImageBehavior = false;
            this.SchoollistView.View = System.Windows.Forms.View.Details;
            this.SchoollistView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.SchoollistView_AfterLabelEdit);
            // 
            // SchoolIdcolumnHeader
            // 
            this.SchoolIdcolumnHeader.Text = "学校编号";
            this.SchoolIdcolumnHeader.Width = 108;
            // 
            // SchoolNamecolumnHeader
            // 
            this.SchoolNamecolumnHeader.Text = "学校名称";
            this.SchoolNamecolumnHeader.Width = 125;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(910, 144);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 3;
            this.Deletebutton.Text = "button1";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(471, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "双击学校表或班级表更新界面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(376, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "查";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(376, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "增";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(377, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "删";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 13.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(376, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "改";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 13.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(450, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(424, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "单击条目，选定行，再点击右边删除选项";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 499);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.SchoollistView);
            this.Controls.Add(this.ClasslistView);
            this.Controls.Add(this.StulistView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView StulistView;
        private System.Windows.Forms.ColumnHeader StudentIdcolumnHeader;
        private System.Windows.Forms.ColumnHeader StudentNamecolumnHeader;
        private System.Windows.Forms.ColumnHeader Student_ClassIdcolumnHeader;
        private System.Windows.Forms.ColumnHeader AgecolumnHeader;
        private System.Windows.Forms.ColumnHeader SexcolumnHeader;
        private System.Windows.Forms.ListView ClasslistView;
        private System.Windows.Forms.ColumnHeader Class_ClassIdcolumnHeader;
        private System.Windows.Forms.ColumnHeader Class_SchoolIdcolumnHeader;
        private System.Windows.Forms.ColumnHeader MajorcolumnHeader;
        private System.Windows.Forms.ColumnHeader GradecolumnHeader;
        private System.Windows.Forms.ColumnHeader NumscolumnHeader;
        private System.Windows.Forms.ListView SchoollistView;
        private System.Windows.Forms.ColumnHeader SchoolIdcolumnHeader;
        private System.Windows.Forms.ColumnHeader SchoolNamecolumnHeader;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

