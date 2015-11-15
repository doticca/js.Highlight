﻿using Orchard.ContentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace js.Highlight.Models
{
    public class HighlightSettingsPart : ContentPart<HighlightSettingsPartRecord> {    
        public string Style
        {
            get { return Record.Style; }
            set { Record.Style = value; }
        }
        public bool AutoEnable
        {
            get { return Record.AutoEnable; }
            set { Record.AutoEnable = value; }
        }
        public bool AutoEnableAdmin
        {
            get { return Record.AutoEnableAdmin; }
            set { Record.AutoEnableAdmin = value; }
        }
        public bool FullBundle
        {
            get { return Record.FullBundle; }
            set { Record.FullBundle = value; }
        }
    }
}