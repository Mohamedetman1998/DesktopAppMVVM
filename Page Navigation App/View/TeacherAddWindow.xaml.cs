using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Page_Navigation_App.View
{
    /// <summary>
    /// Interaction logic for TeacherAddWindow.xaml
    /// </summary>
    public partial class TeacherAddWindow : MahApps.Metro.Controls.MetroWindow
    {
        //public int TeacherId { get; set; }
        //public string Name { get; set; }
        //public string Rate { get; set; }

        public TeacherAddWindow()
        {
            InitializeComponent();
        }

        //private void Add_Click(object sender, RoutedEventArgs e)
        //{
        //    // Retrieve the teacher details from the text boxes
        //    TeacherId = int.Parse(txtTeacherId.Text);
        //    Name = txtName.Text;
        //    Rate = txtRate.Text;

        //    // Set the DialogResult property to indicate the teacher addition confirmation
        //    DialogResult = true;
        //}

        //private void Cancel_Click(object sender, RoutedEventArgs e)
        //{
        //    // Close the window without performing any action
        //    DialogResult = false;
        //}
    }
}