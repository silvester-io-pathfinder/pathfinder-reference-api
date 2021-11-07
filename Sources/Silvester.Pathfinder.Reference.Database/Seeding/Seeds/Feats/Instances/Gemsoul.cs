using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Gemsoul : Template
    {
        public static readonly Guid ID = Guid.Parse("02a132c6-d9e1-4633-8126-498d7d3b9952");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gemsoul",
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
            yield return new TextBlock { Id = Guid.Parse("3e7c45e6-b292-44be-88bb-516fa9589442"), Type = TextBlockType.Text, Text = "The earth inside you asserts itself as crystallized gemstones or metals, like a cluster of quartz or veins of iron and gold. This shimmering presence inside your being inspires you to flashy and flamboyant performances. You gain the trained proficiency rank in Performance. If you would automatically become trained in Performance (from your background or class, for example), you instead become trained in a skill of your choice. You gain the (feat: Impressive Performance) skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cccdd08e-9ea5-401f-acd0-8a54f15202c1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
