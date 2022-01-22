using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Gemsoul : Template
    {
        public static readonly Guid ID = Guid.Parse("a5d845e8-a563-49b8-887c-37ac2da65b08");

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
            yield return new TextBlock { Id = Guid.Parse("92e68858-3a95-4f0d-9dd6-2c26ada8ad72"), Type = TextBlockType.Text, Text = $"The earth inside you asserts itself as crystallized gemstones or metals, like a cluster of quartz or veins of iron and gold. This shimmering presence inside your being inspires you to flashy and flamboyant performances. You gain the trained proficiency rank in Performance. If you would automatically become trained in Performance (from your background or class, for example), you instead become trained in a skill of your choice. You gain the {ToMarkdownLink<Models.Entities.Feat>("Impressive Performance", Feats.Instances.ImpressivePerformance.ID)} skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3437aeac-bf49-419f-abf2-7fc07de32f92"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
