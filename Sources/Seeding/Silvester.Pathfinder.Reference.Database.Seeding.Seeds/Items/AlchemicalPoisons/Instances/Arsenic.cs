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
    public class Arsenic : Template
    {
        public static readonly Guid ID = Guid.Parse("7b9ae413-e4eb-4d41-be02-148aca65a38a");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Arsenic",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ab9af6c8-886c-4cc4-8347-d5d5b6c520e5"), "This toxin is a compound of arsenic and other substances. You can't reduce your sickened condition while affected.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("6e10d0aa-d9df-463f-9b4d-6e8f62e06611"),
				Name = "Arsenic",
				Level = 1,
				Price = 300,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("bbe5e1ba-aed9-44fb-a7e8-cc9467c91eba"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("37764fda-a770-40e6-98e5-1207002f7708"),
					Name = "Arsenic",
                    DifficultyCheck = 18,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "10 Minutes",
					MaximumDuration = "5 Minutes",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("0468236a-951d-4f4b-ba55-9677d2872063"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("0bf453a8-ad63-4059-a589-a47a771a388a"), ConditionId = Sickened.ID, Severity = 1},
                                new DamageEffect {Id = Guid.Parse("901de562-81e9-4a7a-ad10-cc865341ed13"), Damage = "1d4", DamageTypeId = DamageTypes.Instances.Poison.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("3abafdfd-bb76-4211-8bd2-733116b08360"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("3af0f5a8-e26c-4328-8bfd-586297d76416"), ConditionId = Sickened.ID, Severity = 2},
                                new DamageEffect {Id = Guid.Parse("c27b7d34-8fa2-4373-9c8d-5c042e168fe1"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("39bc0f47-bd42-488e-bb8c-bbd82bc20771"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("aad3acd9-12b3-4aec-ae90-c5f96235837e"), ConditionId = Sickened.ID, Severity = 3},
                                new DamageEffect {Id = Guid.Parse("9a349ef1-5a02-4309-a095-d298f879328d"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("139b65f5-940f-42f3-afb8-3dca606fafba"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("363ac7ed-55a9-4546-8a9d-9b9b419b5cd1"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("b0dfcf07-c222-48e0-a70a-f69f4353c692"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("0f4c70f0-72f2-4f0e-8dca-ffcc019233d6"), Traits.Instances.Ingested.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c09132c-90a6-4d8f-a62e-64faf7f8ffca"),
                SourceId = CoreRulebook.ID,
                Page = 550
            };
        }
    }
}
