using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Medic : Template
    {
        public static readonly Guid ID = Guid.Parse("c8e31095-76ef-4af5-bf5c-866a6847cd2f");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Medic",
                DedicationFeatId = Feats.Instances.MedicDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2656608f-ea5f-4105-8be2-9c206cf30a3e"), Type = TextBlockType.Text, Text = "You�ve studied countless techniques for providing medical aid, making you a peerless doctor and healer." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c75df79-07d2-4c51-a2d7-a76ef99cafc7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 184
            };
        }
    }
}
