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
    public class KingsSleep : Template
    {
        public static readonly Guid ID = Guid.Parse("7d31dbce-9230-4960-99cc-71de51c18977");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "King's Sleep",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("620d976a-9aa5-421e-a5a0-124b60cdc8db"), "King's sleep is an insidious long-term poison that can seem like a disease or even death from natural causes on a venerable target. The drained condition from king's sleep is cumulative with each failed save and can't be removed while the poison lasts.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("60548a41-5ef3-4e52-814c-b57497283209"),
				Name = "King's Sleep",
				Level = 18,
				Price = 400000,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("0e081874-d877-422d-8fe7-95ca826983d3"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("5b2e24eb-1beb-45ab-b69b-750b8f175033"),
				    Name = "King's Sleep",
                    DifficultyCheck = 41,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1 Day",
					MaximumDuration = "Indefinite",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("fe6bc444-914b-49bc-93b0-1a87206e99c1"),
                            Duration = "1 Day",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("7e1988d4-037a-47bc-85ae-ee1234048ccf"),  ConditionId = Drained.ID, Severity = 1}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("14971f7b-66f5-4053-bf38-1a5a23459eea"),
                            Duration = "1 Day",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("bd39ba66-7b6a-4b5c-9342-66a8019a260a"),  ConditionId = Drained.ID, Severity = 1}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("f2ab2c28-5734-4ae9-80fc-2ebaf7481ed3"),
                            Duration = "1 Day",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("ebdb2091-9058-4809-bf44-87af8f639b03"),  ConditionId = Drained.ID, Severity = 2}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c183eecd-80e8-4eb1-8f70-8bf4e679e1a9"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("405edb60-cc31-49f0-8341-59cea8acd587"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("6ce46894-1dd3-4aae-859f-3737373103e5"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("23481bfb-bf87-40fe-88c4-39ebdb8f11ff"), Traits.Instances.Ingested.ID);
            builder.Add(Guid.Parse("8ebad56d-4096-4b3a-b89c-124d75090854"), Traits.Instances.Virulent.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9541ee54-4d19-4904-9161-9412cd2b7905"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
