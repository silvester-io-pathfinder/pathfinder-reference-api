using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Stheno : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("7afcb828-a625-4492-9249-614e272e840e");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Stheno",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c76ce98-e1fd-433e-b340-16ff3b247ac5"), Type = TextBlockType.Text, Text = "A family of diminutive winged fey with a strong connection to primal magic." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4375a79c-5dae-4fc7-a251-141071d063df"),
                SourceId = Bestiary.ID,
                Page = 347
            };
        }
    }
}
