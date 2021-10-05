using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class BrimstoneFumes : Template
    {
        public static readonly Guid ID = Guid.Parse("81b07f7b-2e70-4b38-80f7-0b28a4c6f399");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Brimstone Fumes",
                ItemLevel = 16,
                Price = 150000,
                Usage = "Held in 1 hand",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
            };
        }

        protected override StaggeredEffect GetPoisonEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("0860cb5f-6bf5-423b-944e-1c4e79802565"),
                DifficultyCheck = 36,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "1 Round",
                MaximumDuration = "6 Rounds"
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Inhaled.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b28e3fa-1348-41cb-ba9f-25f5230e45d3"), Text = "Fumes from the forges of Hell drain health and strength alike." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("8b833ef5-c504-4580-bee7-b124e0d63981"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("9058f97d-0aac-4d3b-b68c-adb1e8c7f84a"), Damage = "7d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("bb63ec34-7c71-4ac0-bc8b-8b4316f78364"),  ConditionId = Enfeebled.ID, Severity = 1}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("b52f55c1-44e0-479a-8d1e-24cbeb57189e"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("b065f341-8bac-49ee-83a1-87d03f27e66e"), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("488cc010-f4d3-44cc-b0b9-ebbd408c4e5e"),  ConditionId = Enfeebled.ID, Severity = 2}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("8b8011f3-58a5-4e72-9e3f-db705c384bf8"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("2a2a1976-91a5-40dd-b293-db3608f5398c"), Damage = "10d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                    new ConditionEffect { Id = Guid.Parse("8c8ab084-efcb-455d-9029-28b2ac9b3b4c"),  ConditionId = Enfeebled.ID, Severity = 3}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0381fe8b-2404-42fb-9abd-74e28f1401d5"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
