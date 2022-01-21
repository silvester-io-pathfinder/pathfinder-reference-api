using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
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
    public class BlackAdderVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("c65fd194-6210-42c8-80a2-b54ff81b6585");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Black Adder Venom",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("26dd2686-7c61-4c86-8724-6d2e336401a0"), "Adder venom is a simple but effective way to enhance a weapon.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("c5547fa5-4ce0-442e-be19-baf52926d7f7"),
				Name = "Black Adder Venom",
				Level = 2,
				Price = 600,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("f8334ad7-47d7-483f-93fb-f281afbb8263"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("9ab302d1-94a8-46c3-8ce5-f658e4e63531"),
					Name = "Black Adder Venom",
                    DifficultyCheck = 18,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "3 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("d44a502a-e5f1-4014-899a-1b9ac8425764"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("7a7a221e-1e36-4169-9184-af24aeb92769"), Damage = "1d8", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("7e0f3f16-8979-426b-878a-ed4f6223a119"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("bdb667b8-4850-4ca8-837c-9b8126773640"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        }
                    }
				}
			};
		}
        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("696bdbf6-4d2a-4af8-bffa-ed923576e9ee"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("aabfc0d8-2f3c-424a-9c6a-03a52cf2c9c4"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("0a37c4bb-0fdf-454e-8d05-ee5d9aa98042"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("d8f02e2b-7b23-41c1-8a3f-add31816e81d"), Traits.Instances.Injury.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5033a055-e80f-43a5-b42a-14262a046351"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
