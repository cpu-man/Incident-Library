using System.Windows;
using System.Windows.Controls;

namespace Incident_Library.WPF_VIEWS.SUB_VIEWS
{
    public partial class AdminView : Page
    {
        public AdminView()
        {
            InitializeComponent();
            // TODO: DataContext = new AdminViewModel();
            // await ViewModel.LoadUsersAsync();
        }

        private void UserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            bool hasSelection = UserList.SelectedItem != null;
            btnRemoveUser.IsEnabled = hasSelection;
            btnChangeRole.IsEnabled = hasSelection;
        }

        private void BtnAddUser_Click(object sender, RoutedEventArgs e)
        {
            // TODO: open add user dialog
        }

        private void BtnRemoveUser_Click(object sender, RoutedEventArgs e)
        {
            if (UserList.SelectedItem == null) return;

            var result = MessageBox.Show(
                "Are you sure you want to remove this user?",
                "Confirm Remove",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                // TODO: await ViewModel.RemoveUserAsync(selectedUserId);
            }
        }

        private void BtnChangeRole_Click(object sender, RoutedEventArgs e)
        {
            // TODO: open role picker dialog
        }
    }
}