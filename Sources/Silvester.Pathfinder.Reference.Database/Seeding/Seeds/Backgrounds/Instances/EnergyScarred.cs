using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class EnergyScarred : Template
    {
        public static readonly Guid ID = Guid.Parse("eb19c5b9-bc2e-4b1a-9a9f-9cb9a10ed4c3");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Energy Scarred",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f0f77697-b95e-4c0a-8659-f9829f09f8dc"), Type = TextBlockType.Text, Text = "Exposure to a significant magical event overloaded you with magical energy. Perhaps you were exposed to dangerous levels of magical energy that left you near death, or it built up over long-term exposure to a powerful source of magic." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.PervasiveMagic.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
            builder.GainSpecificTrait(Guid.Parse("6d681efb-6f9c-4a21-bae5-0fe550fb309e"), Traits.Instances.Primal.ID);
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Acid.ID);
                    and.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Acid.ID);
                });
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Cold.ID);
                    and.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Cold.ID);
                });
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Electricity.ID);
                    and.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Electricity.ID);
                });
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Fire.ID);
                    and.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Fire.ID);
                });
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Force.ID);
                    and.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Force.ID);
                });
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Negative.ID);
                    and.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Negative.ID);
                });
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Positive.ID);
                    and.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Positive.ID);
                });
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Sonic.ID);
                    and.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Sonic.ID);
                });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87bbd49f-bdd7-4b6b-89f7-3fcef64e05c2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 219
            };
        }
    }
}
