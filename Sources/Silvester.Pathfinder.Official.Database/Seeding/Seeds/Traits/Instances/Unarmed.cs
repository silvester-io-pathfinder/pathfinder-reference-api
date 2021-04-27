using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Unarmed : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("7f4d2c14-f2ae-4499-abb3-5a618a14b66d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Unarmed",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0cd71c1f-bada-4a90-9583-65e0343be8b8"), Type = TextBlockType.Text, Text = "An unarmed attack uses your body rather than a manufactured weapon. An unarmed attack isn't a weapon, though it's categorized with weapons for weapon groups, and it might have weapon traits. Since it's part of your body, an unarmed attack can't be Disarmed. It also doesn't take up a hand, though a fist or other grasping appendage generally works like a free-hand weapon." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f37b618d-a214-4bf0-bebe-c75c0974eb82"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
