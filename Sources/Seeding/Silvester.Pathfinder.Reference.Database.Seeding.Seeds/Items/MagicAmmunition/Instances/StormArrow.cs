using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.MagicAmmunitions.Instances
{
    public class StormArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("65d2a7b1-82d1-4780-9f81-23db34520950");

        protected override MagicAmmunition GetMagicAmmunition()
        {
            return new MagicAmmunition
            {
                Id = ID,
                Name = "Storm Arrow",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("789830d6-6efd-4953-af12-aa4fe1eb1289"), "The head of this arrow is made from gleaming copper. When an activated storm arrow hits a target, it is buffeted by raging winds and struck by a bolt of lightning that deals 3d12 electricity damage and the target must attempt a DC 25 Reflex saving throw. If this arrow is shot from a weapon with a shock property rune, the save DC increases to 27, though the attack doesn�t benefit from the shock property rune itself.");
        }

        protected override IEnumerable<MagicAmmunitionVariant> GetMagicAmmunitionVariants()
        {
            yield return new MagicAmmunitionVariant
            {
                Id = Guid.Parse("32e4df80-4c5b-49a1-90ec-f4ce3f095179"),
                Name = "Storm Arrow",
                Level = 9,
                Price = 13000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e11f7f51-8d65-4190-84fc-58557d6e2688"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .RollableEffect(Guid.Parse("cba19260-780d-4466-ad7d-f4673b9c71c9"), effect => 
                            {
                                effect.CriticalSuccess("The foe is unaffected.");
                                effect.Success("The foe takes half damage and isn't affected by the wind.");
                                effect.Failure("The foe takes full damage and is buffeted by winds for 1 round, taking a �2 circumstance penalty to ranged attack rolls and a �10-foot circumstance penalty to its fly Speed.");
                                effect.CriticalFailure("As failure, but the foe takes double damage.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a0193e89-e967-4806-8734-dba9d64e4938"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("d3b1d0d8-03bc-4bc8-a806-74d8778ae23e"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("68a793f2-bf2f-444f-9299-f811e11acbe7"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("afa7a3a8-c90a-4107-9949-8a4f41b98fd0"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("9cd7b397-ca01-4001-9cd7-78927dea20ee"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<Guid> GetCraftableAs()
        {
            yield return Ammunitions.Instances.Arrows.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b41ef942-724d-4616-b3f6-61797b5a7b96"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 560
            };
        }
    }
}
