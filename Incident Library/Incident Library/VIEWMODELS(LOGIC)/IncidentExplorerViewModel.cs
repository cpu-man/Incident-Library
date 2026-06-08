using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Incident_Library.Repository;
using Incident_Library.MODELS__Data_;

namespace Incident_Library.VIEWMODELS_LOGIC_
{
   class IncidentExplorerViewModel
    {
        private readonly IncidentRepository _repo = new IncidentRepository();

        public async Task<List<IncidentReport>> GetByStatusAsync(int statusId)
        {
            var all = await _repo.ReadAsync();
            return all.Where(i => i.Status == statusId).ToList();
        }
    }
}
