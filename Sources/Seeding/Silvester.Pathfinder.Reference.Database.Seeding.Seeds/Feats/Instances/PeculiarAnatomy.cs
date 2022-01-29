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
    public class PeculiarAnatomy : Template
    {
        public static readonly Guid ID = Guid.Parse("f42ea2a1-4716-4903-9f50-d9ccc9b28c96");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Peculiar Anatomy",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5786943f-8ecc-4b00-bc75-f1d66a8d6314"), Type = TextBlockType.Text, Text = $"Your circulatory system contains viscous protoplasmic fluid instead of ordinary blood. You gain a +2 circumstance bonus to saving throws against {ToMarkdownLink<Models.Entities.Trait>("disease", Traits.Instances.Disease.ID)} and {ToMarkdownLink<Models.Entities.Trait>("poison", Traits.Instances.Poison.ID)}, and resistance to poison damage equal to half your level." };
            yield return new TextBlock { Id = Guid.Parse("516b2d2f-e46d-489b-9210-a3cea58842f7"), Type = TextBlockType.Text, Text = $"In addition, your resistance to precision damage from {ToMarkdownLink<Models.Entities.Feat>("Disturbing Defense", Feats.Instances.DisturbingDefense.ID)} increases to an amount equal to 7 + your number of class feats from the oozemorph archetype, and the DC of your flat checks to recover from persistent bleed damage is 8 rather than 13." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bb821226-ebfd-4bf8-90ab-0d72b0d26dc3"), Feats.Instances.DisturbingDefense.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ec610dc-ebb6-4016-add1-2bb9a2d6357f"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
