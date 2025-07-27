using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record_Management
{
    internal class TreeNode
    {
        // Each node holds one student record
        public Student Data { get; set; }

        // Pointers to left and right child nodes
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        // Constructor that assigns the student data
        public TreeNode(Student student)
        {
            Data = student;
            Left = null;
            Right = null;
        }
    }
}
