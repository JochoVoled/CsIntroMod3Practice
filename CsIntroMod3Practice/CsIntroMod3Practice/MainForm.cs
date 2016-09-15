using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsIntroMod3Practice.Classes;

namespace CsIntroMod3Practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
          var name = txtName.Text;
            var points = numPoints.Value.ToString();
            int i = int.Parse(points);
            var sd = dateStart.Value;
            var ed = dateEnd.Value;
            Course c = new Course(name, i, sd, ed);
            MessageBox.Show("\nName on  course: " + name + "\nPoints of course: " + points + "\nCourse starts: " + sd + "\nCourse ends: " + ed);
        }

        private void cmdCalc_Click(object sender, EventArgs e)
        {
            var nr = numPoints.Value.ToString();
            int p = int.Parse(nr);
         
            Course c = new Course(txtName.Text, p, dateStart.Value, dateEnd.Value);
            var i = c.CalculateCourseDays();
            MessageBox.Show("The course is: " + i + " days.");
        }

        private void cmdCalcPoint_Click(object sender, EventArgs e)
        {

        }
    }
}
