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
    public class BenthicAzarketi : Template
    {
        public static readonly Guid ID = Guid.Parse("4202c5a4-0d9b-481b-9f47-49f6f811f9e1");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Benthic Azarketi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bcf68649-4992-4f3a-a718-d34aef99b6df"), Type = TextBlockType.Text, Text = "Your heritage traces to azarketis living deep beneath the sea, and you can handle the chilling depths more easily than most. You gain resistance to cold equal to half your level, and you don't treat environmental cold as one degree more severe when you are wet. You adapt to pressure changes from being deep underwater automatically without ill effect." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("b8ef68c8-38e2-4ed7-abb2-cd494c81bf41"), DamageTypes.Instances.Cold.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.ModifyTemperature(Guid.Parse("033adcde-430d-4670-be17-648104ffed53"), Temperature.Cold, ModifierType.Subtract, modifier: 1);
            builder.Manual(Guid.Parse("f52c1a6e-4409-470b-96e3-71a2856aac08"), "You adapt to pressure changes from being deep underwater automatically without ill effect.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82ab6fe3-8116-46b1-97a5-3df3d5f7cd3b"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 13
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Azarketi.ID;
        }
    }
}
