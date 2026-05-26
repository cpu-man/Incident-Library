using System.Windows.Controls;

namespace Incident_Library.WPF_VIEWS.SUB_VIEWS
{
    public partial class UnderReview : Page
    {
        public UnderReview()
        {
            InitializeComponent();
            // TODO: DataContext = new IncidentExplorerViewModel();
            // await ViewModel.LoadIncidentsByStatusAsync(2); // 2 = Under Review
        }
    }
}