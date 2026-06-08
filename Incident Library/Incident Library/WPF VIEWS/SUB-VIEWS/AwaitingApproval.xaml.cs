using System.Windows;
using System.Windows.Controls;

namespace Incident_Library.WPF_VIEWS.SUB_VIEWS
{
    public partial class AwaitingApproval : Page
    {
        public AwaitingApproval()
        {
            InitializeComponent();
            // TODO: DataContext = new IncidentExplorerViewModel();
            // await ViewModel.LoadIncidentsByStatusAsync(4); // 4 = Awaiting Approval
        }

        private void BtnApprove_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag is int id)
            {
                // TODO: await ViewModel.ApproveIncidentAsync(id);
                // Moves incident to Archived status
            }
        }

        private void BtnReject_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Tag is int id)
            {
                // TODO: await ViewModel.RejectIncidentAsync(id);
                // Moves incident back to Work In Progress
            }
        }
    }
}