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
    public class IntuitiveCrafting : Template
    {
        public static readonly Guid ID = Guid.Parse("dd02be16-4c83-4d0f-a595-3f79558d0a41");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intuitive Crafting",
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
            yield return new TextBlock { Id = Guid.Parse("0a79c70a-0aef-47ca-a3f3-515e287b0aad"), Type = TextBlockType.Text, Text = $"Your affinity with process and order makes you a natural artisan. You gain the trained proficiency rank in Crafting (or another skill of your choice, if you're already trained in Crafting). You gain the {ToMarkdownLink<Models.Entities.Feat>("Specialty Crafting", Feats.Instances.SpecialtyCrafting.ID)} skill feat in a specialty of your choice." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Aphorite.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21c4829f-8ec7-447f-9e77-6b2c8cb7a0a2"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
