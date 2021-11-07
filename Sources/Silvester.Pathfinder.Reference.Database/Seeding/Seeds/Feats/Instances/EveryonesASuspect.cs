using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EveryonesASuspect : Template
    {
        public static readonly Guid ID = Guid.Parse("5bbc2e3c-fac4-4d7c-b5fc-4eeca41fd7fa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Everyone's a Suspect",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa706967-5010-4222-858c-41b794bd0104"), Type = TextBlockType.Text, Text = "You are so suspicious of everyone you meet that you keep mental notes on how to defeat them all – even your own allies. After interacting with a creature for at least 1 minute, you automatically (feat: Pursue a Lead) with that creature as the subject. You can have any number of such leads at any given time, and when you (feat: Pursue a Lead) again, you don&#39;t give up any of these automatic subjects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3626de09-90ab-4e44-bde9-141c898475dc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
