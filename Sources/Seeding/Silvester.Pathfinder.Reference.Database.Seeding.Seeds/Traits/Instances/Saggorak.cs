using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Saggorak : Template
    {
        public static readonly Guid ID = Guid.Parse("2ada1501-9857-49e8-ac4f-d97750797df4");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Saggorak",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("12e18d98-6a3f-40fd-95eb-843fec7cd654"), Type = TextBlockType.Text, Text = "Ancient dwarven blacksmiths in Saggorak designed a series of spectacularly powerful runes. Only someone with legendary proficiency in Crafting, or a well-versed dwarven crafter from the city of Kovlar, can apply, transfer, or remove a rune with the Saggorak trait." };
            yield return new TextBlock { Id = Guid.Parse("642773a7-1794-4e74-81ad-38f05d3b50a1"), Type = TextBlockType.Text, Text = "Because of their considerable power, all Saggorak runes take up two property rune slots, and consequently they can be applied only to armor and weapons with at least a +2 potency rune." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ff5190e-c2f2-444b-8020-5656313d7821"),
                SourceId = Pathfinder148.ID,
                Page = 73
            };
        }
    }
}
