using Login.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form3 : Form
    {
        public Form3(List<Student> students)
        {
            InitializeComponent();
            
            foreach (var  student in students)
            {
                dataGridView1.Rows.Add(student.Name, student.Status, student.Date.ToShortDateString());
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
