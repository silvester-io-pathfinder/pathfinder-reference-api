using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Human : Template
    {
        public static readonly Guid ID = Guid.Parse("8d112e3c-c8da-4a95-aee2-38e209e3f32d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Human",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e3ae488-8404-48eb-83d2-a7f823f555ef"), Type = TextBlockType.Text, Text = "A creature with this trait is a member of the human ancestry. Humans are a diverse array of people known for their adaptability. An ability with this trait can be used or selected only by humans." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f0cf9e8-94e7-4609-a8fa-74eb367f6a49"),
                SourceId = CoreRulebook.ID,
                Page = 633
            };
        }
    }
}
