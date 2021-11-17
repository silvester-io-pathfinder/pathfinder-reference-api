using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("96222462-7ed4-429b-a604-bf31e241ed7c");

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
            yield return new TextBlock { Id = Guid.Parse("68af9217-04f5-408f-9bf4-9672c139b296"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("720fc735-4883-492b-817d-12685fc89412"), Guid.Parse("4793cf8d-ba35-4e45-bc9d-c3c33745a0e9"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("4ce21647-1ff0-4182-880f-de96872e630c"), Guid.Parse("4dff211b-4a74-4ba7-8dc6-15281a1b5363"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("163fd284-7399-454e-8881-e91e6f35b956"), Guid.Parse("98185d77-fc28-4da9-871f-830cf179be57"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("cf714856-9bff-4719-b4bc-69d159b7d0a0"), Guid.Parse("9b73470e-ec4c-4242-95fa-6a7e895c26e2"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("99d226f1-bddf-4c6c-bccc-096b4edfbf61"), Guid.Parse("c98fbd24-0f5a-4b95-bc55-b3a226485020"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33d298db-8188-41f5-af84-2fa9ccd2b079"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 98
            };
        }
    }
}
