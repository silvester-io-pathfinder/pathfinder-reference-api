using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Kickback : Template
    {
        public static readonly Guid ID = Guid.Parse("05098b04-5eb8-4f08-b7da-5175cec90099");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Kickback",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("891b1e6c-b141-453c-90d9-8d38c96df05a"), Type = TextBlockType.Text, Text = "A kickback weapon is extra powerful and difficult to use. A kickback weapon deals 1 additional damage with all attacks. Firing a kickback weapon gives a �2 circumstance penalty to the attack roll, but characters with 14 or more Strength ignore the penalty. Attaching a kickback weapon to stabilizers can lower or negate this penalty (page 182 of Guns & Gears)." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a29c3fd-f946-4b4a-a687-94b3e691f79c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
