using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Water : Template
    {
        public static readonly Guid ID = Guid.Parse("f459a7a6-5121-48ce-a7f6-640809b795f5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Water",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2c7bcb3-6464-4203-9aeb-0c491459cb65"), Type = TextBlockType.Text, Text = "Effects with the water trait either manipulate or conjure water. Those that manipulate water have no effect in an area without water. Creatures with this trait consist primarily of water or have a magical connection to the element. Planes with this trait are mostly liquid, perhaps with pockets of breathable air." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("110c7076-91d1-4b48-93a5-3633bba284b2"),
                SourceId = CoreRulebook.ID,
                Page = 638
            };
        }
    }
}
