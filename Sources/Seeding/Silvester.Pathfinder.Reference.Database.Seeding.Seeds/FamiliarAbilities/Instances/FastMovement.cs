using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class FastMovement : Template
    {
        public static readonly Guid ID = Guid.Parse("81bcdb6e-c964-421c-891c-67cd0c19be5d");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Fast Movement", 
                Description = "Increase one of the familiar's Speeds from 25 feet to 40 feet."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3116c2e5-e57a-4e8b-861f-f55d84ddb1e6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
