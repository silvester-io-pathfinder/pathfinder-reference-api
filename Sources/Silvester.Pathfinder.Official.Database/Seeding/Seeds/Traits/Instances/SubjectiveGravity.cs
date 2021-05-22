using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class SubjectiveGravity : Template
    {
        public static readonly Guid ID = Guid.Parse("133638b4-16e8-466a-9ba6-cf6bd339f763");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Subjective Gravity",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d76245ee-841c-4c93-8246-1a3cbe4e157b"), Type = TextBlockType.Text, Text = "On planes with this trait, all bodies of mass can be centers of gravity with the same amount of force, but only if a non-mindless creature wills it." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bf57918-c76d-4d75-9da7-b5f81fb4f3c0"),
                SourceId = GamemasteryGuide.ID,
                Page = 254
            };
        }
    }
}
