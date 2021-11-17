using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
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
            builder.GainSpecificAbilityBoost(Guid.Parse("c6eb4f6a-5783-4e9f-ae9f-6065604bb6c1"), Stats.Instances.Constitution.ID);
            builder.GainSpecificTrait(Guid.Parse("6d681efb-6f9c-4a21-bae5-0fe550fb309e"), Traits.Instances.Primal.ID);
            builder.AddOr(Guid.Parse("216356a7-9b6f-469c-9035-143c79797765"), or => 
            {
                or.AddAnd(Guid.Parse("cb3431ba-bc51-4f63-ba4c-02047907f308"), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse("ab1a6199-4157-4c72-a467-2bd58503c3de"), Proficiencies.Instances.Trained.ID, Lores.Instances.Acid.ID);
                    and.GainSpecificDamageResistance(Guid.Parse("0cba1ebf-51a8-4663-8f8a-b3e229986f18"), DamageTypes.Instances.Acid.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                });
                or.AddAnd(Guid.Parse("bc8cc1bf-c3ef-4ef2-bdbb-eeaf6f2f6360"), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse("4109e18d-7263-4c1e-94fe-d0149cc12d9b"), Proficiencies.Instances.Trained.ID, Lores.Instances.Cold.ID);
                    and.GainSpecificDamageResistance(Guid.Parse("c311c68d-39e0-4f3e-8343-291095a8a53c"), DamageTypes.Instances.Cold.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                });
                or.AddAnd(Guid.Parse("d26fb10f-ec67-4e82-98f4-99a9df033abe"), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse("c7a2e89a-2b22-483b-b446-7dcc93b97a84"), Proficiencies.Instances.Trained.ID, Lores.Instances.Electricity.ID);
                    and.GainSpecificDamageResistance(Guid.Parse("d8c215e2-4c34-488e-9581-dd58ae886167"), DamageTypes.Instances.Electricity.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                });
                or.AddAnd(Guid.Parse("ab66a70f-b9dc-4077-9137-f3a1a221536b"), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse("9a02e78a-0027-4c76-b3eb-77a6258b159e"), Proficiencies.Instances.Trained.ID, Lores.Instances.Fire.ID);
                    and.GainSpecificDamageResistance(Guid.Parse("18ae582c-cf59-44d3-9144-c9781c9e1ff7"), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                });
                or.AddAnd(Guid.Parse("3e6826eb-4d45-4c93-8228-00dd892e16d5"), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse("bbbf12fd-c815-4996-8b12-90e9e4987491"), Proficiencies.Instances.Trained.ID, Lores.Instances.Force.ID);
                    and.GainSpecificDamageResistance(Guid.Parse("daf41b60-dc15-428b-9b16-78e9663165aa"), DamageTypes.Instances.Force.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                });
                or.AddAnd(Guid.Parse("5429a09a-41fd-4306-8652-6bb0de20f316"), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse("30a5cc3e-7495-413b-8654-171d2fe95718"), Proficiencies.Instances.Trained.ID, Lores.Instances.Negative.ID);
                    and.GainSpecificDamageResistance(Guid.Parse("0d0632e1-5d31-4d39-9df5-69801f839bc5"), DamageTypes.Instances.Negative.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                });
                or.AddAnd(Guid.Parse("13e2c34a-1d6e-473a-9155-9ef26bf9b0e1"), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse("15873cc3-6a8c-4bb7-9199-5b9de1cad33b"), Proficiencies.Instances.Trained.ID, Lores.Instances.Positive.ID);
                    and.GainSpecificDamageResistance(Guid.Parse("db0b0b29-167e-4b6f-b45f-1a8f599ec20d"), DamageTypes.Instances.Positive.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                });
                or.AddAnd(Guid.Parse("fb175390-9103-4edb-a978-0052c48ec491"), and =>
                {
                    and.GainSpecificLoreProficiency(Guid.Parse("af8a22ff-84f1-48ea-b7ed-f51868b2b4e4"), Proficiencies.Instances.Trained.ID, Lores.Instances.Sonic.ID);
                    and.GainSpecificDamageResistance(Guid.Parse("3e540fa1-a555-44dc-bb3b-30d422e84d0c"), DamageTypes.Instances.Sonic.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
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
