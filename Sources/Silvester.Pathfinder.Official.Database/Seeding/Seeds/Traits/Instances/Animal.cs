using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Animal : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("9977a055-9dd0-496d-bffa-2ac631d6e465");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Animal",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe0b7000-8586-4a07-883d-e48ccda3ee4a"), Type = TextBlockType.Text, Text = "An animal is a creature with a relatively low intelligence. It typically doesn’t have an Intelligence ability modifier over –4, can’t speak languages, and can’t be trained in Intelligence-based skills." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("175e9785-7715-40b3-abdc-abf7708b49fe"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
