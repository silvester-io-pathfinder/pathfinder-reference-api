using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class LanguageType : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Language> Languages { get; set; } = new List<Language>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
