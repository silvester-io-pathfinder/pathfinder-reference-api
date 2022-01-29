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
    public class GreaterAugmentation : Template
    {
        public static readonly Guid ID = Guid.Parse("c5a9c920-0cf3-4610-8660-2d3310a8b985");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Augmentation",
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
            yield return new TextBlock { Id = Guid.Parse("3bfc3a2c-d612-4566-9f88-9b1229996a56"), Type = TextBlockType.Text, Text = $"You've greatly improved your abilities and your core can support further augmentations. You gain the enhancement benefits of one of your 1st-, 5th-, 9th-, or 13th-level automaton ancestry feats." };
            yield return new TextBlock { Id = Guid.Parse("917dd54f-fdf1-44f3-bd48-211667e7e8b7"), Type = TextBlockType.Text, Text = $"You are also capable of reconfiguring your augmentations to meet your needs. You can spend one week of downtime to change the enhancement you gain with this feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3a31d8d5-3c43-4ec6-93a2-0a585c7a1953"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
