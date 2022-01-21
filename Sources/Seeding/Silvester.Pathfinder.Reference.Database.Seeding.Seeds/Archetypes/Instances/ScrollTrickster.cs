using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class ScrollTrickster : Template
    {
        public static readonly Guid ID = Guid.Parse("1b577eb6-4815-4743-b12e-0456b49dbb3d");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Scroll Trickster",
                DedicationFeatId = Feats.Instances.ScrollTricksterDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6a6c80c5-e8e5-48de-800a-4aecdba4883d"), Type = TextBlockType.Text, Text = "Magic has long been written down, and in myriad forms. From the classic rolled parchment to strings tied with a hundred intricate knots, from baked clay tablets covered with incisions to bound collections of bamboo slips, magic is everywhere. You just need to know how to read it." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a3ac198-097b-4a50-8364-5e06cb2af16d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 189
            };
        }
    }
}
