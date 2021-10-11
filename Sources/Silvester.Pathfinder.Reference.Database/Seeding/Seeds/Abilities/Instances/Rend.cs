using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Rend : Template
    {
        public static readonly Guid ID = Guid.Parse("a71f219a-6365-4248-b994-0f5648a451c1");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Rend",
                Description = "A Rend entry lists a Strike the monster has.",
                Requirements = "The monster hit the same enemy with two consecutive Strikes of the listed type in the same round. ",
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("781f5d52-19ba-41b3-a954-96b877579e52"), Text = "The monster automatically deals that Strike's damage again to the enemy." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab6469e8-674e-4337-a450-4ea833f889ef"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 344
            };
        }
    }
}
