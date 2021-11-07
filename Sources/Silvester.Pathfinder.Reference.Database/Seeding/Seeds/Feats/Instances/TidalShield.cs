using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TidalShield : Template
    {
        public static readonly Guid ID = Guid.Parse("a55a7819-8343-482b-bee3-ec47d1dde253");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tidal Shield",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8494e8d0-dce3-408d-a1ed-588ff9fb5a3e"), Type = TextBlockType.Text, Text = "You conjure the force of the tides to gain a +4 circumstance bonus to AC until the end of your next turn. Any allies adjacent to you during the duration gain a +2 circumstance bonus to AC as long as they remain adjacent to you. You can (action: Sustain | Sustain an Activation) the effect to a maximum duration of 5 rounds. When a creature receiving a circumstance bonus to AC from Tidal Shield would take damage from an attack, as a reaction, you can reduce the damage to that creature by 40; after you do so, Tidal Shield ends." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac059b43-8907-4e88-bf2d-e2776b93757e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
