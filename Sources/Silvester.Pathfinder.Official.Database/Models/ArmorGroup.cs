using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ArmorGroup : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string ArmorSpecializationEffect { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Armor> Armors { get; set; } = new List<Armor>();
    }
}
