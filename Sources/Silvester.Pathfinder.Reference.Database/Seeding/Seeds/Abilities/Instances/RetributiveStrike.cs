using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class RetributiveStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("76a2c8e7-1878-46f9-9709-91160a98e954");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Retributive Strike",
                Trigger = "An enemy damages the monster�s ally, and both are within 15 feet of the monster.",
                ActionTypeId = ActionTypes.Instances.Reaction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("bdf7b0b1-a3a6-4492-8ba9-ea908148b417"), Text = " The ally gains resistance to all damage against the triggering damage equal to 2 + the monster�s level. If the foe is within reach, the monster makes a melee Strike against it." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("070a4c69-f252-4edc-9c34-94659cfd2f75"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 344
            };
        }
    }
}
