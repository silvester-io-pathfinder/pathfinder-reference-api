using Silvester.Pathfinder.Official.Database;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class LanguageType : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Language> Languages { get; set; } = new List<Language>();
    }
}
