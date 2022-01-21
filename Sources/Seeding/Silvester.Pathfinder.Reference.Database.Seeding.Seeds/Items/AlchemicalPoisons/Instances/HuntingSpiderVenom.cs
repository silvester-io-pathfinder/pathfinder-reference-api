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
    public class HuntingSpiderVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("1e830309-8b32-4860-85d0-a704be45b0f6");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Hunting Spider Venom",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("84e7645e-26c9-436c-824e-f485cba68ba0"), "This venom erodes its target's defenses, aiding the spider in securing prey.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("671507af-a18e-485a-bc0b-4cde7a282fb3"),
				Name = "Hunting Spider Venom",
				Level = 5,
				Price = 2500,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("791e990e-6bcf-401d-9121-4afedfc24301"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("02525cd2-d5b9-4e41-a7e7-8ea60b3b105e"),
				    Name = "Hunting Spider Venom",
                    DifficultyCheck = 21,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("67839e5e-b6f6-4ce8-b536-10004c043041"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("a78408c4-2205-480a-8609-2cd28a755fe1"), Damage = "1d10", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("58936569-a213-4c32-bad0-8dd632e8c143"),  ConditionId = FlatFooted.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("6cb56422-0099-4a94-a59d-46cb9ca5f2f6"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("0727811c-bfd4-4a38-9166-c94d17fd239f"), Damage = "1d12", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("a4706319-051d-4c98-af73-398cdccec687"),  ConditionId = Clumsy.ID, Severity = 1},
                                new ConditionEffect { Id = Guid.Parse("eb2dce7e-db4d-4bac-a61c-b3e9aea525ed"),  ConditionId = FlatFooted.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("238e7d05-3376-4c19-999f-2675ae1940ca"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("de183ff8-e257-433d-8768-043895f2ade5"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("eeb7db98-674f-4052-b325-60e52efca32d"),  ConditionId = Clumsy.ID, Severity = 2},
                                new ConditionEffect { Id = Guid.Parse("e2fcf7f8-043e-44c8-a54b-c30295bd1fff"),  ConditionId = FlatFooted.ID}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("975bcdc5-d222-45bd-8eee-64896da9fc4e"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("a30fafb8-0bf4-4f8f-9dc3-d1facc0054d7"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("03d810f7-0f07-410f-bf3e-702a9566e826"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("f1daaced-9ff5-458d-a5af-a302106679c0"), Traits.Instances.Injury.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20c6c8fb-0561-4b49-8649-9f894536f993"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
