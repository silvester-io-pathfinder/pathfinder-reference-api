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
    public class NettleweedResidue : Template
    {
        public static readonly Guid ID = Guid.Parse("427af463-394a-423e-be07-d4788fc27ec7");

        protected override AlchemicalPoison GetAlchemicalPoison()
		{
			return new AlchemicalPoison
			{
				Id = ID,
                Name = "Nettleweed Residue",
			};
		}

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a7391054-edfc-4951-8efc-8b995fde8148"), "Concentrated sap of stinging weeds makes an effective toxin.");
        }

        protected override IEnumerable<AlchemicalPoisonVariant> GetAlchemicalPoisonVariants()
		{
			yield return new AlchemicalPoisonVariant
			{
				Id = Guid.Parse("9fb964e0-7601-4f87-abd5-5bc9c4f9ef7f"),
				Name = "Nettleweed Residue",
				Level = 8,
				Price = 7500,
				Usage = "Held in 2 hands",
				BulkId = Bulks.Instances.LightBulk.ID,
				RarityId = Rarities.Instances.Common.ID,
				InlineActions = new InlineActionCollectionBuilder()
					.Add(Guid.Parse("6a226b33-ed41-4232-9949-f0b1fa46cfc3"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
					{
						action.Kind("Interact");
					})
					.Build(),
				PoisonEffect = new StaggeredEffect
				{
					Id = Guid.Parse("990ea5c3-22bc-4c51-9aca-c533e5bddd88"),
                    Name = "Nettleweed Residue",
                    DifficultyCheck = 27,
					SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
					Onset = "1 Minute",
					MaximumDuration = "6 Minutes",
					Stages = new List<StaggeredEffectStage>
					{
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("12cf4b7b-4c31-43de-b96f-9b8d1999ecf3"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("452e8475-cdf0-44a4-ba16-09560013f210"), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("a8c16f0b-6882-4350-8778-9a5c81b30693"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("7837cfb0-e1b7-49d1-974b-e54579663570"), Damage = "10d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        },
                        new StaggeredEffectStage
                        {
                            Id = Guid.Parse("eecd7522-686e-4a45-8171-dfdd005905b6"),
                            Duration = "1 Minute",
                            Effects = new StaggeredEffectStageEffect[]
                            {
                                new DamageEffect { Id = Guid.Parse("eecd7522-686e-4a45-8171-dfdd005905b6"), Damage = "13d6", DamageTypeId = DamageTypes.Instances.Poison.ID},
                            }
                        }
                    }
				}
			};
		}

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("84702258-6dd5-42c2-99f5-c70cdf7086b3"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("bd3e8363-8560-4275-a3a5-266c41f4d694"), Traits.Instances.Poison.ID);
            builder.Add(Guid.Parse("2e232578-fb3c-49d6-98a9-f155df86df33"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("cf5e5a20-0ba0-42fa-a3a8-1693615c23fd"), Traits.Instances.Contact.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d82d7b7d-f861-463d-ba6a-a5f4f331484c"),
                SourceId = CoreRulebook.ID,
                Page = 553
            };
        }
    }
}
