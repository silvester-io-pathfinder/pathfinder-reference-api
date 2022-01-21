using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class PolyglotAndroid : Template
    {
        public static readonly Guid ID = Guid.Parse("80a133e4-27b8-4129-8838-c49fbf385a24");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Polyglot Android"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2ea2fa1d-591e-4b8c-b32f-fcf9e0c8b610"), Type = TextBlockType.Text, Text = "You were preprogrammed with a multitude of linguistic proficiencies, likely to act as a translator. You learn two new languages, chosen from common languages and any uncommon languages you have access to. These languages take the same form (signed or spoken) as your other languages. If you select the Multilingual feat, you learn three new languages instead of two." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificRarityAnyLanguage(Guid.Parse("76adc098-2eb5-4560-918f-e4887fd5244f"), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            builder.GainSpecificRarityAnyLanguage(Guid.Parse("d72492fe-6ba5-4f9f-8136-221c78166d80"), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            builder.ModifyFeatEffects(Guid.Parse("c9128943-cbc5-43d8-a1fc-c2287a1ee907"), Guid.Parse("abc3b6fa-4185-408b-86c3-95100adfeb17"), Feats.Instances.Multilingual.ID, modifications => 
            {
                modifications.GainSpecificRarityAnyLanguage(Guid.Parse("1b25936b-67af-4de5-9cfa-f5d0cde6a894"), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1f55855-3e07-4c7a-9dbd-9b314e56eb3e"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 71
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Android.ID;
        }
    }
}
