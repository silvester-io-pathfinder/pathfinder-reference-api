using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class AeonStone : Template
    {
        public static readonly Guid ID = Guid.Parse("c5d22329-2e84-49f5-8a52-d09b4f07284e");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Aeon Stone",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("79c83544-47f7-4863-bd50-39bc017f6c8a"), "Over millennia, these mysterious, intricately cut gemstones have been hoarded by mystics and fanatics hoping to discover their secrets. Despite their myriad forms and functions, these stones are purportedly all fragments of crystal tools used by otherworldly entities to construct the universe in primeval times.");
            builder.Text(Guid.Parse("c76d84f4-eb84-44f5-8840-7c3c0215b9f7"), "When you invest one of these precisely shaped crystals, the stone orbits your head instead of being worn on your body. You can stow an aeon stone with an Interact action, and an orbiting stone can be snatched out of the air with a successful Disarm action against you. A stowed or removed stone remains invested, but its effects are suppressed until you return it to orbit your head again.");
            builder.Text(Guid.Parse("acfb6b74-aaeb-4c8e-8889-13d4c6e911e7"), "There are various types of aeon stones, each with a different shape, color, and magical effect. Each aeon stone also gains a resonant power when slotted into a special magical item called a wayfinder (page 617).");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a7e17394-213b-44a5-8e6f-7d7eb23d8b9b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("88fa2f1b-46b6-4c01-a756-91347fc659b2"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("83b2ca8e-c608-495f-a444-c06b30ca8493"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("ea54db39-1063-4c94-9ed1-c6b50bc239c3"), Traits.Instances.Transmutation.ID);
        }
       
        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("d568a146-333f-4242-8516-7458d2f591ce"),
                Name = "Clear Spindle",
                Usage = "Worn.",
                Level = 7,
                Price = 32500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("1bda9557-5263-4f60-a9a7-246517d9c916"), "You don't need to eat or drink while this aeon stone is invested by you. This aeon stone doesn't function until it has been worn continuously for a week and invested each day therein. If it�s invested by someone else, this interval starts over.")
                    .Text(Guid.Parse("cb1d7334-8295-4f2b-a2eb-7c4e251a771a"), "The resonant power allows you to cast air bubble as a primal innate spell once per day.")
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("e22f1584-246e-42de-8a29-91221b0a91cc"),
                Name = "Dull Gray",
                Usage = "Worn.",
                Level = 1,
                Price = 900,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c6d54c95-409c-485d-b935-46da0eae9e6b"), "A dull gray aeon stone has lost its special magical properties, sometimes as a result of overusing a tourmaline sphere or pale lavender ellipsoid aeon stone. It still orbits your head like any other aeon stone and can thus serve as a stylish, hands-free option for various spells that target an object, like continual flame.")
                    .Text(Guid.Parse("b817ed63-e1cd-413a-a9c4-ee924a04cd80"), "Dull gray aeon stones have no resonant power.")
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("65e77cdb-7d1f-4363-9160-93e9ad27defc"),
                Name = "Gold Nodule",
                Usage = "Worn.",
                Level = 6,
                Price = 2300,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c398b921-9650-4efc-b661-2ac2076dc89f"), "When a gold nodule aeon stone is created, its creator chooses a language they know to store within the crystal. When you invest the stone, you gain the ability to understand, speak, and write that language.")
                    .Text(Guid.Parse("8f416852-f18a-41e0-8d85-d0826ee63386"), "The resonant power allows you to cast comprehend language as an occult innate spell once per day.")
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("6c3620fa-4968-49e8-a3d5-89f7669ab100"),
                Name = "Lavender and Green Ellipsoid",
                Usage = "Worn.",
                Level = 19,
                Price = 3000000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("e79c40ab-e8a7-4f99-855c-0cf41e3ffe2f"), "This functions as a pale lavender ellipsoid aeon stone, but it casts an 8th-level dispel magic spell with a counteract modifier of +31.")
                    .Text(Guid.Parse("99bb1c4b-b290-4bcd-bae6-fd9a0e26ea17"), "The resonant power allows you to cast detect magic and read aura as arcane innate spells at will.")
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("eea10e1d-248c-40db-8cc2-efd4d1328536"),
                Name = "Orange Prism",
                Usage = "Worn.",
                Level = 16,
                Price = 975000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("b09e8b5e-eec9-41b6-98d5-aaea52df30b5"), "An orange prism aeon stone must be activated to provide a benefit. The resonant power grants you a +2 item bonus to Arcana, Nature, Occultism, or Religion checks�whichever corresponds to the tradition of the last spell you enhanced with this aeon stone.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e835b6f3-2efb-42e8-b41e-e9215036b229"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Details(effects =>
                            {
                                effects.Text(Guid.Parse("b5373956-dda0-405a-a4da-1dfa1122aa9f"), "If your next action is to Cast a Spell, that spell�s level is 1 higher (maximum 10th level) for the purposes of counteracting and being counteracted.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("1d3b4a49-4214-4a9c-bdaa-20d5a3089a10"),
                Name = "Pale Lavender Ellipsoid",
                Usage = "Worn.",
                Level = 13,
                Price = 220000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("25fefdf2-29d2-47d2-b208-2044f1890beb"), "This aeon stone must be activated to provide a benefit. The resonant power allows you to cast the read aura cantrip as an arcane innate spell.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8c6b6225-3412-42ca-af80-6a766054bdc9"), ActionTypes.Instances.Reaction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Trigger("A spell targets you.")
                            .Frequency("Once per day.")
                            .Details(effects =>
                            {
                                effects.Text(Guid.Parse("8225fae5-3ea7-4952-bfd1-4d49aa6331cb"), "The stone casts a 6th-level dispel magic spell in an attempt to counteract the triggering spell, with a counteract modifier of +22. This can be used only on spells that specifically target you�not area spells that don�t have targets. If it succeeds, it counteracts the spell for all targets if other creatures were targeted in addition to you. Each time you activate this aeon stone, attempt a DC 5 flat check. On a failure, the stone permanently turns into a dull gray aeon stone.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("bd286bde-325b-4328-aa24-4b58f3b69f00"),
                Name = "Pink Rhomboid",
                Usage = "Worn.",
                Level = 12,
                Price = 190000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("77260d47-48a9-4f7d-9146-1e38cff5359b"), "When you invest this stone, you gain 15 temporary Hit Points. If the stone�s effects are suppressed, you lose any of the temporary Hit Points remaining until it returns. The temporary Hit Points refresh during your daily preparations; they do not refresh if you re-invest the stone, or invest another pink rhomboid aeon stone, before then. The resonant power allows you to cast the stabilize cantrip as a divine innate spell.")
                    .Build(),
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("ae821639-f7d6-4c6a-8f58-bbc8d1b52aca"),
                Name = "Tourmaline Sphere",
                Usage = "Worn.",
                Level = 7,
                Price = 35000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ebc2527c-7623-4fee-86b4-9f0825e72aed"), "When you would die from the dying condition (typically at dying 4), this aeon stone automatically activates and reduces your dying value to 1 less than would normally kill you (typically to dying 3). The stone then permanently turns into a dull gray aeon stone. You can benefit from this ability only once per day, even if you have multiple such stones.")
                    .Text(Guid.Parse("df7a7943-db66-49ad-866a-6b1131a4e063"), "The resonant power allows you to cast 1st-level heal as a divine innate spell once per day.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f8ded443-4689-4d1f-a8c1-5ac8fa66390c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 605
            };
        }
    }
}
