using Incident_Library.VIEWMODELS_LOGIC_;
using System.Windows.Controls;

namespace Incident_Library.WPF_VIEWS.SUB_VIEWS
{
    public partial class Archived : Page
    {
        public Archived()
        {
            InitializeComponent();
            LoadIncidents();
            // TODO: DataContext = new IncidentExplorerViewModel();
            // await ViewModel.LoadIncidentsByStatusAsync(3); // 3 = Archived
        }

        private void LoadIncidents()
        {
            var viewModel = new IncidentViewModel();
            var incidents = viewModel.GetByStatus(3);

            if (incidents.Count == 0)
            {
                txtEmpty.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                IncidentList.ItemsSource = incidents;
            }
        }
    }
}