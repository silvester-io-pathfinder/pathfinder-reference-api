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
    public class SilversRefrain : Template
    {
        public static readonly Guid ID = Guid.Parse("618d4815-936a-46bc-9c07-8355ef72609d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Silver's Refrain",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8395d0ff-d1a0-4d42-ae19-05d0e898c612"), Type = TextBlockType.Text, Text = $"~ Access: Have earnt Mialari Docur's trust and have proven their worth by defeating the Scarlet Triad." };
            yield return new TextBlock { Id = Guid.Parse("0be8893c-c5a0-4e69-8702-4ea4596f5ec3"), Type = TextBlockType.Text, Text = $"You learn the {ToMarkdownLink<Models.Entities.Feat>("silver's refrain", Feats.Instances.SilversRefrain.ID)} composition cantrip, which aids you when fighting devils." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Bard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14f105af-9de6-4c78-af8f-9f7d46384fb3"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
