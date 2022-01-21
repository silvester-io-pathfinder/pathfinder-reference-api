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
    public class TearsOfDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("0e9adbb7-41e0-4935-8e1e-5339b7b076d0");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Tears of Death",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e61c1c37-3720-4a0d-8c2b-956bc8f7e9d1"), "Tears of death are among the most powerful of alchemical poisons, distilled from extracts of five other deadly poisons in just the right ratios.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("9c9ae6ff-45d6-4de6-af66-1bef2b601284"),
				Name = "Tears of Death",
				Level = 20,
				Price = 1200000,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("99fa4d1b-9173-4218-9141-91b12b242b14"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("213ba841-ab7d-40e2-93ef-70f3984b3d26"),
				    Name = "Tears of Death",
                    DifficultyCheck = 46,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1 Minute",
					MaximumDuration = "10 Minutes",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("4cdc2685-68fc-4b72-a7cd-0aa14e057ef3"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("e1de345d-5e5a-4103-99cc-bf818d653478"), Damage = "18d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("dd54ff19-7b01-40c7-80e7-f2c80cc3d5da"),  ConditionId = Paralyzed.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("608b96fd-baa6-4acf-9c71-983a8a11ea6e"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("8971c661-b31b-41aa-a17d-36641bd8d368"), Damage = "25d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("6a7a8f08-e882-4f8d-9aa6-d69febb46bf8"),  ConditionId = Paralyzed.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("78f1b6ff-e864-4e1e-9792-5d7315050373"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("0efd65bc-b1ab-4577-a023-ce31044392dd"), Damage = "30d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("5232864d-00f2-4081-b065-7d25921188b5"),  ConditionId = Paralyzed.ID}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("79684d3b-3f60-48b1-91fc-880379767ff3"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("8b07c536-51c4-469b-9871-b3be3e76bd8b"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("40f57ce9-e53e-4c77-8ad7-bc04202f5354"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("47815909-29d0-479a-bcbd-09601e7aaea8"), Traits.Instances.Contact.ID);
            builder.Add(Guid.Parse("0015b524-762c-4640-b275-b2626ee3128f"), Traits.Instances.Virulent.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c959f5c-c614-464e-85aa-8157adcf9154"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
