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
    public class Graveroot : Template
    {
        public static readonly Guid ID = Guid.Parse("b445e986-a45a-4d3a-8089-a2d33fee60dc");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Graveroot",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0b7f7c29-9473-4281-8d95-5264cfe8b23d"), "The opaque white sap from the graveroot shrub clouds the mind.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("6dc0c31d-e1a0-4c6b-9da4-51b201e68291"),
				Name = "Graveroot",
				Level = 3,
				Price = 1000,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("7f9db4cb-c7a1-40e7-b58a-7817b8053ade"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("f5edfc5f-434a-4838-889e-69265151354a"),
				    Name = "Graveroot",
                    DifficultyCheck = 19,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "4 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("6bc9fb73-f457-44b8-b248-bcfe9d2424a5"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("6965f0cd-09aa-404b-a6a0-1a16eb74f9a6"), Damage = "1d10", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("29db829e-3e03-4f20-b040-1fd524fd7e68"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("50459bf2-fa21-44cc-86b3-4f58965daef7"), Damage = "1d12", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("07ba2ef2-6563-4f3f-8897-3405dfaea9ee"),  ConditionId = Stupefied.ID, Severity = 1}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("8d39a64f-67d5-49f9-9937-5bf5d282fc03"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("e5d81de4-9af1-4427-80fd-f804ae6534f7"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("3302a027-a721-4d57-a4c8-29b6fe7fb2cf"),  ConditionId = Stupefied.ID, Severity = 2}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("38805963-b0d9-4d8c-a68f-bed27508f543"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("155a0592-16e9-4bec-81eb-c0e1afcf8525"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("0f3816bb-4b20-44fd-ad3e-4f557ad0d04f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("7089728c-d73d-4341-86a6-8625c455a69c"), Traits.Instances.Injury.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e079a8b8-5730-481b-9ea1-f40cd189a6d3"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
