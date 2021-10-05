using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Splash : Template
    {
        public static readonly Guid ID = Guid.Parse("50ff3481-2aea-45a6-a9f5-66e7d33439d3");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Splash",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e445ad52-5176-4763-af40-10893fbe92b3"), Type = TextBlockType.Text, Text = "When you use a thrown weapon with the splash trait, you don’t add your Strength modifier to the damage roll. If an attack with a splash weapon fails, succeeds, or critically succeeds, all creatures within 5 feet of the target (including the target) take the listed splash damage. On a failure (but not a critical failure), the target of the attack still takes the splash damage. Add splash damage together with the initial damage against the target before applying the target’s weaknesses or resistances. You don’t multiply splash damage on a critical hit." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87a81580-fc4f-46e8-a92d-3b6e06276d1f"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
