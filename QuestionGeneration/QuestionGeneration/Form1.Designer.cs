namespace QuestionGeneration
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
            this.Submit = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Question = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pause = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Mark = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.textBoxacount = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(494, 316);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(86, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "提交";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(494, 191);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(86, 25);
            this.Answer.TabIndex = 1;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Question.Location = new System.Drawing.Point(205, 191);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(181, 25);
            this.Question.TabIndex = 2;
            this.Question.Text = "Question Demo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(290, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "自动出题程序";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("宋体", 15F);
            this.Time.Location = new System.Drawing.Point(174, 70);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 25);
            this.Time.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(588, 42);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(75, 23);
            this.Pause.TabIndex = 5;
            this.Pause.Text = "暂停";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(588, 87);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(75, 23);
            this.Continue.TabIndex = 6;
            this.Continue.Text = "继续";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Index.Location = new System.Drawing.Point(415, 128);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(0, 25);
            this.Index.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(324, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "题号";
            // 
            // Mark
            // 
            this.Mark.AutoSize = true;
            this.Mark.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Mark.Location = new System.Drawing.Point(632, 191);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(0, 28);
            this.Mark.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(39, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "题目总数";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("宋体", 15F);
            this.Total.Location = new System.Drawing.Point(170, 128);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 25);
            this.Total.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(44, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "满分";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(44, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "当前分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(175, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "100";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("宋体", 15F);
            this.Score.Location = new System.Drawing.Point(175, 330);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(25, 25);
            this.Score.TabIndex = 15;
            this.Score.Text = "0";
            // 
            // textBoxacount
            // 
            this.textBoxacount.Location = new System.Drawing.Point(170, 128);
            this.textBoxacount.Name = "textBoxacount";
            this.textBoxacount.Size = new System.Drawing.Size(56, 25);
            this.textBoxacount.TabIndex = 16;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(170, 73);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(56, 25);
            this.textBoxTime.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(44, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "每题时间";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(329, 316);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(86, 23);
            this.Start.TabIndex = 19;
            this.Start.Text = "开始答题";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxacount);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label Index;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Mark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.TextBox textBoxacount;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Start;
    }
}

