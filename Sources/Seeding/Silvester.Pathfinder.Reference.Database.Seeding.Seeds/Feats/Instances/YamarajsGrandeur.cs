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
    public class YamarajsGrandeur : Template
    {
        public static readonly Guid ID = Guid.Parse("57b9094f-4f58-4569-b76e-7b1ff73d2a7f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Yamaraj's Grandeur",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("25fd2fda-8dae-4d83-bb2b-1f8600b22809"), Type = TextBlockType.Text, Text = $"You have been granted a sliver of the power of the yamaraj, the magistrates of the dead who agreed to allow duskwalkers to exist at all. You exhale a blast of icy wind and ravenous insects. This is a 30-foot cone that deals 14d6 slashing damage and 4d6 persistent slashing damage (basic Reflex save using your class DC or spell DC, whichever is higher). On a critical failure, targets also become sickened 2." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Duskwalker.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6158e2c-4f03-4457-9c2f-db0faea92d93"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
