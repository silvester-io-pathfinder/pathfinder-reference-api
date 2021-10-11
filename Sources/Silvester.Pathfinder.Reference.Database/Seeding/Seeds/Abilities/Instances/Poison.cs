using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Poison : Template
    {
        public static readonly Guid ID = Guid.Parse("8d5ce519-bf93-4db7-941c-40f83aa9ebfc");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Poison",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("db099ebe-0dfa-4648-a6fe-6475398628fe"), Text = "When a creature is exposed to a monster�s poison, it attempts a Fortitude save to avoid becoming poisoned. The level of a poison is the level of the monster inflicting the poison. The poison follows the rules for afflictions." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56c58688-6fb4-4070-bb33-1d463a85f94e"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
