using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsIntroMod3Practice.Classes
{
   public class Course
    {
        public string name { get; set; }
        public int points { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Course(string studentName, int coursePoints, DateTime start, DateTime end)
        {
            name = studentName;
            points = coursePoints;
            startDate = start;
            endDate = end;
        }

        public double CalculateCourseDays()
        {
            TimeSpan count = endDate - startDate;
            double diffrence = count.Days;
            diffrence++;

            return diffrence;
        }
        public float PointsPerCourseDay()
        {
            
            var i = CalculateCourseDays();
            var pointsDivider = points / i;
            float pointsPerDay = Convert.ToSingle(pointsDivider);

            return pointsPerDay;
        }
    }
}
