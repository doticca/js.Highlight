using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace js.Highlight.Models
{
    public class HighlightSettingsPartRecord: ContentPartRecord
    {
        public virtual string Style { get; set; }
        public virtual bool AutoEnable { get; set; }
        public virtual bool AutoEnableAdmin { get; set; }
        public virtual bool FullBundle { get; set; }

        public HighlightSettingsPartRecord()
        {
            Style = "default";
            AutoEnable = true;
            AutoEnableAdmin = false;
            FullBundle = false;
        }
    }
}