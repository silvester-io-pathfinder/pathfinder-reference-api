using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class FastHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("fd5f5dc2-dcc0-43bb-9033-108d9df03484");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Fast Healing",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("1cc817fc-5d04-46ce-92fc-a63cf3b321bf"), Text = "A monster with this ability regains the given number of Hit Points each round at the beginning of its turn." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa620351-a6b1-4553-9ac1-dc5e2a74ffee"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
