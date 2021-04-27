using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Wright : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("e48d94cb-4027-4dd7-9770-b2e02716eeef");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Wright",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27baf7c6-2f7a-4e77-a4e0-be06b4686423"), Type = TextBlockType.Text, Text = "A wight is an undead creature that drains life and stands vigil over its burial site." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("216fbfc6-9135-4b27-aae9-7dfa39772cc3"),
                SourceId = Bestiary.ID,
                Page = 332
            };
        }
    }
}
