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
    public class DeathcapPowder : Template
    {
        public static readonly Guid ID = Guid.Parse("ae0386af-cfaf-40c0-83b4-8dd5a8d80d9a");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Deathcap Powder",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("86a05df2-37ef-4162-9576-46a53b42e381"), "The toxic deathcap mushroom can be dried, ground, and treated to form a flavorless powder with accelerated effects.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("ef893e74-bcea-4cf8-a3ba-5847e6a4bc39"),
				Name = "Deathcap Powder",
				Level = 13,
				Price = 45000,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("a0a83c66-d60d-4a8d-b048-f25cf10edb1d"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("cbd1a958-ac5e-4a17-9b53-affb4831ffca"),
				    Name = "Deathcap Powder",
                    DifficultyCheck = 33,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "10 Minutes",
					MaximumDuration = "6 Minutes",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("101a5abd-b68c-4ec5-92ac-a568358d2eda"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("522e11c6-2156-4c69-8ced-b2ff70428e30"), Damage = "13d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("03e91a70-68d4-4048-b785-2f7c52e1a5ab"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("289600b9-a130-42f0-84eb-9d0875ef6d45"), Damage = "17d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("802df304-2287-4d04-99d6-c5a3dee6eb31"),  ConditionId = Sickened.ID, Severity = 2}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("37604a6a-f8cb-40a2-8ad8-15dc110662f8"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("0927240a-dbdf-41a5-a145-a63234f3398b"), Damage = "20d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("3efd49c0-5197-484d-862d-0f00e9357f5a"),  ConditionId = Sickened.ID, Severity = 3}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8cb1669e-7fdf-4f27-a400-f8436ba40b99"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("9a86260b-1424-4626-9d39-2c0a1937f79e"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("65c90156-eebb-4053-877a-ab1346dc6c6f"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("86e3ce8c-3eaf-4831-8c11-8189517b997d"), Traits.Instances.Ingested.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a2779414-69b9-416c-abda-71ae15fe3b10"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
