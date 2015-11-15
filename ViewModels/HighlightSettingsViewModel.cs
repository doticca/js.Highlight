using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace js.Highlight.ViewModels
{
    public class HighlightSettingsViewModel
    {
        public string Style { get; set; }
        public bool AutoEnable { get; set; }
        public bool AutoEnableAdmin { get; set; }
        public bool FullBundle { get; set; }
    }
}