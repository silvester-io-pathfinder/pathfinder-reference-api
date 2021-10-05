using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Forceful : Template
    {
        public static readonly Guid ID = Guid.Parse("220dd07b-029e-42f9-b541-03c1cac8c816");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Forceful",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("710b1f87-71a2-46dd-bc67-de76fa3f7c29"), Type = TextBlockType.Text, Text = "This weapon becomes more dangerous as you build momentum. When you attack with it more than once on your turn, the second attack gains a circumstance bonus to damage equal to the number of weapon damage dice, and each subsequent attack gains a circumstance bonus to damage equal to double the number of weapon damage dice." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12319259-d108-42b5-a1d5-3ae27304809f"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
