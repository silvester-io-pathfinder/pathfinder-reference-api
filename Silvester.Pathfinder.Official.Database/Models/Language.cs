using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Language : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid TypeId { get; set; }

        public LanguageType Type { get; set; } = default!;

        public ICollection<Race> Races { get; set; } = new List<Race>();
    }
}
