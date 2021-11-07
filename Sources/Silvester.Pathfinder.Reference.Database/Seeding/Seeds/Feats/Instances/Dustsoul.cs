using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Dustsoul : Template
    {
        public static readonly Guid ID = Guid.Parse("b34d4ece-8714-43b7-b8a6-a5852827a46d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dustsoul",
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
            yield return new TextBlock { Id = Guid.Parse("cd4af7f5-6d43-4586-b213-7d7bcbe4e98f"), Type = TextBlockType.Text, Text = "Your earth elemental ancestor’s influence manifests in you as dust and dirt, like the soil of a field or the hot desert sands. You gain the trained proficiency rank in Survival. If you would automatically become trained in Survival (from your background or class, for example), you instead become trained in a skill of your choice. You can sustain yourself on dirt and ash instead of normal food and water." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13260a93-04de-40e0-98b6-1688dea9dcd9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
