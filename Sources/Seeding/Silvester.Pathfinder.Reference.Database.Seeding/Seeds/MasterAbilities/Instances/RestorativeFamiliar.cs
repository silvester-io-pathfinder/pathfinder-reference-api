using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class RestorativeFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("07b1eff7-d28c-45d3-9a73-acbafe857ef9");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Restorative Familiar", 
                Description = "Once per day, your familiar can use 2 actions with the concentrate trait to give up some of its animating energy and heal you. It must be in your space to do so. You restore a number of Hit Points equal to 1d8 times half your level (minimum 1d8)."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47ea76de-4c05-4ab0-b43f-1414c6289a08"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 34
            };
        }
    }
}
