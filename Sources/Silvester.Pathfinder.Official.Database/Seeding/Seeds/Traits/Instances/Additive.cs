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
    public class Additive : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait(TraitSeeder seeder)
        {
            return new Trait
            {
                Id = ID,
                Name = "Additive",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Feats with the additive trait allow you to spend actions to add special substances to bombs or elixirs. You can add only one additive to a single alchemical item, and attempting to add another spoils the item. You can typically use actions with the additive trait only when you're creating an infused alchemical item, and some can be used only with the Quick Alchemy action. The additive trait is always followed by a level, such as additive 2. An additive adds its level to the level of the alchemical item you're modifying; the result is the new level of the mixture. The mixture's item level must be no higher than your advanced alchemy level." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = CoreRulebook.ID,
                Page = 75
            };
        }
    }
}
