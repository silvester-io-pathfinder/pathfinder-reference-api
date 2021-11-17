using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class InnateSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("2467d52a-9988-4fe4-977f-72ae87395b28");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Innate Surge", 
                Description = "Once per day, you can draw upon your familiar's innate magic to replenish your own. You can cast one innate spell gained from an ancestry feat that you have already cast today. You must still Cast the Spell and meet the spell's other requirements."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a84c58f-78ea-40be-a5aa-8e8f87c4901a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 147
            };
        }
    }
}
