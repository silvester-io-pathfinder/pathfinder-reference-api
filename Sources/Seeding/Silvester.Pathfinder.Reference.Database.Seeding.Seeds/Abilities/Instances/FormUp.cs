using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class FormUp : Template
    {
        public static readonly Guid ID = Guid.Parse("42b56554-e7b3-4f74-bfd6-2044a1fe9dd2");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Form Up",
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("97110241-6cc5-40d1-b350-d507b797f71e"), Text = "The troop chooses one of the squares it currently occupies and redistributes its squares to any configuration in which all squares are contiguous and within 15 feet of the chosen square. The troop can't share its space with other creatures." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a577305-5dae-4d0d-88e4-6355654f1557"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
