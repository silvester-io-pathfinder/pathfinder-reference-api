using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Lineage : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("0592d521-3b13-4f7a-9c05-a24dffeb34d3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Lineage",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1f8a3157-e5fd-4b43-9b24-55a1729ee95a"), Type = TextBlockType.Text, Text = "A feat with this trait indicates a character's descendance from a particular type of creature. You can have only one lineage feat. You can select a lineage feat only at 1st level, and you can't retrain into or out of these feats." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7bfa17f4-be8a-466c-bf8e-c7142141202c"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 268
            };
        }
    }
}
