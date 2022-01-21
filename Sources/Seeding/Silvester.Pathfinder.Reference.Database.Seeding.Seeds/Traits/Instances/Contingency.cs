using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Contingency : Template
    {
        public static readonly Guid ID = Guid.Parse("409db23a-0c22-4fb7-a64e-0fada77ef652");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Contingency",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1f35be64-4d01-42ad-b77a-44fe5a138100"), Type = TextBlockType.Text, Text = "Spells with this trait grant you an action during the spell's effects, typically a reaction with a special trigger. They typically have a long duration, such as 24 hours. You can have only one spell with the contingency trait, or one contingency spell, active at a time. If you cast another spell with the contingency trait or contingency, the newer casting supersedes the older." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e28e63f-1b12-4397-a10d-fc169ae1ff82"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 252
            };
        }
    }
}
