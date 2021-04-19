using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Apex : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait(TraitSeeder seeder)
        {
            return new Trait
            {
                Id = ID,
                Name = "Apex",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you Invest an Item that has the apex trait, it improves one of your ability scores, either increasing it by 2 or to a total of 18, whichever grants the higher score. This gives you all the benefits of the new ability score until the investiture ends. An apex item grants this benefit only the first time it’s invested within a 24-hour period, and you can benefit from only one apex item at a time. If you attempt to invest an apex item when you already have one invested, you don’t gain the ability score increase, though you do gain any other effects of Investing the Item." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
