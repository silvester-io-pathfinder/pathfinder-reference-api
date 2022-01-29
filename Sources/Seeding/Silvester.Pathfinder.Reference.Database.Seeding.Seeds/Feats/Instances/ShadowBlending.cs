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
    public class ShadowBlending : Template
    {
        public static readonly Guid ID = Guid.Parse("a9b3bbc8-e96d-4674-ab70-7792de216bb6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Blending",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature attempts a flat check to target you while you're concealed or hidden due to dim light or darkness.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("62ceeb2b-33d6-42c1-8330-f278c087800f"), Type = TextBlockType.Text, Text = $"You draw shadows close to create a shroud. Increase the DC of the flat check by 2." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("b4f3565f-a55f-4a97-967b-09abf8ed2fc3"), Traits.Instances.Fetchling.ID);
            builder.Add(Guid.Parse("387fdeef-2271-4c8f-b847-be16d46d20aa"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("44aa2a17-0fbc-481f-86bd-a5072bb73415"), Traits.Instances.Occult.ID);
            builder.Add(Guid.Parse("a1dc9471-f13c-4783-8338-7cba12f5b6ca"), Traits.Instances.Shadow.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab474fe5-1563-4a46-8015-3d0b93d8f347"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
