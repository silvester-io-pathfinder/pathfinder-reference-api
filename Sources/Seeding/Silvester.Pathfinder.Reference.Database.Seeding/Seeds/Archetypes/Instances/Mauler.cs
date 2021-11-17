using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Mauler : Template
    {
        public static readonly Guid ID = Guid.Parse("1c8c982f-a722-44c1-8f4c-99ed2dd39e7a");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Mauler",
                DedicationFeatId = Feats.Instances.MaulerDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2c663d65-ea59-4252-82e2-04ef22f2382a"), Type = TextBlockType.Text, Text = "You shove your way through legions of foes, knock enemies on all sides to the ground, and deal massive blows to anyone or anything that comes near." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d26692a-1918-4a5c-a4ba-65088ac46428"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 183
            };
        }
    }
}
