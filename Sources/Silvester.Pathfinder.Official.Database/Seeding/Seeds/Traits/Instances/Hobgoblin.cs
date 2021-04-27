using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Hobgoblin : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("4d39fd41-7d6f-4032-95e6-13c346e3b55a");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Hobgoblin",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5dee63c7-66bf-4dd1-a07a-d50044eeb8c0"), Type = TextBlockType.Text, Text = "Hobgoblins are a sturdy, clever people with a propensity for militaristic order" };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed231a8f-d69d-4d9e-adcd-6deba0e12700"),
                SourceId = CharacterGuide.ID,
                Page = 133
            };
        }
    }
}
