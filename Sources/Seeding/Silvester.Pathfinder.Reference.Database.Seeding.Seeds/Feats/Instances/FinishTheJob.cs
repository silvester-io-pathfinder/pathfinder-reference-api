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
    public class FinishTheJob : Template
    {
        public static readonly Guid ID = Guid.Parse("d7177e79-387f-4d25-b23e-03aa5d9632ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Finish the Job",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37e08091-6978-43ba-9fdb-82ae869e0e00"), Type = TextBlockType.Text, Text = $"Your last attack failed, but it set you up for another. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with your other hand, using a one-handed melee weapon or unarmed attack. This {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} uses the same multiple attack penalty as the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} that failed on the last action. Afterward, increase your multiple attack penalty normally." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("072f6281-e2b8-4a82-be59-eb1cb5b0b1ba"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
