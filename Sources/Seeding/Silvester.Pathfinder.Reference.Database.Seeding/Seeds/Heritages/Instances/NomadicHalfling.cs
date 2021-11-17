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
            yield return new TextBlock { Id = Guid.Parse("b3c777a4-c70f-4103-b867-8c275a7b0770"), Type = TextBlockType.Text, Text = "Your ancestors have traveled from place to place for generations, never content to settle down. You gain two additional languages of your choice, chosen from among the common and uncommon languages available to you, and every time you take the Multilingual feat, you gain another new language." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificRarityAnyLanguage(Guid.Parse("c954d436-2b2e-4a6b-b184-00a15d3eca80"), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            builder.GainSpecificRarityAnyLanguage(Guid.Parse("25a840f3-3459-43a9-8dab-f759b382b648"), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            builder.ModifyFeatEffects(Guid.Parse("7eaf1d80-0d4e-4768-96ea-7fb11736515c"), Guid.Parse("7ab240ac-48aa-4629-8aef-436da56aac11"), Feats.Instances.Multilingual.ID, modification => 
            {
                modification.GainSpecificRarityAnyLanguage(Guid.Parse("a2c59792-d993-41a6-8388-22c101f47dbf"), Comparator.LessThanOrEqualTo, Rarities.Instances.Uncommon.ID);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44446021-bc87-4f29-906a-1dc170aea72c"),
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
