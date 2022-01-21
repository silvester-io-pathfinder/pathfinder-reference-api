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
    public class BlackLotusExtract : Template
    {
        public static readonly Guid ID = Guid.Parse("fa11da7d-e05b-486b-a6e0-444dee34bae9");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Black Lotus Extract",
			};
		}
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c36e3697-6277-474e-b992-a95f955a857b"), "Black lotus extract causes severe internal bleeding.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("17969174-97cf-40b8-b35e-af385bec4869"),
				Name = "Black Lotus Extract",
				Level = 19,
				Price = 650000,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("5ddf5996-a98d-4aa2-8a8b-1434467be8a8"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("040e91d5-536e-4836-b63d-3f29b0301c9f"),
                    Name = "Black Lotus Extract",
					DifficultyCheck = 42,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1 Minute",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("d82f5ea0-0885-4d2f-9073-8715968a98c4"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("876e2ff9-313e-4e44-a314-1170ed53922b"), Damage = "15d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("d7873b5f-2373-4e16-bf65-5b5a67bed2d5"),  ConditionId = Drained.ID, Severity = 1},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("a22c53f3-6440-4ea1-a0ea-bf7bffeacb7e"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("6396fb33-6c06-448d-b103-b03454ec0e59"), Damage = "17d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("fdd9210a-5c37-4805-b2ef-9fb1177d7526"),  ConditionId = Drained.ID, Severity = 1},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("16bef704-1548-4a7a-ad3b-6d307c5cf93e"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("75c1b506-f418-4971-8443-59db5a0ff891"), Damage = "20d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("ac0aef9e-5c9d-4984-b589-63889f8f1553"),  ConditionId = Drained.ID, Severity = 2},
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e5c11c17-ccc3-4b52-8b5d-2aaea071f25a"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("5e83e488-eb11-4775-9276-019b4c67a609"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("df37460a-4824-4c07-96c5-68974838f6c7"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e1f633e1-5c71-4dcd-807d-d40906e9da42"), Traits.Instances.Contact.ID);
            builder.Add(Guid.Parse("78b132d3-42e7-464b-bdb1-153a5e2867ca"), Traits.Instances.Virulent.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df4f9201-28e4-4357-8a2d-e976657da5cf"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
