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
    public class Riftmarked : Template
    {
        public static readonly Guid ID = Guid.Parse("346c18f1-5cff-497f-a0d7-a307e9e0ff89");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Riftmarked",
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
            yield return new TextBlock { Id = Guid.Parse("eefb0e35-2249-4641-8331-2b6408685056"), Type = TextBlockType.Text, Text = $"Long ago, qlippoth marked someone in your lineage, most likely through their ancient runestones that dot Golarion's surface. Yours is an old lineage, primordial and twisted, and you have a sense for similarly twisted things. You're trained in Occultism. If you're already trained in Occultism (from your background or class, for example), you instead become trained in a skill of your choice. You also gain the {ToMarkdownLink<Models.Entities.Feat>("Oddity Identification", Feats.Instances.OddityIdentification.ID)} skill feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("797616d4-a411-428b-a77e-236e5293d8d1"), Traits.Instances.Lineage.ID);
            builder.Add(Guid.Parse("400b5f1f-0cb2-4cf7-8203-e9d2d579c88a"), Traits.Instances.Tiefling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc40f195-a719-4b0d-a67a-96bbc6562b18"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
