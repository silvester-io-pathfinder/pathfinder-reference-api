using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
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
    public class StuporPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("b03092e0-3539-44e8-9e1f-50ea5f9b5474");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, 
                Name = "Stupor Poison",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("6cdf0a09-7f23-452e-b4e5-f9b6ed094d8e"), "Stupor poison is a more potent distillation of lethargy poison. Further exposure to stupor poison doesn't require the target to attempt additional saving throws; only failing a saving throw against an ongoing exposure can progress its stage.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("6399ef8a-4b98-4755-8138-925c32236708"),
				Name = "Stupor Poison",
				Level = 4,
				Price = 1600,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Uncommon.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("66911b8c-c323-4efb-9dd3-53166327ef48"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("ff938733-1ac5-4858-967e-5152b276c90e"),
					Name = "Stupor Poison",
                    DifficultyCheck = 20,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "6 Hours",
					Stages = new List<StaggeredEffectStage>
                    {
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("907eb246-83c8-4cbb-b0e6-89df437cf467"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("4c33f60b-9116-457d-a0b8-f9e3821f019f"), ConditionId = Conditions.Instances.Slowed.ID, Severity = 1},
                                new ConditionEffect { Id = Guid.Parse("58ebf3d6-43fb-443a-a3bc-e4bee7d93b83"), ConditionId = Conditions.Instances.FlatFooted.ID, Severity = 1},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("411f871e-a97e-4743-8934-1a34246f37c4"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("31cc516b-ccc6-4043-88f2-6687ff1a99a6"), ConditionId = Conditions.Instances.Slowed.ID, Severity = 2},
                                new ConditionEffect { Id = Guid.Parse("f69b4c45-5090-4d51-b6dd-caf590bd4e49"), ConditionId = Conditions.Instances.FlatFooted.ID, Severity = 1},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("fc90cece-a326-4726-b22f-7d1d9c22f21f"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new OtherEffect { Id = Guid.Parse("36d2c346-6ace-4e6c-ab81-148dc90ef6ed"), Effect = "Unconscious with no Perception check to wake up."},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("48232750-afbc-42a6-850c-13c7d17129f0"),
                            Duration = "1d6 Hours",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new OtherEffect { Id = Guid.Parse("77c87086-2ef4-442a-a19e-a48a5b74b34c"), Effect = "Unconscious with no Perception check to wake up."},
                            }
                        },
                    }
				}
			};
		}
        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("c47f6aa2-651e-4d94-9981-2f347f9a96f4"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("ea2cdb60-15b0-48fa-8e35-4865da4daef8"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("ad8cd9b3-f541-4061-a02f-930738e0b354"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("1f79304b-0333-4890-8627-ee837a4a7b3d"), Traits.Instances.Injury.ID);
            builder.Add(Guid.Parse("a0213da3-7cb0-49ea-ae5d-5a7139c4f901"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("5453a774-5c68-4a28-b9f5-036aa1edba2c"), Traits.Instances.Sleep.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35fed6f5-ef5f-433d-8272-9ab7b5901b0c"),
                SourceId = Sources.Instances.Pathfinder165.ID,
                Page = 74
            };
        }
    }
}
