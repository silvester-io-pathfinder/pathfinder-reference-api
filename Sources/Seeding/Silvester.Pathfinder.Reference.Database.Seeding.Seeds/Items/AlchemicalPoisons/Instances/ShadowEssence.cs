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
    public class ShadowEssence : Template
    {
        public static readonly Guid ID = Guid.Parse("eec5e097-c60a-4a1d-91d3-57bcf30e6a31");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Shadow Essence",
			};
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("44e8074e-5cc8-46f9-8829-7ab92e42f176"), "Distilled from the Plane of Shadow, this oily substance imposes tenebrous effects. The enfeebled condition from shadow essence lasts for 24 hours.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("9670f698-71bf-4cc5-8c08-a492dc3fbcc6"),
				Name = "Shadow Essence",
				Level = 10,
				Price = 16000,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("c677809f-7b5d-4b40-bb40-a179c1fc9a5f"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("91536163-f5f3-4666-b738-76b88e8feab3"),
				    Name = "Shadow Essence",
                    DifficultyCheck = 29,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("4fb01e13-3147-4cd2-ae48-b4b406a65b0a"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("255f40bb-16a3-455a-b558-e7238bc000e2"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                                new DamageEffect { Id = Guid.Parse("024061f6-ed08-4d12-a9f4-7e547d19e40b"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("9dafbeca-1a1b-42b5-b5bc-47186caf8647"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("21af795d-bfb1-477c-b893-3724811eaeed"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                                new DamageEffect { Id = Guid.Parse("76970863-6b34-4ea4-8779-4d894597688b"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("9bed9e22-354a-4d24-ae9a-4d3d9bee650f"),  ConditionId = Enfeebled.ID, Severity = 1}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("a15a472e-00c7-49d1-961c-3653286ac3d4"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("1cff677e-5a7a-4cd1-9ee7-1151cf963153"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                                new DamageEffect { Id = Guid.Parse("b28d1d65-738b-4537-a4dc-b4ae742f7b3c"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("42f240f3-d15d-46a4-a5ec-bc3777948cfe"),  ConditionId = Enfeebled.ID, Severity = 2}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fd35fa7f-ed5b-439f-8622-540ce4b4615c"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("d692a4b8-7057-46c6-bd39-c025cd8852ca"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("72243325-2ed0-498b-ad4a-be31b976e6d7"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("2e8d0f70-9c39-443a-8f4d-85fd775e78ba"), Traits.Instances.Injury.ID);
            builder.Add(Guid.Parse("c7eb950e-70c5-402c-824f-b18837de69e4"), Traits.Instances.Negative.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fde5577d-2503-4d43-928a-228fcc34d11f"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
