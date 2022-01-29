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
    public class Beastbrood : Template
    {
        public static readonly Guid ID = Guid.Parse("242d2cfb-8f1b-4672-896b-b76ec38bcf95");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Beastbrood",
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
            yield return new TextBlock { Id = Guid.Parse("e25ab3fe-8d4c-416e-aa94-58efd4e0b1c4"), Type = TextBlockType.Text, Text = $"One of your ancestors was a rakshasa, the corrupt and aristocratic reincarnated souls that call Golarion home. You have some dim echo of your ancestor's memories— enough to play the role of noble as needed, no matter your origins. You're trained in Society. If you're already trained in Society (from your background or class, for example), you instead become trained in a skill of your choice. You also gain the {ToMarkdownLink<Models.Entities.Feat>("Courtly Graces", Feats.Instances.CourtlyGraces.ID)} skill feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a2dd1271-cce7-46a0-9359-4c0ffa7197dd"), Traits.Instances.Lineage.ID);
            builder.Add(Guid.Parse("6093780c-6dff-4fc2-ae74-0a077ec1dcec"), Traits.Instances.Tiefling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("366a2ec1-27db-48de-b18b-5578e14bbf91"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
