using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class NomadicHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("dce19cbd-7be3-4fd6-939b-48712d5f6daa");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Nomadic Halfling"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your ancestors have traveled from place to place for generations, never content to settle down. You gain two additional languages of your choice, chosen from among the common and uncommon languages available to you, and every time you take the Multilingual feat, you gain another new language." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificRarityAnyLanguage(Guid.Parse(""), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            builder.GainSpecificRarityAnyLanguage(Guid.Parse(""), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            builder.ModifyFeatEffects(Guid.Parse(""), Guid.Parse(""), Feats.Instances.Multilingual.ID, modification => 
            {
                modification.GainSpecificRarityAnyLanguage(Guid.Parse(""), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 52
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Halfling.ID;
        }
    }
}
