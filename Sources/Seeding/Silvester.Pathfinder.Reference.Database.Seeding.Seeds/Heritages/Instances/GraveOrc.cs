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
    public class GraveOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("44681848-85bf-470b-8e0d-5a3f1f5cbc3a");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Grave Orc"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("79968a76-f4e9-491c-bad4-88ae8b7ea302"), Type = TextBlockType.Text, Text = "You were exposed to powerful necromantic energies that should have killed you - but you survived. Your skin is cold, clammy, and gray. You gain resistance to negative damage equal to half your level (minimum 1). You also gain a +1 circumstance bonus to saving throws against necromancy effects." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("531df58a-2840-4640-9520-2e9e9a46d1e5"), DamageTypes.Instances.Negative.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.GainSpecificMagicSchoolAnySavingThrowCircumstanceBonus(Guid.Parse("5a5aa17c-b157-4017-a0ad-6a9112f56800"), MagicSchools.Instances.Necromancy.ID, bonus: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c23c371-5b21-499c-bb8b-9c68dbeedf05"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 50
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Orc.ID;
        }
    }
}
