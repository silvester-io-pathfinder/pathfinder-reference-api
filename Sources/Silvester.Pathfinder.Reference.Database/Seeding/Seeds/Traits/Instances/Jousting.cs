using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Jousting : Template
    {
        public static readonly Guid ID = Guid.Parse("632903e9-caec-4f21-ae87-cc0138297453");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Jousting",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c8f7994-b9d8-4a94-a83c-6b18f78c9d1f"), Type = TextBlockType.Text, Text = "The weapon is suited for mounted combat with a harness or similar means. When mounted, if you moved at least 10 feet on the action before your attack, add a circumstance bonus to damage for that attack equal to the number of damage dice for the weapon. In addition, while mounted, you can wield the weapon in one hand, changing the damage die to the listed value." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1819004a-c057-442b-b6b6-9a1a40be34b5"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
