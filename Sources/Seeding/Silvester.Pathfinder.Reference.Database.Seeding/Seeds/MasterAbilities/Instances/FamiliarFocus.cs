using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class FamiliarFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("0d9ae7e2-7af0-416c-af07-ccaf549a6ffb");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Familiar Focus", 
                Description = "Once per day, your familiar can use 2 actions with the concentrate trait to restore 1 Focus Point to your focus pool, up to your usual maximum. You must have a focus pool to select this."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("482a9b25-363b-4c62-86f3-fa8c6333a135"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 218
            };
        }
    }
}
