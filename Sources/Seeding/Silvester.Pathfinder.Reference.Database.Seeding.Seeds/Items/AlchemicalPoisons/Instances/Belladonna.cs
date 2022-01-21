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
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalPoisons.Instances
{
    public class Belladonna : Template
    {
        public static readonly Guid ID = Guid.Parse("28f803a7-f093-4be7-a3d2-623a77560f93");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Belladonna",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ce438b37-57d0-41eb-83ed-65302a63073b"), "Sometimes called \"deadly nightshade,\" belladonna is a widely available toxin produced from a plant similar to a tomato.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("29c7e0bb-f895-460f-9b2a-11ba64accbc2"),
				Name = "Belladonna",
				Level = 2,
				Price = 500,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("9b5f8081-ce83-4091-9e25-8c8b90e01ef7"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("7627c22c-d186-4ff6-bbc3-827ac7235770"),
					Name = "Belladonna",
                    DifficultyCheck = 19,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "10 Minutes",
					MaximumDuration = "30 Minutes",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("edd921e7-2f4b-4709-9e7f-806d97c2861d"),
                            Duration = "10 Minutes",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("72f8bc3a-e04e-4fad-b2a4-60b786545ca7"),  ConditionId = Dazzled.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("725558bb-745a-4919-a817-30087a434af0"),
                            Duration = "10 Minutes",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("0c5f181c-a6a8-4038-8b7f-3360eaf636ea"),  ConditionId = Sickened.ID, Severity = 1},
                                new DamageEffect { Id = Guid.Parse("6175ff55-844c-4783-9a38-61a8bc9bf838"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("4d2f2a82-e324-4da0-adaa-b5f011fbbc50"),
                            Duration = "1 Minutes",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("4ca8d6dd-acfc-4bf5-b8fd-40f2a1322b05"),  ConditionId = Confused.ID},
                                new ConditionEffect { Id = Guid.Parse("e14d989e-2280-4792-9758-fb5d94e4969a"),  ConditionId = Sickened.ID, Severity = 1},
                                new DamageEffect { Id = Guid.Parse("09f5f419-3e05-450a-ac4e-a040ae6f4615"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("047fc48f-2fa4-41b6-802b-701f84c8e404"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("e282d1e7-8a42-4fd2-a41b-d5154e116c76"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("0217c449-0adf-49e6-b8f1-f8e1349e8a7f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("b70b7f4b-21e7-4219-95cd-312811b3c922"), Traits.Instances.Ingested.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de85d10c-dda0-4b8a-a8c4-75262c40cd56"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
