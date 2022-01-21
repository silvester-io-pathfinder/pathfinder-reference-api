using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Resistance : Template
    {
        public static readonly Guid ID = Guid.Parse("ec232e58-5736-4812-84b3-586dd9cf15b1");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Resistance", 
                Description = "Choose two of the following: acid, cold, electricity, fire, poison, or sonic. Your familiar gains resistance equal to half your level against the chosen damage types."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0468d86b-c9e4-470d-8308-b6e5e8f7aa65"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 146
            };
        }
    }
}
