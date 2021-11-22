using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class Arsenic : Template
    {
        public static readonly Guid ID = Guid.Parse("b28f4309-cc04-4522-8837-b653995b3028");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Arsenic",
                ItemLevel = 1,
                Price = 300,
                Usage = "Held in 1 hand",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override StaggeredEffect GetPoisonEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("37764fda-a770-40e6-98e5-1207002f7708"),
                DifficultyCheck = 18,
                MaximumDuration = "5 Minutes",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "10 Minutes",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Ingested.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ab9af6c8-886c-4cc4-8347-d5d5b6c520e5"), Text = "This toxin is a compound of arsenic and other substances. You can't reduce your sickened condition while affected." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("0468236a-951d-4f4b-ba55-9677d2872063"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionEffect { Id = Guid.Parse("0bf453a8-ad63-4059-a589-a47a771a388a"), ConditionId = Sickened.ID, Severity = 1},
                    new DamageEffect {Id = Guid.Parse("901de562-81e9-4a7a-ad10-cc865341ed13"), Damage = "1d4", DamageTypeId = DamageTypes.Instances.Poison.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("3abafdfd-bb76-4211-8bd2-733116b08360"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionEffect { Id = Guid.Parse("3af0f5a8-e26c-4328-8bfd-586297d76416"), ConditionId = Sickened.ID, Severity = 2},
                    new DamageEffect {Id = Guid.Parse("c27b7d34-8fa2-4373-9c8d-5c042e168fe1"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("39bc0f47-bd42-488e-bb8c-bbd82bc20771"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionEffect { Id = Guid.Parse("aad3acd9-12b3-4aec-ae90-c5f96235837e"), ConditionId = Sickened.ID, Severity = 3},
                    new DamageEffect {Id = Guid.Parse("9a349ef1-5a02-4309-a095-d298f879328d"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c09132c-90a6-4d8f-a62e-64faf7f8ffca"),
                SourceId = CoreRulebook.ID,
                Page = 550
            };
        }
    }
}
