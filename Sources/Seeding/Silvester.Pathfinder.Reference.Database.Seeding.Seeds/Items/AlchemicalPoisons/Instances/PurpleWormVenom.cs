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
    public class PurpleWormVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("0a713a66-44df-45ff-8917-5977c0c90e8f");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Purple Worm Venom",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4de33799-27d7-42f5-a3cc-1458b3aef42d"), "Venom from enormous purple worms leaves a victim weakened.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("81d57d94-d02d-4bd2-8ce4-73de24169353"),
				Name = "Purple Worm Venom",
				Level = 13,
				Price = 50000,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("0d275830-790f-47fd-a90a-bb5abfa3f45f"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("724c0ddf-e5e3-4591-af38-154c62039b50"),
				    Name = "Purple Worm Venom",
                    DifficultyCheck = 32,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("6aeb73f9-a53b-47ff-8902-ede15b5a1650"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("05efa5dc-5e14-418c-be89-4d9f4a3500fe"), Damage = "5d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("2ba264b5-6806-41e9-9525-7b7245538a19"),  ConditionId = Enfeebled.ID, Severity = 2}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("795ce35a-f3cc-43d9-b6bb-6b9d73564c32"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("e550f252-a0e1-4e50-92ce-fbb0a02a5066"), Damage = "6d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("a4ea2ad9-1e02-4f91-bec6-15ab460cdea4"),  ConditionId = Enfeebled.ID, Severity = 2}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("ba8b6a38-0f9e-47a6-942a-858cfaaf2258"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("2c234f6c-3c55-4948-acc5-6575b4dedc72"), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("29139073-3fe6-46f0-a36a-210bd33b952d"),  ConditionId = Enfeebled.ID, Severity = 2}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("890d5176-7d88-4c13-8fba-a6dc34a56c08"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("7c5f4487-e80b-4503-b9f5-22e463570022"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("8c3f4152-112b-4426-b076-95c9f95acc01"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("19df9461-8754-4ecd-b2d4-0e90067962a3"), Traits.Instances.Injury.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c2617fd-4abd-4b17-a689-8ccb94ab206b"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
