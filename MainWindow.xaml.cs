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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using Data_Storage_using_SQL_server.Helper_Code.Common;
using Data_Storage_using_SQL_server.Model.BusinessLogic.Helper_Code.Common;


namespace OJT_012022_Activity1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string FirstName = this.FirstName.Text;
            string MiddleName = this.MiddleName.Text;
            string LastName = this.LastName.Text;
            string PhoneNumber = this.PhoneNumber.Text;
            string GenderMale = this.GenderMale.GroupName;
            string GenderFemale = this.GenderFemale.GroupName;

            PhonebookLogic.SaveInfo(FirstName);
            PhonebookLogic.SaveInfo(MiddleName);
            PhonebookLogic.SaveInfo(LastName);
            PhonebookLogic.SaveInfo(PhoneNumber);
            PhonebookLogic.SaveInfo(GenderMale);
            PhonebookLogic.SaveInfo(GenderFemale);

        }

        private void BtnView_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Phonebook_ViewRecords = new MainWindow();
            Phonebook_ViewRecords.Show();
        }
    }
}
