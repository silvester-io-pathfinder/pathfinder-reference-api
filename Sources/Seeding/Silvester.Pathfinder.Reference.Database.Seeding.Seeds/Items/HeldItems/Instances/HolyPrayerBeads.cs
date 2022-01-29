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


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.HeldItems.Instances
{
    public class HolyPrayerBeads : Template
    {
        public static readonly Guid ID = Guid.Parse("a8bdc57c-3c15-4efe-9b4f-b0fee4ac7875");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Holy Prayer Beads",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e3c6a8fc-6c5a-4851-b602-4a9d618b23b4"), "This strand of ordinary-looking prayer beads glows with a soft light and becomes warm to the touch the first time you cast a divine spell while holding it. When you do, the prayer beads become attuned to your deity, changing their form and iconography to prominently incorporate your deity's religious symbol and iconography. The beads don't transform or function for an evil spellcaster.");
            builder.Text(Guid.Parse("75fa0365-2350-4775-99de-622484b08dee"), "Whenever you cast a divine spell from your own spell slots while holding the prayer beads, you recover 1 Hit Point; this is a positive healing effect. If the spell you cast was a healing spell, you can grant this additional healing to one of the spell's targets instead of yourself.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("b351ed78-34ad-42f7-8530-b2295cc2191e"),
                Name = "Holy Prayer Beads",
                Usage = "Held in 1 hand.",
                CraftingRequirements = "You have a spellcasting class feature with the divine tradition.",
                Hands = "1",
                Level = 5,
                Price = 16000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("82ac0118-149b-4602-8179-bd46f6a56f34"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("417d8197-e349-4a38-80f7-301c92f3351e"), "Cast Bless.");
                            });
                    })
                    .Add(Guid.Parse("e180be00-7e39-4129-98d2-6338f10b0af2"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("676eb8ee-de6c-4a91-a9ba-c62a215f717c"), "Cast Heal.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("1af7de76-ac2c-4ebb-aecd-4b9980235167"),
                Name = "Holy Prayer Beads (Greater)",
                Usage = "Held in 1 hand.",
                CraftingRequirements = "You have a spellcasting class feature with the divine tradition.",
                Hands = "1",
                Level = 11,
                Price = 140000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("7268dffd-b963-4525-afa1-52ae47d371fb"), "You recover 1d4 Hit Points instead of 1 Hit Point when casting divine spells from your spell slots. Change the beads' list of spells to the 4th-level versions of bless, divine wrath (matching one component of your deity's alignment), heal, neutralize poison, and remove disease. You can cast each of these once per day.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fbebb7c1-b400-4dea-8782-73f5e9a22131"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("f2145fcd-4e88-42f3-a3ff-d3754f133001"), "Cast a 4-th level Bless.");
                            });
                    })
                    .Add(Guid.Parse("e86e8866-24bd-4f51-b974-2eb23974e59f"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("5d2827aa-5217-4756-a809-e312ca6a31ad"), "Cast Heal.");
                            });
                    })
                    .Add(Guid.Parse("27ec50f0-c998-4799-98e7-3b67630bcd1c"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("f8e63027-42c3-4e2f-83d7-e5fa98185218"), "Cast Divine Wrath (matching one component of your deity's alignment).");
                            });
                    })
                    .Add(Guid.Parse("e54e8de0-a427-4980-9ca3-5687cee143e6"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("c6fc3d38-f92f-4e1b-95ba-09a7328a8d34"), "Cast Neutralize Poison.");
                            });
                    })
                    .Add(Guid.Parse("3836625f-5357-4e5b-951c-bd05003514ce"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("83167ba1-608e-4cdf-b4af-c3712bc389f6"), "Cast Remove Disease.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f4bf9622-b364-45c4-86d6-e1571d651c8b"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("8a8c5750-b8fe-4405-bc4e-f532ee024d32"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("7e9ba31b-18d9-4365-b330-3731a27a43ae"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("f33ca53b-a0e5-4b94-88b1-be98fbc8ea63"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34bbe66d-17c6-46b2-a0e4-4214e6e21774"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 573
            };
        }
    }
}
