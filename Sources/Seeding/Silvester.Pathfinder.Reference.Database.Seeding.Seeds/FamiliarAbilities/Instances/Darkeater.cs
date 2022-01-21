using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Darkeater : Template
    {
        public static readonly Guid ID = Guid.Parse("fe596d13-4fb2-4fd8-ab5b-0b134203b509");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Darkeater", 
                Description = " Your familiar naturally recovers in the shadows. After spending 10 consecutive minutes in an area of dim light or darkness, your familiar recovers a number of Hit Points equal to half your level. This ability is for a shadow familiar. A shadowcaster, however, can select this ability for any kind of familiar."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("402a2ed7-3b39-49a9-a6a3-3554bb492c6f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 229
            };
        }
    }
}
