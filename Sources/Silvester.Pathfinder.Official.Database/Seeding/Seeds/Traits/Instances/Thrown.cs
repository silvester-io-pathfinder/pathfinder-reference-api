using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Thrown : Template
    {
        public static readonly Guid ID = Guid.Parse("c70e1bc4-ca02-4d77-b117-415baa4058eb");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Thrown",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff057606-9360-47b9-8a18-1df0b565f440"), Type = TextBlockType.Text, Text = "You can throw this weapon as a ranged attack, and it is a ranged weapon when thrown. A thrown weapon adds your Strength modifier to damage just like a melee weapon does. When this trait appears on a melee weapon, it also includes the range increment. Ranged weapons with this trait use the range increment specified in the weapon’s Range entry." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("189aad16-b5cd-4574-bca9-e65ac1f206d5"),
                SourceId = CoreRulebook.ID,
                Page = 283
            };
        }
    }
}
