using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Page_Navigation_App.Model;

namespace Page_Navigation_App.ViewModel
{
    public class SubjectDetailsWindowVM
    {
        #region Properties

        private ObservableCollection<Students> students;

        public TeacherClass Teacher { get; set; }
        public List<Students> Students { get; set; }
        #endregion
        #region Ctor
        public SubjectDetailsWindowVM(TeacherClass teacher, List<Students> students)
        {
            Teacher = teacher;
            Students = students;
        }

        public SubjectDetailsWindowVM(TeacherClass teacher, ObservableCollection<Students> students)
        {
            Teacher = teacher;
            this.students = students;
        }

        #endregion
    }
}
