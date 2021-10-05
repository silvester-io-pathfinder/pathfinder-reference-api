using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class MindfogMist : Template
    {
        public static readonly Guid ID = Guid.Parse("c55ad542-1fba-49e6-ab84-f95050cc3d7f");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Mindfog Mist",
                ItemLevel = 15,
                Price = 100000,
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
                Id = Guid.Parse("478475fe-cd71-477d-a01b-3320f4aa4a32"),
                DifficultyCheck = 35,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "1 Round",
                MaximumDuration = "6 Rounds",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Poison.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Inhaled.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("765ca329-35c6-4f20-8d10-000b35ce1a78"), Text = "Mindfog mist can be used to undermine spellcasters, as its effect on a victim’s mental faculties are swift and powerful." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("bbdcbd62-49d6-44fe-8bbd-dbb3af8335a0"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionEffect { Id = Guid.Parse("bddebbfc-cc35-4a5e-b652-c0f9a83c3f49"),  ConditionId = Stupefied.ID, Severity = 2}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("ae0e2c13-d597-404b-a347-3022ee522878"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionEffect { Id = Guid.Parse("69312c8d-fa78-4abc-8090-11990a49fbbc"),  ConditionId = Confused.ID},
                    new ConditionEffect { Id = Guid.Parse("d6ffe1a6-0373-4e2d-bc65-256555bbdf30"),  ConditionId = Stupefied.ID, Severity = 3}
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("e3c7e67f-fac6-44bc-bca2-4e305a383db2"),
                Duration = "1 Round",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new ConditionEffect { Id = Guid.Parse("07c4bb2b-a1b8-4497-bcaf-edd83a10e826"),  ConditionId = Confused.ID},
                    new ConditionEffect { Id = Guid.Parse("af7c7592-da0a-4afa-9a97-4a9fbe98f219"),  ConditionId = Stupefied.ID, Severity = 4}
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d06a375-4a3e-4487-95c1-5d207d5f98b0"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
