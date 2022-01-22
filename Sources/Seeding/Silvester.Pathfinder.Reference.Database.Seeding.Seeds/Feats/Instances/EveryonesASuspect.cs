using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EveryonesASuspect : Template
    {
        public static readonly Guid ID = Guid.Parse("8cdecd97-a019-45c1-a505-aca6dca6a6bf");

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
            yield return new TextBlock { Id = Guid.Parse("a5275150-5bb2-4e46-9140-fda86aaadf37"), Type = TextBlockType.Text, Text = $"You are so suspicious of everyone you meet that you keep mental notes on how to defeat them all – even your own allies. After interacting with a creature for at least 1 minute, you automatically {ToMarkdownLink<Models.Entities.Feat>("Pursue a Lead", Feats.Instances.PursueALead.ID)} with that creature as the subject. You can have any number of such leads at any given time, and when you {ToMarkdownLink<Models.Entities.Feat>("Pursue a Lead", Feats.Instances.PursueALead.ID)} again, you don't give up any of these automatic subjects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3602eabc-6366-4a9d-8972-903a3ffb5537"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
