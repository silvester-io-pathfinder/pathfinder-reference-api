using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Apex : Template
    {
        public static readonly Guid ID = Guid.Parse("9c9a620a-de8d-47c2-8a65-9aab7283d09a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Apex",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8bf1432-6448-4dbd-8175-ca6a78687ea5"), Type = TextBlockType.Text, Text = "When you Invest an Item that has the apex trait, it improves one of your ability scores, either increasing it by 2 or to a total of 18, whichever grants the higher score. This gives you all the benefits of the new ability score until the investiture ends. An apex item grants this benefit only the first time it's invested within a 24-hour period, and you can benefit from only one apex item at a time. If you attempt to invest an apex item when you already have one invested, you don't gain the ability score increase, though you do gain any other effects of Investing the Item." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a9a8842-6044-46f9-8b44-d75120be19d9"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
