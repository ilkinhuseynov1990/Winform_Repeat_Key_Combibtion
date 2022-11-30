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
    public partial class Delete : Form
    {
        private List<Student> _studentList;
        private Student student;
        private DataGridView _gridView;
        public Delete(List<Student> stuList, DataGridView gridView)
        {
            InitializeComponent();
            _studentList = stuList;
            comboBox1.DataSource = _studentList;
            _gridView = gridView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _studentList.Remove(student);
            refreshCombo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            student = comboBox1.SelectedItem as Student;
        }

        public void refreshCombo()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = _studentList;
            _gridView.DataSource = "";
            _gridView.DataSource = _studentList;
        }
    }
}
