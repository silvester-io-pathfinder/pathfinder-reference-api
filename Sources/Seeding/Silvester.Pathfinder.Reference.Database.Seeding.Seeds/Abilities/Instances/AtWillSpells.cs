using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class AtWillSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("686cb7cc-45c0-4b9e-9798-7bbb9de7732e");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "At-Will Spells",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("2add86e5-e687-4735-8f04-93ef7458c25a"), Text = "The monster can cast its at-will spells any number of times without using up spell slots." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd539e7e-6693-4e31-a37d-91352314e381"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 342
            };
        }
    }
}
