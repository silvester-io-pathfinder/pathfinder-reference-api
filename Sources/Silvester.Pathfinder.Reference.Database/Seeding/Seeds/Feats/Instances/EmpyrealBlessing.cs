using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmpyrealBlessing : Template
    {
        public static readonly Guid ID = Guid.Parse("195c8462-3f3c-4226-8dd3-ce0e9f716a87");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Empyreal Blessing",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b7188434-7cbf-406a-b327-dcd48f045d0b"), Type = TextBlockType.Text, Text = "You can call forth a benediction upon your allies, whether you pray to a deity of the celestial realms or just find the power within yourself. You can cast (spell: bless) once per day as a 1st-level divine innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b69bed5b-c0fe-426e-8f51-bf933a20c636"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
