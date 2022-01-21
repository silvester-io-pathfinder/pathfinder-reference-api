using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Alchemical : Template
    {
        public static readonly Guid ID = Guid.Parse("d1cba1ea-926f-4724-98ec-5d46b7b1fe9d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Alchemical",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c56f73e-8fec-4975-8bb6-7430e8b702cc"), Type = TextBlockType.Text, Text = "Alchemical items are powered by reactions of alchemical reagents. Alchemical items aren't magical and don't radiate a magical aura." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50a6cfb8-2a8b-43d1-af38-e7c6047810b5"),
                SourceId = CoreRulebook.ID,
                Page = 628
            };
        }
    }
}
