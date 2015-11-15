using Orchard.Data.Migration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace js.Highlight
{
    public class HighlightMigrations : DataMigrationImpl {    
        public int Create()
        {
            SchemaBuilder.CreateTable(
                "HighlightSettingsPartRecord",
                table => table
                             .ContentPartRecord()
                             .Column<bool>("AutoEnable", c => c.WithDefault(true))
                             .Column<bool>("AutoEnableAdmin", c => c.WithDefault(false))
                             .Column<bool>("FullBundle", c => c.WithDefault(false))
                             .Column<string>("Style", c => c.WithDefault("default"))
                );
            return 1;
        }

    }
}