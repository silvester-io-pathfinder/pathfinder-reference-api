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
    public class PierceTheLight : Template
    {
        public static readonly Guid ID = Guid.Parse("a296e648-169c-475a-8f50-a267fb61715a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pierce the Light",
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
            yield return new TextBlock { Id = Guid.Parse("d8c3ad67-7e78-436e-8050-79abf30824bc"), Type = TextBlockType.Text, Text = $"You tear the veil between the Material Plane and its shadow. You can cast {ToMarkdownLink<Models.Entities.Spell>("plane shift", Spells.Instances.PlaneShift.ID)} twice per week as an occult innate spell that can only target yourself; you can travel only to the Material or Shadow Planes, and your body serves as the focus component." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("025998e7-7b9d-48a6-9d67-439f00230c89"), Traits.Instances.Fetchling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3adc61a-bfd1-442c-8bfc-acd6d7294d81"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
