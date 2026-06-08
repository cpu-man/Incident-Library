using System;
using System.Collections.Generic;
using System.Text;

namespace Incident_Library.MODELS__Data_
{
    class Label
    {
        
            private int _labelId;
            private string _name;

            public Label(int labelId, string name)
            {
                _labelId = labelId;
                _name = name;
            }

            public int GetLabelId() => _labelId;
            public string GetName() => _name;
            public void SetName(string name) { _name = name; }
        

    }
}
