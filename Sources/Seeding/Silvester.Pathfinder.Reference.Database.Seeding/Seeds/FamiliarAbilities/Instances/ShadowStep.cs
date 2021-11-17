using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class ShadowStep : Template
    {
        public static readonly Guid ID = Guid.Parse("e804e516-1fcf-4c69-958f-690f82defdda");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Shadow Step", 
                Description = "This ability is for a shadow familiar. A shadowcaster, however, can select this ability for any kind of familiar. Your familiar gains the Shadow Step action. You must be at least 7th level to select this familiar ability for your familiar."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79be5887-e483-4ac0-82f1-aa7708f187a4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 229
            };
        }
    }
}
