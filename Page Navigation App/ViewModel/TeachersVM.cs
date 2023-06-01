using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Page_Navigation_App.Commands;
using Page_Navigation_App.Model;
using Page_Navigation_App.View;

namespace Page_Navigation_App.ViewModel
{
    class TeachersVM : Utilities.ViewModelBase
    {

        #region Fields

        private int teacherId;
        private string name;
        private string rate;
        private int age;
        private int mobile;
        private TeacherClass selectedTeacher;
        private string _img;
        public ObservableCollection<TeacherClass> Teachers { get; set; } = new ObservableCollection<TeacherClass>();

        #endregion
        #region Properties

        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        public int TeacherId
        {
            get { return teacherId; }
            set
            {
                if (teacherId != value)
                {
                    teacherId = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Rate
        {
            get { return rate; }
            set
            {
                if (rate != value)
                {
                    rate = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (age != value)
                {
                    age = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Mobile
        {
            get { return mobile; }
            set
            {
                if (mobile != value)
                {
                    mobile = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Img
        {
            get { return _img; }
            set
            {
                if (_img != value)
                {
                    _img = value;
                    OnPropertyChanged();
                }
            }
        }
        public TeacherClass SelectedTeacher
        {
            get { return selectedTeacher; }
            set
            {
                if (selectedTeacher != value)
                {
                    selectedTeacher = value;
                    OnPropertyChanged();
                }
            }
        }
        public MvCommands AddTeacherCommand { get; }
        public MvCommands DeleteTeacherCommand { get; }

        #endregion
        #region Constructor

        public TeachersVM()
        {
            AddTeacherCommand = new MvCommands(AddTeacher);
            DeleteTeacherCommand = new MvCommands(DeleteTeacher);
        }
        #endregion
        #region Methods
        private void DeleteTeacher(object parameter)
        {
            if (SelectedTeacher != null)
            {
                Teachers.Remove(SelectedTeacher);
            }
        }

        private void AddTeacher(object parameter)
        {
            TeacherAddWindow teacherAddingWindow = new TeacherAddWindow();
            var teacherAddingViewModel = new TeacherAddWindowVM(Teachers); // Pass the Teachers collection
            teacherAddingWindow.DataContext = teacherAddingViewModel; // Set the view model as the DataContext of the window
            teacherAddingWindow.ShowDialog();

            if (teacherAddingWindow.DialogResult.HasValue && teacherAddingWindow.DialogResult.Value)
            {
                TeacherClass teacher = new TeacherClass
                {
                    Id = teacherAddingViewModel.TeacherId, // Access the properties from the view model
                    Name = teacherAddingViewModel.Name,
                    Rate = teacherAddingViewModel.Rate,
                    Age = teacherAddingViewModel.Age,
                    Mobile = teacherAddingViewModel.Mobile,
                    Img = teacherAddingViewModel.Img

                };

                Teachers.Add(teacher);
            }
        }

     

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
