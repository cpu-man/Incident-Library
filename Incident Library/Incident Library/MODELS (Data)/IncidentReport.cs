using System;
using System.Collections.Generic;
using System.Text;

namespace Incident_Library.MODELS__Data_
{
    class IncidentReport
    {
        private int _incidentId;
        private string _title;
        private string _description;
        private string _priority;
        private string _status;
        private DateTime _createdAt;
        private DateTime? _resolvedAt;
        private int _createdById;

        private List<User> _assignedUsers;
        private List<Label> _labels;

        public IncidentReport(int incidentId, string title, string description,
                              string priority, string status, DateTime createdAt,
                              int createdById)
        {
            _incidentId = incidentId;
            _title = title;
            _description = description;
            _priority = priority;
            _status = status;
            _createdAt = createdAt;
            _resolvedAt = null;
            _createdById = createdById;
            _assignedUsers = new List<User>();
            _labels = new List<Label>();
        }

        // ── WPF-bindbare properties ──────────────────────────────────────
        // WPF's {Binding ...} kræver properties — ikke metoder
        public int IncidentId => _incidentId;
        public string Title => _title;
        public string Description => _description;
        public string Priority => _priority;
        public string Status => _status;
        public DateTime CreatedAt => _createdAt;
        public DateTime? ResolvedAt => _resolvedAt;
        public int CreatedById => _createdById;
        public List<Label> Labels => _labels;
        public List<User> AssignedUsers => _assignedUsers;

        // ── Getters (bruges stadig i C#-kode) ───────────────────────────
        public int GetIncidentId() => _incidentId;
        public string GetTitle() => _title;
        public string GetDescription() => _description;
        public string GetPriority() => _priority;
        public string GetStatus() => _status;
        public DateTime GetCreatedAt() => _createdAt;
        public DateTime? GetResolvedAt() => _resolvedAt;
        public int GetCreatedById() => _createdById;
        public List<User> GetAssignedUsers() => _assignedUsers;
        public List<Label> GetLabels() => _labels;

        // ── Setters ──────────────────────────────────────────────────────
        public void SetTitle(string title) { _title = title; }
        public void SetDescription(string description) { _description = description; }
        public void SetPriority(string priority) { _priority = priority; }

        public void SetStatus(string status)
        {
            _status = status;
            if (status == "Archived")
                _resolvedAt = DateTime.Now;
        }

        public void AddLabel(Label label)
        {
            if (!_labels.Contains(label)) _labels.Add(label);
        }
        public void RemoveLabel(Label label) { _labels.Remove(label); }

        public void AddUser(User user)
        {
            if (!_assignedUsers.Contains(user)) _assignedUsers.Add(user);
        }
        public void RemoveUser(User user) { _assignedUsers.Remove(user); }
    }
}
