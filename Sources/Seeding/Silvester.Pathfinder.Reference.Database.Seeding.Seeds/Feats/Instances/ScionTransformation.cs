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
    public class ScionTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("940de874-4d14-484e-b398-6fc6bc00b282");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scion Transformation",
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
            yield return new TextBlock { Id = Guid.Parse("1b5606b1-acee-4060-8097-f2d1a0a42e59"), Type = TextBlockType.Text, Text = $"You go into hibernation for 24 hours and perform a ritual dedicated to your ancestors, undergoing a one-time metamorphosis. You permanently gain the effects of {ToMarkdownLink<Models.Entities.Spell>("enlarge", Spells.Instances.Enlarge.ID)}, and your maximum Hit Points increase by your level. The ritual transforms most of your gear to the appropriate size for your new body (though powerful items like artifacts or items strongly tied to their original size may not transform, at the GM's discretion)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("0cb6ccfc-c8cd-4bb5-80a3-0cefff683ac5"), Traits.Instances.Lizardfolk.ID);
            builder.Add(Guid.Parse("1527ff77-ad98-42c6-b8c1-265851fb130a"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("4971f9f4-304f-4531-a665-4eca9f5bc845"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51911e6e-cc02-4cda-a341-526d1e7df56a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
