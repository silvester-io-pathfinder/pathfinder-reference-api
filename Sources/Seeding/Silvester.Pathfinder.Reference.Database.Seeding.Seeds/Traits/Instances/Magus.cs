using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Magus : Template
    {
        public static readonly Guid ID = Guid.Parse("880a3ea1-a632-4526-b624-f97218646fb8");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Magus",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0e97e70-2741-4c29-94ad-4afae79ff940"), Type = TextBlockType.Text, Text = "This indicates abilities from the magus class." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94814e1a-8b95-4ad5-bf25-67e66c684a4e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 253
            };
        }
    }
}
