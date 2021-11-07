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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You were preprogrammed with a multitude of linguistic proficiencies, likely to act as a translator. You learn two new languages, chosen from common languages and any uncommon languages you have access to. These languages take the same form (signed or spoken) as your other languages. If you select the Multilingual feat, you learn three new languages instead of two." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificRarityAnyLanguage(Guid.Parse(""), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            builder.GainSpecificRarityAnyLanguage(Guid.Parse(""), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            builder.ModifyFeatEffects(Guid.Parse(""), Guid.Parse(""), Feats.Instances.Multilingual.ID, modifications => 
            {
                modifications.GainSpecificRarityAnyLanguage(Guid.Parse(""), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
