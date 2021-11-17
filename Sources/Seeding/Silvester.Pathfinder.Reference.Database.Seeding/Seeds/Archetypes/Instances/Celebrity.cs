using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Celebrity : Template
    {
        public static readonly Guid ID = Guid.Parse("c936aa9d-a221-4781-9b58-7e51df77eb92");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Celebrity",
                DedicationFeatId = Feats.Instances.CelebrityDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bcb24d09-df02-4006-8a5b-ccc7e672b917"), Type = TextBlockType.Text, Text = "You�re a special personality... and you know it. You�re not merely comfortable in the spotlight, you crave it. While the traditional celebrity is a musician or another type of performer, you could be known for any occupation." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6c858bd-3098-4cfd-bb39-2e7431695cae"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 166
            };
        }
    }
}
