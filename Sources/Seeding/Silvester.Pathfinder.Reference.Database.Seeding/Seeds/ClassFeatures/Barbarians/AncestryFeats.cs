using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class AncestryFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("a70339b2-d4df-4e8b-b526-c60c978ca327");

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
            yield return new TextBlock { Id = Guid.Parse("544dfb4b-376c-44a1-b15b-2a7a01c393a0"), Type = TextBlockType.Text, Text = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAncestryFeat(Guid.Parse("374072d8-3298-4650-8eae-8f320cbfd84c"), Guid.Parse("71570791-4738-4a94-a0d3-cfab48d8c238"), requiredLevel: 5);
            builder.GainAnyAncestryFeat(Guid.Parse("4c8db957-485c-4139-b9fd-9abc58a2c726"), Guid.Parse("bae4d4bb-cef2-495a-a772-123dfd498e99"), requiredLevel: 9);
            builder.GainAnyAncestryFeat(Guid.Parse("30fe455f-cd09-46fb-9c7e-3a4a558a99a5"), Guid.Parse("4e757e5d-6e95-4f62-b3fe-0ffa5e34cb38"), requiredLevel: 13);
            builder.GainAnyAncestryFeat(Guid.Parse("2fcd943b-8ab8-4a06-8782-29f034bb8111"), Guid.Parse("31afaaf5-489d-44d7-babc-7b9bb19ed666"), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d9b61a6-4a5d-4b7b-825b-c6613d302970"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 85
            };
        }
    }
}
