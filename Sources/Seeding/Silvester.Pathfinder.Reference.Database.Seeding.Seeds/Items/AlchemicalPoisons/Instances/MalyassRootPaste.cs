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
    public class MalyassRootPaste : Template
    {
        public static readonly Guid ID = Guid.Parse("aef8461a-019a-4c5e-baeb-949f8ebd6e66");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Malyass Root Paste",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("42d4e1ff-92b4-4153-b3eb-42ea8d70eb41"), "Malyass root paste sees use to impede opponents in athletic competitions, in addition to espionage and tracking.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("56f1dcdd-564f-4b95-a3b0-71c58eb4a404"),
				Name = "Malyass Root Paste",
				Level = 7,
				Price = 5500,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("afa6f9d8-300f-4f2b-807a-753aa4970b26"), ActionTypes.Instances.ThreeActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("f18a5fc7-e53f-4851-a988-735d5a61129f"),
				    Name = "Malyass Root Paste",
                    DifficultyCheck = 26,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1 Minute",
					MaximumDuration = "6 Minutes",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("21b5eabd-aff1-436f-a501-1b825aecb69b"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("65f8e81b-a1a5-4e2e-8438-3a916d6db650"),  ConditionId = Clumsy.ID, Severity = 1},
                                new ConditionEffect { Id = Guid.Parse("88e24d10-6b18-47b2-88fb-767470c877b4"),  ConditionId = WeighedDown.ID, Severity = 10},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("0919e98f-4b60-4afe-9097-d5a5810e00b3"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("9b240dfe-79d6-4bc6-a125-6c270dab633b"),  ConditionId = Clumsy.ID, Severity = 2},
                                new ConditionEffect { Id = Guid.Parse("9ef1187a-3825-4bd4-a0b6-b3bf8ebcd19d"),  ConditionId = WeighedDown.ID, Severity = 20},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("8c04d178-f441-4fcc-82f4-57f97ab22b9d"),
                            Duration = "4 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("a7046f36-0812-481c-8e53-45d094d2608a"),  ConditionId = Clumsy.ID, Severity = 3},
                                new ConditionEffect { Id = Guid.Parse("1f198a30-8ab5-4d93-8750-cca7e6c55141"),  ConditionId = FlatFooted.ID},
                                new ConditionEffect { Id = Guid.Parse("cf5f02ee-0a44-4991-a7b6-454880d2d97a"),  ConditionId = WeighedDown.ID, Severity = 30},
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("9a35daa9-ecdc-45f3-bfcd-688baf9ca5c6"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("b4f77c13-88c8-46bd-976e-1a18e0702a65"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("213e7608-0b69-489c-b087-ad94b1b8e831"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("905e2305-350d-4e95-8f53-addab6ae1d0c"), Traits.Instances.Contact.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2597f652-2268-4bd5-b1c3-73d4f6df3656"),
                SourceId = CoreRulebook.ID,
                Page = 552
            };
        }
    }
}
