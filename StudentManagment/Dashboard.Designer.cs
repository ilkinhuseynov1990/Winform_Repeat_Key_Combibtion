
namespace StudentManagment
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stuNametxt = new System.Windows.Forms.TextBox();
            this.studentSurnametxt = new System.Windows.Forms.TextBox();
            this.studentAge = new System.Windows.Forms.TextBox();
            this.addStudent = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User dashboard";
            // 
            // dataList
            // 
            this.dataList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataList.Location = new System.Drawing.Point(0, 227);
            this.dataList.Name = "dataList";
            this.dataList.ReadOnly = true;
            this.dataList.Size = new System.Drawing.Size(749, 156);
            this.dataList.TabIndex = 1;
            this.dataList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataList_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student Age";
            // 
            // stuNametxt
            // 
            this.stuNametxt.Location = new System.Drawing.Point(12, 72);
            this.stuNametxt.Name = "stuNametxt";
            this.stuNametxt.Size = new System.Drawing.Size(151, 20);
            this.stuNametxt.TabIndex = 5;
            // 
            // studentSurnametxt
            // 
            this.studentSurnametxt.Location = new System.Drawing.Point(12, 124);
            this.studentSurnametxt.Name = "studentSurnametxt";
            this.studentSurnametxt.Size = new System.Drawing.Size(151, 20);
            this.studentSurnametxt.TabIndex = 6;
            // 
            // studentAge
            // 
            this.studentAge.Location = new System.Drawing.Point(12, 181);
            this.studentAge.Name = "studentAge";
            this.studentAge.Size = new System.Drawing.Size(151, 20);
            this.studentAge.TabIndex = 7;
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(192, 69);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(107, 23);
            this.addStudent.TabIndex = 8;
            this.addStudent.Text = "Add";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(192, 124);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(107, 23);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteStudentToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student | Alt+ C";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 383);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.studentAge);
            this.Controls.Add(this.studentSurnametxt);
            this.Controls.Add(this.stuNametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dashboard_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dashboard_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stuNametxt;
        private System.Windows.Forms.TextBox studentSurnametxt;
        private System.Windows.Forms.TextBox studentAge;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
    }
}