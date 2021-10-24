using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Cavalier : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Cavalier",
                DedicationFeatId = Feats.Instances.CavalierDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You are a skilled and dedicated warrior of the battlefield who specializes in fighting astride a powerful animal companion that serves as your mount. You and your mount are an unparalleled team, moving with shared intent to become a powerful force on the battlefield. You might wield a banner in the name of a greater organization, a liege, or an ideal you uphold, or you might fight solely to further enrich your own prestige, reputation, and coffers." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 164
            };
        }
    }
}
