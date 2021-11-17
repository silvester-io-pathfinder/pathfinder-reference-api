using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("a74e13c5-93e8-467d-af28-1c168f2d828a");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "General Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c86b41ee-ae7c-480b-93f5-c01b0058fe6a"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("edec0668-9809-4993-b366-a54bc43165e9"), Guid.Parse("84bb01de-72c7-403b-ba31-2c6d05851c97"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("e14bf4e3-a6ce-4ab1-a19b-9e621d2446b2"), Guid.Parse("71f429b4-23af-4e11-8754-3c60d6b91485"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("c3da5e59-e96b-480d-93e5-5b91523b7495"), Guid.Parse("d69cd546-3f8e-48ed-b0a0-c392c6baafe3"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("e1350ed3-4e73-4553-b581-a2419a6dd703"), Guid.Parse("33c6f5bb-23a5-4e34-8986-23300ff1f71f"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("6e873641-a887-4425-a90b-c2677aa422b0"), Guid.Parse("410bf52b-8c4e-41d7-8d67-f6904eaeda28"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aed91161-79c1-4f85-bc2b-b2a093ced2be"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 206
            };
        }
    }
}
