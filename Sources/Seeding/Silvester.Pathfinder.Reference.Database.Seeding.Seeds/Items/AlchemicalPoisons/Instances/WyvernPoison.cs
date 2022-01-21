using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalPoisons.Instances
{
    public class WyvernPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("1f8e9d8a-52ba-4b7c-b041-6e797a91e25b");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Wyvern Poison",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("240bf270-cf24-434c-983a-4b5217b80772"), "Properly harvested and preserved, the poison from a wyvern's sting is effective and direct.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("c5420b54-f4f5-4140-a79d-7ac9c99b8855"),
				Name = "Wyvern Poison",
				Level = 8,
				Price = 8000,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("1646646b-0326-4275-aa29-eb6d1b9a5077"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("5e4e4683-10b6-452d-8389-77874f60ae04"),
				    Name = "Wyvern Poison",
                    DifficultyCheck = 26,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("a0475e88-48bd-43c8-8d28-5b9e70fd9fd7"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("73c9d6cf-4a09-4c4f-8092-d498c8d07175"), Damage = "5d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("024442d6-e84c-4eaf-8735-7f8c6e1639c9"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("a253ee6c-70ae-4468-9a00-a650af66c45e"), Damage = "6d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("ede8cd6e-8055-4b1e-b613-e373cc316074"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("cd70bf4e-6e09-4447-a5cf-50099eb78ce5"), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("db2c1092-1b75-457c-bcf5-fea5ab874410"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("a3d3ed20-884e-4f22-a13b-b129536f040d"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("9cf7fb0b-75e5-4e3b-bd47-11f112425f44"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("95bfe8ff-d9fa-4f58-9916-8a97edd6c912"), Traits.Instances.Injury.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7124c979-03d4-4edf-84e0-d88c267629cf"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }
    }
}
