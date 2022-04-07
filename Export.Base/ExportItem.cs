using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Export.Base
{
    public class ExportItem
    {
        public string? Name { get; set; }
        public string? ShortText { get; set; }
        public string? TextContent { get; set; }
        public Uri[]? VideoUri { get; set; }
        public string[]? Images { get; set; }
        public Uri[]? AudioUri {get; set; }
    }
}
