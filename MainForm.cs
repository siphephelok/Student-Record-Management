using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record_Management
{
    public partial class MainForm : Form
    {
        // Create instance of our BST
        private StudentBST bst = new StudentBST();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // Add student when "Add" button is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse input fields
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                double mark = double.Parse(txtMark.Text);

                // Create a new student object
                Student student = new Student(id, name, mark);

                // Insert student into BST
                bst.Insert(student);

                MessageBox.Show("Student added successfully.");
                ClearFields();
            }
            catch
            {
                MessageBox.Show("Invalid input. Please check your entries.");
            }
        }
        // Search student by ID when "Search" button is clicked
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchID.Text, out int id))
            {
                Student found = bst.Search(id);
                if (found != null)
                    MessageBox.Show("Found: " + found.ToString());
                else
                    MessageBox.Show("Student not found.");
            }
            else
            {
                MessageBox.Show("Enter a valid numeric ID.");
            }
            txtSearchID.Clear();
        }
        // Display all students in sorted order when "Display All" is clicked
        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            listBoxStudents.Items.Clear(); // Clear previous items

            var allStudents = bst.InOrderTraversal(); // Get sorted list of students

            // Check if there are no students in the list
            if (allStudents == null || allStudents.Count == 0)
            {
                MessageBox.Show("There are currently no students to display.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Add each student to the ListBox
            foreach (var student in allStudents)
            {
                listBoxStudents.Items.Add(student.ToString());
            }
        }
        // Clears input fields after adding a student
        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtMark.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

