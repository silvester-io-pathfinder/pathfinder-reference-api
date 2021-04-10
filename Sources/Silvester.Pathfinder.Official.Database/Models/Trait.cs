using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Trait : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();

        public ICollection<Feat> Feats { get; set; } = new List<Feat>();

        public ICollection<Curse> Curses { get; set; } = new List<Curse>();

        public ICollection<Disease> Diseases { get; set; } = new List<Disease>();
        
        public ICollection<Models.Action> Actions { get; set; } = new List<Models.Action>();
    }
}
