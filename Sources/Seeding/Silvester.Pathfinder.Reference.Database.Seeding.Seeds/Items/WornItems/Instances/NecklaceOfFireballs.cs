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
    public class NecklaceOfFireballs : Template
    {
        public static readonly Guid ID = Guid.Parse("998816cb-4089-44a7-a2a0-14544ac0e8d5");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Necklace of Fireballs",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("679c1020-ffe0-4521-bd6c-da71b4b6d97f"), "This string of beads appears to be a hemp string with lustrous red beads of various sizes hanging from it. When activated, it briefly appears in its true form: a golden chain with golden spheres attached by fine threads.");
            builder.Text(Guid.Parse("f9c2aaa7-08fe-4d31-8bea-03bddaacd3a6"), "Numerous varieties of the necklace of fireballs exist. Each has a different basic Reflex save DC and includes a combination of spheres dealing different amounts of damage, as listed for each type below. When all the beads are gone, the necklace becomes a non-magical hemp string.");
            builder.Text(Guid.Parse("f10a08d8-1580-4719-a4ab-a0403d300488"), "Numerous varieties of the necklace of fireballs exist. Each has a different basic Reflex save DC and includes a combination of spheres dealing different amounts of damage, as listed for each type below. When all the beads are gone, the necklace becomes a non-magical hemp string.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("8b1af704-d7ff-4f61-b0b3-e36898452ca4"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("fc3faa73-9cc5-4923-848b-d117e39ed347"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("d43cef80-73f8-4a2f-a5cd-08a6c485888b"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
        {
            yield return new WornItemVariant
            {
                Id = Guid.Parse("670e7ca9-c901-425b-8b22-e36b5a48a2bd"),
                Name = "Necklace of Fireballs (Type I)",
                Usage = "Worn.",
                Level = 5,
                Price = 4400,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("03b820c7-5100-4ab3-bfb3-f18156328480"), "One 6d6 sphere, two 4d6 spheres (DC 21).")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("ec2700d3-4ed7-46a8-80a6-567311e31a25"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(builder =>
                            {
                                builder.Text(Guid.Parse("d7be61c5-2b01-4479-9fa6-a3a4ed6c622a"), "You detach a sphere from the necklace, causing it to glow with orange light. After you activate a sphere, if you or anyone else hurls it (an Interact action), it detonates as a fireball where it lands. Your toss can place the center of the fireball anywhere within 70 feet, though at the GM's discretion you might need to make an attack roll if the throw is unusually challenging. If no one hurls the sphere by the start of your next turn, it turns into a non-magical red bead.");
                            });
                    })
                    .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("017f34e8-a0a9-4feb-b23c-56b65d0329b8"),
                Name = "Necklace of Fireballs (Type II)",
                Usage = "Worn.",
                Level = 7,
                Price = 11500,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                      .Text(Guid.Parse("1026b9d8-019f-4469-b73e-599aa4133688"), "One 8d6 sphere, two 4d6 spheres (DC 25).")
                      .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                      .Add(Guid.Parse("659607d8-86ee-4247-a962-ded71137f7b1"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                      {
                          action
                              .Kind("Interact")
                              .Details(builder =>
                              {
                                  builder.Text(Guid.Parse("0ae19b19-71f3-4d48-9b13-ae34ecf74820"), "You detach a sphere from the necklace, causing it to glow with orange light. After you activate a sphere, if you or anyone else hurls it (an Interact action), it detonates as a fireball where it lands. Your toss can place the center of the fireball anywhere within 70 feet, though at the GM's discretion you might need to make an attack roll if the throw is unusually challenging. If no one hurls the sphere by the start of your next turn, it turns into a non-magical red bead.");
                              });
                      })
                      .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("631c6fac-c528-4556-b9b3-6ee5d5ffb63f"),
                Name = "Necklace of Fireballs (Type III)",
                Usage = "Worn.",
                Level = 9,
                Price = 30000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                         .Text(Guid.Parse("77ad3a68-007f-49e7-b37c-0e2ff0feb563"), "One 10d6 sphere, two 8d6 spheres, two 6d6 spheres (DC 27).")
                         .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                         .Add(Guid.Parse("19cf904e-408e-4919-b87d-95a2c9d6bfc3"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                         {
                             action
                                 .Kind("Interact")
                                 .Details(builder =>
                                 {
                                     builder.Text(Guid.Parse("4b1be57a-d41e-47e7-91c3-f131e776aaee"), "You detach a sphere from the necklace, causing it to glow with orange light. After you activate a sphere, if you or anyone else hurls it (an Interact action), it detonates as a fireball where it lands. Your toss can place the center of the fireball anywhere within 70 feet, though at the GM's discretion you might need to make an attack roll if the throw is unusually challenging. If no one hurls the sphere by the start of your next turn, it turns into a non-magical red bead.");
                                 });
                         })
                         .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("42c99348-3f83-424c-afe1-911a59aed1df"),
                Name = "Necklace of Fireballs (Type IV)",
                Usage = "Worn.",
                Level = 11,
                Price = 70000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("1bb95a9a-bd73-4acb-ba60-539fea66e47e"), "One 12d6 sphere, two 10d6 spheres, three 8d6 spheres (DC 30).")
                   .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                   .Add(Guid.Parse("88355340-ecb8-4f19-af59-0f88cf3aa802"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                   {
                       action
                           .Kind("Interact")
                           .Details(builder =>
                           {
                               builder.Text(Guid.Parse("e31767fd-e702-4876-ae53-33ba73cd1246"), "You detach a sphere from the necklace, causing it to glow with orange light. After you activate a sphere, if you or anyone else hurls it (an Interact action), it detonates as a fireball where it lands. Your toss can place the center of the fireball anywhere within 70 feet, though at the GM's discretion you might need to make an attack roll if the throw is unusually challenging. If no one hurls the sphere by the start of your next turn, it turns into a non-magical red bead.");
                           });
                   })
                   .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("119d7111-fcc9-4b74-bfa7-9dda37a53579"),
                Name = "Necklace of Fireballs (Type V)",
                Usage = "Worn.",
                Level = 13,
                Price = 160000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("6be7707c-229b-4687-a6e9-bcf6491a9a72"), "One 14d6 sphere, two 12d6 spheres, four 10d6 spheres (DC 32).")
                   .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                   .Add(Guid.Parse("1af34df1-1389-4bea-ae0d-87037fa72405"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                   {
                       action
                           .Kind("Interact")
                           .Details(builder =>
                           {
                               builder.Text(Guid.Parse("1e0fdf55-878e-454d-b78f-4243131482fa"), "You detach a sphere from the necklace, causing it to glow with orange light. After you activate a sphere, if you or anyone else hurls it (an Interact action), it detonates as a fireball where it lands. Your toss can place the center of the fireball anywhere within 70 feet, though at the GM's discretion you might need to make an attack roll if the throw is unusually challenging. If no one hurls the sphere by the start of your next turn, it turns into a non-magical red bead.");
                           });
                   })
                   .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("1bef6036-3e3c-4ee2-a048-7891da4b551d"),
                Name = "Necklace of Fireballs (Type VI)",
                Usage = "Worn.",
                Level = 15,
                Price = 420000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("7bdcbc62-5a0f-4867-9394-181751c3c4b9"), "One 16d6 sphere, three 14d6 spheres, four 12d6 spheres (DC 36).")
                   .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                   .Add(Guid.Parse("728bf4aa-5bf0-498b-a139-2f15e1c9304c"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                   {
                       action
                           .Kind("Interact")
                           .Details(builder =>
                           {
                               builder.Text(Guid.Parse("da52e2ad-6df8-4685-9463-a918c33be611"), "You detach a sphere from the necklace, causing it to glow with orange light. After you activate a sphere, if you or anyone else hurls it (an Interact action), it detonates as a fireball where it lands. Your toss can place the center of the fireball anywhere within 70 feet, though at the GM's discretion you might need to make an attack roll if the throw is unusually challenging. If no one hurls the sphere by the start of your next turn, it turns into a non-magical red bead.");
                           });
                   })
                   .Build()
            };

            yield return new WornItemVariant
            {
                Id = Guid.Parse("b226eeed-93e9-4d48-ad43-2ea4d0393d14"),
                Name = "Necklace of Fireballs (Type VII)",
                Usage = "Worn.",
                Level = 17,
                Price = 960000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("cf1530cd-fb11-4e38-a105-8e601ccb1675"), "One 18d6 sphere, three 16d6 spheres, five 14d6 spheres (DC 39).")
                   .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                   .Add(Guid.Parse("abfb3cb7-3975-422c-a2db-1365c6864729"), ActionTypes.Instances.OneAction.ID, name: "Activate", action =>
                   {
                       action
                           .Kind("Interact")
                           .Details(builder =>
                           {
                               builder.Text(Guid.Parse("6a6f9cd3-b147-484d-bd51-47a4bffd9aa7"), "You detach a sphere from the necklace, causing it to glow with orange light. After you activate a sphere, if you or anyone else hurls it (an Interact action), it detonates as a fireball where it lands. Your toss can place the center of the fireball anywhere within 70 feet, though at the GM's discretion you might need to make an attack roll if the throw is unusually challenging. If no one hurls the sphere by the start of your next turn, it turns into a non-magical red bead.");
                           });
                   })
                   .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5f6dba0-87d2-4f05-a993-6f7936f752f4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 613
            };
        }
    }
}
