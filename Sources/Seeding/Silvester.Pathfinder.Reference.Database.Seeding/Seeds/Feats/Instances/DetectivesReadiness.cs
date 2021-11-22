using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DetectivesReadiness : Template
    {
        public static readonly Guid ID = Guid.Parse("72b3efc8-a315-4bf7-8519-41cfad404bc3");

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
            yield return new TextBlock { Id = Guid.Parse("ad1c81f7-27da-49ea-b35d-79a3e699f0a3"), Type = TextBlockType.Text, Text = "When you're on a case, you stay watchful and resolute to avoid tricks your suspect might pull. You gain your circumstance bonus from (feat: Pursue a Lead) on saving throws (and their DCs, as normal) against the subject of a lead, and you can use (feat: Clue In) to assist an ally's saving throw against that subject." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("12641b3d-0224-4575-99fc-30a51d4fa3c7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
