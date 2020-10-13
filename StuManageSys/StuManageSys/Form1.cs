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

namespace StuManageSys
{
    public partial class Form1 : Form
    {
        private MiddleWare middleWare;
        private Student SelectedStudent;
        private Class SelectedClass;
        private School SelectedSchool;

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
            paintStuListView();
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
            middleWare.Delete(SelectedStudent);
            students.Remove(SelectedStudent);
        }
        private void paintStuListView()
        {
            foreach(Student stu in students)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = stu.GetStudentId().ToString();
                StulistView.Items.Add(lvi);
            }
            StulistView.Update();
        }
    }
}
