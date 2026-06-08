using System;
using System.Collections.Generic;
using System.Text;
using Incident_Library.MODELS__Data_;
using Incident_Library.Repository;

namespace Incident_Library.VIEWMODELS_LOGIC_
{
    public class EditIncidentViewModel
    {
        private readonly IncidentRepository _repo = new IncidentRepository();

        public IncidentReport Incident { get; set; }

        public EditIncidentViewModel(IncidentReport i)
        {
            Incident = i;
        }

        public async Task SaveAsync()
        {
            await _repo.UpdateAsync(Incident);
        }

        public async Task DeleteAsync()
        {
            await _repo.DeleteAsync(Incident);
        }
    }
}
