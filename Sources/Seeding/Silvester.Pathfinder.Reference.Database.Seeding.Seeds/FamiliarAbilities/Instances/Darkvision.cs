using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Darkvision : Template
    {
        public static readonly Guid ID = Guid.Parse("33e1ae57-272a-4e9b-a1e4-f14687e97abd");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Darkvision", 
                Description = "It gains darkvision."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc411072-89a2-4ac9-b0b4-06a6114f195c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
