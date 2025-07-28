using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record_Management
{
    internal class StudentBST
    {
        // Root node of the BST
        private TreeNode root;

        // Method to insert a student into the BST
        public void Insert(Student student)
        {
            root = InsertRec(root, student); // Start the recursive insert
        }

        // Recursive method for inserting a new node in correct position
        private TreeNode InsertRec(TreeNode node, Student student)
        {
            if (node == null)
                return new TreeNode(student);

            // Navigate left or right depending on the student ID
            if (student.ID < node.Data.ID)
                node.Left = InsertRec(node.Left, student); // Go left
            else if (student.ID > node.Data.ID)
                node.Right = InsertRec(node.Right, student); // Go right
            // Duplicate IDs are ignored

            return node; // Return the updated tree
        }

        // Search for a student by ID
        public Student Search(int id)
        {
            return SearchRec(root, id); // Start search from root
        }

        // Recursive search helper
        private Student SearchRec(TreeNode node, int id)
        {
            if (node == null)
                return null; // Reached bottom, not found
            if (id == node.Data.ID)
                return node.Data; // Found the student
            else if (id < node.Data.ID)
                return SearchRec(node.Left, id); // Go left
            else
                return SearchRec(node.Right, id); // Go right
        }

        // Returns a sorted list of all students using in-order traversal
        public List<Student> InOrderTraversal()
        {
            List<Student> result = new List<Student>(); // Empty list
            InOrderRec(root, result); // Fill it
            return result;
        }
        
         // Recursive in-order traversal
         private void InOrderRec(TreeNode node, List<Student> list)
         {
            if (node != null)
            {
                InOrderRec(node.Left, list);        // Visit left
                list.Add(node.Data);               // Visit current node
                InOrderRec(node.Right, list);       // Visit right
            }
         }
    }
}
