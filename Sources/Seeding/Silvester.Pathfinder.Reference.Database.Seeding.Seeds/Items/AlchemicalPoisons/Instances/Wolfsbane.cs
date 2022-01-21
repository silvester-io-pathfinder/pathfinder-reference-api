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
    public class Wolfsbane : Template
    {
        public static readonly Guid ID = Guid.Parse("25956d4a-b3ee-49fe-9660-b1ee2b67b1de");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Wolfsbane",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e864228b-0a29-43de-bebb-175ea6468573"), "Wolfsbane appears in folklore for its link to werecreatures. If you are afflicted with lycanthropy and survive stage 3 of wolfsbane, you're immediately cured of the lycanthropy.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("a4a0748d-1f48-4473-aa87-7b1003e9f773"),
				Name = "Wolfsbane",
				Level = 10,
				Price = 15500,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("f88f1610-b36e-4b8d-8ff6-464e718f83af"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("43783b7b-56ff-49e0-a0f2-68e83a373918"),
				    Name = "Wolfsbane",
                    DifficultyCheck = 30,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "10 Minutes",
					MaximumDuration = "6 Minutes",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("4e559a7a-d1c2-4c97-841a-56a1133d5dd0"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("2499800c-521f-414e-92f2-5df2fcfafe36"), Damage = "12d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("58e92f10-359f-4c0c-8de8-41b297e185f4"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("a4bc049d-893a-4292-839e-d0930a668b97"), Damage = "16d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("cb73d3c9-853b-403f-ade4-16d27e40bbb8"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("53314a91-0060-4517-8192-fa4fa6cacf74"), Damage = "20d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ab4a4f99-307c-45a4-b8b0-264f60969eff"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("2d402894-1ad5-4fca-a8bc-fd5666e5648c"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("e66956fc-f34b-456f-85bc-297440241376"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("960a31dc-9b28-4640-b67d-b2f053c95427"), Traits.Instances.Ingested.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67140723-8d8e-46a2-8971-c7a5ca9b63f8"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
