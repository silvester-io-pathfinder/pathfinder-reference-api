using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Potions.Instances
{
    public class TruthPotion : Template
    {
        public static readonly Guid ID = Guid.Parse("3b700e2e-4b09-4ba0-a603-2d9c2746c708");

        protected override Potion GetPotion()
        {
            return new Potion
            {
                Id = ID,
                Name = "Truth Potion",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e28949c1-ded4-40d6-9e62-3ebd521022c1"), "An astringent potion that prevents the user from intentionally lying for a short amount of time.");
        }

        protected override IEnumerable<PotionVariant> GetPotionVariants()
        {
            yield return new PotionVariant
            {
                Id = Guid.Parse("09879a55-1b72-4ad6-8ded-3e348c0c6076"),
                Name = "Truth Potion",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 6,
                Price = 4600,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("cf0e30ac-0ec7-4902-b68e-0fb86f40c1cc"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Details(effect => 
                            {
                                effect.Text(Guid.Parse("b75eb145-1aad-42d0-a412-c993f8af6719"), "You can�t intentionally lie and may be compelled to tell the truth for 10 minutes after drinking. Upon drinking the potion, attempt a DC 19 Will save. You can voluntarily fail or critically fail.");
                            })
                            .RollableEffect(Guid.Parse("fd30b319-1f70-47ad-bfca-0710d746a6df"), effect => 
                            {
                                effect.Success("The potion does not affect you.");
                                effect.Failure("When you speak, you must tell the truth.");
                                effect.CriticalFailure("As failure, and when someone asks you a question, you must attempt another DC 19 Will saving throw. If you fail this saving throw, you must answer the question truthfully if you are able to do so; if you succeed, you are temporarily immune to further attempts to ask the same question within the potion�s duration.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("76516480-73cf-4803-998d-de7b98fd3fd3"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("1a31583c-c58c-4861-8922-15178dea43b4"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("3fab2fce-7e25-4c20-9a60-437822bdb671"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d1fc90cc-d238-4dde-bfbb-c8061e612d64"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("28c26d28-498d-4395-a5ea-280b25692abe"), Traits.Instances.Potion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5922f398-a211-489b-9641-edf52904a61f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 564
            };
        }
    }
}
