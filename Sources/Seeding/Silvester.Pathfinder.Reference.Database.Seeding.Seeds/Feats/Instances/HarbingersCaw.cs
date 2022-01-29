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
    public class HarbingersCaw : Template
    {
        public static readonly Guid ID = Guid.Parse("e0b56a4f-6e48-4afe-a654-85d9c735aeef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Harbinger's Caw",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within 60 feet is about to attempt an attack roll or skill check.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4eb2bd8a-c25c-4ccf-893a-a97bb3c37e68"), Type = TextBlockType.Text, Text = $"You caw ominously, cursing the creature with misfortune. The target creature must roll the triggering check twice and take the lower result." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("60128783-ae14-4de5-a2eb-ff71293f45ba"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("9f8b18d9-82f2-4cbb-bdea-1b18f7626e7e"), Traits.Instances.Misfortune.ID);
            builder.Add(Guid.Parse("ca8d8539-bb8e-4ca8-ac8c-0e9092635a06"), Traits.Instances.Tengu.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a678455-120e-4731-bad4-afa43f0bd8b5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
