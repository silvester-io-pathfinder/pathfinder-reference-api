using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DetectivesReadiness : Template
    {
        public static readonly Guid ID = Guid.Parse("f4b01ff0-121f-436d-90ea-ff59e592f3b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Detective's Readiness",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5db3971e-3378-4115-8751-6d9a43332707"), Type = TextBlockType.Text, Text = "When you&#39;re on a case, you stay watchful and resolute to avoid tricks your suspect might pull. You gain your circumstance bonus from (feat: Pursue a Lead) on saving throws (and their DCs, as normal) against the subject of a lead, and you can use (feat: Clue In) to assist an ally&#39;s saving throw against that subject." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18bbdf6d-313b-47a2-ab45-6bc960c36ec9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
