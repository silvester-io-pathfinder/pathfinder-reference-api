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
    public class GiantScorpionVenom : Template
    {
        public static readonly Guid ID = Guid.Parse("7b143b21-75a9-4d41-9c09-1e4a872526b9");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Giant Scorpion Venom",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("39eeb491-4cff-4764-89d2-9ce910775200"), "Scorpion venom is excruciating and its effects are somewhat debilitating.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("8ffbfccf-6a12-4e13-a673-0d1280ff9a9c"),
				Name = "Giant Scorpion Venom",
				Level = 6,
				Price = 4000,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("0cbf9721-ba85-45f6-baba-bfefb2f7bd0b"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("330553c5-7739-45cd-b99e-0f3bd85d5f8d"),
				    Name = "Giant Scorpion Venom",
					DifficultyCheck = 22,
                    SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("89bdb239-6d05-463b-8cba-8139bc50e0f9"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("14fb278e-8a07-4a78-ba04-76ba5cea9530"), Damage = "1d10", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("96174e93-daf0-457c-8122-33dad6e29aaf"),  ConditionId = Enfeebled.ID, Severity = 1}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("6cbcf457-9203-44fb-a882-4c0886e3c735"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("ea08a570-60de-4df2-8527-9f7788b5ecf3"), Damage = "2d10", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("c442ad47-f2f7-40e9-86c4-536f0fad0912"),  ConditionId = Enfeebled.ID, Severity = 1}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("e57dcb4e-11ad-4431-8638-776ee1bf0b24"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("8d5e5a88-1588-47aa-8564-6113fffbebc5"), Damage = "2d10", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("8885ee16-dcd3-4d91-bd14-8c6aa1c36326"),  ConditionId = Enfeebled.ID, Severity = 2}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("987e07fe-73ac-48ea-8787-69f7cdc9c4e6"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("8fb4671d-40b4-441d-90a2-ba3f0e9dcf02"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("60463bc8-8f22-49f9-95b0-fca164d45133"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("fef20874-6f90-4e5e-84ee-2cc6d3cbd9e6"), Traits.Instances.Injury.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4412b0d-a84d-4bc3-9430-41e015d7632b"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
