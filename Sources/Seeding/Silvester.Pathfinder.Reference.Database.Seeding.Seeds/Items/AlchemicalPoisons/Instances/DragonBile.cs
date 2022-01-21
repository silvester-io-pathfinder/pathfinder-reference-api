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
    public class DragonBile : Template
    {
        public static readonly Guid ID = Guid.Parse("b2e3f38f-f570-4cf8-ba74-633bdc0a1405");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Dragon Bile",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f8d404e3-12fb-4647-adb6-60888962e8f2"), "A mix of digestive juices and green dragon poison glands nauseates the victim as its flesh is digested from within.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("f4d52954-57af-4496-b172-6718fd3def72"),
				Name = "Dragon Bile",
				Level = 15,
				Price = 92500,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("b0c0a3b8-8e76-4236-921e-a467d4bb38ef"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("fc20616d-7ba0-49dd-94be-cf547dab680e"),
			    	Name = "Dragon Bile",
					DifficultyCheck = 37,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1 Minute",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("dadede4d-28bb-4cbc-b825-4cd8a7e1901f"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("b81c29ee-7c52-465e-87f7-70c46b8c71fe"), Damage = "6d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("35b50894-a2c7-468e-8ba0-5cd4a107b51e"),  ConditionId = Sickened.ID, Severity = 2}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("6f2a640f-b71e-4c13-a457-17767f74a6d3"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("4c826d4b-41fc-4b85-b43e-e43bd48862d6"), Damage = "7d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("049755e3-4e91-453c-981b-9ee1f657d318"),  ConditionId = Sickened.ID, Severity = 3}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("ecc2dccf-0d82-4d85-b11d-74656cec77c6"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("9877f704-09a9-401a-956d-26533fa67458"), Damage = "9d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                                new ConditionEffect { Id = Guid.Parse("06db10c0-1c72-4baa-80d9-5ddd27243912"),  ConditionId = Sickened.ID, Severity = 4}
                            }
                        }
					}
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("80c004ae-e098-4b2d-9846-7af4e6cfd020"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("a2393e96-52e6-439c-a676-c896396ba3ce"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("d07107a2-cf8d-4b43-8ded-12045187e3be"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("1525da0c-ebde-4790-bfe6-8acba34972ff"), Traits.Instances.Contact.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6713fbf0-18f0-453e-a361-b339aafad6f3"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
