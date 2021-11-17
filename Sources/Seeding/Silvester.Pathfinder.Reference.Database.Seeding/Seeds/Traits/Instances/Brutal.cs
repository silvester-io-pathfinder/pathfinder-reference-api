using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Brutal : Template
    {
        public static readonly Guid ID = Guid.Parse("14a69046-3a30-4a80-a708-23f3f121b28a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Brutal",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("acc2ee12-144b-4b37-bd39-76fbb9cbd876"), Type = TextBlockType.Text, Text = "A ranged attack with this trait uses its Strength modifier instead of Dexterity on the attack roll." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd226a4b-c2f5-42d4-85d7-45a9fb8bfcc0"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
