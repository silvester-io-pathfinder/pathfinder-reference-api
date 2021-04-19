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
    public class Intelligent : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait(TraitSeeder seeder)
        {
            return new Trait
            {
                Id = ID,
                Name = "Intelligent",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "An item with this trait is intelligent and has its own will and personality, as well as several statistics that most items don’t have. Intelligent items can’t be crafted by normal means, and they are always rare or unique." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = GamemasteryGuide.ID,
                Page = 252
            };
        }
    }
}
