using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Telepathy : Template
    {
        public static readonly Guid ID = Guid.Parse("96443321-7e08-4c0d-a8d3-3907a6ac31c4");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Telepathy",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("b0e50640-3105-4ef4-94a2-1efb398d63e4"), Text = "A monster with telepathy can communicate mentally with any creatures within the listed radius, as long as they share a language. This doesn't give any special access to their thoughts, and communicates no more information than normal speech would." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Aura.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Magical.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("468f62ab-f4a6-4e5c-be5a-49b6141fdf10"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 344
            };
        }
    }
}
