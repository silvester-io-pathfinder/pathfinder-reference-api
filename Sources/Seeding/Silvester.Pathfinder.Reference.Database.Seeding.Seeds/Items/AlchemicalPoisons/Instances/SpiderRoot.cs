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
    public class SpiderRoot : Template
    {
        public static readonly Guid ID = Guid.Parse("c4f4ddce-c112-44b3-90a5-06aaaed80f1e");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Spider Root",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7891623b-6f09-4e17-b565-40ac365b6b59"), "A paste made by mashing the fine, threadlike roots of a certain creeper vine, spider root renders a victim clumsy and maladroit.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("87f88d3c-87b7-421b-a615-a474a5135801"),
				Name = "Spider Root",
				Level = 9,
				Price = 11000,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("87b82dc9-b066-4b18-b342-c36180bc8b4f"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("3935e556-052d-48b8-994d-5163cf9f4ca7"),
				    Name = "Spider Root",
                    DifficultyCheck = 28,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1  Minute",
					MaximumDuration = "6 Minutes",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("038ae784-9e97-4b76-9474-7e71f2e866f9"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("0829c1e6-8249-4419-ad41-dbd6da1aaa01"), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("d355d61d-32bb-441c-b612-2a38d98928c1"),  ConditionId = Clumsy.ID, Severity = 1}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("959cd97b-8af6-43d3-b464-96f192c4e0d3"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("908525b2-5ebc-4927-8cdb-2226cc29d631"), Damage = "9d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("506ecf2b-2aff-4e39-9744-10e4a502b7ed"),  ConditionId = Clumsy.ID, Severity = 2}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("cb8ec76e-2ed6-4157-9edf-eb54cc553f0b"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("26c7cf57-a9f3-4df1-8ef4-e6f296d3431c"), Damage = "10d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("b4b392eb-6f20-496f-963c-f0939043f235"),  ConditionId = Clumsy.ID, Severity = 3}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4ad761ae-fa77-4f3a-8865-f27e6c2802f4"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("0007ba72-4897-4859-8e9d-9c151a58502c"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("b22a1253-af78-45eb-955c-f98f92cc0ea9"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e4e9ae98-598a-4ba5-b712-0d4af46f1072"), Traits.Instances.Contact.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c8431c4-5db9-4ea3-8306-d4db00c4efb7"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
