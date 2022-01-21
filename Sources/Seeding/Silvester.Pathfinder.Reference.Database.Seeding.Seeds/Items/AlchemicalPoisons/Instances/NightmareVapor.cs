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
    public class NightmareVapor : Template
    {
        public static readonly Guid ID = Guid.Parse("d493d861-70f0-4362-a954-2d0609869352");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Nightmare Vapor",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a7f2675e-38a7-4d2e-bb3f-a893a4538f22"), "Purportedly sourced from any number of outlandish locales, nightmare vapor is most often created by boiling the sweat collected from humanoids caught in the throes of terrible nightmares.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("f546e9ec-02e0-4246-bde8-ac61f6b67eae"),
				Name = "Nightmare Vapor",
				Level = 16,
				Price = 140000,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("6c08467f-4970-4c38-bebe-e8606778e35c"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("a219e285-2d4f-4720-8266-1aefc03cd7ae"),
				    Name = "Nightmare Vapor",
                    DifficultyCheck = 36,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1 Round",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("e229a0be-7872-494f-8b8d-0d9243b55209"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("2fb6cbeb-862a-47d6-8a14-beba496fa865"),  ConditionId = Confused.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("61776e14-9ede-46f4-a06c-159dc5449417"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("e901e773-4ddd-45b3-b08a-dfcfa2df5bf7"),  ConditionId = Confused.ID},
                                new ConditionEffect { Id = Guid.Parse("040091a6-d7c9-4d09-892d-8b47780ad8ba"),  ConditionId = FlatFooted.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("c818b8ed-9c57-4b0e-91be-91d714eb84be"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("a3fe5d9e-596c-4a4c-9bba-15c06efd2771"),  ConditionId = Confused.ID},
                                new ConditionEffect { Id = Guid.Parse("597f934c-9fdc-4b2f-a1e8-22e3b4727bf6"),  ConditionId = FlatFooted.ID},
                                new ConditionEffect { Id = Guid.Parse("4e11fe72-86a4-462a-8e76-fe7a1a29af16"),  ConditionId = Stupefied.ID, Severity = 2}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2ad85492-384b-4626-8179-12425d50be5a"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("b98351db-2051-47d7-84be-3f5744e07f0e"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("0aecbf18-7091-4f33-90b1-7e3feb154119"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("e23e34ed-b34c-463a-a733-ec182070d64a"), Traits.Instances.Inhaled.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbac34ef-0bee-4110-b002-b65aab1130db"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
