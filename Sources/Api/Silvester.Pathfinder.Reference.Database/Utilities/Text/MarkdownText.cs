using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Utilities.Text
{
    public class MarkdownText : BaseEntity
    {
        public string Plain { get; set; } = default!;

        public string Markdown  { get; set; } = default!;
    }
}
