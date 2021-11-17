using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Gladiator : Template
    {
        public static readonly Guid ID = Guid.Parse("29dfa66f-9de8-46d7-bf0d-30803ec23106");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Gladiator",
                DedicationFeatId = Feats.Instances.GladiatorDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f58aab82-e7db-41f2-9be7-0ecf85ad7a61"), Type = TextBlockType.Text, Text = "The roar of the crowd and thrill of competitive combat drive you to become the best�and the fame isn�t bad either." };
            yield return new TextBlock { Id = Guid.Parse("b2cabba8-c633-4ffc-b285-9c13cfe29cfa"), Type = TextBlockType.Text, Text = "If there are sapient creatures observing a combat encounter, and these onlookers are neither engaged in the combat themselves nor allied or affiliated with either side, the combatants have spectators. The GM is the final arbiter." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5399eae4-87ce-463b-88ec-f22cdd005d36"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 175
            };
        }
    }
}
