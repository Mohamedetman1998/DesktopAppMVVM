using Page_Navigation_App.Commands;
using Page_Navigation_App.Model;
using Page_Navigation_App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Page_Navigation_App.ViewModel
{
    public class SubjectVM
    {
        #region Properties
        public ICommand Command1 { get; }
        public ICommand Command2 { get; }
        public ICommand Command3 { get; }
        public ICommand Command4 { get; }
        public ICommand Command5 { get; }
        public ICommand Command6 { get; }

        #endregion
        #region Ctor
        public SubjectVM()
        {
            Command1 = new MvCommands(OpenSubject1);
            Command2 = new MvCommands(OpenSubject2);
            Command3 = new MvCommands(OpenSubject3);
            Command4 = new MvCommands(OpenSubject4);
            Command5 = new MvCommands(OpenSubject5);
            Command6 = new MvCommands(OpenSubject6);
        }

        #endregion
        #region Methods

        private void OpenSubject1(object parameter)
        {
            OpenSubject(1);
        }

        private void OpenSubject2(object parameter)
        {
            OpenSubject(2);
        }

        private void OpenSubject3(object parameter)
        {
            OpenSubject(3);
        }

        private void OpenSubject4(object parameter)
        {
            OpenSubject(4);
        }

        private void OpenSubject5(object parameter)
        {
            OpenSubject(5);
        }

        private void OpenSubject6(object parameter)
        {
            OpenSubject(6);
        }

        private void OpenSubject(int subjectNumber)
        {
            // Create and show the SubjectDetailsWindow
            SubjectDetailsWindow subjectDetailsWindow = new SubjectDetailsWindow();

            // Generate random teacher and student information
            Random random = new Random();
            TeacherClass teacher = new TeacherClass { Name = "Ahmed Ahmed" }; 
            List<Students> students = new List<Students>
            {
                new Students { StudentId = 1, StudentName = "Mohamed", Grade = "A",},
                new Students { StudentId = 2, StudentName = "Ahmed", Grade = "B" },
                new Students { StudentId = 3, StudentName = "Aly", Grade = "C" }    
            }; 

            // Set the DataContext of the SubjectDetailsWindow to the generated data
            subjectDetailsWindow.DataContext = new SubjectDetailsWindowVM(teacher, students);

            // Show the SubjectDetailsWindow
            subjectDetailsWindow.ShowDialog();
        }
        #endregion
    }
}
