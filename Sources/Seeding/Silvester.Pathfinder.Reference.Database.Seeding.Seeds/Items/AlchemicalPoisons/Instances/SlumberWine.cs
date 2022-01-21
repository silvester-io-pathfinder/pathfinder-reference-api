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
    public class SlumberWine : Template
    {
        public static readonly Guid ID = Guid.Parse("1a0af776-3dc1-48f7-bc0a-17c676e4f044");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Slumber Wine",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a699aced-f89e-4a8e-b70e-f46ef9abdbd3"), "Slumber wine sees its greatest use in games of intrigue, where an absence can be more devastating than injury. Characters unconscious from slumber wine can't wake up by any means while the poison lasts, don't need to eat or drink while unconscious in this way, and appear to be recently dead unless an examiner succeeds at a DC 40 Medicine check.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("5e55ea43-8d1b-4c09-9942-cae98f562024"),
				Name = "Slumber Wine",
				Level = 12,
				Price = 32500,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("3234ed3b-3a12-45e2-9ae2-a075b673a9b3"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("4bdc5466-490e-48c2-b346-43bacd734125"),
				    Name = "Slumber Wine",
                    DifficultyCheck = 32,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1 Hour",
					MaximumDuration = "7 Days",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("1ac15651-b0d8-4677-bae9-f6e3d7d63d95"),
                            Duration = "1 Day",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("caf16477-a14f-4430-aeb3-098cba159e84"),  ConditionId = Unconscious.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("4c718a24-8c01-48c3-bd5c-f4df12db2edc"),
                            Duration = "2 Days",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("3b935c66-65ea-48c8-95bf-06adb04e8b49"),  ConditionId = Unconscious.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("e158a6d9-59bd-45e3-ac4b-62c3bd13f0b9"),
                            Duration = "3 Days",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("f8114adf-1e3e-4056-9fac-50e6972e782c"),  ConditionId = Unconscious.ID}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("064d2aac-70b1-4b77-8494-d10895132d6c"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("f4ab53a7-c031-4681-926e-c59b967e1659"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("3899698e-40f8-4888-b26f-e54bcaaa16f6"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("61114daf-43fb-498c-97d9-affc03697cde"), Traits.Instances.Ingested.ID);
            builder.Add(Guid.Parse("bcdf49a4-3101-4df5-a5c1-9832ff1dd8da"), Traits.Instances.Sleep.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8885d836-cabf-4a53-a3f2-8d0d6a6a9bff"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
