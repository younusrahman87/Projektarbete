using Logic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI.Pages
{
    /// <summary>
    /// Interaction logic for Alla_Mekaniker.xaml
    /// </summary>
    public partial class Alla_Mekaniker : Page
    {
        public Alla_Mekaniker()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Search_Mechanic.Visibility = Visibility.Visible;
            // tb_SC_mechanic_id.Text = IUserDataAccess.Read()
            // tb_SC_mechanic_name = IUserDataAccess.Read()
            // tb_SC_mechanic_birthday = IUserDataAccess.Read()
            // tb_SC_mechanic_skills = IUserDataAccess.Read()
            // tb_SC_mechanic_job1
            // tb_SC_mechanic_job2
        }
    }
}
