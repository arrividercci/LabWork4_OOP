using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace LabWork4.Classes
{
    internal class Helper
    {
        private Stopwatch stopwatch;

        public Helper()
        {
            stopwatch = new Stopwatch();
        }

        public void StartStopwatch()
        {
            stopwatch.Start();
        }
        public string GetStopWatchTime()
        {
            if (stopwatch.IsRunning)
            {
                var seconds = (int)stopwatch.Elapsed.TotalSeconds;
                return string.Format("{0:00.##}", seconds / 60) + " : " + string.Format("{0:00.##}", seconds % 60);
            }
            else
            {
                return "not working";
            }
        }

        public BindingList<Scientist> FindScientistsByFaculty(string criterion, BindingList<Scientist> scientists)
        {
            var result = scientists.Where(scientist => scientist.Faculty.ToUpper().Equals(criterion.ToUpper())).ToList();
            return new BindingList<Scientist>(result);
        }

        public Scientist FindLongestSurname(BindingList<Scientist> scientists)
        {
            var result = scientists.OrderBy(scientist => scientist.Surname.Length)
                .Last();
            return result;
        }

        public BindingList<Scientist> SortDescending(BindingList<Scientist> scientists)
        {
            return new BindingList<Scientist>(scientists.OrderByDescending(scientist => scientist.Surname)
                .ThenBy(scientist => scientist.Name)
                .ThenBy(scientist => scientist.Patronimyc)
                .ThenBy(scientist => scientist.Faculty)
                .ThenBy(scientist => scientist.Departament)
                .ThenBy(scientist => scientist.Degree)
                .ThenBy(scientist => scientist.AcademicRank)
                .ToList());
        }
    }
}
