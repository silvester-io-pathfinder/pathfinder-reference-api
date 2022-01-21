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
    public class MindfogMist : Template
    {
        public static readonly Guid ID = Guid.Parse("c55ad542-1fba-49e6-ab84-f95050cc3d7f");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Mindfog Mist",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("765ca329-35c6-4f20-8d10-000b35ce1a78"), "Mindfog mist can be used to undermine spellcasters, as its effect on a victim's mental faculties are swift and powerful.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("7b3ccef4-e283-4933-afaf-547526398985"),
				Name = "Mindfog Mist",
				Level = 15,
				Price = 100000,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("bde8ef66-b5a5-4631-add8-4da1fc5267d4"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("478475fe-cd71-477d-a01b-3320f4aa4a32"),
				    Name = "Mindfog Mist",
                    DifficultyCheck = 35,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1 Round",
					MaximumDuration = "6 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("bbdcbd62-49d6-44fe-8bbd-dbb3af8335a0"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("bddebbfc-cc35-4a5e-b652-c0f9a83c3f49"),  ConditionId = Stupefied.ID, Severity = 2}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("ae0e2c13-d597-404b-a347-3022ee522878"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("69312c8d-fa78-4abc-8090-11990a49fbbc"),  ConditionId = Confused.ID},
                                new ConditionEffect { Id = Guid.Parse("d6ffe1a6-0373-4e2d-bc65-256555bbdf30"),  ConditionId = Stupefied.ID, Severity = 3}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("e3c7e67f-fac6-44bc-bca2-4e305a383db2"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new ConditionEffect { Id = Guid.Parse("07c4bb2b-a1b8-4497-bcaf-edd83a10e826"),  ConditionId = Confused.ID},
                                new ConditionEffect { Id = Guid.Parse("af7c7592-da0a-4afa-9a97-4a9fbe98f219"),  ConditionId = Stupefied.ID, Severity = 4}
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fccf57c2-0d58-4609-959a-cd0a1ff4f392"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("156f1586-7660-4d97-8789-e97896d68335"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("7d5b1785-ab46-4841-a6b9-1281eeb0d07b"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("441f5b1f-c811-468b-a1ae-a45de6ca02b0"), Traits.Instances.Inhaled.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d06a375-4a3e-4487-95c1-5d207d5f98b0"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
