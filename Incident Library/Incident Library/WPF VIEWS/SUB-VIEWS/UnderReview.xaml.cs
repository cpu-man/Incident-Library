using Incident_Library.MODELS__Data_;
using Incident_Library.VIEWMODELS_LOGIC_;
using System.Windows.Controls;

namespace Incident_Library.WPF_VIEWS.SUB_VIEWS
{
    public partial class UnderReview : Page
    {
        public UnderReview()
        {
            InitializeComponent();
            LoadIncidents();
            // TODO: DataContext = new IncidentExplorerViewModel();
            // await ViewModel.LoadIncidentsByStatusAsync(2); // 2 = Under Review     
        }

       private void LoadIncidents()
        {
            var viewModel = new IncidentViewModel();
            var incidents = viewModel.GetByStatus(2);

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