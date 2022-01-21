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
    public class BrimstoneFumes : Template
    {
        public static readonly Guid ID = Guid.Parse("81b07f7b-2e70-4b38-80f7-0b28a4c6f399");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Brimstone Fumes",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5b28e3fa-1348-41cb-ba9f-25f5230e45d3"), "Fumes from the forges of Hell drain health and strength alike.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("eb6f6172-7ca5-4f2a-ac45-a3a56db4036a"),
				Name = "Brimstone Fumes",
				Level = 16,
				Price = 150000,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("32dad4da-698d-4d88-85bf-cf5a32b67556"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("0860cb5f-6bf5-423b-944e-1c4e79802565"),
                    Name = "Brimstone Fumes",
					DifficultyCheck = 36,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1 Round",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("8b833ef5-c504-4580-bee7-b124e0d63981"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("9058f97d-0aac-4d3b-b68c-adb1e8c7f84a"), Damage = "7d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("bb63ec34-7c71-4ac0-bc8b-8b4316f78364"),  ConditionId = Enfeebled.ID, Severity = 1}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("b52f55c1-44e0-479a-8d1e-24cbeb57189e"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("b065f341-8bac-49ee-83a1-87d03f27e66e"), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("488cc010-f4d3-44cc-b0b9-ebbd408c4e5e"),  ConditionId = Enfeebled.ID, Severity = 2}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("8b8011f3-58a5-4e72-9e3f-db705c384bf8"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("2a2a1976-91a5-40dd-b293-db3608f5398c"), Damage = "10d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("8c8ab084-efcb-455d-9029-28b2ac9b3b4c"),  ConditionId = Enfeebled.ID, Severity = 3}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("3f34751d-1c9b-4a3a-8998-bcea628abdd2"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("54884d7a-c3bf-4dc8-ae41-5f604c626c28"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("d53bf6be-750e-4ce3-b4e3-30213cc95d44"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("6ee1a47e-05fd-4021-a4e8-ba9d1c2b9f37"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("f99727c4-1a1e-45f8-9241-7de3877153e2"), Traits.Instances.Inhaled.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0381fe8b-2404-42fb-9abd-74e28f1401d5"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
