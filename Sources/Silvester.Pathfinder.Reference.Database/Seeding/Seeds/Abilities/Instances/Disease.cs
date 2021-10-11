using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Disease : Template
    {
        public static readonly Guid ID = Guid.Parse("2b9f06b7-3c83-44ba-89f3-18581dcc23a1");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Disease",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("5b5c7728-320d-4397-b4cd-32e65d648b11"), Text = "When a creature is exposed to a monster's disease, it attempts a Fortitude save or succumbs to the disease. The level of a disease is the level of the monster inflicting the disease. The disease follows the rules for afflictions." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50d6cb9f-d06c-47e4-8b48-14ba996f818c"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
