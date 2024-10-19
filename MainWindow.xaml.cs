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

namespace ContractClaimManagers
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

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Your logic to submit claim
                MessageBox.Show("Claim submitted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");

            }
        }

        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Document files (*.pdf;*.docx;*.xlsx)|*.pdf;*.docx;*.xlsx";
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                // Logic for saving the file path.
            }
        }

        private void RemoveText(object sender, RoutedEventArgs e)
        {
            if ((sender as TextBox).Text == "Hours Worked" || (sender as TextBox).Text == "Hourly Rate")
            {
                (sender as TextBox).Text = "";
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace((sender as TextBox).Text))
            {
                if ((sender as TextBox) == HoursWorked)
                {
                    (sender as TextBox).Text = "Hours Worked";
                }
                else if ((sender as TextBox) == HourlyRate)
                {
                    (sender as TextBox).Text = "Hourly Rate";
                }
            }
        }
    }
}
