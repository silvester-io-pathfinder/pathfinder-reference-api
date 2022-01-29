using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RatfolkGrowth : Template
    {
        public static readonly Guid ID = Guid.Parse("78e98cd6-be0d-450d-82d4-80df0639edbc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ratfolk Growth",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("205d27e6-6e1f-4767-8835-49f1b5302622"), Type = TextBlockType.Text, Text = $"You call upon the familial bonds you share with other ysoki to defend them in battle. You can cast {ToMarkdownLink<Models.Entities.Spell>("enlarge", Spells.Instances.Enlarge.ID)} as a 6th-level primal innate spell once per day. You can target only yourself and other ratfolk with this spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("740eeadd-23c8-42b9-86c0-7fb3c5316a47"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
