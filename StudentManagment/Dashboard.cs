using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagment
{
    public partial class Dashboard : Form
    {
        private Form _form;
        private List<Student> _studentList;
        private int updateId;
        
        public Dashboard(Form1 form)
        {
            InitializeComponent();
            _form = form;
            _studentList = new List<Student>
            {
                new Student{StudentName="Ilkin", StudentSurname="Huseynov", Age=30 },
                new Student{StudentName="Elmeddin", StudentSurname="Ceferov", Age= 33},
                new Student{StudentName="Ayaz", StudentSurname="Veliyev", Age=33 }
            };

            dataList.DataSource = _studentList;

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.Show();
             Hide();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            
            bool res = checkFields(stuNametxt.Text.Trim(),studentSurnametxt.Text.Trim(),studentAge.Text.Trim());
            if (res)
            {
                Student student = new Student();
                student.StudentName = stuNametxt.Text.Trim();
                student.StudentSurname = studentSurnametxt.Text.Trim();
                student.Age = Convert.ToInt32(studentAge.Text.Trim());
                AddStudent(student);
            }
            else
            {
                MessageBox.Show("Fild cannot be empty","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void AddStudent(Student student)
        {
            _studentList.Add(student);
            refeshDataList();
        }

        public void refeshDataList()
        {
            dataList.DataSource = "";
            dataList.DataSource = _studentList;
        }

        private bool checkFields(string stuName,string stuSurname , string stuAge)
        {
            if (String.IsNullOrEmpty(stuName) || String.IsNullOrEmpty(stuSurname)|| String.IsNullOrEmpty(stuAge))
            {
                return false;
            }
            return true;
        }

        private void dataList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedItem = Convert.ToInt32(dataList.Rows[e.RowIndex].Cells[0].Value.ToString()); // Getting Id hansi row clicklenibse
           // int selectedItem = Convert.ToInt32(dataList.SelectedCells[0].Value.ToString()); // Getting Id 
            updateId = selectedItem;
            Student selectedStudent = _studentList.FirstOrDefault(s=> s._Id == selectedItem);
            stuNametxt.Text = selectedStudent.StudentName;
            studentSurnametxt.Text = selectedStudent.StudentSurname;
            studentAge.Text = Convert.ToString(selectedStudent.Age);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Student selectedStudent = _studentList.FirstOrDefault(s => s._Id == updateId);
            selectedStudent.StudentName = stuNametxt.Text.Trim();
            selectedStudent.StudentSurname = studentSurnametxt.Text.Trim();
            selectedStudent.Age = Convert.ToInt32(studentAge.Text);
            refeshGird();
        }

        public void refeshGird()
        {
            dataList.DataSource = "";
            dataList.DataSource = _studentList;
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete deleteForm = new Delete(_studentList, dataList);
            deleteForm.ShowDialog();
        }

        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(Keys.Shift.ToString());
            //MessageBox.Show(Control.ModifierKeys.ToString());

           // Control.ModifierKeys hansi teyin edici basilib shift or alt;
           // Key enum butun klaviaturada ki elementleri verir
           // e.KeyCode hansi simvol basilib

            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.A)
            {
                MessageBox.Show("You clikced "+Control.ModifierKeys.ToString()+" and "+e.KeyCode + " simvol");
            }else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.B)
            {
                UserForm userForm = new UserForm();
                userForm.Show();
            }else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.C)
            {
                Delete deleteForm = new Delete(_studentList, dataList);
                deleteForm.ShowDialog();
            }
        }

        private void Dashboard_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
