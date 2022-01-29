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
    public class Caterwaul : Template
    {
        public static readonly Guid ID = Guid.Parse("64416f16-6449-4ddd-818b-3554b73758c6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Caterwaul",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet would be reduced to 0 HP but not immediately killed.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d2d2d693-07d8-4599-b477-60e4a7a7084e"), Type = TextBlockType.Text, Text = $"You give a daring yowl in the face of adversity, calling your companion back from the brink of unconsciousness. Your ally isn't knocked out and remains at 1 Hit Point. Your ally's wounded condition still increases by 1 as though they had been dying and recovered." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f95f69e4-53ba-4090-b907-a4c4530ee8fe"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("88ae26bc-29be-4361-806d-7813d6d61274"), Traits.Instances.Catfolk.ID);
            builder.Add(Guid.Parse("75bb7053-1228-417a-83e4-085f117ebfaf"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("9531d8d7-ee83-4b50-8723-3697287516f0"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("f5c0884d-4e25-40d3-b485-8480437757a5"), Traits.Instances.Mental.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f9941a6-0a22-42eb-90da-5f4474cefd47"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
