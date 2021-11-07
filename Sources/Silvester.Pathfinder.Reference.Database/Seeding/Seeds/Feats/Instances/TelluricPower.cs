using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TelluricPower : Template
    {
        public static readonly Guid ID = Guid.Parse("30952fa2-7023-433e-92fd-7df7f05eb586");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Telluric Power",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("329c8c70-9d2e-4c70-9baa-3bdcc7bbf59b"), Type = TextBlockType.Text, Text = "You channel strength from the earth beneath your feet to pummel your enemies. When making a melee (action: Strike) against a target who is standing on the same earth or stone surface as you are, you gain a circumstance bonus to the damage roll equal to the number of weapon damage dice." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc81e6ee-d93a-4e9a-8316-1e89d9a4e9fc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
