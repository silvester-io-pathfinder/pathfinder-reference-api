using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SpellTypes.Instances
{
    public class Focus : Template
    {
        public static readonly Guid ID = Guid.Parse("5d666234-7158-4fc5-934d-8d0f4b2ef786");

        public override SpellType GetSpellType()
        {
           return new SpellType 
           { 
               Id = ID, 
               Name = "Focus", 
               Description = "Some classes gain special spells that they cast using Focus Points instead of spell slots. These focus spells are listed below, organized by class. The full rules for casting focus spells appear on page 300 of the Core Rulebook."
           };
        }
    }
}
