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
    public class CytilleshOil : Template
    {
        public static readonly Guid ID = Guid.Parse("0381fe8b-2404-42fb-9abd-74e28f1401d5");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID, Name = "Cytillesh Oil",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("062e4990-d0b3-4931-9ee3-ede80d54ec72"), "This thick substance is distilled from the mind-robbing cytillesh fungus, though it lacks memory-altering capabilities.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("c8832100-95a1-447c-ac4b-0f0f9b78e0db"),
				Name = "Cytillesh Oil",
				Level = 3,
				Price = 1000,
				Usage = "Held in 1 hand",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("5302759d-dad8-42db-ac6a-dee1ecd77758"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("92a84c99-95e2-4602-8a72-437137c69613"),
                    Name = "Cytillesh Oil",
					DifficultyCheck = 19,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "Immediate",
					MaximumDuration = "4 Rounds",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("f7235d2a-9724-4360-985b-839bab8513c3"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("b735be5c-1040-403f-acfa-6f366435b546"), Damage = "1d10", DamageTypeId = DamageTypes.Instances.Poison.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("b3de3810-a480-4f26-9d10-b1ef0e16928e"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("6bb797d7-f7bc-4cb7-bde0-a40a77485bb1"), Damage = "1d12", DamageTypeId = DamageTypes.Instances.Poison.ID}
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("8b095b9c-c427-4860-8b1a-d012207e6877"),
                            Duration = "1 Round",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("a6a8aa11-5936-4b59-8935-ddfbc34ce833"), Damage = "2d10", DamageTypeId = DamageTypes.Instances.Poison.ID}
                            }
                        }
					}
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("4572a844-4382-4432-914a-a6f08b01ec44"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("1de4f365-20d0-4840-a9f6-d2bcf5c6c0cf"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("df1a1021-7602-4baa-ad59-134113a616ba"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7156a518-fb39-47b8-9579-72db434fac68"),
                SourceId = CoreRulebook.ID,
                Page = 551
            };
        }
    }
}
