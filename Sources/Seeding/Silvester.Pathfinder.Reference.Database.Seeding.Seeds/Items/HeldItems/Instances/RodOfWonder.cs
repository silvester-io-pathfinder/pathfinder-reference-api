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
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.HeldItems.Instances
{
    public class RodOfWonder : Template
    {
        public static readonly Guid ID = Guid.Parse("d4c2a225-b4d4-45a6-9574-d027b57438ba");
        
        protected override HeldItem GetHeldItem()
        {
            return new HeldItem
            {
                Id = ID, 
                Name = "Rod of Wonder",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("79e2edbd-e40f-4cc4-a30e-cdf5abcfbbcb"), "This peculiar rod is strange and unpredictable. Each time it is activated, it produces one of a variety of effects at random.");
        }
       
        protected override IEnumerable<HeldItemVariant> GetHeldItemVariants()
        {
            yield return new HeldItemVariant
            {
                Id = Guid.Parse("54461ac0-803c-49ff-a3ca-5289ec43770f"),
                Name = "Rod of Wonder",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 8,
                Price = 46500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1a319713-5b41-4bfc-9152-af2740975587"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("ef07d906-4123-470c-b6a7-54d54f960522"), "Choose a creature within 60 feet and roll d% on the table below to determine the rod�s effect. If an entry lists only a spell name, the rod casts that spell at its lowest level. You make any decisions for a spell cast by the rod unless otherwise indicated, except that it must target the creature you chose, or the creature you chose must be the center of the spell�s area, if it has an area but no targets. If the spell�s range is less than 60 feet, increase the range to 60 feet.");
                                details.Text(Guid.Parse("2eac0609-b90a-470f-ac0c-bc7c8493f299"), "Any spell DC required is DC 27, and any spell attack roll required is +17. If the rod casts a spell on you, you don�t get a saving throw or other defense against it.");
                                details.Text(Guid.Parse("d09438fd-3a2b-4147-8132-de62a45e860b"), "The rod can�t be activated again for 1d4 hours.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("fab7869d-1ebd-4771-b1a4-6a571f3cbc4c"), Traits.Instances.Chaotic.ID);
            builder.Add(Guid.Parse("b56ffc48-d5dc-4edd-8268-cd829ea140ed"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("00edadac-f021-4edf-895a-a949c01ce793"), Traits.Instances.Magical.ID);
        }

        protected override Table GetTable()
        {
            return new TableBuilder(Guid.Parse("8c0a1a50-1171-445c-9947-1370abc3e66c"))
                .AddColumn("b54771a0-9603-4c14-9540-484bb610a4e7", "d%")
                .AddColumn("d0931777-2050-4dd4-8f66-ec2a73de742b", "Wondrous Effect")
                .AddRow("765d4594-b36f-4951-ae35-325ba3e2087b", row =>
                {
                    row
                        .AddCell("68b6cc26-c0f1-4201-a81e-27c39a3fd6ab", "1-3")
                        .AddCell("88dbbe56-7fb4-4323-9e83-672e8121e059", "Leaves grow from the target; they last 24 hours.");
                })
                .AddRow("d33ca25e-cee8-481a-8caa-6c0ab3c38890", row =>
                {
                    row
                        .AddCell("e30f4e59-dbc3-48cb-a258-b6ee702b17b4", "4-8")
                        .AddCell("c9ebb102-aa2a-402e-964b-04a21d3f7c85", "Darkness");
                })
                .AddRow("9af772a3-0aeb-46f6-a640-36867f595798", row =>
                {
                    row
                        .AddCell("89c6dd7a-72b8-49ee-bfdc-e8cc462e5acd", "9")
                        .AddCell("40cf58d6-95ca-4c16-bbf3-96f8a0e8aea7", "Summon a giant stag beetle (5th-level summon animal; Pathfinder Bestiary 41).");
                })
                .AddRow("8cebe13e-b869-4ce6-a1ed-a7f1d2d78c23", row =>
                {
                    row
                        .AddCell("46394c42-aecf-49de-87ef-fa637b0dc7a6", "10-13")
                        .AddCell("f910b62d-ef68-4967-be50-bc3797482967", "A stream of 600 large and colorful butterflies pours forth, fluttering in a 20-foot burst for 2 rounds; creatures are blinded while in the cloud of butterflies.");
                })
                .AddRow("8c4e14ac-2cf6-4dd7-8442-ecf19b4d2ed5", row =>
                {
                    row
                        .AddCell("bee2ced2-8ff8-4fc8-a03c-396e20d48d86", "14-15")
                        .AddCell("c81be798-8812-4707-8dab-46258f56b789", "All the target�s weapons animate with the effects of the dancing rune.");
                })
                .AddRow("b3b9377a-f711-4aac-bff6-52807ced199c", row =>
                {
                    row
                        .AddCell("6788601c-50a2-4224-9c55-f9b56d0ba2e7", "16-25")
                        .AddCell("b2a4711f-386e-462a-b895-f7f4f42c8011", "Lightning bolt");
                })
                .AddRow("f5a6dcfe-9790-4996-805c-b4b68533a96a", row =>
                {
                    row
                        .AddCell("7ecf1b17-6f52-4273-80b0-554300949133", "26-29")
                        .AddCell("fa8753cd-45c6-4eee-a6bf-ad6e66cf5b3c", "Grass grows in a 60-foot cone in front of the rod, or existing grass grows at 10 � normal rate.");
                })
                .AddRow("eaaf2940-f148-4ecf-9c36-ff4dc9393e28", row =>
                {
                    row
                        .AddCell("bde8ed74-ef96-4c30-9c29-5e6893bfa29f", "30")
                        .AddCell("696f81db-2d28-4b49-ae5e-3dddfcc134d9", "Target turns blue, green, or purple with an unlimited duration.");
                })
                .AddRow("1f2380f7-ab72-4cb6-b305-a3a40f0ac094", row =>
                {
                    row
                        .AddCell("21636551-5429-470d-98f8-eaf5646c5694", "31")
                        .AddCell("f1d2b33d-9714-4d83-bae8-4ff6278000fc", "Summon an elephant (6th-level summon animal; Pathfinder Bestiary 154).");
                })
                .AddRow("5971c2f0-01a4-4ba4-a490-660b06211b8e", row =>
                {
                    row
                        .AddCell("c66a46a1-a35c-42bf-87b6-c67748e6cc67", "32-34")
                        .AddCell("9ab0cf57-e551-4dad-99be-d91ad1b8b584", "Heavy rain falls in a 60-foot radius around you for 1 round.");
                })
                .AddRow("f07dd39c-7792-4ea9-bad6-49db0734056d", row =>
                {
                    row
                        .AddCell("85e4661f-5d26-480c-9b2c-632d3dbc1440", "35-38")
                        .AddCell("5324e50e-f9dc-4faa-acff-2a1a66ec6cdc", "Stinking cloud.");
                })
                .AddRow("25f99898-ee0e-4649-b070-e81ee3225fdd", row =>
                {
                    row
                        .AddCell("dcb383bb-4e26-4a7a-aaa0-06595dd62899", "39")
                        .AddCell("0e8abaf2-6a79-4d5f-99b0-8a61cd43a02f", "Summon an ineffective mouse (1st-level summon animal).");
                })
                .AddRow("d56056db-4f0e-47a5-bfb7-5c7fe9c42c77", row =>
                {
                    row
                        .AddCell("4a65befc-aec2-42e0-85d3-42f4e7b97f64", "40-42")
                        .AddCell("b9a33c97-3229-4fc3-82bd-af343f8e60a0", "Vibrant pattern, with a 1-round duration.");
                })
                .AddRow("016c7ae3-b7e2-400e-8b28-acf88a02462f", row =>
                {
                    row
                        .AddCell("6eeb922e-194d-4fe2-b29e-388f10374720", "43-44")
                        .AddCell("49fe9e81-7d9c-45ec-ac95-0345ef2464eb", "The rod casts mirror image on you.");
                })
                .AddRow("c0fdf358-69e7-4c83-9909-c3d798a029be", row =>
                {
                    row
                        .AddCell("cda3cd02-030e-439a-af20-446344d5f303", "45-46")
                        .AddCell("bbcb270a-cd64-406a-b962-ee64e15ece27", "Gust of wind.");
                })
                .AddRow("cb090064-ae33-4fdc-90a5-b010d75061a4", row =>
                {
                    row
                        .AddCell("f62316f5-60f1-48d9-9686-9ab004d7507d", "47-48")
                        .AddCell("3b220b59-917b-47ec-bce0-0f3f3f921646", "The non-living, unattended object closest to the target(up to 30 cubic feet in size) turns ethereal for an unlimited duration.");
                })
                .AddRow("a93643ad-371d-49f9-8f98-4982de37cbb4", row =>
                {
                    row
                        .AddCell("127d2f39-6a17-4d23-8532-bb1eed63e07f", "49-53")
                        .AddCell("932c8b61-c8fb-4605-b4cb-8a8d47d36788", "Slow.");
                })
                .AddRow("e3266e99-6d83-4f0a-b123-e4c38b2b0083", row =>
                {
                    row
                        .AddCell("16f6b3f8-284b-4c76-b98c-95130b209371", "54")
                        .AddCell("ffa20c74-4b37-47e5-8338-c025f3d48541", "You turn blue, green, or purple with an unlimited duration.");
                })
                .AddRow("2e043c81-1c76-4692-b54a-5fa4a1612f96", row =>
                {
                    row
                        .AddCell("a4ec4637-ae89-4d7a-8a72-cab2c5e632e4", "55-59")
                        .AddCell("a60c2372-0632-4b89-b96e-a41a68ab7a05", "The rod casts pest form on you, lasting 1d4 rounds.");
                })
                .AddRow("c7b2c196-9299-4857-9650-a70bc9c62c3f", row =>
                {
                    row
                        .AddCell("85106f3b-b49e-4747-9794-59bf028cc68d", "60-61")
                        .AddCell("0c1ec979-e373-487f-97d9-7dfed663231a", "1d4 � 10 gems, each worth 1 sp, shoot from the rod, dealing 1 piercing damage to each creature in a 15-foot cone.");
                })
                .AddRow("cb3fb306-c417-495d-92f1-35b40f825f03", row =>
                {
                    row
                        .AddCell("8c10e9dc-c502-40e2-983c-af5b9f1dd290", "62")
                        .AddCell("bbdaa23e-099d-4148-82e5-379148a7e3a8", "Sleep, with a 100-foot burst.");
                })
                .AddRow("43d84b2e-85f3-4c00-a626-268b1e260429", row =>
                {
                    row
                        .AddCell("3ee61386-6383-42d7-945b-2692272420ee", "63-72")
                        .AddCell("bde602ab-5f9e-4af4-9449-6c1939fd784d", "Fireball.");
                })
                .AddRow("2a6b3bca-9e0f-4c77-b5e2-fbd69be06c9f", row =>
                {
                    row
                        .AddCell("fa91b84d-40b9-4b24-ad50-240ef45fcee3", "73-77")
                        .AddCell("ed243992-f550-4615-a827-8ce9e753877b", "Mind reading.");
                })
                .AddRow("a6e74db8-565f-4422-9b64-2c46f85527a2", row =>
                {
                    row
                        .AddCell("7ad64796-281d-4002-93cd-455be61902f7", "78-80")
                        .AddCell("88a065e6-0a03-4961-bc30-3425125daf62", "Roll again; the target believes you created the effect of the second roll.");
                })
                .AddRow("c76a652a-30d9-4e99-86c6-0ded38610c6a", row =>
                {
                    row
                        .AddCell("41d42532-0c06-48b2-befd-1b099bb6de13", "81-84")
                        .AddCell("7d373fb5-6ab3-4dcf-9582-83b8f4fcd8bb", "Enlarge.");
                })
                .AddRow("9d3a3a5b-20e5-4005-bf49-e5f077287654", row =>
                {
                    row
                        .AddCell("b07e54fc-5aab-400d-a338-1cb3d370e5fe", "85-87")
                        .AddCell("dfd5745c-0dd2-4bee-bb9a-4050c6e0a05d", "Target is coated in nectar, making it clumsy 1 for 1 round.");
                })
                .AddRow("6e96169a-db59-420e-a627-8fe6632988e5", row =>
                {
                    row
                        .AddCell("ee545160-bd32-4971-866f-b8daabb979f1", "88-92")
                        .AddCell("d94f21dd-d1f0-40d3-a4d9-fb4f65659af2", "Faerie Fire.");
                })
                .AddRow("b3148d3e-6e36-4477-820f-e6eefb3ecbfd", row =>
                {
                    row
                        .AddCell("22eff53e-65c9-48cc-97bc-42564d87c316", "93-97")
                        .AddCell("7b2d5dd7-3edd-42e8-9418-eb6244d1fd27", "The rod casts invisibility on you.");
                })
                .AddRow("a4589c4d-92ee-44ea-8d05-c32c0fcaf4c0", row =>
                {
                    row
                        .AddCell("3ce67de3-3866-43b6-bb09-01fd38b0e901", "98-100")
                        .AddCell("380baae0-5ac2-4e41-9be6-aa7213bb8810", "The rod casts shrink on you, lasting 1 day.");
                })
                .Build();
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bdee252-abb0-49bb-b297-811abe4c44df"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 575
            };
        }
    }
}
