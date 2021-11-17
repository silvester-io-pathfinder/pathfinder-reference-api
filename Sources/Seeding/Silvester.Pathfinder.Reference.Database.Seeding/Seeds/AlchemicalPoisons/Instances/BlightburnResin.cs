using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class BlightburnResin : Template
    {
        public static readonly Guid ID = Guid.Parse("dc73bb29-2a4e-429e-bc99-26d85ae74e1c");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Blightburn Resin",
                ItemLevel = 11,
                Price = 22500,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
            };
        }

        protected override StaggeredEffect GetPoisonEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("cf6c8427-6b80-4787-a745-0cc22c85f6cf"),
                DifficultyCheck = 31,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "1 Minute",
                MaximumDuration = "6 Rounds",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Contact.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("785aa516-6335-4df7-9078-4230d4bdf0e7"), Text = "This tacky, hardened sap is harvested from trees infected by fungal blights and exposed to open flames." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("7da7d5d7-7109-4181-8ffe-9a08570559e8"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("1a85f9c6-5743-433a-a7b3-687ab32981cb"), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("2853ce52-ea4a-4f9c-b8a3-dded56127ad2"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("4fd42652-15b6-4286-aa70-b81e34ec90a7"), Damage = "10d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("a1608314-f954-4c33-b6a4-ce5cabc1b52c"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("d09dd3cd-e867-463c-b911-106662f84b44"), Damage = "15d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("214ab4fd-cbfe-4533-ab5d-e815fb2c48f0"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
