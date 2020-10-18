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
            this.components = new System.ComponentModel.Container();
            this.StulistView = new System.Windows.Forms.ListView();
            this.StudentIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student_ClassIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SexcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClasslistView = new System.Windows.Forms.ListView();
            this.Class_ClassIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Class_SchoolIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MajorcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GradecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumscolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClasscontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SchoollistView = new System.Windows.Forms.ListView();
            this.SchoolIdcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SchoolNamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SchoolcontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加条目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Schoolpanel = new System.Windows.Forms.Panel();
            this.InsertSchoolButton = new System.Windows.Forms.Button();
            this.SchoolNameSchooltextBox = new System.Windows.Forms.TextBox();
            this.SchoolIdSchooltextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Studentpanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StudentIdStudenttextBox = new System.Windows.Forms.TextBox();
            this.StudentNameStudenttextBox = new System.Windows.Forms.TextBox();
            this.ClassIdStudenttextBox = new System.Windows.Forms.TextBox();
            this.AgeStudenttextBox = new System.Windows.Forms.TextBox();
            this.SexStudenttextBox = new System.Windows.Forms.TextBox();
            this.ClassPanel = new System.Windows.Forms.Panel();
            this.InsertStudentbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ClassIdClasstextBox = new System.Windows.Forms.TextBox();
            this.SchoolIdClasstextBox = new System.Windows.Forms.TextBox();
            this.NumsClasstextBox = new System.Windows.Forms.TextBox();
            this.MajorClasstextBox = new System.Windows.Forms.TextBox();
            this.GradeClasstextBox = new System.Windows.Forms.TextBox();
            this.InsertClassbutton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SchoolcontextMenuStrip.SuspendLayout();
            this.Schoolpanel.SuspendLayout();
            this.Studentpanel.SuspendLayout();
            this.ClassPanel.SuspendLayout();
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
            this.StulistView.ContextMenuStrip = this.StudentcontextMenuStrip;
            this.StulistView.FullRowSelect = true;
            this.StulistView.GridLines = true;
            this.StulistView.HideSelection = false;
            this.StulistView.LabelEdit = true;
            this.StulistView.Location = new System.Drawing.Point(562, 318);
            this.StulistView.MultiSelect = false;
            this.StulistView.Name = "StulistView";
            this.StulistView.Size = new System.Drawing.Size(340, 209);
            this.StulistView.TabIndex = 0;
            this.StulistView.UseCompatibleStateImageBehavior = false;
            this.StulistView.View = System.Windows.Forms.View.Details;
            this.StulistView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.StulistView_AfterLabelEdit);
            this.StulistView.Click += new System.EventHandler(this.StulistView_Click);
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
            // StudentcontextMenuStrip
            // 
            this.StudentcontextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StudentcontextMenuStrip.Name = "StudentcontextMenuStrip";
            this.StudentcontextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // ClasslistView
            // 
            this.ClasslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Class_ClassIdcolumnHeader,
            this.Class_SchoolIdcolumnHeader,
            this.MajorcolumnHeader,
            this.GradecolumnHeader,
            this.NumscolumnHeader});
            this.ClasslistView.ContextMenuStrip = this.ClasscontextMenuStrip;
            this.ClasslistView.FullRowSelect = true;
            this.ClasslistView.GridLines = true;
            this.ClasslistView.HideSelection = false;
            this.ClasslistView.LabelEdit = true;
            this.ClasslistView.Location = new System.Drawing.Point(95, 318);
            this.ClasslistView.MultiSelect = false;
            this.ClasslistView.Name = "ClasslistView";
            this.ClasslistView.Size = new System.Drawing.Size(383, 209);
            this.ClasslistView.TabIndex = 1;
            this.ClasslistView.UseCompatibleStateImageBehavior = false;
            this.ClasslistView.View = System.Windows.Forms.View.Details;
            this.ClasslistView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.ClasslistView_AfterLabelEdit);
            this.ClasslistView.Click += new System.EventHandler(this.ClasslistView_Click);
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
            // ClasscontextMenuStrip
            // 
            this.ClasscontextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ClasscontextMenuStrip.Name = "ClasscontextMenuStrip";
            this.ClasscontextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // SchoollistView
            // 
            this.SchoollistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SchoolIdcolumnHeader,
            this.SchoolNamecolumnHeader});
            this.SchoollistView.ContextMenuStrip = this.SchoolcontextMenuStrip;
            this.SchoollistView.FullRowSelect = true;
            this.SchoollistView.GridLines = true;
            this.SchoollistView.HideSelection = false;
            this.SchoollistView.LabelEdit = true;
            this.SchoollistView.Location = new System.Drawing.Point(95, 154);
            this.SchoollistView.MultiSelect = false;
            this.SchoollistView.Name = "SchoollistView";
            this.SchoollistView.Size = new System.Drawing.Size(269, 158);
            this.SchoollistView.TabIndex = 2;
            this.SchoollistView.UseCompatibleStateImageBehavior = false;
            this.SchoollistView.View = System.Windows.Forms.View.Details;
            this.SchoollistView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.SchoollistView_AfterLabelEdit);
            this.SchoollistView.Click += new System.EventHandler(this.SchoollistView_Click);
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
            // SchoolcontextMenuStrip
            // 
            this.SchoolcontextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SchoolcontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加条目ToolStripMenuItem});
            this.SchoolcontextMenuStrip.Name = "SchoolcontextMenuStrip";
            this.SchoolcontextMenuStrip.Size = new System.Drawing.Size(139, 28);
            // 
            // 增加条目ToolStripMenuItem
            // 
            this.增加条目ToolStripMenuItem.Name = "增加条目ToolStripMenuItem";
            this.增加条目ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.增加条目ToolStripMenuItem.Text = "增加条目";
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(942, 392);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 3;
            this.Deletebutton.Text = "删除";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(562, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 126);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // Schoolpanel
            // 
            this.Schoolpanel.Controls.Add(this.InsertSchoolButton);
            this.Schoolpanel.Controls.Add(this.SchoolNameSchooltextBox);
            this.Schoolpanel.Controls.Add(this.SchoolIdSchooltextBox);
            this.Schoolpanel.Controls.Add(this.label2);
            this.Schoolpanel.Controls.Add(this.label1);
            this.Schoolpanel.Location = new System.Drawing.Point(320, 24);
            this.Schoolpanel.Name = "Schoolpanel";
            this.Schoolpanel.Size = new System.Drawing.Size(446, 87);
            this.Schoolpanel.TabIndex = 15;
            // 
            // InsertSchoolButton
            // 
            this.InsertSchoolButton.Location = new System.Drawing.Point(312, 40);
            this.InsertSchoolButton.Name = "InsertSchoolButton";
            this.InsertSchoolButton.Size = new System.Drawing.Size(75, 23);
            this.InsertSchoolButton.TabIndex = 4;
            this.InsertSchoolButton.Text = "插入";
            this.InsertSchoolButton.UseVisualStyleBackColor = true;
            this.InsertSchoolButton.Click += new System.EventHandler(this.InsertSchoolButton_Click);
            // 
            // SchoolNameSchooltextBox
            // 
            this.SchoolNameSchooltextBox.Location = new System.Drawing.Point(168, 51);
            this.SchoolNameSchooltextBox.Name = "SchoolNameSchooltextBox";
            this.SchoolNameSchooltextBox.Size = new System.Drawing.Size(100, 25);
            this.SchoolNameSchooltextBox.TabIndex = 3;
            // 
            // SchoolIdSchooltextBox
            // 
            this.SchoolIdSchooltextBox.Location = new System.Drawing.Point(20, 51);
            this.SchoolIdSchooltextBox.Name = "SchoolIdSchooltextBox";
            this.SchoolIdSchooltextBox.Size = new System.Drawing.Size(100, 25);
            this.SchoolIdSchooltextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "学校名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学校编号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Studentpanel
            // 
            this.Studentpanel.Controls.Add(this.InsertStudentbutton);
            this.Studentpanel.Controls.Add(this.SexStudenttextBox);
            this.Studentpanel.Controls.Add(this.AgeStudenttextBox);
            this.Studentpanel.Controls.Add(this.ClassIdStudenttextBox);
            this.Studentpanel.Controls.Add(this.StudentNameStudenttextBox);
            this.Studentpanel.Controls.Add(this.StudentIdStudenttextBox);
            this.Studentpanel.Controls.Add(this.label8);
            this.Studentpanel.Controls.Add(this.label7);
            this.Studentpanel.Controls.Add(this.label5);
            this.Studentpanel.Controls.Add(this.label4);
            this.Studentpanel.Controls.Add(this.label3);
            this.Studentpanel.Location = new System.Drawing.Point(154, 4);
            this.Studentpanel.Name = "Studentpanel";
            this.Studentpanel.Size = new System.Drawing.Size(748, 144);
            this.Studentpanel.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "学号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "班级Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "年龄";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "性别";
            // 
            // StudentIdStudenttextBox
            // 
            this.StudentIdStudenttextBox.Location = new System.Drawing.Point(19, 91);
            this.StudentIdStudenttextBox.Name = "StudentIdStudenttextBox";
            this.StudentIdStudenttextBox.Size = new System.Drawing.Size(100, 25);
            this.StudentIdStudenttextBox.TabIndex = 6;
            // 
            // StudentNameStudenttextBox
            // 
            this.StudentNameStudenttextBox.Location = new System.Drawing.Point(147, 91);
            this.StudentNameStudenttextBox.Name = "StudentNameStudenttextBox";
            this.StudentNameStudenttextBox.Size = new System.Drawing.Size(100, 25);
            this.StudentNameStudenttextBox.TabIndex = 7;
            // 
            // ClassIdStudenttextBox
            // 
            this.ClassIdStudenttextBox.Location = new System.Drawing.Point(267, 91);
            this.ClassIdStudenttextBox.Name = "ClassIdStudenttextBox";
            this.ClassIdStudenttextBox.Size = new System.Drawing.Size(100, 25);
            this.ClassIdStudenttextBox.TabIndex = 8;
            // 
            // AgeStudenttextBox
            // 
            this.AgeStudenttextBox.Location = new System.Drawing.Point(392, 91);
            this.AgeStudenttextBox.Name = "AgeStudenttextBox";
            this.AgeStudenttextBox.Size = new System.Drawing.Size(100, 25);
            this.AgeStudenttextBox.TabIndex = 9;
            // 
            // SexStudenttextBox
            // 
            this.SexStudenttextBox.Location = new System.Drawing.Point(512, 91);
            this.SexStudenttextBox.Name = "SexStudenttextBox";
            this.SexStudenttextBox.Size = new System.Drawing.Size(100, 25);
            this.SexStudenttextBox.TabIndex = 10;
            // 
            // ClassPanel
            // 
            this.ClassPanel.Controls.Add(this.InsertClassbutton);
            this.ClassPanel.Controls.Add(this.GradeClasstextBox);
            this.ClassPanel.Controls.Add(this.MajorClasstextBox);
            this.ClassPanel.Controls.Add(this.NumsClasstextBox);
            this.ClassPanel.Controls.Add(this.SchoolIdClasstextBox);
            this.ClassPanel.Controls.Add(this.ClassIdClasstextBox);
            this.ClassPanel.Controls.Add(this.label12);
            this.ClassPanel.Controls.Add(this.label11);
            this.ClassPanel.Controls.Add(this.label10);
            this.ClassPanel.Controls.Add(this.label9);
            this.ClassPanel.Controls.Add(this.label6);
            this.ClassPanel.Location = new System.Drawing.Point(168, 12);
            this.ClassPanel.Name = "ClassPanel";
            this.ClassPanel.Size = new System.Drawing.Size(756, 100);
            this.ClassPanel.TabIndex = 17;
            // 
            // InsertStudentbutton
            // 
            this.InsertStudentbutton.Location = new System.Drawing.Point(654, 74);
            this.InsertStudentbutton.Name = "InsertStudentbutton";
            this.InsertStudentbutton.Size = new System.Drawing.Size(75, 23);
            this.InsertStudentbutton.TabIndex = 11;
            this.InsertStudentbutton.Text = "插入";
            this.InsertStudentbutton.UseVisualStyleBackColor = true;
            this.InsertStudentbutton.Click += new System.EventHandler(this.InsertStudentbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "学校";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "人数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "专业";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(420, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "年级";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "班级编号";
            // 
            // ClassIdClasstextBox
            // 
            this.ClassIdClasstextBox.Location = new System.Drawing.Point(6, 60);
            this.ClassIdClasstextBox.Name = "ClassIdClasstextBox";
            this.ClassIdClasstextBox.Size = new System.Drawing.Size(100, 25);
            this.ClassIdClasstextBox.TabIndex = 6;
            // 
            // SchoolIdClasstextBox
            // 
            this.SchoolIdClasstextBox.Location = new System.Drawing.Point(140, 60);
            this.SchoolIdClasstextBox.Name = "SchoolIdClasstextBox";
            this.SchoolIdClasstextBox.Size = new System.Drawing.Size(100, 25);
            this.SchoolIdClasstextBox.TabIndex = 7;
            // 
            // NumsClasstextBox
            // 
            this.NumsClasstextBox.Location = new System.Drawing.Point(556, 60);
            this.NumsClasstextBox.Name = "NumsClasstextBox";
            this.NumsClasstextBox.Size = new System.Drawing.Size(100, 25);
            this.NumsClasstextBox.TabIndex = 8;
            // 
            // MajorClasstextBox
            // 
            this.MajorClasstextBox.Location = new System.Drawing.Point(256, 60);
            this.MajorClasstextBox.Name = "MajorClasstextBox";
            this.MajorClasstextBox.Size = new System.Drawing.Size(100, 25);
            this.MajorClasstextBox.TabIndex = 8;
            // 
            // GradeClasstextBox
            // 
            this.GradeClasstextBox.Location = new System.Drawing.Point(387, 60);
            this.GradeClasstextBox.Name = "GradeClasstextBox";
            this.GradeClasstextBox.Size = new System.Drawing.Size(100, 25);
            this.GradeClasstextBox.TabIndex = 9;
            // 
            // InsertClassbutton
            // 
            this.InsertClassbutton.Location = new System.Drawing.Point(678, 46);
            this.InsertClassbutton.Name = "InsertClassbutton";
            this.InsertClassbutton.Size = new System.Drawing.Size(75, 23);
            this.InsertClassbutton.TabIndex = 10;
            this.InsertClassbutton.Text = "插入";
            this.InsertClassbutton.UseVisualStyleBackColor = true;
            this.InsertClassbutton.Click += new System.EventHandler(this.InsertClassbutton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 10F);
            this.label13.Location = new System.Drawing.Point(939, 206);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(212, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "点击某表中的条目即可操作";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 578);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ClassPanel);
            this.Controls.Add(this.Studentpanel);
            this.Controls.Add(this.Schoolpanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.SchoollistView);
            this.Controls.Add(this.ClasslistView);
            this.Controls.Add(this.StulistView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SchoolcontextMenuStrip.ResumeLayout(false);
            this.Schoolpanel.ResumeLayout(false);
            this.Schoolpanel.PerformLayout();
            this.Studentpanel.ResumeLayout(false);
            this.Studentpanel.PerformLayout();
            this.ClassPanel.ResumeLayout(false);
            this.ClassPanel.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip SchoolcontextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip StudentcontextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip ClasscontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 增加条目ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel Schoolpanel;
        private System.Windows.Forms.Button InsertSchoolButton;
        private System.Windows.Forms.TextBox SchoolNameSchooltextBox;
        private System.Windows.Forms.TextBox SchoolIdSchooltextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Studentpanel;
        private System.Windows.Forms.Button InsertStudentbutton;
        private System.Windows.Forms.TextBox SexStudenttextBox;
        private System.Windows.Forms.TextBox AgeStudenttextBox;
        private System.Windows.Forms.TextBox ClassIdStudenttextBox;
        private System.Windows.Forms.TextBox StudentNameStudenttextBox;
        private System.Windows.Forms.TextBox StudentIdStudenttextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ClassPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InsertClassbutton;
        private System.Windows.Forms.TextBox GradeClasstextBox;
        private System.Windows.Forms.TextBox MajorClasstextBox;
        private System.Windows.Forms.TextBox NumsClasstextBox;
        private System.Windows.Forms.TextBox SchoolIdClasstextBox;
        private System.Windows.Forms.TextBox ClassIdClasstextBox;
        private System.Windows.Forms.Label label13;
    }
}

