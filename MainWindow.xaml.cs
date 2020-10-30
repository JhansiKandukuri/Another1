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

namespace EF_CODEFIRST_WPF_DEMO
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

        private void BtnAddDonor_Click(object sender, RoutedEventArgs e)
        {
            //DonorContext dbCon = new DonorContext("server=.\\Sqlexpress;Integrated security=true;database=Student_details");
            //Donor dObj = new Donor();
            //dObj.DonorID = 101;
            //dObj.Name = "Raman";
            //dObj.BloodGrp = "B+ve";
            //dObj.City = "Patna";

            ////Adding Data to Table

            //dbCon.Donors.Add(dObj);
            ////commit the changes

            //dbCon.SaveChanges();
            //System.Windows.Forms.MessageBox.Show("Donor table created");
            ////////////////////////////////////////////////////////////////////////
            PatientContext pCon = new PatientContext("server=.\\Sqlexpress;Integrated security=true;database=Student_details");
            Patient p = new Patient();
            p.PatientID = 1001;
            p.Name = "Vishu";
            p.City = "Vizag";

            pCon.Patients.Add(p);
            pCon.SaveChanges();
            System.Windows.Forms.MessageBox.Show("Patient table created");
        
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
