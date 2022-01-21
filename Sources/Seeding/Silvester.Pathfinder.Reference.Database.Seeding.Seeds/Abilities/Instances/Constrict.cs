using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Constrict : Template
    {
        public static readonly Guid ID = Guid.Parse("884564a2-5bcd-43d1-acb4-85880f4b71ca");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Constrict",
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("63a26f12-f034-4033-8dcc-91842d281ef1"), Text = "The monster deals the listed amount of damage to any number of creatures grabbed or restrained by it. Each of those creatures can attempt a basic Fortitude save with the listed DC." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7aa5048b-08ad-42ab-9d33-c5daa8b0a517"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 342
            };
        }
    }
}
