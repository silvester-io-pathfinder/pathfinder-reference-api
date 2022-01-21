using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("205062f0-053d-48bb-9462-f47a1f4a55d9");

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
            yield return new TextBlock { Id = Guid.Parse("9ee8b02d-3c0e-418d-ac06-c5c1006c8487"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("603439ea-8763-4102-b2b2-28de7d3232b3"), Guid.Parse("39f11cd7-b74e-4f4c-854f-93fd9cc5d5f4"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("3f759ae5-e342-44a6-ab9c-1412cf1cb2c5"), Guid.Parse("07f77d0d-a845-43f2-8c1f-5a19c185c8d3"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("5b40016d-0e6e-44a3-bc96-1375d8ea3fe8"), Guid.Parse("75341146-1e93-485f-bde1-a298de30c81d"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("85eb8121-8811-479b-bb2f-934fae3a94ee"), Guid.Parse("ab95d0aa-7b96-4c14-9c24-25fef94d8739"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("7721067e-ca70-4bb3-ab0d-edb30f1861b5"), Guid.Parse("e7c903c6-70d8-4c6c-b1b8-caea7acb8da3"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abe18638-730e-455d-84c0-ee8e9a7b03b9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 193
            };
        }
    }
}
