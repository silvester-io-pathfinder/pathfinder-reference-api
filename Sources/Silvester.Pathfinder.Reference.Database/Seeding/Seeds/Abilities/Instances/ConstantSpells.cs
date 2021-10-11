using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class ConstantSpells : Template
    {
        public static readonly Guid ID = Guid.Parse("11e85ccc-19af-4e77-b11d-8e517886da55");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Constant Spells",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("698c01ee-93b0-4e99-8627-05c913f7b3f4"), Text = "A constant spell affects the monster without the monster needing to cast it, and its duration is unlimited. If a constant spell gets counteracted, the monster can reactivate it by spending the normal spellcasting actions the spell requires." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f27e8fd2-cf08-452a-a97d-4181d425030c"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 342
            };
        }
    }
}
