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
    public class MagicalFortitude : Template
    {
        public static readonly Guid ID = Guid.Parse("db09a8d0-fff2-4173-8945-68c818437a62");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 5,
                Name = "Magical Fortitude", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("327bf9e5-8117-46c2-88c8-0d269ca060b0"), Type = TextBlockType.Text, Text = "Magical power has improved your body's resiliency. Your proficiency rank for Fortitude saves increases to expert." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSavingThrowProficiency(Guid.Parse("06dc9708-b2e5-466b-a863-a7a76b7e54c3"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Fortitude.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a3a2918-e0e7-424f-a7a6-aed1a1891c97"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 194
            };
        }
    }
}
