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
        public TreeNode Left { get; set; } // Left child (smaller ID)
        public TreeNode Right { get; set; } // Right child (larger ID)

        // Constructor that assigns the student data
        public TreeNode(Student student)
        {
            Data = student;  // Store the student in this node
            Left = null; // No left child yet
            Right = null; // No right child yet
        }
    }
}
