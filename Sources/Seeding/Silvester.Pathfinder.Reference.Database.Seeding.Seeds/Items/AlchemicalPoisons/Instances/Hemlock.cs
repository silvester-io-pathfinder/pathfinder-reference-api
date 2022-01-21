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
    public class Hemlock : Template
    {
        public static readonly Guid ID = Guid.Parse("7c923c5c-7005-4f1b-9005-5c79b289b056");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Hemlock",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7045ff07-e29c-4f30-9a90-8d4b94e64335"), "Concentrated hemlock is a particularly deadly toxin that halts muscle action—including that of the victim's heart.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("2684348a-a067-480f-ba3e-8dd4e57e6b2e"),
				Name = "Hemlock",
				Level = 17,
				Price = 225000,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("905002b0-2cb3-4985-9001-26575b552fca"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("9531647b-d08d-4c79-8993-c1e9fc5aebb3"),
				    Name = "Hemlock",
                    DifficultyCheck = 40,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "30 Minutes",
					MaximumDuration = "60 Minutes",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("0b046df0-35c7-4ce5-9e8a-ef267997af29"),
                            Duration = "10 Minutes",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("5fe5412a-564e-4a9a-bf76-c34b7d3da595"), Damage = "17d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("6ae69ff8-919d-4a88-a8a6-b0292096d4cc"),  ConditionId = Enfeebled.ID, Severity = 2}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("a9d1a6a2-beff-45bd-8557-83718005de78"),
                            Duration = "10 Minutes",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("610afeb6-7789-4aaf-b020-483aff478009"), Damage = "21d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("7762e24a-96b6-44a5-b5e6-fa0810975e64"),  ConditionId = Enfeebled.ID, Severity = 3}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("4ee75b8e-2d54-4748-abbc-280cae951532"),
                            Duration = "10 Minutes",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("c239d60f-0e66-4b61-9f04-311b09d80272"), Damage = "26d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("bbd15e86-b959-4126-b304-9d7991c252bf"),  ConditionId = Enfeebled.ID, Severity = 4}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7f9069e8-1fba-4730-883f-9d22a8a7ccfd"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("663acd52-e0a5-494a-aa71-64c1286625b3"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("39090cee-cbb0-423c-9957-eb4f2ede32aa"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("0051189a-0426-41ca-930a-2c3097d8c886"), Traits.Instances.Ingested.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc948d2b-fe6e-4a8c-937f-ea8c597e92e5"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
