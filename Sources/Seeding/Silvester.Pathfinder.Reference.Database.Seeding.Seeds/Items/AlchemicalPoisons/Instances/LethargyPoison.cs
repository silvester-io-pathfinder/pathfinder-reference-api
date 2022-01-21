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
    public class LethargyPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("ed3a6476-d01d-44c9-a3a5-72e753c48be5");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, 
                Name = "Lethargy Poison",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ed3a6476-d01d-44c9-a3a5-72e753c48be5"), "Lethargy poison is commonly used in hit-and-run tactics by drow and others who want their victims alive; the ambusher retreats until the poison sets in and the victim falls unconscious. Further exposure to lethargy poison does not require the target to attempt additional saving throws; only failing an saving throw against an ongoing exposure can progress its stage.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("fea01610-f785-4d1b-a48b-3a64caaf2baa"),
				Name = "Lethargy Poison",
				Level = 2,
				Price = 700,
				Usage = "Held in s hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("b10e5ca2-01b4-42c4-acf3-bff286c4015b"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("0cad04aa-c37a-40ba-bc39-d936c09a63ed"),
				    Name = "Lethargy Poison",
                    DifficultyCheck = 18,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "4 Hours",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("6c9e289f-c6e9-4c1d-bdf8-2f27a8e0f286"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("d465d853-ec47-4dae-8127-12eb28f7772e"),  ConditionId = Slowed.ID, Severity = 1}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("7b554a0b-5001-4e46-98a7-fce18cc80c10"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("d879fa2d-c94f-4800-bea2-dae5fbae818e"),  ConditionId = Slowed.ID, Severity = 1}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("fcad32cd-f3ac-4cb6-a108-f54b16dcbbf9"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("f07abe26-4519-452c-9ede-9e1324f0af60"),  ConditionId = Unconscious.ID},
                                new OtherEffect { Id = Guid.Parse("c6063c4e-4644-4972-baa0-fab5ae0eb0b0"),  Effect = "You cannot Perception check to wake up from unconsciousness."}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("a85df2c1-e5f2-448b-ac85-03c85869417d"),
                            Duration = "1d4 Hours",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("33a4cee8-887e-4b38-b519-1d31ff816a33"),  ConditionId = Unconscious.ID},
                                new OtherEffect { Id = Guid.Parse("a4bc689a-bae6-4049-9da8-b5c4eb8a75b6"),  Effect = "You cannot Perception check to wake up from unconsciousness."}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ca792fe4-4a81-49a9-9c68-b23344d67eee"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("19f4a9f2-da8f-4966-bf53-59e58c5e9f1a"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("23ebe2ad-a968-4b32-90d7-eaf272370a66"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("15e9bf5c-67f9-4c2c-9c8c-ae08a0a9dfbf"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("687ad502-cc30-4864-a07e-5d0a804299b0"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("c8673133-cc92-4852-9bf2-ebbcf57b74dc"), Traits.Instances.Injury.ID);
            builder.Add(Guid.Parse("933db496-ecc3-4b50-8ece-cc0ae12ac4d4"), Traits.Instances.Sleep.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed3a6476-d01d-44c9-a3a5-72e753c48be5"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
