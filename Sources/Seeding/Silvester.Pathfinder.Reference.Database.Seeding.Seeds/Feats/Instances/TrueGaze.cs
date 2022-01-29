using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrueGaze : Template
    {
        public static readonly Guid ID = Guid.Parse("bc42c2d1-e556-4887-b20a-4c998b13b69d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "True Gaze",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eae7cf14-6d0b-4b1e-a37b-986b32017626"), Type = TextBlockType.Text, Text = $"When you focus your eyes carefully, your gaze can pierce through all obfuscations, even magical ones. When you use True Gaze, you gain the effects of a 6th-level {ToMarkdownLink<Models.Entities.Spell>("true seeing", Spells.Instances.TrueSeeing.ID)} spell, using your Perception modifier for the counteract check." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b9cbbed-b103-4955-9980-1550dd6219e7"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
