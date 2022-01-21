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
    public class GiantCentipedeVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("acc877c9-ea44-4977-b0da-6bf6ec70922a");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Giant Centipede Venom",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e9c5a72e-0a96-4f96-ba1f-a64036c4cfda"), "Giant centipede venom causes severe muscle stiffness.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("9c7f6f35-40e7-4b5c-93dd-bd35b567bb7e"),
				Name = "Giant Centipede Venom",
				Level = 1,
				Price = 400,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("48eab0f0-076f-4507-b92f-42087d8e8359"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("bc6151f2-8d2d-4656-8e8d-bdde9641ae1a"),
				    Name = "Giant Centipede Venom",
                    DifficultyCheck = 17,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("7ab45a14-5323-4788-8547-bde6dcef2eea"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("a2a670e4-c86f-453c-b5f2-4c55108bf2b2"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("18e5d82c-4e9b-4e03-aa6a-7b2506af4227"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("c2016d79-d34e-40fc-bda1-255c004de10a"), Damage = "1d8", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("c38d3ca0-e6d3-468d-b78f-b16fd0d39bec"),  ConditionId = FlatFooted.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("1acf2634-6f8e-415c-b5be-929dcbf7c174"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("e8135bb7-15ea-4a1c-94da-da193525cd2d"), Damage = "1d12", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("195e7a37-1ff5-4c8f-9de4-3b36405c2a01"),  ConditionId = FlatFooted.ID},
                                new ConditionEffect { Id = Guid.Parse("78670bc1-771e-4221-8eca-466d80e3aff2"),  ConditionId = Clumsy.ID, Severity = 1}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4cc626a3-5cab-476a-ac2e-5f0116317b00"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("e12cf320-8fcd-4e22-a0b7-0642231769e6"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("6a79b4b8-e6ff-47d2-afae-55620a7f47d1"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("539b7854-73ef-40cc-a1d9-9e2206cb0ed8"), Traits.Instances.Injury.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b30b8cbc-1230-4e7c-be11-8f7a995a7cf1"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
