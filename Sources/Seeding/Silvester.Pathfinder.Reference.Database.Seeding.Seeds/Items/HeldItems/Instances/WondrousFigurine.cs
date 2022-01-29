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
    public class WondrousFigurine : Template
    {
        public static readonly Guid ID = Guid.Parse("f34b56b6-c3e9-4118-b736-f7e063d411d4");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Wondrous Figurine",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("36097faf-7d0d-4428-958f-05c465672df0"), "Each one of these statuettes is 1 inch in height, carved from a specific material and taking the shape of a particular animal or animals.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("92e9df97-63d4-4071-9d9a-beec77917ec0"),
                Name = "Wondrous Figurine (Golden Lions)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 10,
                Price = 90000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f4f4bd35-6196-4855-8dde-ecd1b3a678b0"), "This statuette depicts a pair of gold lions, and when activated, it becomes a pair of adult lions (Pathfinder Bestiary 52). The lions can be called on only once per day, and they remain in lion form for no more than 1 hour. If either of the lions is slain, that lion cannot be summoned again until 1 week has passed, but this doesn't prevent you from summoning the other.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("24566d1b-4b82-42ed-b850-58f58f106263"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("50dcbb90-e0b1-4ffe-90e0-24e3edfc25a5"), "You activate the statue by placing it on solid ground and then speaking its name, causing the statuette to transform into a pair of living adult lions. In creature form, the figurine has the minion trait. It can understand your language and it obeys you to the best of its ability when you use an action to command it.");
                                details.Text(Guid.Parse("c859ad26-340b-4580-83fc-61f948c9bbcb"), "If the lions are slain while in animal form, it reverts to its statue shape and cannot be activated again until 1 week has passed. If the figurine is destroyed in statue form, it is shattered and its magic is lost.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("2205106b-f6f0-4dc4-8bad-66d87b10f284"),
                Name = "Wondrous Figurine (Jade Serpent)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 7,
                Price = 34000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("663c8fec-eb1d-4e80-a397-fce2d576e67e"), "This tiny statue first appears to be a formless lump of jade until closer inspection reveals it to be a serpentine body curled into a snug knot. When activated, this figurine becomes a giant viper (Pathfinder Bestiary 303). The figurine can be used only once per day, and it can remain in serpent form for no more than 10 minutes.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("2e60c635-fd61-4668-bf69-8fe9e5c772b6"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Frequency("Once per day.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("c0b34490-eec3-445e-a5af-49697fd6ba76"), "You activate the statue by placing it on solid ground and then speaking its name, causing the statuette to transform into a living giant viper (Pathfinder Bestiary 303). In creature form, the figurine has the minion trait. It can understand your language and it obeys you to the best of its ability when you use an action to command it.");
                                details.Text(Guid.Parse("c6b76a9c-cd17-4513-9bf3-2874b558e1e9"), "If the figurine is slain while in animal form, it reverts to its statue shape and cannot be activated again until 1 week has passed. If the figurine is destroyed in statue form, it is shattered and its magic is lost.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("9854330d-fd9e-4326-85be-ef7f37caa79e"),
                Name = "Wondrous Figurine (Marble Elephant)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 13,
                Price = 270000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("14fc2702-1284-4f43-9e07-0e374acc11e4"), "Finely carved from a solid piece of marble, this gleaming elephant statuette becomes a fully grown elephant (Pathfinder Bestiary 154) when activated. The elephant can be called upon no more than four times per month. It remains for 24 hours as long as it is being used as a beast of burden or for transport. If it attempts an attack or otherwise engages in combat, it reverts to statuette form after 1d4 rounds.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d81c353c-1431-4d3e-87ed-134dfbfde7fa"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Frequency("Four times per month.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("a63243b3-1bfc-4a90-a12f-b22b37094799"), "You activate the statue by placing it on solid ground and then speaking its name, causing the statuette to transform into a living fully grown elephant (Pathfinder Bestiary 154). In creature form, the figurine has the minion trait. It can understand your language and it obeys you to the best of its ability when you use an action to command it.");
                                details.Text(Guid.Parse("f5b3160b-fc1b-4b26-b98b-903c1fd54996"), "If the figurine is slain while in animal form, it reverts to its statue shape and cannot be activated again until 1 week has passed. If the figurine is destroyed in statue form, it is shattered and its magic is lost.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("868f5feb-0370-4d39-b081-2e10eb690cea"),
                Name = "Wondrous Figurine (Obsidian Steed)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 15,
                Price = 90000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("beacf925-7640-4558-86ba-9fb1a669af2f"), "This sinister-looking black statuette resembles a horse rearing up on its hind legs. When activated, this figurine becomes a nightmare (Pathfinder Bestiary 244). It can be called upon once per week for up to 24 hours, though it won't use plane shift or its other abilities on behalf of its rider. Although evil, it allows itself to be ridden by creatures of any alignment, although if a good creature mounts it, the rider must attempt a DC 3 flat check. On a failure, the nightmare uses plane shift to take the rider to a random location in the Abyss, where it promptly returns to statue form, stranding its rider in that nightmarish place.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5bcd1989-9d5b-4f8f-8df5-f39135980d09"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Frequency("Once per week.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("edfe3549-12cd-4578-9f28-f02923ee849d"), "You activate the statue by placing it on solid ground and then speaking its name, causing the statuette to transform into a living nightmare (Pathfinder Bestiary 244). In creature form, the figurine has the minion trait. It can understand your language and it obeys you to the best of its ability when you use an action to command it.");
                                details.Text(Guid.Parse("95d351ac-d7e6-4dc2-b971-bb79086fe417"), "If the figurine is slain while in animal form, it reverts to its statue shape and cannot be activated again until 1 week has passed. If the figurine is destroyed in statue form, it is shattered and its magic is lost.");
                            });
                    })
                    .Build()
            };

            yield return new HeldItemVariant
            {
                Id = Guid.Parse("72d0693d-f93f-4776-b762-673652fa4f8f"),
                Name = "Wondrous Figurine (Onyx Dog)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 2,
                Price = 3400,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5488f965-ff10-40a4-9830-d2ed7be59a5b"), "This simple onyx statue transforms into a guard dog (Pathfinder Bestiary 102). The dog has a +4 circumstance bonus to Survival checks to Track, and it has darkvision. When the dog senses a hidden creature with its scent, that creature is instead observed and concealed. The onyx dog can be activated once per week and remains in its form for up to 6 hours.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4e40c282-4e55-4b80-99c5-8b91407e7187"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Frequency("Once per week.")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("7eb62c66-ae3c-47cb-b488-2a2016393f41"), "You activate the statue by placing it on solid ground and then speaking its name, causing the statuette to transform into a living guard dog (Pathfinder Bestiary 102). In creature form, the figurine has the minion trait. It can understand your language and it obeys you to the best of its ability when you use an action to command it.");
                                details.Text(Guid.Parse("c923d41c-4e9e-4788-bf5d-aabc765b438a"), "If the figurine is slain while in animal form, it reverts to its statue shape and cannot be activated again until 1 week has passed. If the figurine is destroyed in statue form, it is shattered and its magic is lost.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f90285b8-f8da-480e-8f2c-5c6630883d08"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("58278a74-7d39-4b0c-95f3-0553fa725528"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64babd42-dbbe-4f81-bcc3-13b7d74562ab"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 576
            };
        }
    }
}
