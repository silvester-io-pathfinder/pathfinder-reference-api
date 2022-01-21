using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalPoisons.Instances
{
    public class LichDust : Template
    {
        public static readonly Guid ID = Guid.Parse("949064c1-4862-4a51-a4fe-8ac7c91559d1");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Lich Dust",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d4ce3729-a117-4501-b8b3-2526bfb0ff43"), "Dust salvaged from the remains of a destroyed lich has paralytic properties that make it a valuable poison.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("672d2ec2-04eb-4dca-a9c2-b54acc4c262e"),
				Name = "Lich Dust",
				Level = 9,
				Price = 11000,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("c921a65f-dfa0-4a60-b224-58bb05f56bee"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("792ba8fd-fe7a-45ac-a7b7-c7a88d8902d9"),
				    Name = "Lich Dust",
                    DifficultyCheck = 28,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "10 Minutes",
					MaximumDuration = "6 Minutes",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("fd3da93d-0239-4e54-b076-069bbdb0aaac"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("9bff1446-c02c-46f6-8138-1801cb3f549e"),  ConditionId = Fatigued.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("d4585a9b-1f6e-4626-89e0-54428475754c"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("27a4d185-f05c-40d9-950d-f1919356ad85"), Damage = "5d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("05ac86bb-0e64-4c15-91db-dec7da56acd4"),  ConditionId = Fatigued.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("8dc1ed03-ff8b-49a0-bbf3-6ccabf16b382"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("a7f081b2-87db-4a04-91b9-9fa81352e936"), Damage = "5d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("903e1d6d-379c-4223-8032-88bc21d562e6"),  ConditionId = Fatigued.ID},
                                new ConditionEffect { Id = Guid.Parse("e8c54635-1a96-4cb1-9175-68f7d7378b45"),  ConditionId = Paralyzed.ID},
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a6110952-9547-478a-a9f8-45f098026587"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("98b981d8-b62c-4bc1-ac32-97dbdffed211"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("996631a6-3eb4-4abe-a2e0-0baba402bb6a"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("c6c42bf3-9a1e-4bce-9cee-d40606980436"), Traits.Instances.Ingested.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ccc8202-a856-4b7b-8660-03390c20d026"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
