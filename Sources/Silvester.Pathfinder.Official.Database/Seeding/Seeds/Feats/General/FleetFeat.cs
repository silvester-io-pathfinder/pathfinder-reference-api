using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class FleetFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("37e3bc29-be7b-4112-92aa-0b7dddbc2da3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fleet",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7b4e22c3-cf7d-4ab3-9d47-3bca57cd7ed6"), Type = Utilities.Text.TextBlockType.Text, Text = "You move more quickly on foot. Your Speed increases by 5 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }
    }
}
