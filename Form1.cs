using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Any09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        /* setup function */

        List<Student> listStudent = new List<Student>();

        public void InputData()
        {
            try
            {
                Student student = new Student()
                {
                    studentCode = Convert.ToDouble(txtStudentCode.Text),
                    studentName = txtStudentName.Text,
                    classCode = txtClassCode.Text,
                    departmentName = txtDepartmentName.Text,
                    mediumScore = Convert.ToDouble(txtMediumScore.Text),
                    studentRank = txtStudentRank.Text
                };
                listStudent.Add(student);
            }
            catch(Exception ex)
            {
                if(txtStudentCode.Text == "" || txtStudentName.Text == "" || txtClassCode.Text == ""
                    || txtDepartmentName.Text == "" || txtMediumScore.Text == ""
                    || txtStudentRank.Text == "")
                {
                    MessageBox.Show("Một hoặc các trường không được để trống" + ex.Message);
                }
            }
        }

        public void ShowData()
        {
            var list = from i in listStudent
                       select new
                       {
                           i.studentCode,
                           i.studentName,
                           i.classCode,
                           i.departmentName,
                           i.mediumScore,
                           i.studentRank
                       };
            dgvListStudent.DataSource = list.ToList();
        }

        public void FindCode()
        {
            Student find = listStudent.FirstOrDefault(x => x.studentCode == Convert.ToDouble(txtFindCode.Text));
            var list = from i in listStudent
                       where i.studentCode == Convert.ToDouble(find.studentCode)
                       select new
                       {
                           i.studentCode,
                           i.studentName,
                           i.classCode,
                           i.departmentName,
                           i.mediumScore,
                           i.studentRank
                       };
            dgvListTask.DataSource = list.ToList();
        }

        public void Scholarship()
        {
            listStudent = listStudent.FindAll(x => x.mediumScore >= 8.7 && x.mediumScore <= 10);
            var list = from i in listStudent
                       select new
                       {
                           i.studentCode,
                           i.studentName,
                           i.classCode,
                           i.departmentName,
                           i.mediumScore,
                           i.studentRank
                       };
            dgvListTask.DataSource = list.ToList();
        }

        public void Orderby()
        {
            var sort = listStudent.OrderBy(x => x.studentCode).ToList();
            dgvListStudent.DataSource = sort;
        }

        public void OrderbyDescending()
        {
            var sort = listStudent.OrderByDescending(x => x.studentCode).ToList();
            dgvListStudent.DataSource = sort;
        }

        public void scoreMax()
        {
            double max = listStudent.Max(x => x.mediumScore);
            var list = from i in listStudent
                       where i.mediumScore == max
                       select new
                       {
                           i.studentCode,
                           i.studentName,
                           i.classCode,
                           i.departmentName,
                           i.mediumScore,
                           i.studentRank
                       };
            dgvListTask.DataSource = list.ToList();
        }

        public void scoreMin()
        {
            double min = listStudent.Min(x => x.mediumScore);
            var list = from i in listStudent
                       where i.mediumScore == min
                       select new
                       {
                           i.studentCode,
                           i.studentName,
                           i.classCode,
                           i.departmentName,
                           i.mediumScore,
                           i.studentRank
                       };
            dgvListTask.DataSource = list.ToList();
        }

        /* Statement */

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InputData();
            ShowData();
        }

        private void btnFindCode_Click(object sender, EventArgs e)
        {
            FindCode();
        }

        private void btnScholarship_Click(object sender, EventArgs e)
        {
            Scholarship();
        }

        private void btnOrderby_Click(object sender, EventArgs e)
        {
            Orderby();
        }

        private void btnOrderbyDescending_Click(object sender, EventArgs e)
        {
            OrderbyDescending();
        }

        private void btnScoreMax_Click(object sender, EventArgs e)
        {
            scoreMax();
        }

        private void btnScoreMin_Click(object sender, EventArgs e)
        {
            scoreMin();
        }
    }
}
