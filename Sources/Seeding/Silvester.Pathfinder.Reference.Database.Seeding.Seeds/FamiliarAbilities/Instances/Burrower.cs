using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Burrower : Template
    {
        public static readonly Guid ID = Guid.Parse("24b06f0a-df59-4cb2-9a26-df864142ab55");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Burrower", 
                Description = "It gains a burrow Speed of 5 feet, allowing it to dig Tiny holes."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05fddeb5-24ef-4c4e-86b5-1032bffb000d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
