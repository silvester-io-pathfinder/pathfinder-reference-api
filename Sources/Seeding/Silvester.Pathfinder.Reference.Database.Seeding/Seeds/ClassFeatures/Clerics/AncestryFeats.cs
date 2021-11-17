using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("aa5fd8af-eed7-439c-ae18-a64ac4e3f469");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Ancestry Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("94de050c-17aa-4a30-997f-9b03a8150435"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("43b7024d-faea-4180-b402-decf7f014e62"), Guid.Parse("58fd1350-9863-49fb-8753-c0420a703e02"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("7e6d4494-f348-42d6-a3ad-86b7f71c1be3"), Guid.Parse("28cdd884-8398-4e1e-9cb2-34ecc2a2e60c"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("62553b03-fdd2-4733-868a-3c95dbe8fd2e"), Guid.Parse("8cb83d0b-79b6-4828-9f93-12d496d6c9a7"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("61c88ea5-751c-45d0-9eb1-dd0acbc43178"), Guid.Parse("46f4b48f-defe-44a9-a6fb-51c6d46e1394"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d189b694-7922-4539-ab18-a4230cd18b7c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 121
            };
        }
    }
}
