/**
 * author:lcknight
 * repo:https://github.com/LcKnight/.Net-ProjectDuringTheClass
 * email:819818746@qq.com
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace StuManageSys
{
    public partial class Form1 : Form
    {
        private MiddleWare middleWare;
        private Student SelectedStudent;
        private Class SelectedClass;
        private School SelectedSchool;
        private ListViewItem Selectedlvi;
        private List<Student> students;
        private List<Class> classes;
        private List<School> schools;
        public Form1()
        {
            middleWare = new MiddleWare("StuManageSys.sqlite");
            middleWare.FillLists();
            students = middleWare.GetStudents();
            classes = middleWare.GetClasses();
            schools = middleWare.GetSchools();
            //Op = new SqliteOp("StuManageSys.sqlite");
            InitializeComponent();
            this.ClassPanel.Hide();
            this.Schoolpanel.Hide();
            this.Studentpanel.Hide();
            paintStuListView();
            paintClaListView();
            paintSchoolListView();
            OpenLog();
        }

        private void OpenLog()
        {
            richTextBox1.Clear();
            using (StreamReader sw = new StreamReader("log.txt"))
            {
                string line;
                while((line = sw.ReadLine())!=null)
                {
                    richTextBox1.Text += line + "\n";
                }
            }
        }
        private void paintStuListView()
        {
            StulistView.Items.Clear();
            foreach(Student stu in students)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = stu.GetStudentId().ToString();
                lvi.SubItems.Add(stu.GetStudentName().ToString());
                lvi.SubItems.Add(stu.GetClassId().ToString());
                lvi.SubItems.Add(stu.GetAge().ToString());
                lvi.SubItems.Add(stu.GetSex().ToString());
                StulistView.Items.Add(lvi);
            }
            StulistView.Update();


           



          
        }
        public void paintClaListView()
        {
            ClasslistView.Items.Clear();
            foreach (Class cla in classes)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = cla.GetClassId().ToString();
                lvi.SubItems.Add(cla.GetSchoolId().ToString());
                lvi.SubItems.Add(cla.GetMajor());
                lvi.SubItems.Add(cla.GetGrade().ToString());
                lvi.SubItems.Add(cla.GetNums().ToString());

                ClasslistView.Items.Add(lvi);
            }
            ClasslistView.Update();
        }
        public void paintSchoolListView()
        {
            SchoollistView.Items.Clear();
            foreach (School sch in schools)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sch.GetSchoolId().ToString();
                lvi.SubItems.Add(sch.GetSchoolName());
                SchoollistView.Items.Add(lvi);
            }
            SchoollistView.Update();
        }

        private void StulistView_Click(object sender, EventArgs e)
        {
            this.ClassPanel.Hide();
            this.Schoolpanel.Hide();
            this.Studentpanel.Show();
            if (this.StulistView.SelectedItems.Count == 0)
                return;
            //ListViewItem currentRow = StulistView.SelectedItems[0];
            int currentRow = StulistView.SelectedItems[0].Index;
            SelectedStudent = students[currentRow];

            SelectedSchool = null;
            SelectedClass = null;
            
        }
        private void SchoollistView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            string newLabel = e.Label;
        }

        private void ClasslistView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            string newLabel = e.Label;
        }

        private void StulistView_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            string newLabel = e.Label;
        }

        private void StulistView_DoubleClick(object sender, EventArgs e)
        {
           

            if (this.StulistView.SelectedItems.Count == 0)
                return;
            //ListViewItem currentRow = StulistView.SelectedItems[0];
            int currentRow = StulistView.SelectedItems[0].Index;
            SelectedStudent = students[currentRow];
        }

        private void StulistView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if(SelectedClass!=null)
            {
                middleWare.Delete(SelectedClass);
                classes.Remove(SelectedClass);
                paintClaListView();
            }
            if (SelectedStudent != null)
            {
                middleWare.Delete(SelectedStudent);
                students.Remove(SelectedStudent);
                paintStuListView();
            }
            if (SelectedSchool != null)
            {
                middleWare.Delete(SelectedSchool);
                schools.Remove(SelectedSchool);
                paintSchoolListView();
            }
            OpenLog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertSchoolButton_Click(object sender, EventArgs e)
        {
            try
            {
                middleWare.Insert(new School(Int32.Parse(SchoolIdSchooltextBox.Text), SchoolNameSchooltextBox.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            OpenLog();
        }

        private void InsertClassbutton_Click(object sender, EventArgs e)
        {
            try
            {
                middleWare.Insert(new Class(Int32.Parse(ClassIdClasstextBox.Text),Int32.Parse(SchoolIdClasstextBox.Text),Int32.Parse(NumsClasstextBox.Text),MajorClasstextBox.Text,Int32.Parse(GradeClasstextBox.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            OpenLog();
        }

        private void InsertStudentbutton_Click(object sender, EventArgs e)
        {
            try
            {
                middleWare.Insert(new Student(Int32.Parse(StudentIdStudenttextBox.Text), StudentNameStudenttextBox.Text,Int32.Parse(ClassIdStudenttextBox.Text),SexStudenttextBox.Text,Int32.Parse(SexStudenttextBox.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            OpenLog();
        }

        private void SchoollistView_Click(object sender, EventArgs e)
        {
            
            this.ClassPanel.Hide();
            this.Studentpanel.Hide();
            this.Schoolpanel.Show();
            if (this.SchoollistView.SelectedItems.Count == 0)
                return;
            //ListViewItem currentRow = StulistView.SelectedItems[0];
            int currentRow = SchoollistView.SelectedItems[0].Index;
            SelectedSchool = schools[currentRow];
            SelectedClass = null;
            SelectedStudent = null;
        }

        private void ClasslistView_Click(object sender, EventArgs e)
        {
            this.Studentpanel.Hide();
            this.Schoolpanel.Hide();
            this.ClassPanel.Show();
            if (this.ClasslistView.SelectedItems.Count == 0)
                return;
            //ListViewItem currentRow = StulistView.SelectedItems[0];
            int currentRow = ClasslistView.SelectedItems[0].Index;
            SelectedClass = classes[currentRow];
            SelectedStudent = null;
            SelectedSchool = null;
        }
    }
    
}
