using System.Windows.Controls;

namespace Incident_Library.WPF_VIEWS.SUB_VIEWS
{
    public partial class Archived : Page
    {
        public Archived()
        {
            InitializeComponent();
            // TODO: DataContext = new IncidentExplorerViewModel();
            // await ViewModel.LoadIncidentsByStatusAsync(3); // 3 = Archived
        }
    }
}