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
    public class AriseYeWorthy : Template
    {
        public static readonly Guid ID = Guid.Parse("635d22f7-7ba0-43b3-b358-ce7cb579b775");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arise, Ye Worthy!",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3782bb3a-7ee9-419b-9d39-09895ebe0e32"), Type = TextBlockType.Text, Text = $"You are descended from the valkyries who protect worthy souls, and can hold back death's grasp. You can cast {ToMarkdownLink<Models.Entities.Spell>("breath of life", Spells.Instances.BreathOfLife.ID)} as a divine innate spell once per day." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ffa1ce24-b3ec-45c6-bb1e-70adabfa0bfd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
