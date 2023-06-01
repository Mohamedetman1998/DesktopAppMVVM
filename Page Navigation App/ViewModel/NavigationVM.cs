using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Page_Navigation_App.Utilities;
using System.Windows.Input;
using Page_Navigation_App.View;
using Page_Navigation_App.Commands;

namespace Page_Navigation_App.ViewModel
{
    class NavigationVM : ViewModelBase
    {

        #region Proprties

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        public MvCommands HomeCommand { get; set; }
        public MvCommands TeachersCommand { get; set; }
        public MvCommands SubjectCommand { get; set; }
        public MvCommands GameCommand { get; set; }
        #endregion

        #region Methods
        private void Home(object obj) => CurrentView = new HomeVM();
        private void Teacher(object obj) => CurrentView = new TeachersVM();
        private void Subject(object obj) => CurrentView = new SubjectVM();

        private void Game(object obj)  => CurrentView = new Game();

        #endregion

        #region Ctor
        public NavigationVM()
        {
            HomeCommand = new MvCommands(Home);
            TeachersCommand = new MvCommands(Teacher);
            SubjectCommand = new MvCommands(Subject);
            GameCommand = new MvCommands(Game);



            // Startup Page

            CurrentView = new HomeVM();
        }

        #endregion



    }
}
