using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Knockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("e71ef7cb-118e-4097-803b-f31b11ee146c");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Knockdown",
                Requirements = "The monster's last action was a success with a Strike that lists Knockdown in its damage entry.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("1d7540fe-9085-44a0-abf2-901c59f41f87"), Text = "The monster knocks the target prone." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f00fa616-1b71-488d-acba-9e64f1e9f156"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
