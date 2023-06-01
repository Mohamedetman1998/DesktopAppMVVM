using Microsoft.Win32;
using Page_Navigation_App.Commands;
using Page_Navigation_App.Model;
using Page_Navigation_App.View;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Page_Navigation_App.ViewModel
{
    public class TeacherAddWindowVM
    {
        #region Proprties

        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Rate { get; set; }
        public string Img { get; set; }
        public int Age { get; set; }
        public int Mobile { get; set; }

        private TeacherClass newTeacher;

        public MvCommands AddCommand { get; }
        public MvCommands CancelCommand { get; }
        public MvCommands LoadImageCommand { get; }   

        private ObservableCollection<TeacherClass> Teachers;
        #endregion

        #region Methods
        private void LoadImage(object parameter)
        {
            // Open a file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";

            if (openFileDialog.ShowDialog() == true)
            {
                // Get the selected file path and assign it to the Img property
                Img = openFileDialog.FileName;
            }
        }
        private void AddTeacher(object parameter)
        {
            // Verify that the required fields are filled
            if (TeacherId == 0 || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Rate) || string.IsNullOrEmpty(Img))
            {
                MessageBox.Show("Please fill in all the required fields and load an image.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Create a new TeacherClass object with the filled data
            newTeacher = new TeacherClass
            {
                Id = TeacherId,
                Name = Name,
                Rate = Rate,
                Age = Age,
                Mobile = Mobile,
                Img = Img
            };

            // Add the teacher to the collection
            Teachers.Add(newTeacher);

            // Reset the form fields
            TeacherId = 0;
            Name = string.Empty;
            Rate = string.Empty;
            Age = 0;
            Mobile = 0;
            Img = string.Empty;

            var window = parameter as Window;
            window?.Close();
        }
        private void Cancel(object parameter)
        {
            var window = parameter as Window;
            if (window != null)
            {
                // Close the window without performing any action
                window.DialogResult = false;
                window.Close();
            }
        }
        #endregion

        #region Ctor
        public TeacherAddWindowVM(ObservableCollection<TeacherClass> teachers)
        {
            Teachers = teachers;
            AddCommand = new MvCommands(AddTeacher);
            CancelCommand = new MvCommands(Cancel);
            LoadImageCommand = new MvCommands(LoadImage);
        }

        #endregion



    }
}
