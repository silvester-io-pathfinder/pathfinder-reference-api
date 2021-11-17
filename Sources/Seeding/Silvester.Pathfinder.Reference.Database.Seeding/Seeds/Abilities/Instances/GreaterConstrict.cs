using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class GreaterConstrict : Template
    {
        public static readonly Guid ID = Guid.Parse("299a593a-8ba1-46fc-af96-9795b003e0d4");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Greater Constrict",
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("bd2f25bf-aab1-43dc-a61b-0fba3d794bf9"), Text = "The monster deals the listed amount of damage to any number of creatures grabbed or restrained by it. Each of those creatures can attempt a basic Fortitude save with the listed DC. A creature that fails this save falls unconscious, and a creature that succeeds is then temporarily immune to falling unconscious from Greater Constrict for 1 minute." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d1658d6-98f6-4dbb-987f-139320325fc5"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 343
            };
        }
    }
}
