using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Trait : BaseEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();

        public ICollection<Feat> Feats { get; set; } = new List<Feat>();

        public ICollection<Curse> Curses { get; set; } = new List<Curse>();

        public ICollection<ItemCurse> ItemCurses { get; set; } = new List<ItemCurse>();

        public ICollection<Disease> Diseases { get; set; } = new List<Disease>();

        public ICollection<Action> Actions { get; set; } = new List<Action>();
        
        public ICollection<Race> Races { get; set; } = new List<Race>();

        public ICollection<Hazard> Hazards { get; set; } = new List<Hazard>();

        public ICollection<HazardAction> HazardActions { get; set; } = new List<HazardAction>();

        public ICollection<HazardActionEffect> HazardActionEffects { get; set; } = new List<HazardActionEffect>();

        public ICollection<AlchemicalBomb> AlchemicalBombs { get; set; } = new List<AlchemicalBomb>();
     
        public ICollection<AlchemicalElixir> AlchemicalElixirs{ get; set; } = new List<AlchemicalElixir>();

        public ICollection<AlchemicalTool> AlchemicalTools { get; set; } = new List<AlchemicalTool>();

        public ICollection<AlchemicalPoison> AlchemicalPoisons { get; set; } = new List<AlchemicalPoison>();

        public ICollection<Plane> Planes { get; set; } = new List<Plane>();
    
        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();
    }
}
