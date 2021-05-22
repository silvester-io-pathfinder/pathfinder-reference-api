using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons.Instances
{
    public class Wolfsbane : Template
    {
        public static readonly Guid ID = Guid.Parse("25956d4a-b3ee-49fe-9660-b1ee2b67b1de");

        protected override AlchemicalPoison GetAlchemicalPoison()
        {
            return new AlchemicalPoison
            {
                Id = ID,
                Name = "Wolfsbane",
                ItemLevel = 10,
                Price = 15500,
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
                Id = Guid.Parse("43783b7b-56ff-49e0-a0f2-68e83a373918"),
                DifficultyCheck = 30,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Onset = "10 Minutes",
                MaximumDuration = "6 Minutes",
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
            yield return new TextBlock { Id = Guid.Parse("e864228b-0a29-43de-bebb-175ea6468573"), Text = "Wolfsbane appears in folklore for its link to werecreatures. If you are afflicted with lycanthropy and survive stage 3 of wolfsbane, you’re immediately cured of the lycanthropy." };
        }

        protected override IEnumerable<StaggeredEffectStage> GetAlchemicalPoisonStages()
        {
            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("4e559a7a-d1c2-4c97-841a-56a1133d5dd0"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("2499800c-521f-414e-92f2-5df2fcfafe36"), Damage = "12d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("58e92f10-359f-4c0c-8de8-41b297e185f4"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("a4bc049d-893a-4292-839e-d0930a668b97"), Damage = "16d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                }
            };

            yield return new StaggeredEffectStage
            {
                Id = Guid.Parse("cb73d3c9-853b-403f-ade4-16d27e40bbb8"),
                Duration = "1 Minute",
                Effects = new StaggeredEffectStageEffect[]
                {
                    new DamageEffect { Id = Guid.Parse("53314a91-0060-4517-8192-fa4fa6cacf74"), Damage = "20d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                }
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67140723-8d8e-46a2-8971-c7a5ca9b63f8"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
