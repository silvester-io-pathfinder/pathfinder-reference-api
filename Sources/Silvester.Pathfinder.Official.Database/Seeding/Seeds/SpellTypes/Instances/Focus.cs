using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.SpellTypes.Instances
{
    public class Focus : Template
    {
        public static readonly Guid ID = Guid.Parse("c81b4b1a-e500-48b7-a37f-c686defe4d15");

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
