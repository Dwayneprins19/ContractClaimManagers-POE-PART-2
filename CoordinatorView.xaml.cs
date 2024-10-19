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

namespace ContractClaimManagers
{
    /// <summary>
    /// Interaction logic for CoordinatorView.xaml
    /// </summary>
    public partial class CoordinatorView : Window
    {
        public CoordinatorView()
        {
            InitializeComponent();
            LoadClaims();
        }

        private void LoadClaims()
        {
            // Load claims data - this should come from your data source
            var claims = new List<ClaimModel>
            {
                new ClaimModel { ClaimID = 1, LecturerName = "Isagi Yoichi", HoursWorked = 10, HourlyRate = 50, TotalAmount = 500 },
                new ClaimModel { ClaimID = 2, LecturerName = "Max Aarons", HoursWorked = 20, HourlyRate = 60, TotalAmount = 1200 },
                // Add more claims here
            };

            ClaimsListView.ItemsSource = claims; //Why is ClaimsListView and error
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            // Logic to approve claim
        }

        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            // Logic to reject claim

        }

        public class ClaimModel
        {
            public int ClaimID { get; set; }
            public string LecturerName { get; set; }
            public int HoursWorked { get; set; }
            public decimal HourlyRate { get; set; }
            public decimal TotalAmount { get; set; }
        }
    }
}