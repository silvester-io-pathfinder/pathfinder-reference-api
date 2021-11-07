using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FocusedFascination : Template
    {
        public static readonly Guid ID = Guid.Parse("ea68a075-c9e3-42f0-b9fe-e286e2b1ca76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Focused Fascination",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e57c0341-3edb-4ac4-a2bb-f0d33713bbdb"), Type = TextBlockType.Text, Text = "When you use (feat: Fascinating Performance) in a combat encounter, you need only a success, rather than a critical success, to fascinate your target. This works only if you’re attempting to fascinate one target. For example, if you were an expert in Performance, you could choose to target multiple creatures normally or target one creature and fascinate it on a success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e49533e1-c05c-4038-84f6-e12ec824a19d"), Feats.Instances.FascinatingPerformance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bd43c5a-bbc2-44ca-abc0-5b54aa6349be"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
