using System;
using System.Collections.Generic;
using System.Text;

namespace Incident_Library.MODELS__Data_
{
    class User
    {
        private int _userId;
        private string _username;
        private string _password;
        private int _roleId;

        public User (int userId, string username, string password, int roleId)
        {
            _userId = userId;
            _username = username;
            _password = password;
            _roleId = roleId;
        }

        // ── WPF-bindbare properties ──────────────────────────────────────
        // Bruges af AdminView XAML til {Binding UserId}, {Binding Username} osv.
        public int UserId => _userId;
        public string UserName => _username;
        public string Password => _password;
        public int RoleId => _roleId;

        // ── Getters (bruges i C#-kode) ───────────────────────────────────
        public int GetUserId() => _userId;
        public string GetUserName() => _username;
        public string GetPassword() => _password;
        public int GetRoleId() => _roleId;

        // Setter — kun password må ændres
        public void SetPassword(string password) { _password = password; }

        // Hjælpemetode til at tjekke om brugeren er admin (RoleId 2 = Admin)

        public bool IsAdmin() => _roleId == 2;
    }
}
